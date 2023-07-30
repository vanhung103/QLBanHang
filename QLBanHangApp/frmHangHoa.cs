using QLBanHangLibrary.Bussiness;
using QLBanHangLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHangApp
{
    public partial class frmHangHoa : Form
    {
        IHangHoaRepository hangHoaRepository = new HangHoaRepository();
        BindingSource source;
        HangHoa hh;
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            LoadHangHoaList();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var hangHoas = hangHoaRepository.GetHangHoaByKeyword(txtTimKiem.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = hangHoas;

                dgvHangHoa.DataSource = null;
                dgvHangHoa.DataSource = source;
                if (hangHoas.Count() == 0)
                {
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                }
                else
                {
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem_TextChanged(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmHangHoaUpdate frmHangHoaUpdate = new frmHangHoaUpdate()
            {
                Text = "Cập nhật Hàng hoá",
                InsertOrUpdate = false,
                HangHoaInfo = hh,
                HangHoaRepository = hangHoaRepository
            };
            frmHangHoaUpdate.Owner = this;
            if (frmHangHoaUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadHangHoaList();
                source.Position = source.Count - 1;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmHangHoaUpdate frmHangHoaUpdate = new frmHangHoaUpdate()
            {
                Text = "Cập nhật Hàng hoá",
                InsertOrUpdate = true,
                HangHoaInfo = hh,
                HangHoaRepository = hangHoaRepository
            };
            frmHangHoaUpdate.Owner = this;
            if (frmHangHoaUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadHangHoaList();
                source.Position = source.Count - 1;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                hangHoaRepository.DeleteHangHoa(hh.MaHangHoa);
                LoadHangHoaList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void LoadHangHoaList()
        {
            var hangHoas = hangHoaRepository.GetHangHoas();
            try
            {
                source = new BindingSource();
                source.DataSource = hangHoas;

                dgvHangHoa.DataSource = null;
                dgvHangHoa.AutoGenerateColumns = false;
                dgvHangHoa.Columns.Clear();
                var maHangHoa = new DataGridViewTextBoxColumn();
                maHangHoa.DataPropertyName = "MaHangHoa";
                maHangHoa.HeaderText = "Mã Hàng hoá";
                dgvHangHoa.Columns.Add(maHangHoa);

                var tenHangHoa = new DataGridViewTextBoxColumn();
                tenHangHoa.DataPropertyName = "TenHangHoa";
                tenHangHoa.HeaderText = "Tên Hàng hoá";
                dgvHangHoa.Columns.Add(tenHangHoa);

                var soLuong = new DataGridViewTextBoxColumn();
                soLuong.DataPropertyName = "SoLuong";
                soLuong.HeaderText = "Số lượng";
                dgvHangHoa.Columns.Add(soLuong);

                var donGiaNhap = new DataGridViewTextBoxColumn();
                donGiaNhap.DataPropertyName = "DonGiaNhap";
                donGiaNhap.HeaderText = "Đơn giá nhập";
                dgvHangHoa.Columns.Add(donGiaNhap);

                var donGiaBan = new DataGridViewTextBoxColumn();
                donGiaBan.DataPropertyName = "DonGiaBan";
                donGiaBan.HeaderText = "Đơn giá bán";
                dgvHangHoa.Columns.Add(donGiaBan);

                dgvHangHoa.DataSource = source;


                if (hangHoas.Count() == 0)
                {
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                }
                else
                {
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgvHangHoa.Rows.Count - 1)
            // Kiểm tra nếu người dùng click vào một ô hợp lệ
            {
                DataGridViewRow row = dgvHangHoa.Rows[e.RowIndex];
                var hangHoa = hangHoaRepository.GetHangHoaByID(Convert.ToInt32(row.Cells[0].Value));
                hh = new HangHoa()
                {
                    MaHangHoa = hangHoa.MaHangHoa,
                    TenHangHoa = hangHoa.TenHangHoa,
                    SoLuong = hangHoa.SoLuong,
                    DonGiaNhap = hangHoa.DonGiaNhap,
                    DonGiaBan = hangHoa.DonGiaBan,
                    Anh = hangHoa.Anh,
                    GhiChu = hangHoa.GhiChu
                };
            }
        }

        private void dgvHangHoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua_Click(sender, e);
        }
    }
}

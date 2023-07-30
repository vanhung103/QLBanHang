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
    public partial class frmKhachHang : Form
    {
        IKhachHangRepository khachHangRepository = new KhachHangRepository();
        BindingSource source;
        KhachHang kh;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e) => Close();

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmKhachHangUpdate frmKhachHangUpdate = new frmKhachHangUpdate()
            {
                Text = "Cập nhật Khách hàng",
                InsertOrUpdate = true,
                KhachHangInfo = kh,
                KhachHangRepository = khachHangRepository
            };
            frmKhachHangUpdate.Owner = this;
            if (frmKhachHangUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadKhachHangList();
                source.Position = source.Count - 1;
            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHangList();
        }

        public void LoadKhachHangList()
        {
            var khachHangs = khachHangRepository.GetKhachHangs();
            try
            {
                source = new BindingSource();
                source.DataSource = khachHangs;

                dgvKhachHang.DataSource = null;
                dgvKhachHang.DataSource = source;
                if (khachHangs.Count() == 0)
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

        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua_Click(sender, e);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var khachHangs = khachHangRepository.GetKhachHangByKeyword(txtTimKiem.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = khachHangs;

                dgvKhachHang.DataSource = null;
                dgvKhachHang.DataSource = source;
                if (khachHangs.Count() == 0)
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                khachHangRepository.DeleteKhachHang(kh.MaKhachHang);
                LoadKhachHangList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgvKhachHang.Rows.Count - 1)
            // Kiểm tra nếu người dùng click vào một ô hợp lệ
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                kh = new KhachHang()
                {
                    MaKhachHang = Convert.ToInt32(row.Cells[0].Value),
                    TenKhachHang = row.Cells[1].Value.ToString(),
                    DiaChi = row.Cells[2].Value.ToString(),
                    DienThoai = row.Cells[3].Value.ToString()
                };
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmKhachHangUpdate frmKhachHangUpdate = new frmKhachHangUpdate()
            {
                Text = "Cập nhật Khách hàng",
                InsertOrUpdate = false,
                KhachHangInfo = kh,
                KhachHangRepository = khachHangRepository
            };
            frmKhachHangUpdate.Owner = this;
            if (frmKhachHangUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadKhachHangList();
                source.Position = source.Count - 1;
            }
        }
    }
}

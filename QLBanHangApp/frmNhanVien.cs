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
    public partial class frmNhanVien : Form
    {
        INhanVienRepository nhanVienRepository = new NhanVienRepository();
        BindingSource source;
        NhanVien nv;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e) => Close();

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVienList();
        }
        public void LoadNhanVienList()
        {
            var nhanViens = nhanVienRepository.GetNhanViens();
            try
            {
                source = new BindingSource();
                source.DataSource = nhanViens;

                dgvNhanVien.DataSource = null;
                dgvNhanVien.DataSource = source;
                if (nhanViens.Count() == 0)
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var nhanViens = nhanVienRepository.GetNhanVienByKeyword(txtTimKiem.Text);
            try
            {
                source = new BindingSource();
                source.DataSource = nhanViens;

                dgvNhanVien.DataSource = null;
                dgvNhanVien.DataSource = source;
                if (nhanViens.Count() == 0)
                {
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                }
                else
                {
                    btnXoa.Enabled = true;
                    btnXoa.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNhanVienUpdate frmNhanVienUpdate = new frmNhanVienUpdate()
            {
                Text = "Cập nhật Nhân viên",
                InsertOrUpdate = false,
                NhanVienInfo = nv,
                NhanVienRepository = nhanVienRepository
            };
            frmNhanVienUpdate.Owner = this;
            if (frmNhanVienUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadNhanVienList();
                source.Position = source.Count - 1;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmNhanVienUpdate frmNhanVienUpdate = new frmNhanVienUpdate()
            {
                Text = "Cập nhật Nhân viên",
                InsertOrUpdate = true,
                NhanVienInfo = nv,
                NhanVienRepository = nhanVienRepository
            };
            frmNhanVienUpdate.Owner = this;
            if (frmNhanVienUpdate.ShowDialog() == DialogResult.OK)
            {
                LoadNhanVienList();
                source.Position = source.Count - 1;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                nhanVienRepository.DeleteNhanVien(nv.MaNhanVien);
                LoadNhanVienList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgvNhanVien.Rows.Count - 1)
            // Kiểm tra nếu người dùng click vào một ô hợp lệ
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                nv = new NhanVien()
                {
                    MaNhanVien = Convert.ToInt32(row.Cells[0].Value),
                    TenNhanVien = row.Cells[1].Value.ToString(),
                    GioiTinh = Convert.ToBoolean(row.Cells[2].Value.ToString()),
                    DiaChi = row.Cells[3].Value.ToString(),
                    DienThoai = row.Cells[4].Value.ToString(),
                    NgaySinh = Convert.ToDateTime(row.Cells[5].Value.ToString())
                };
            }
        }

        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua_Click(sender, e);
        }
    }
}

using QLBanHangLibrary.Bussiness;
using QLBanHangLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHangApp
{

    public partial class frmNhanVienUpdate : Form
    {
        public INhanVienRepository NhanVienRepository { get; set; }
        public bool InsertOrUpdate { get; set; }//True Update
        public NhanVien NhanVienInfo { get; set; }
        public frmNhanVienUpdate()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void frmNhanVienUpdate_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
                txtMaNhanVien.Text = NhanVienInfo.MaNhanVien.ToString();
                txtTenNhanVien.Text = NhanVienInfo.TenNhanVien.ToString();
                txtDiaChi.Text = NhanVienInfo.DiaChi.ToString();
                txtSoDienThoai.Text = NhanVienInfo.DienThoai.ToString();
                txtNgaySinh.Text = NhanVienInfo.NgaySinh.ToString("dd/MM/yyyy");
                cbGioiTinh.Checked = NhanVienInfo.GioiTinh;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var nv = new NhanVien
                {
                    MaNhanVien = Convert.ToInt32(txtMaNhanVien.Text == "" ? 0 : txtMaNhanVien.Text),
                    TenNhanVien = txtTenNhanVien.Text,
                    DiaChi = txtDiaChi.Text,
                    DienThoai = txtSoDienThoai.Text,
                    GioiTinh = cbGioiTinh.Checked,
                    NgaySinh = DateTime.ParseExact(txtNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)

                };
                if (InsertOrUpdate == false)
                {
                    NhanVienRepository.InsertNhanVien(nv);

                    if (MessageBox.Show("Bạn đã tạo mới thành công!", "Thông tin") == DialogResult.OK)
                    {
                        this.Visible = false;
                        ((frmNhanVien)this.Owner).LoadNhanVienList();
                    }
                }
                else
                {
                    NhanVienRepository.UpdateNhanVien(nv);
                    if (MessageBox.Show("Bạn đã cập nhật thành công!", "Thông tin") == DialogResult.OK)
                    {
                        this.Visible = false;
                        ((frmNhanVien)this.Owner).LoadNhanVienList();
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

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
using static Azure.Core.HttpHeader;

namespace QLBanHangApp
{
    public partial class frmLogin : Form
    {
        public INguoiDungRepository NguoiDungRepository { get; set; }
        INguoiDungRepository nguoiDungRepository = new NguoiDungRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTenDangNhap.Text))
                {
                    errorProvider1.SetError(txtTenDangNhap, "Vui lòng nhập tên đăng nhập");
                    return;
                }
                if (string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    errorProvider1.SetError(txtMatKhau, "Vui lòng nhập mật khẩu");
                    return;
                }
                else
                {
                    errorProvider1.Clear();
                    // Thực hiện xử lý đăng nhập ở đây

                    var nguoiDung = GetNguoiDungObject();
                    var user = nguoiDungRepository.GetNguoiDungLogin(nguoiDung.TenDangNhap, nguoiDung.MatKhau);
                    if (user != null)
                    {
                        this.Visible = false;
                        if (MessageBox.Show("Bạn đã đăng nhập thành công", "Thông tin") == DialogResult.OK)
                        {
                            frmMain frmMain = new frmMain();
                            frmMain.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác", "Thông tin");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private NguoiDung GetNguoiDungObject()
        {
            NguoiDung nguoiDung = null;
            try
            {
                nguoiDung = new NguoiDung()
                {
                    TenDangNhap = txtTenDangNhap.Text,
                    MatKhau = txtMatKhau.Text
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return nguoiDung;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đóng ứng dụng không", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

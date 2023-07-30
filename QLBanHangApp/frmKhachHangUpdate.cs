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
    public partial class frmKhachHangUpdate : Form
    {
        public IKhachHangRepository KhachHangRepository { get; set; }
        public bool InsertOrUpdate { get; set; }//True Update
        public KhachHang KhachHangInfo { get; set; }
        public frmKhachHangUpdate()
        {
            InitializeComponent();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var kh = new KhachHang
                {
                    MaKhachHang = Convert.ToInt32(txtMaKhachHang.Text == "" ? 0 : txtMaKhachHang.Text),
                    TenKhachHang = txtTenKhachHang.Text,
                    DiaChi = txtDiaChi.Text,
                    DienThoai = txtSoDienThoai.Text
                };
                if (InsertOrUpdate == false)
                {
                    KhachHangRepository.InsertKhachHang(kh);

                    if (MessageBox.Show("Bạn đã tạo mới thành công!", "Thông tin") == DialogResult.OK)
                    {
                        this.Visible = false;
                        ((frmKhachHang)this.Owner).LoadKhachHangList();
                    }
                }
                else
                {
                    KhachHangRepository.UpdateKhachHang(kh);
                    if (MessageBox.Show("Bạn đã cập nhật thành công!", "Thông tin") == DialogResult.OK)
                    {
                        this.Visible = false;
                        ((frmKhachHang)this.Owner).LoadKhachHangList();
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void frmKhachHangUpdate_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
                txtMaKhachHang.Text = KhachHangInfo.MaKhachHang.ToString();
                txtTenKhachHang.Text = KhachHangInfo.TenKhachHang.ToString();
                txtDiaChi.Text = KhachHangInfo.DiaChi.ToString();
                txtSoDienThoai.Text = KhachHangInfo.DienThoai.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}

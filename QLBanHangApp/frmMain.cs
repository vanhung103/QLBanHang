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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mn_KhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            this.Hide();
            frmKH.ShowDialog();
            this.Show();
        }

        private void mn_NhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNV = new frmNhanVien();
            this.Hide();
            frmNV.ShowDialog();
            this.Show();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHangHoa frmHH = new frmHangHoa();
            this.Hide();
            frmHH.ShowDialog();
            this.Show();
        }
    }
}

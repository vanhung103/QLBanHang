namespace QLBanHangApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            tệpTinToolStripMenuItem = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            mn_KhachHang = new ToolStripMenuItem();
            mn_NhanVien = new ToolStripMenuItem();
            hàngHóaToolStripMenuItem = new ToolStripMenuItem();
            hóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            trợGiúpToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tệpTinToolStripMenuItem, danhMụcToolStripMenuItem, hóaĐơnToolStripMenuItem, trợGiúpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(790, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tệpTinToolStripMenuItem
            // 
            tệpTinToolStripMenuItem.Image = (Image)resources.GetObject("tệpTinToolStripMenuItem.Image");
            tệpTinToolStripMenuItem.Name = "tệpTinToolStripMenuItem";
            tệpTinToolStripMenuItem.Size = new Size(89, 24);
            tệpTinToolStripMenuItem.Text = "Tệp tin";
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mn_KhachHang, mn_NhanVien, hàngHóaToolStripMenuItem });
            danhMụcToolStripMenuItem.Image = (Image)resources.GetObject("danhMụcToolStripMenuItem.Image");
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(93, 24);
            danhMụcToolStripMenuItem.Text = "Quản lý";
            // 
            // mn_KhachHang
            // 
            mn_KhachHang.Image = (Image)resources.GetObject("mn_KhachHang.Image");
            mn_KhachHang.Name = "mn_KhachHang";
            mn_KhachHang.Size = new Size(224, 26);
            mn_KhachHang.Text = "Khách Hàng";
            mn_KhachHang.Click += mn_KhachHang_Click;
            // 
            // mn_NhanVien
            // 
            mn_NhanVien.Image = (Image)resources.GetObject("mn_NhanVien.Image");
            mn_NhanVien.Name = "mn_NhanVien";
            mn_NhanVien.Size = new Size(224, 26);
            mn_NhanVien.Text = "Nhân Viên";
            mn_NhanVien.Click += mn_NhanVien_Click;
            // 
            // hàngHóaToolStripMenuItem
            // 
            hàngHóaToolStripMenuItem.Image = (Image)resources.GetObject("hàngHóaToolStripMenuItem.Image");
            hàngHóaToolStripMenuItem.Name = "hàngHóaToolStripMenuItem";
            hàngHóaToolStripMenuItem.Size = new Size(224, 26);
            hàngHóaToolStripMenuItem.Text = "Hàng Hóa";
            hàngHóaToolStripMenuItem.Click += hàngHóaToolStripMenuItem_Click;
            // 
            // hóaĐơnToolStripMenuItem
            // 
            hóaĐơnToolStripMenuItem.Image = (Image)resources.GetObject("hóaĐơnToolStripMenuItem.Image");
            hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            hóaĐơnToolStripMenuItem.Size = new Size(101, 24);
            hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            // 
            // trợGiúpToolStripMenuItem
            // 
            trợGiúpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem });
            trợGiúpToolStripMenuItem.Image = (Image)resources.GetObject("trợGiúpToolStripMenuItem.Image");
            trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            trợGiúpToolStripMenuItem.Size = new Size(98, 24);
            trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Image = (Image)resources.GetObject("đăngXuấtToolStripMenuItem.Image");
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(224, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 432);
            Controls.Add(menuStrip1);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tệpTinToolStripMenuItem;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private ToolStripMenuItem mn_KhachHang;
        private ToolStripMenuItem mn_NhanVien;
        private ToolStripMenuItem hàngHóaToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}
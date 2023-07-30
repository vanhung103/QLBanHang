namespace QLBanHangApp
{
    partial class frmHangHoaUpdate
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
            label6 = new Label();
            btnExit = new Button();
            btnUpdate = new Button();
            label4 = new Label();
            label5 = new Label();
            txtTenHangHoa = new TextBox();
            txtMaHangHoa = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSoLuong = new NumericUpDown();
            txtDonGiaNhap = new TextBox();
            txtDonGiaBan = new TextBox();
            pbAvatar = new PictureBox();
            btnUpload = new Button();
            label7 = new Label();
            txtGhiChu = new TextBox();
            ((System.ComponentModel.ISupportInitialize)txtSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(36, 320);
            label6.Name = "label6";
            label6.Size = new Size(117, 23);
            label6.TabIndex = 57;
            label6.Text = "Đơn giá bán";
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.Highlight;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(390, 496);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(116, 45);
            btnExit.TabIndex = 56;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Highlight;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(211, 496);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 45);
            btnUpdate.TabIndex = 55;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 260);
            label4.Name = "label4";
            label4.Size = new Size(127, 23);
            label4.TabIndex = 52;
            label4.Text = "Đơn giá nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(36, 192);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 51;
            label5.Text = "Số lượng";
            // 
            // txtTenHangHoa
            // 
            txtTenHangHoa.Location = new Point(211, 135);
            txtTenHangHoa.Name = "txtTenHangHoa";
            txtTenHangHoa.Size = new Size(295, 27);
            txtTenHangHoa.TabIndex = 50;
            // 
            // txtMaHangHoa
            // 
            txtMaHangHoa.Location = new Point(211, 77);
            txtMaHangHoa.Name = "txtMaHangHoa";
            txtMaHangHoa.ReadOnly = true;
            txtMaHangHoa.Size = new Size(295, 27);
            txtMaHangHoa.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 135);
            label3.Name = "label3";
            label3.Size = new Size(129, 23);
            label3.TabIndex = 48;
            label3.Text = "Tên hàng hóa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 77);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 47;
            label2.Text = "Mã hàng hóa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(81, 9);
            label1.Name = "label1";
            label1.Size = new Size(424, 44);
            label1.TabIndex = 46;
            label1.Text = "CẬP NHẬT HÀNG HÓA";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(211, 193);
            txtSoLuong.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(295, 27);
            txtSoLuong.TabIndex = 58;
            // 
            // txtDonGiaNhap
            // 
            txtDonGiaNhap.Location = new Point(211, 260);
            txtDonGiaNhap.Name = "txtDonGiaNhap";
            txtDonGiaNhap.Size = new Size(294, 27);
            txtDonGiaNhap.TabIndex = 59;
            // 
            // txtDonGiaBan
            // 
            txtDonGiaBan.Location = new Point(211, 320);
            txtDonGiaBan.Name = "txtDonGiaBan";
            txtDonGiaBan.Size = new Size(295, 27);
            txtDonGiaBan.TabIndex = 60;
            // 
            // pbAvatar
            // 
            pbAvatar.Location = new Point(556, 77);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(344, 210);
            pbAvatar.TabIndex = 61;
            pbAvatar.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.LawnGreen;
            btnUpload.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpload.ForeColor = Color.White;
            btnUpload.Location = new Point(662, 320);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(158, 43);
            btnUpload.TabIndex = 62;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(36, 401);
            label7.Name = "label7";
            label7.Size = new Size(77, 23);
            label7.TabIndex = 63;
            label7.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(210, 397);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(295, 71);
            txtGhiChu.TabIndex = 64;
            // 
            // frmHangHoaUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(945, 567);
            Controls.Add(txtGhiChu);
            Controls.Add(label7);
            Controls.Add(btnUpload);
            Controls.Add(pbAvatar);
            Controls.Add(txtDonGiaBan);
            Controls.Add(txtDonGiaNhap);
            Controls.Add(txtSoLuong);
            Controls.Add(label6);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtTenHangHoa);
            Controls.Add(txtMaHangHoa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmHangHoaUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmHangHoaUpdate";
            Load += frmHangHoaUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)txtSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Button btnExit;
        private Button btnUpdate;
        private Label label4;
        private Label label5;
        private TextBox txtTenHangHoa;
        private TextBox txtMaHangHoa;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown txtSoLuong;
        private TextBox txtDonGiaNhap;
        private TextBox txtDonGiaBan;
        private PictureBox pbAvatar;
        private Button btnUpload;
        private Label label7;
        private TextBox txtGhiChu;
    }
}
namespace QLBanHangApp
{
    partial class frmNhanVienUpdate
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
            btnExit = new Button();
            btnUpdate = new Button();
            txtSoDienThoai = new MaskedTextBox();
            txtDiaChi = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtTenNhanVien = new TextBox();
            txtMaNhanVien = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNgaySinh = new MaskedTextBox();
            label6 = new Label();
            label7 = new Label();
            cbGioiTinh = new CheckBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.Highlight;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(366, 441);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(116, 45);
            btnExit.TabIndex = 41;
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
            btnUpdate.Location = new Point(187, 441);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 45);
            btnUpdate.TabIndex = 40;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(187, 256);
            txtSoDienThoai.Mask = "(00)000.000.000";
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(295, 27);
            txtSoDienThoai.TabIndex = 39;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(187, 192);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(295, 27);
            txtDiaChi.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 260);
            label4.Name = "label4";
            label4.Size = new Size(124, 23);
            label4.TabIndex = 37;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 192);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 36;
            label5.Text = "Địa chỉ";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(187, 135);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(295, 27);
            txtTenNhanVien.TabIndex = 35;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(187, 77);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.ReadOnly = true;
            txtMaNhanVien.Size = new Size(295, 27);
            txtMaNhanVien.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 135);
            label3.Name = "label3";
            label3.Size = new Size(130, 23);
            label3.TabIndex = 33;
            label3.Text = "Tên nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(125, 23);
            label2.TabIndex = 32;
            label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 9);
            label1.Name = "label1";
            label1.Size = new Size(425, 44);
            label1.TabIndex = 31;
            label1.Text = "CẬP NHẬT NHÂN VIÊN";
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Location = new Point(187, 316);
            txtNgaySinh.Mask = "00/00/0000";
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.ShortcutsEnabled = false;
            txtNgaySinh.Size = new Size(295, 27);
            txtNgaySinh.TabIndex = 43;
            txtNgaySinh.ValidatingType = typeof(DateTime);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 320);
            label6.Name = "label6";
            label6.Size = new Size(95, 23);
            label6.TabIndex = 42;
            label6.Text = "Ngày sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 383);
            label7.Name = "label7";
            label7.Size = new Size(85, 23);
            label7.TabIndex = 44;
            label7.Text = "Giới tính";
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.AutoSize = true;
            cbGioiTinh.Location = new Point(187, 385);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(63, 24);
            cbGioiTinh.TabIndex = 45;
            cbGioiTinh.Text = "Nam";
            cbGioiTinh.UseVisualStyleBackColor = true;
            // 
            // frmNhanVienUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(565, 508);
            Controls.Add(cbGioiTinh);
            Controls.Add(label7);
            Controls.Add(txtNgaySinh);
            Controls.Add(label6);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtDiaChi);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtTenNhanVien);
            Controls.Add(txtMaNhanVien);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNhanVienUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNhanVienUpdate";
            Load += frmNhanVienUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnUpdate;
        private MaskedTextBox txtSoDienThoai;
        private TextBox txtDiaChi;
        private Label label4;
        private Label label5;
        private TextBox txtTenNhanVien;
        private TextBox txtMaNhanVien;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox txtNgaySinh;
        private Label label6;
        private Label label7;
        private CheckBox cbGioiTinh;
    }
}
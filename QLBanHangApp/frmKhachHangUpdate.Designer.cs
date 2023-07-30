namespace QLBanHangApp
{
    partial class frmKhachHangUpdate
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
            txtSoDienThoai = new MaskedTextBox();
            txtDiaChi = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtTenKhachHang = new TextBox();
            txtMaKhachHang = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(235, 256);
            txtSoDienThoai.Mask = "(00)000.000.000";
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(295, 27);
            txtSoDienThoai.TabIndex = 28;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(235, 192);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(295, 27);
            txtDiaChi.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(60, 260);
            label4.Name = "label4";
            label4.Size = new Size(124, 23);
            label4.TabIndex = 26;
            label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(60, 192);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 25;
            label5.Text = "Địa chỉ";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(235, 135);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(295, 27);
            txtTenKhachHang.TabIndex = 24;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Location = new Point(235, 77);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.ReadOnly = true;
            txtMaKhachHang.Size = new Size(295, 27);
            txtMaKhachHang.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 135);
            label3.Name = "label3";
            label3.Size = new Size(148, 23);
            label3.TabIndex = 22;
            label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(60, 77);
            label2.Name = "label2";
            label2.Size = new Size(143, 23);
            label2.TabIndex = 21;
            label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(60, 9);
            label1.Name = "label1";
            label1.Size = new Size(476, 44);
            label1.TabIndex = 20;
            label1.Text = "CẬP NHẬT KHÁCH HÀNG";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Highlight;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(235, 308);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 45);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.Highlight;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(414, 308);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(116, 45);
            btnExit.TabIndex = 30;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmKhachHangUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 436);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtDiaChi);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtTenKhachHang);
            Controls.Add(txtMaKhachHang);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmKhachHangUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmKhachHangUpdate";
            Load += frmKhachHangUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtSoDienThoai;
        private TextBox txtDiaChi;
        private Label label4;
        private Label label5;
        private TextBox txtTenKhachHang;
        private TextBox txtMaKhachHang;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnUpdate;
        private Button btnExit;
    }
}
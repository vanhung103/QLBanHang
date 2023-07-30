namespace QLBanHangApp
{
    partial class frmKhachHang
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
            label1 = new Label();
            txtTimKiem = new TextBox();
            label2 = new Label();
            dgvKhachHang = new DataGridView();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(171, 9);
            label1.Name = "label1";
            label1.Size = new Size(452, 44);
            label1.TabIndex = 8;
            label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(257, 113);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(319, 27);
            txtTimKiem.TabIndex = 14;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(58, 117);
            label2.Name = "label2";
            label2.Size = new Size(164, 23);
            label2.TabIndex = 12;
            label2.Text = "Từ khóa tìm kiếm";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(58, 169);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.RowTemplate.Height = 29;
            dgvKhachHang.Size = new Size(651, 221);
            dgvKhachHang.TabIndex = 20;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            dgvKhachHang.CellDoubleClick += dgvKhachHang_CellDoubleClick;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.Highlight;
            btnThem.Cursor = Cursors.Hand;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(58, 426);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 46);
            btnThem.TabIndex = 21;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.Highlight;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(238, 426);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 46);
            btnXoa.TabIndex = 22;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.Highlight;
            btnSua.Cursor = Cursors.Hand;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(414, 426);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(120, 46);
            btnSua.TabIndex = 23;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.Highlight;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(589, 426);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(120, 46);
            btnThoat.TabIndex = 24;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(589, 106);
            button1.Name = "button1";
            button1.Size = new Size(120, 38);
            button1.TabIndex = 26;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(768, 506);
            Controls.Add(button1);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(dgvKhachHang);
            Controls.Add(txtTimKiem);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmKhachHang";
            Load += frmKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTenKhachHang;
        private TextBox txtTimKiem;
        private Label label3;
        private Label label2;
        private TextBox txtDiaChi;
        private Label label4;
        private Label label5;
        private MaskedTextBox txtSoDienThoai;
        private DataGridView dgvKhachHang;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThoat;
        private Button button1;
    }
}
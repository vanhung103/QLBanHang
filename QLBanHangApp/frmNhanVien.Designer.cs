namespace QLBanHangApp
{
    partial class frmNhanVien
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
            button1 = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            dgvNhanVien = new DataGridView();
            txtTimKiem = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(606, 91);
            button1.Name = "button1";
            button1.Size = new Size(120, 38);
            button1.TabIndex = 35;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.Highlight;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(606, 411);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(120, 46);
            btnThoat.TabIndex = 34;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.Highlight;
            btnSua.Cursor = Cursors.Hand;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(431, 411);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(120, 46);
            btnSua.TabIndex = 33;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.Highlight;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(255, 411);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 46);
            btnXoa.TabIndex = 32;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.Highlight;
            btnThem.Cursor = Cursors.Hand;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(75, 411);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 46);
            btnThem.TabIndex = 31;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(75, 154);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 29;
            dgvNhanVien.Size = new Size(651, 221);
            dgvNhanVien.TabIndex = 30;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            dgvNhanVien.CellDoubleClick += dgvNhanVien_CellDoubleClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(274, 98);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(319, 27);
            txtTimKiem.TabIndex = 29;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(75, 102);
            label2.Name = "label2";
            label2.Size = new Size(164, 23);
            label2.TabIndex = 28;
            label2.Text = "Từ khóa tìm kiếm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(183, 9);
            label1.Name = "label1";
            label1.Size = new Size(401, 44);
            label1.TabIndex = 27;
            label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(774, 484);
            Controls.Add(button1);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(dgvNhanVien);
            Controls.Add(txtTimKiem);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnThoat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private DataGridView dgvNhanVien;
        private TextBox txtTimKiem;
        private Label label2;
        private Label label1;
    }
}
namespace FormChinh
{
    partial class frmQuanLySinhVien
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quanLySinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phanMemDiemDanhDataSet1 = new FormChinh.phanMemDiemDanhDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMaSinhVien = new System.Windows.Forms.TextBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.tbLop = new System.Windows.Forms.TextBox();
            this.tbSoDienThoai = new System.Windows.Forms.TextBox();
            this.cbNam = new System.Windows.Forms.CheckBox();
            this.cbNu = new System.Windows.Forms.CheckBox();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bThem = new System.Windows.Forms.Button();
            this.bXoa = new System.Windows.Forms.Button();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.quanLySinhVienTableAdapter1 = new FormChinh.phanMemDiemDanhDataSetTableAdapters.QuanLySinhVienTableAdapter();
            this.dgMaSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgHoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanMemDiemDanhDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgMaSinhVien,
            this.dgHoVaTen,
            this.dgLop,
            this.dgGioiTinh,
            this.dgNgaySinh,
            this.dgSoDienThoai,
            this.email,
            this.maSVDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.maLopDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.sdtDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.quanLySinhVienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(388, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(870, 579);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // quanLySinhVienBindingSource
            // 
            this.quanLySinhVienBindingSource.DataMember = "QuanLySinhVien";
            this.quanLySinhVienBindingSource.DataSource = this.phanMemDiemDanhDataSet1;
            // 
            // phanMemDiemDanhDataSet1
            // 
            this.phanMemDiemDanhDataSet1.DataSetName = "phanMemDiemDanhDataSet";
            this.phanMemDiemDanhDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã sinh viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lớp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày sinh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số điện thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Giới tính:";
            // 
            // tbMaSinhVien
            // 
            this.tbMaSinhVien.Location = new System.Drawing.Point(109, 129);
            this.tbMaSinhVien.Name = "tbMaSinhVien";
            this.tbMaSinhVien.Size = new System.Drawing.Size(191, 27);
            this.tbMaSinhVien.TabIndex = 0;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(109, 162);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(191, 27);
            this.tbHoTen.TabIndex = 1;
            // 
            // tbLop
            // 
            this.tbLop.Location = new System.Drawing.Point(109, 228);
            this.tbLop.Name = "tbLop";
            this.tbLop.Size = new System.Drawing.Size(191, 27);
            this.tbLop.TabIndex = 3;
            // 
            // tbSoDienThoai
            // 
            this.tbSoDienThoai.Location = new System.Drawing.Point(109, 195);
            this.tbSoDienThoai.Name = "tbSoDienThoai";
            this.tbSoDienThoai.Size = new System.Drawing.Size(191, 27);
            this.tbSoDienThoai.TabIndex = 2;
            // 
            // cbNam
            // 
            this.cbNam.AutoSize = true;
            this.cbNam.Location = new System.Drawing.Point(109, 321);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(58, 23);
            this.cbNam.TabIndex = 6;
            this.cbNam.Text = "Nam";
            this.cbNam.UseVisualStyleBackColor = true;
            this.cbNam.CheckedChanged += new System.EventHandler(this.cbNam_CheckedChanged);
            // 
            // cbNu
            // 
            this.cbNu.AutoSize = true;
            this.cbNu.Location = new System.Drawing.Point(173, 321);
            this.cbNu.Name = "cbNu";
            this.cbNu.Size = new System.Drawing.Size(48, 23);
            this.cbNu.TabIndex = 7;
            this.cbNu.Text = "Nữ";
            this.cbNu.UseVisualStyleBackColor = true;
            this.cbNu.CheckedChanged += new System.EventHandler(this.cbNu_CheckedChanged);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(109, 71);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(191, 27);
            this.tbTimKiem.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tìm kiếm:";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(309, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bThem
            // 
            this.bThem.AutoSize = true;
            this.bThem.Location = new System.Drawing.Point(109, 360);
            this.bThem.Name = "bThem";
            this.bThem.Size = new System.Drawing.Size(91, 29);
            this.bThem.TabIndex = 8;
            this.bThem.Text = "Thêm";
            this.bThem.UseVisualStyleBackColor = true;
            this.bThem.Click += new System.EventHandler(this.bThem_Click);
            // 
            // bXoa
            // 
            this.bXoa.AutoSize = true;
            this.bXoa.Location = new System.Drawing.Point(206, 360);
            this.bXoa.Name = "bXoa";
            this.bXoa.Size = new System.Drawing.Size(94, 29);
            this.bXoa.TabIndex = 10;
            this.bXoa.Text = "Xóa";
            this.bXoa.UseVisualStyleBackColor = true;
            this.bXoa.Click += new System.EventHandler(this.bXoa_Click);
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaySinh.Location = new System.Drawing.Point(109, 292);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(191, 27);
            this.dateNgaySinh.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(109, 259);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(191, 27);
            this.tbEmail.TabIndex = 4;
            // 
            // quanLySinhVienTableAdapter1
            // 
            this.quanLySinhVienTableAdapter1.ClearBeforeFill = true;
            // 
            // dgMaSinhVien
            // 
            this.dgMaSinhVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgMaSinhVien.DataPropertyName = "maSV";
            this.dgMaSinhVien.DividerWidth = 1;
            this.dgMaSinhVien.HeaderText = "Mã sinh viên";
            this.dgMaSinhVien.Name = "dgMaSinhVien";
            this.dgMaSinhVien.ReadOnly = true;
            // 
            // dgHoVaTen
            // 
            this.dgHoVaTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgHoVaTen.DataPropertyName = "hoTen";
            this.dgHoVaTen.HeaderText = "Họ và tên";
            this.dgHoVaTen.Name = "dgHoVaTen";
            this.dgHoVaTen.ReadOnly = true;
            // 
            // dgLop
            // 
            this.dgLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgLop.DataPropertyName = "maLop";
            this.dgLop.HeaderText = "Lớp";
            this.dgLop.Name = "dgLop";
            this.dgLop.ReadOnly = true;
            // 
            // dgGioiTinh
            // 
            this.dgGioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgGioiTinh.DataPropertyName = "gioiTinh";
            this.dgGioiTinh.HeaderText = "Giới tính";
            this.dgGioiTinh.Name = "dgGioiTinh";
            this.dgGioiTinh.ReadOnly = true;
            // 
            // dgNgaySinh
            // 
            this.dgNgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgNgaySinh.DataPropertyName = "ngaySinh";
            this.dgNgaySinh.HeaderText = "Ngày sinh";
            this.dgNgaySinh.Name = "dgNgaySinh";
            this.dgNgaySinh.ReadOnly = true;
            // 
            // dgSoDienThoai
            // 
            this.dgSoDienThoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgSoDienThoai.DataPropertyName = "sdt";
            this.dgSoDienThoai.HeaderText = "Số điện thoại";
            this.dgSoDienThoai.Name = "dgSoDienThoai";
            this.dgSoDienThoai.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "maSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "maSV";
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            this.maSVDataGridViewTextBoxColumn.ReadOnly = true;
            this.maSVDataGridViewTextBoxColumn.Visible = false;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "hoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "hoTen";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoTenDataGridViewTextBoxColumn.Visible = false;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "ngaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "ngaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngaySinhDataGridViewTextBoxColumn.Visible = false;
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "maLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "maLop";
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            this.maLopDataGridViewTextBoxColumn.ReadOnly = true;
            this.maLopDataGridViewTextBoxColumn.Visible = false;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "gioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "gioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.ReadOnly = true;
            this.gioiTinhDataGridViewTextBoxColumn.Visible = false;
            // 
            // sdtDataGridViewTextBoxColumn
            // 
            this.sdtDataGridViewTextBoxColumn.DataPropertyName = "sdt";
            this.sdtDataGridViewTextBoxColumn.HeaderText = "sdt";
            this.sdtDataGridViewTextBoxColumn.Name = "sdtDataGridViewTextBoxColumn";
            this.sdtDataGridViewTextBoxColumn.ReadOnly = true;
            this.sdtDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 661);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateNgaySinh);
            this.Controls.Add(this.bXoa);
            this.Controls.Add(this.bThem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.cbNu);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.tbSoDienThoai);
            this.Controls.Add(this.tbLop);
            this.Controls.Add(this.tbHoTen);
            this.Controls.Add(this.tbMaSinhVien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLySinhVien";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phanMemDiemDanhDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMaSinhVien;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.TextBox tbLop;
        private System.Windows.Forms.TextBox tbSoDienThoai;
        private System.Windows.Forms.CheckBox cbNam;
        private System.Windows.Forms.CheckBox cbNu;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bThem;
        private System.Windows.Forms.Button bXoa;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbEmail;
        private phanMemDiemDanhDataSet phanMemDiemDanhDataSet1;
        private System.Windows.Forms.BindingSource quanLySinhVienBindingSource;
        private phanMemDiemDanhDataSetTableAdapters.QuanLySinhVienTableAdapter quanLySinhVienTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMaSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgHoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}


﻿namespace FormChinh
{
    partial class frmQuanLyLopHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.lbLop = new System.Windows.Forms.Label();
            this.lbKhoa = new System.Windows.Forms.Label();
            this.lbNganh = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.lbGVCN = new System.Windows.Forms.Label();
            this.txtGVCN = new System.Windows.Forms.TextBox();
            this.cmdThem = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.dgDanhMuc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdSua = new System.Windows.Forms.Button();
            this.cmdThoat = new System.Windows.Forms.Button();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.cboNganh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboKhoaHoc = new System.Windows.Forms.ComboBox();
            this.cmdToanBo = new System.Windows.Forms.Button();
            this.cmdNhap = new System.Windows.Forms.Button();
            this.cmdHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ LỚP";
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLop.Location = new System.Drawing.Point(14, 305);
            this.lbMaLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(55, 16);
            this.lbMaLop.TabIndex = 1;
            this.lbMaLop.Text = "Mã Lớp:";
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLop.Location = new System.Drawing.Point(14, 341);
            this.lbLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(33, 16);
            this.lbLop.TabIndex = 2;
            this.lbLop.Text = "Lớp:";
            // 
            // lbKhoa
            // 
            this.lbKhoa.AutoSize = true;
            this.lbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhoa.Location = new System.Drawing.Point(415, 341);
            this.lbKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(66, 16);
            this.lbKhoa.TabIndex = 3;
            this.lbKhoa.Text = "Khoá học:";
            // 
            // lbNganh
            // 
            this.lbNganh.AutoSize = true;
            this.lbNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNganh.Location = new System.Drawing.Point(415, 305);
            this.lbNganh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNganh.Name = "lbNganh";
            this.lbNganh.Size = new System.Drawing.Size(50, 16);
            this.lbNganh.TabIndex = 4;
            this.lbNganh.Text = "Ngành:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(106, 302);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(256, 21);
            this.txtMaLop.TabIndex = 5;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(106, 339);
            this.txtLop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(256, 21);
            this.txtLop.TabIndex = 6;
            // 
            // lbGVCN
            // 
            this.lbGVCN.AutoSize = true;
            this.lbGVCN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGVCN.Location = new System.Drawing.Point(14, 381);
            this.lbGVCN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGVCN.Name = "lbGVCN";
            this.lbGVCN.Size = new System.Drawing.Size(48, 16);
            this.lbGVCN.TabIndex = 9;
            this.lbGVCN.Text = "GVCN:";
            // 
            // txtGVCN
            // 
            this.txtGVCN.Location = new System.Drawing.Point(106, 378);
            this.txtGVCN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGVCN.Name = "txtGVCN";
            this.txtGVCN.Size = new System.Drawing.Size(256, 21);
            this.txtGVCN.TabIndex = 10;
            // 
            // cmdThem
            // 
            this.cmdThem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmdThem.Location = new System.Drawing.Point(418, 373);
            this.cmdThem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(79, 27);
            this.cmdThem.TabIndex = 11;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = false;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmdXoa.Location = new System.Drawing.Point(602, 373);
            this.cmdXoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(77, 27);
            this.cmdXoa.TabIndex = 12;
            this.cmdXoa.Text = "Xoá";
            this.cmdXoa.UseVisualStyleBackColor = false;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // dgDanhMuc
            // 
            this.dgDanhMuc.AllowUserToAddRows = false;
            this.dgDanhMuc.AllowUserToDeleteRows = false;
            this.dgDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgDanhMuc.Location = new System.Drawing.Point(17, 47);
            this.dgDanhMuc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgDanhMuc.Name = "dgDanhMuc";
            this.dgDanhMuc.ReadOnly = true;
            this.dgDanhMuc.Size = new System.Drawing.Size(758, 237);
            this.dgDanhMuc.TabIndex = 14;
            this.dgDanhMuc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDanhMuc_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "maLop";
            this.Column1.HeaderText = "Mã lớp";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "maKhoa";
            this.Column2.HeaderText = "Khoá";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "maNganh";
            this.Column3.HeaderText = "Ngành";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "tenLop";
            this.Column4.HeaderText = "Lớp";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "GVCN";
            this.Column5.HeaderText = "GVCN";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // cmdSua
            // 
            this.cmdSua.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmdSua.Location = new System.Drawing.Point(510, 373);
            this.cmdSua.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(79, 27);
            this.cmdSua.TabIndex = 15;
            this.cmdSua.Text = "Sửa";
            this.cmdSua.UseVisualStyleBackColor = false;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdThoat
            // 
            this.cmdThoat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmdThoat.Location = new System.Drawing.Point(693, 373);
            this.cmdThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.Size = new System.Drawing.Size(79, 27);
            this.cmdThoat.TabIndex = 16;
            this.cmdThoat.Text = "Thoát";
            this.cmdThoat.UseVisualStyleBackColor = false;
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // cboKhoa
            // 
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(517, 338);
            this.cboKhoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(256, 21);
            this.cboKhoa.TabIndex = 17;
            // 
            // cboNganh
            // 
            this.cboNganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNganh.FormattingEnabled = true;
            this.cboNganh.Location = new System.Drawing.Point(517, 302);
            this.cboNganh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboNganh.Name = "cboNganh";
            this.cboNganh.Size = new System.Drawing.Size(256, 21);
            this.cboNganh.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Khoá học:";
            // 
            // cboKhoaHoc
            // 
            this.cboKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoaHoc.FormattingEnabled = true;
            this.cboKhoaHoc.Location = new System.Drawing.Point(98, 16);
            this.cboKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboKhoaHoc.Name = "cboKhoaHoc";
            this.cboKhoaHoc.Size = new System.Drawing.Size(196, 21);
            this.cboKhoaHoc.TabIndex = 20;
            this.cboKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cboKhoaHoc_SelectedIndexChanged);
            // 
            // cmdToanBo
            // 
            this.cmdToanBo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmdToanBo.Location = new System.Drawing.Point(306, 13);
            this.cmdToanBo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdToanBo.Name = "cmdToanBo";
            this.cmdToanBo.Size = new System.Drawing.Size(56, 27);
            this.cmdToanBo.TabIndex = 21;
            this.cmdToanBo.Text = "All";
            this.cmdToanBo.UseVisualStyleBackColor = false;
            this.cmdToanBo.Click += new System.EventHandler(this.cmdToanBo_Click);
            // 
            // cmdNhap
            // 
            this.cmdNhap.Location = new System.Drawing.Point(416, 13);
            this.cmdNhap.Name = "cmdNhap";
            this.cmdNhap.Size = new System.Drawing.Size(26, 27);
            this.cmdNhap.TabIndex = 22;
            this.cmdNhap.Text = "✔";
            this.cmdNhap.UseVisualStyleBackColor = true;
            this.cmdNhap.Click += new System.EventHandler(this.cmdNhap_Click);
            // 
            // cmdHuy
            // 
            this.cmdHuy.Location = new System.Drawing.Point(449, 13);
            this.cmdHuy.Name = "cmdHuy";
            this.cmdHuy.Size = new System.Drawing.Size(26, 27);
            this.cmdHuy.TabIndex = 23;
            this.cmdHuy.Text = "❌";
            this.cmdHuy.UseVisualStyleBackColor = true;
            this.cmdHuy.Click += new System.EventHandler(this.cmdHuy_Click);
            // 
            // frmQuanLyLopHoc
            // 
            this.AcceptButton = this.cmdNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(786, 409);
            this.Controls.Add(this.cmdHuy);
            this.Controls.Add(this.cmdNhap);
            this.Controls.Add(this.cmdToanBo);
            this.Controls.Add(this.cboKhoaHoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboNganh);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.cmdThoat);
            this.Controls.Add(this.cmdSua);
            this.Controls.Add(this.dgDanhMuc);
            this.Controls.Add(this.cmdXoa);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.txtGVCN);
            this.Controls.Add(this.lbGVCN);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.lbNganh);
            this.Controls.Add(this.lbKhoa);
            this.Controls.Add(this.lbLop);
            this.Controls.Add(this.lbMaLop);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanLyLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Lớp Học";
            this.Load += new System.EventHandler(this.frmQuanLyLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Label lbKhoa;
        private System.Windows.Forms.Label lbNganh;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Label lbGVCN;
        private System.Windows.Forms.TextBox txtGVCN;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.DataGridView dgDanhMuc;
        private System.Windows.Forms.Button cmdSua;
        private System.Windows.Forms.Button cmdThoat;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.ComboBox cboNganh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboKhoaHoc;
        private System.Windows.Forms.Button cmdToanBo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button cmdNhap;
        private System.Windows.Forms.Button cmdHuy;
    }
}


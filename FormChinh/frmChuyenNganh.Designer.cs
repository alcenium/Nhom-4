namespace FormChinh
{
    partial class frmChuyenNganh
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
            this.dgChuyenNganh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.bThem = new System.Windows.Forms.Button();
            this.bSua = new System.Windows.Forms.Button();
            this.bXoa = new System.Windows.Forms.Button();
            this.lbMaChuyenNganh = new System.Windows.Forms.Label();
            this.tbMaChuyenNganh = new System.Windows.Forms.TextBox();
            this.tbTenChuyenNganh = new System.Windows.Forms.TextBox();
            this.lbTenChuyenNganh = new System.Windows.Forms.Label();
            this.bXacNhan = new System.Windows.Forms.Button();
            this.bHuy = new System.Windows.Forms.Button();
            this.bThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgChuyenNganh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CHUYÊN NGÀNH";
            // 
            // dgChuyenNganh
            // 
            this.dgChuyenNganh.AllowUserToAddRows = false;
            this.dgChuyenNganh.AllowUserToDeleteRows = false;
            this.dgChuyenNganh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChuyenNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChuyenNganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgChuyenNganh.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgChuyenNganh.Location = new System.Drawing.Point(389, 61);
            this.dgChuyenNganh.Name = "dgChuyenNganh";
            this.dgChuyenNganh.ReadOnly = true;
            this.dgChuyenNganh.RowHeadersWidth = 51;
            this.dgChuyenNganh.RowTemplate.Height = 24;
            this.dgChuyenNganh.Size = new System.Drawing.Size(621, 285);
            this.dgChuyenNganh.TabIndex = 1;
            this.dgChuyenNganh.TabStop = false;
            this.dgChuyenNganh.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgChuyenNganh_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maNganh";
            this.Column1.HeaderText = "Mã chuyên ngành";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenNganh";
            this.Column2.HeaderText = "Tên chuyên ngành";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm:";
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(109, 61);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(274, 24);
            this.tbTimKiem.TabIndex = 3;
            this.tbTimKiem.TextChanged += new System.EventHandler(this.tbTimKiem_TextChanged);
            // 
            // bThem
            // 
            this.bThem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bThem.Location = new System.Drawing.Point(30, 110);
            this.bThem.Name = "bThem";
            this.bThem.Size = new System.Drawing.Size(99, 44);
            this.bThem.TabIndex = 4;
            this.bThem.Text = "THÊM";
            this.bThem.UseVisualStyleBackColor = true;
            this.bThem.Click += new System.EventHandler(this.bThem_Click);
            // 
            // bSua
            // 
            this.bSua.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSua.Location = new System.Drawing.Point(150, 110);
            this.bSua.Name = "bSua";
            this.bSua.Size = new System.Drawing.Size(99, 44);
            this.bSua.TabIndex = 5;
            this.bSua.Text = "SỬA";
            this.bSua.UseVisualStyleBackColor = true;
            this.bSua.Click += new System.EventHandler(this.bSua_Click);
            // 
            // bXoa
            // 
            this.bXoa.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bXoa.Location = new System.Drawing.Point(268, 110);
            this.bXoa.Name = "bXoa";
            this.bXoa.Size = new System.Drawing.Size(99, 44);
            this.bXoa.TabIndex = 6;
            this.bXoa.Text = "XÓA";
            this.bXoa.UseVisualStyleBackColor = true;
            this.bXoa.Click += new System.EventHandler(this.bXoa_Click);
            // 
            // lbMaChuyenNganh
            // 
            this.lbMaChuyenNganh.AutoSize = true;
            this.lbMaChuyenNganh.Location = new System.Drawing.Point(13, 220);
            this.lbMaChuyenNganh.Name = "lbMaChuyenNganh";
            this.lbMaChuyenNganh.Size = new System.Drawing.Size(137, 17);
            this.lbMaChuyenNganh.TabIndex = 7;
            this.lbMaChuyenNganh.Text = "Mã chuyên ngành:";
            // 
            // tbMaChuyenNganh
            // 
            this.tbMaChuyenNganh.Location = new System.Drawing.Point(156, 217);
            this.tbMaChuyenNganh.Name = "tbMaChuyenNganh";
            this.tbMaChuyenNganh.Size = new System.Drawing.Size(227, 24);
            this.tbMaChuyenNganh.TabIndex = 8;
            // 
            // tbTenChuyenNganh
            // 
            this.tbTenChuyenNganh.Location = new System.Drawing.Point(156, 260);
            this.tbTenChuyenNganh.Name = "tbTenChuyenNganh";
            this.tbTenChuyenNganh.Size = new System.Drawing.Size(227, 24);
            this.tbTenChuyenNganh.TabIndex = 10;
            // 
            // lbTenChuyenNganh
            // 
            this.lbTenChuyenNganh.AutoSize = true;
            this.lbTenChuyenNganh.Location = new System.Drawing.Point(6, 263);
            this.lbTenChuyenNganh.Name = "lbTenChuyenNganh";
            this.lbTenChuyenNganh.Size = new System.Drawing.Size(144, 17);
            this.lbTenChuyenNganh.TabIndex = 9;
            this.lbTenChuyenNganh.Text = "Tên chuyên ngành:";
            // 
            // bXacNhan
            // 
            this.bXacNhan.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bXacNhan.Location = new System.Drawing.Point(87, 302);
            this.bXacNhan.Name = "bXacNhan";
            this.bXacNhan.Size = new System.Drawing.Size(99, 44);
            this.bXacNhan.TabIndex = 11;
            this.bXacNhan.Text = "Xác nhận";
            this.bXacNhan.UseVisualStyleBackColor = true;
            this.bXacNhan.Click += new System.EventHandler(this.bXacNhan_Click);
            // 
            // bHuy
            // 
            this.bHuy.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHuy.Location = new System.Drawing.Point(206, 302);
            this.bHuy.Name = "bHuy";
            this.bHuy.Size = new System.Drawing.Size(99, 44);
            this.bHuy.TabIndex = 12;
            this.bHuy.Text = "Hủy";
            this.bHuy.UseVisualStyleBackColor = true;
            this.bHuy.Click += new System.EventHandler(this.bHuy_Click);
            // 
            // bThoat
            // 
            this.bThoat.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bThoat.Location = new System.Drawing.Point(30, 160);
            this.bThoat.Name = "bThoat";
            this.bThoat.Size = new System.Drawing.Size(337, 33);
            this.bThoat.TabIndex = 13;
            this.bThoat.Text = "THOÁT";
            this.bThoat.UseVisualStyleBackColor = true;
            this.bThoat.Click += new System.EventHandler(this.bThoat_Click);
            // 
            // frmChuyenNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1022, 356);
            this.Controls.Add(this.bThoat);
            this.Controls.Add(this.bHuy);
            this.Controls.Add(this.bXacNhan);
            this.Controls.Add(this.tbTenChuyenNganh);
            this.Controls.Add(this.lbTenChuyenNganh);
            this.Controls.Add(this.tbMaChuyenNganh);
            this.Controls.Add(this.lbMaChuyenNganh);
            this.Controls.Add(this.bXoa);
            this.Controls.Add(this.bSua);
            this.Controls.Add(this.bThem);
            this.Controls.Add(this.tbTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgChuyenNganh);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChuyenNganh";
            this.Text = "Quản_lý_chuyên_ngành";
            ((System.ComponentModel.ISupportInitialize)(this.dgChuyenNganh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgChuyenNganh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTimKiem;
        private System.Windows.Forms.Button bThem;
        private System.Windows.Forms.Button bSua;
        private System.Windows.Forms.Button bXoa;
        private System.Windows.Forms.Label lbMaChuyenNganh;
        private System.Windows.Forms.TextBox tbMaChuyenNganh;
        private System.Windows.Forms.TextBox tbTenChuyenNganh;
        private System.Windows.Forms.Label lbTenChuyenNganh;
        private System.Windows.Forms.Button bXacNhan;
        private System.Windows.Forms.Button bHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button bThoat;
    }
}
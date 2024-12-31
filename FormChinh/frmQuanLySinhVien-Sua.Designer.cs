namespace FormChinh
{
    partial class frmQuanLySinhVien_Sua
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
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.tbSoDienThoai = new System.Windows.Forms.TextBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.tbMaSinhVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bXacNhan = new System.Windows.Forms.Button();
            this.bHuy = new System.Windows.Forms.Button();
            this.cbNu = new System.Windows.Forms.CheckBox();
            this.cbNam = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbLop
            // 
            this.cbLop.DisplayMember = "MaLop";
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(145, 162);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(191, 26);
            this.cbLop.TabIndex = 2;
            this.cbLop.ValueMember = "MaLop";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(145, 194);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(191, 26);
            this.tbEmail.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(81, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 23);
            this.label9.TabIndex = 37;
            this.label9.Text = "Email:";
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dateNgaySinh.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaySinh.Location = new System.Drawing.Point(145, 226);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(191, 26);
            this.dateNgaySinh.TabIndex = 4;
            // 
            // tbSoDienThoai
            // 
            this.tbSoDienThoai.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoDienThoai.Location = new System.Drawing.Point(145, 128);
            this.tbSoDienThoai.Name = "tbSoDienThoai";
            this.tbSoDienThoai.Size = new System.Drawing.Size(191, 26);
            this.tbSoDienThoai.TabIndex = 1;
            // 
            // tbHoTen
            // 
            this.tbHoTen.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoTen.Location = new System.Drawing.Point(145, 96);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(191, 26);
            this.tbHoTen.TabIndex = 0;
            // 
            // tbMaSinhVien
            // 
            this.tbMaSinhVien.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaSinhVien.Location = new System.Drawing.Point(145, 62);
            this.tbMaSinhVien.Name = "tbMaSinhVien";
            this.tbMaSinhVien.ReadOnly = true;
            this.tbMaSinhVien.Size = new System.Drawing.Size(191, 26);
            this.tbMaSinhVien.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 23);
            this.label6.TabIndex = 36;
            this.label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mã sinh viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 31);
            this.label1.TabIndex = 39;
            this.label1.Text = "Sửa thông tin sinh viên";
            // 
            // bXacNhan
            // 
            this.bXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bXacNhan.Location = new System.Drawing.Point(93, 291);
            this.bXacNhan.Name = "bXacNhan";
            this.bXacNhan.Size = new System.Drawing.Size(80, 35);
            this.bXacNhan.TabIndex = 7;
            this.bXacNhan.Text = "Xác nhận";
            this.bXacNhan.UseVisualStyleBackColor = true;
            this.bXacNhan.Click += new System.EventHandler(this.bXacNhan_Click);
            // 
            // bHuy
            // 
            this.bHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHuy.Location = new System.Drawing.Point(204, 291);
            this.bHuy.Name = "bHuy";
            this.bHuy.Size = new System.Drawing.Size(80, 35);
            this.bHuy.TabIndex = 8;
            this.bHuy.Text = "Hủy";
            this.bHuy.UseVisualStyleBackColor = true;
            this.bHuy.Click += new System.EventHandler(this.bHuy_Click);
            // 
            // cbNu
            // 
            this.cbNu.AutoSize = true;
            this.cbNu.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNu.Location = new System.Drawing.Point(216, 258);
            this.cbNu.Name = "cbNu";
            this.cbNu.Size = new System.Drawing.Size(52, 27);
            this.cbNu.TabIndex = 6;
            this.cbNu.Text = "Nữ";
            this.cbNu.UseVisualStyleBackColor = true;
            this.cbNu.CheckedChanged += new System.EventHandler(this.cbNu_CheckedChanged);
            // 
            // cbNam
            // 
            this.cbNam.AutoSize = true;
            this.cbNam.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNam.Location = new System.Drawing.Point(145, 258);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(65, 27);
            this.cbNam.TabIndex = 5;
            this.cbNam.Text = "Nam";
            this.cbNam.UseVisualStyleBackColor = true;
            this.cbNam.CheckedChanged += new System.EventHandler(this.cbNam_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 44;
            this.label7.Text = "Giới tính:";
            // 
            // frmQuanLySinhVien_Sua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 338);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbNu);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.bHuy);
            this.Controls.Add(this.bXacNhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateNgaySinh);
            this.Controls.Add(this.tbSoDienThoai);
            this.Controls.Add(this.tbHoTen);
            this.Controls.Add(this.tbMaSinhVien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmQuanLySinhVien_Sua";
            this.Text = "frmQuanLySinhVien_Sua";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.TextBox tbSoDienThoai;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.TextBox tbMaSinhVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bXacNhan;
        private System.Windows.Forms.Button bHuy;
        private System.Windows.Forms.CheckBox cbNu;
        private System.Windows.Forms.CheckBox cbNam;
        private System.Windows.Forms.Label label7;
    }
}
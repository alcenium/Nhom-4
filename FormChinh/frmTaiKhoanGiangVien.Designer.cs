namespace FormChinh
{
    partial class frmTaiKhoanGiangVien
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
            this.bThoat = new System.Windows.Forms.Button();
            this.tbNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbNu = new System.Windows.Forms.CheckBox();
            this.cbNam = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMGV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bHuy = new System.Windows.Forms.Button();
            this.bXacNhan = new System.Windows.Forms.Button();
            this.bSua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin giảng viên";
            // 
            // bThoat
            // 
            this.bThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bThoat.Location = new System.Drawing.Point(403, 197);
            this.bThoat.Name = "bThoat";
            this.bThoat.Size = new System.Drawing.Size(75, 35);
            this.bThoat.TabIndex = 13;
            this.bThoat.Text = "Thoát";
            this.bThoat.UseVisualStyleBackColor = true;
            this.bThoat.Click += new System.EventHandler(this.bThoat_Click);
            // 
            // tbNgaySinh
            // 
            this.tbNgaySinh.CalendarFont = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.tbNgaySinh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbNgaySinh.Location = new System.Drawing.Point(115, 108);
            this.tbNgaySinh.Name = "tbNgaySinh";
            this.tbNgaySinh.Size = new System.Drawing.Size(231, 27);
            this.tbNgaySinh.TabIndex = 54;
            // 
            // cbNu
            // 
            this.cbNu.AutoSize = true;
            this.cbNu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNu.Location = new System.Drawing.Point(298, 157);
            this.cbNu.Name = "cbNu";
            this.cbNu.Size = new System.Drawing.Size(48, 23);
            this.cbNu.TabIndex = 44;
            this.cbNu.Text = "Nữ";
            this.cbNu.UseVisualStyleBackColor = true;
            this.cbNu.CheckedChanged += new System.EventHandler(this.cbNu_CheckedChanged);
            // 
            // cbNam
            // 
            this.cbNam.AutoSize = true;
            this.cbNam.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNam.Location = new System.Drawing.Point(225, 156);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(58, 23);
            this.cbNam.TabIndex = 43;
            this.cbNam.Text = "Nam";
            this.cbNam.UseVisualStyleBackColor = true;
            this.cbNam.CheckedChanged += new System.EventHandler(this.cbNam_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(140, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 51;
            this.label6.Text = "Giới tính:";
            // 
            // tbMGV
            // 
            this.tbMGV.Enabled = false;
            this.tbMGV.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMGV.Location = new System.Drawing.Point(478, 64);
            this.tbMGV.Name = "tbMGV";
            this.tbMGV.Size = new System.Drawing.Size(231, 27);
            this.tbMGV.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Mã giảng viên:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(478, 153);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(231, 27);
            this.tbEmail.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(413, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "Email:";
            // 
            // tbSDT
            // 
            this.tbSDT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSDT.Location = new System.Drawing.Point(478, 108);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(231, 27);
            this.tbSDT.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(364, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 45;
            this.label8.Text = "Số điện thoại:";
            // 
            // tbHoTen
            // 
            this.tbHoTen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoTen.Location = new System.Drawing.Point(115, 64);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(231, 27);
            this.tbHoTen.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Ngày Sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Họ và Tên:";
            // 
            // bHuy
            // 
            this.bHuy.Location = new System.Drawing.Point(337, 197);
            this.bHuy.Name = "bHuy";
            this.bHuy.Size = new System.Drawing.Size(40, 35);
            this.bHuy.TabIndex = 57;
            this.bHuy.Text = "❌";
            this.bHuy.UseVisualStyleBackColor = true;
            this.bHuy.Click += new System.EventHandler(this.bHuy_Click);
            // 
            // bXacNhan
            // 
            this.bXacNhan.Location = new System.Drawing.Point(279, 197);
            this.bXacNhan.Name = "bXacNhan";
            this.bXacNhan.Size = new System.Drawing.Size(40, 35);
            this.bXacNhan.TabIndex = 56;
            this.bXacNhan.Text = "✔";
            this.bXacNhan.UseVisualStyleBackColor = true;
            this.bXacNhan.Click += new System.EventHandler(this.bXacNhan_Click);
            // 
            // bSua
            // 
            this.bSua.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSua.Location = new System.Drawing.Point(291, 197);
            this.bSua.Name = "bSua";
            this.bSua.Size = new System.Drawing.Size(75, 35);
            this.bSua.TabIndex = 55;
            this.bSua.Text = "Sửa";
            this.bSua.UseVisualStyleBackColor = true;
            this.bSua.Click += new System.EventHandler(this.bSua_Click);
            // 
            // frmTaiKhoanGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 246);
            this.Controls.Add(this.bHuy);
            this.Controls.Add(this.bXacNhan);
            this.Controls.Add(this.bSua);
            this.Controls.Add(this.tbNgaySinh);
            this.Controls.Add(this.cbNu);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bThoat);
            this.Controls.Add(this.label1);
            this.Name = "frmTaiKhoanGiangVien";
            this.Text = "QuanLyGiangVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bThoat;
        private System.Windows.Forms.DateTimePicker tbNgaySinh;
        private System.Windows.Forms.CheckBox cbNu;
        private System.Windows.Forms.CheckBox cbNam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bHuy;
        private System.Windows.Forms.Button bXacNhan;
        private System.Windows.Forms.Button bSua;
    }
}
namespace FormChinh
{
    partial class MDIForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQlySinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQlyLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmDanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thựcHiệnĐiểmDanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchSửĐiểmDanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.tstbLoaiTaiKhoan = new System.Windows.Forms.ToolStripTextBox();
            this.tstbTenTaiKhoan = new System.Windows.Forms.ToolStripTextBox();
            this.tsmiDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKetThuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.điểmDanhToolStripMenuItem,
            this.tsmiTaiKhoan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQlySinhVien,
            this.mnuQlyLopHoc});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // mnuQlySinhVien
            // 
            this.mnuQlySinhVien.Name = "mnuQlySinhVien";
            this.mnuQlySinhVien.Size = new System.Drawing.Size(180, 22);
            this.mnuQlySinhVien.Text = "Quản lý Sinh Viên";
            this.mnuQlySinhVien.Click += new System.EventHandler(this.mnuQlySinhVien_Click);
            // 
            // mnuQlyLopHoc
            // 
            this.mnuQlyLopHoc.Name = "mnuQlyLopHoc";
            this.mnuQlyLopHoc.Size = new System.Drawing.Size(180, 22);
            this.mnuQlyLopHoc.Text = "Quản lý Lớp Học";
            this.mnuQlyLopHoc.Click += new System.EventHandler(this.mnuQlyLopHoc_Click);
            // 
            // điểmDanhToolStripMenuItem
            // 
            this.điểmDanhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thựcHiệnĐiểmDanhToolStripMenuItem,
            this.lịchSửĐiểmDanhToolStripMenuItem});
            this.điểmDanhToolStripMenuItem.Name = "điểmDanhToolStripMenuItem";
            this.điểmDanhToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.điểmDanhToolStripMenuItem.Text = "Điểm Danh";
            // 
            // thựcHiệnĐiểmDanhToolStripMenuItem
            // 
            this.thựcHiệnĐiểmDanhToolStripMenuItem.Name = "thựcHiệnĐiểmDanhToolStripMenuItem";
            this.thựcHiệnĐiểmDanhToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.thựcHiệnĐiểmDanhToolStripMenuItem.Text = "Thực hiện Điểm danh";
            // 
            // lịchSửĐiểmDanhToolStripMenuItem
            // 
            this.lịchSửĐiểmDanhToolStripMenuItem.Name = "lịchSửĐiểmDanhToolStripMenuItem";
            this.lịchSửĐiểmDanhToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.lịchSửĐiểmDanhToolStripMenuItem.Text = "Lịch sử điểm danh";
            // 
            // tsmiTaiKhoan
            // 
            this.tsmiTaiKhoan.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbTenTaiKhoan,
            this.tstbLoaiTaiKhoan,
            this.tsmiDoiMatKhau,
            this.tsmiDangXuat,
            this.tsmiKetThuc});
            this.tsmiTaiKhoan.Name = "tsmiTaiKhoan";
            this.tsmiTaiKhoan.Size = new System.Drawing.Size(70, 20);
            this.tsmiTaiKhoan.Text = "Tài Khoản";
            // 
            // tstbLoaiTaiKhoan
            // 
            this.tstbLoaiTaiKhoan.Enabled = false;
            this.tstbLoaiTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbLoaiTaiKhoan.Name = "tstbLoaiTaiKhoan";
            this.tstbLoaiTaiKhoan.Size = new System.Drawing.Size(100, 23);
            // 
            // tstbTenTaiKhoan
            // 
            this.tstbTenTaiKhoan.Enabled = false;
            this.tstbTenTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbTenTaiKhoan.Name = "tstbTenTaiKhoan";
            this.tstbTenTaiKhoan.Size = new System.Drawing.Size(100, 23);
            // 
            // tsmiDoiMatKhau
            // 
            this.tsmiDoiMatKhau.Name = "tsmiDoiMatKhau";
            this.tsmiDoiMatKhau.Size = new System.Drawing.Size(180, 22);
            this.tsmiDoiMatKhau.Text = "Đổi mật khẩu";
            this.tsmiDoiMatKhau.Click += new System.EventHandler(this.tsmiDoiMatKhau_Click);
            // 
            // tsmiDangXuat
            // 
            this.tsmiDangXuat.Name = "tsmiDangXuat";
            this.tsmiDangXuat.Size = new System.Drawing.Size(180, 22);
            this.tsmiDangXuat.Text = "Đăng xuất";
            this.tsmiDangXuat.Click += new System.EventHandler(this.tsmiDangXuat_Click);
            // 
            // tsmiKetThuc
            // 
            this.tsmiKetThuc.Name = "tsmiKetThuc";
            this.tsmiKetThuc.Size = new System.Drawing.Size(180, 22);
            this.tsmiKetThuc.Text = "Kết thúc";
            this.tsmiKetThuc.Click += new System.EventHandler(this.tsmiKetThuc_Click);
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(598, 285);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIForm";
            this.Text = "Phần mềm Điểm danh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuQlySinhVien;
        private System.Windows.Forms.ToolStripMenuItem mnuQlyLopHoc;
        private System.Windows.Forms.ToolStripMenuItem điểmDanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thựcHiệnĐiểmDanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchSửĐiểmDanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiTaiKhoan;
        private System.Windows.Forms.ToolStripTextBox tstbTenTaiKhoan;
        private System.Windows.Forms.ToolStripTextBox tstbLoaiTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem tsmiDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem tsmiDangXuat;
        private System.Windows.Forms.ToolStripMenuItem tsmiKetThuc;
    }
}


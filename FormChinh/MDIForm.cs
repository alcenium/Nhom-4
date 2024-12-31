using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormChinh
{
    public partial class MDIForm : Form
    {
        private bool Thoatfrm = false;
        private Form _mainForm;
        private String loaiTK;
        private String tenTK;
        public MDIForm(Form mainForm, String tenTK, String loaiTK)
        {
            InitializeComponent();
            _mainForm = mainForm;
            this.tenTK = tenTK;
            this.loaiTK = loaiTK;

            tstbTenTaiKhoan.Text = $"{tenTK}";
            switch (loaiTK)
            {
                case "ql": tstbLoaiTaiKhoan.Text = "Quản lý"; break;
                case "sv": tstbLoaiTaiKhoan.Text = "Sinh viên"; break;
                case "gv": tstbLoaiTaiKhoan.Text = "Giảng viên"; break;
            }
        }

        private void mnuQlySinhVien_Click(object sender, EventArgs e)
        {
            frmQuanLySinhVien frm = new frmQuanLySinhVien();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuQlyLopHoc_Click(object sender, EventArgs e)
        {
            frmQuanLyLopHoc frm = new frmQuanLyLopHoc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tsmiDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất khỏi tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Thoatfrm = true;
                this.Close();
                frmDangNhap frm = new frmDangNhap();
                frm.Show();
            }
        }

        private void tsmiKetThuc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Thoatfrm = true;
                Application.Exit();
            }
        }

        private void tsmiDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau(tenTK);
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuQlyTaiKhoan_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan frm = new frmQuanLyTaiKhoan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan frm = new frmQuanLyTaiKhoan();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MDIForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Thoatfrm)
            {
                if (MessageBox.Show("Bạn có muốn kết thúc không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

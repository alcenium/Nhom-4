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
    public partial class frmDangNhap : Form
    {
        string sql;
        DataTable dt;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "")
            {
                txtTK.Focus(); return;
            }
            if (txtMK.Text == "")
            {
                txtMK.Focus(); return;
            }

            sql = $"SELECT * FROM QuanLyTaiKhoan WHERE tenTaiKhoan = '{txtTK.Text}' AND matKhau = '{txtMK.Text}'";
            dt = Public.LayDuLieu(sql);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                MDIForm frm = new MDIForm(this, txtTK.Text, dt.Rows[0][2].ToString());
                frm.Show();
            }
            else MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LnkQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmQuenMK frm = new frmQuenMK(this);
            frm.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FormChinh
{
    public partial class frmDangNhap : Form
    {
        string sql;
        DataTable dtDangNhap;
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
            dtDangNhap = Public.LayDuLieu(sql);
            if (dtDangNhap.Rows.Count == 1)
            {
                this.Hide();
                MDIForm frm = new MDIForm(this, txtTK.Text, dtDangNhap.Rows[0][2].ToString());
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

        private void bToggle_Click(object sender, EventArgs e)
        {
            if (bToggle.Text == "👁")
            {
                bToggle.Text = "‿";
                txtMK.PasswordChar = '*';
            }
            else
            {
                bToggle.Text = "👁";
                txtMK.PasswordChar = '\0';
            }
        }
    }
}
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
        SqlConnection conn;
        SqlDataAdapter daDangNhap;
        DataTable dtDangNhap;
        string sql = "";
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

            sql = $"SELECT * FROM DiemDanh WHERE tenTaiKhoan = N'{txtTK.Text}' AND matKhau = N'{txtMK.Text}'";
            dt = Public.LayDuLieu(sql);
            if (dt.Rows.Count == 1)
            {
                sql = $"SELECT chucVu from DiemDanh WHERE tenTaiKhoan = N'{txtTK.Text}'";
                this.Hide();
                MDIForm frm = new MDIForm(this, txtTK.Text, dt.Rows[0][0].ToString());
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

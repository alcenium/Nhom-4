using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormChinh
{
    public partial class frmDoiMatKhau : Form
    {
        private String tenTK;
        private String sql;
        public frmDoiMatKhau(String tenTK)
        {
            InitializeComponent();
            this.tenTK = tenTK;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == "")
            {
                MessageBox.Show("Bạn nhập chưa nhập mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauCu.Focus();
                return;
            }

            sql = $"SELECT * FROM QuanLyTaiKhoan WHERE tenTaiKhoan = '{tenTK}' AND matKhau = '{txtMatKhauCu.Text}'";
            if (Public.LayDuLieu(sql).Rows.Count <= 0)
            {
                MessageBox.Show("Bạn đã nhập sai mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMatKhauCu.Text.Equals(txtMatKhauMoi.Text) == true)
            {
                MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauMoi.Clear();
                txtNhapLaiMK.Clear();
                txtMatKhauMoi.Focus();
                return;
            }

            if (txtMatKhauMoi.Text != txtNhapLaiMK.Text)
            {
                MessageBox.Show("Nhập lại sai!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sql = $"UPDATE QuanLyTaiKhoan SET matKhau = '{txtMatKhauMoi.Text}' WHERE tenTaiKhoan = '{tenTK}'";
            Public.ThucHienSQL(sql);
            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

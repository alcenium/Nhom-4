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
    public partial class frmDangKi : Form
    {
        bool ktThem;
        string macu;
        public frmDangKi()
        {
            InitializeComponent();
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
        }

        private void cmdDangKi_Click(object sender, EventArgs e)
        {
            if (txtTenTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTaiKhoan.Focus();
                return;
            }
            if (Public.ktTrungMa("tenTaiKhoan", "QuanLyTaiKhoan", ktThem, txtTenTaiKhoan.Text, macu) == true)
            {
                MessageBox.Show("Tài khoản đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenTaiKhoan.Focus();
                return;
            }
            if (txtMatKhau.Text == "" || txtMatKhau2.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            if (txtMatKhau.Text.ToUpper().Equals(txtMatKhau2.Text.ToUpper()) == false)
            {
                MessageBox.Show("Mật khẩu mới không giống mật khẩu cũ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau2.Focus();
                return;
            }
            else
            {
                try
                {
                    Public.sql = "INSERT INTO QuanLyTaiKhoan (tenTaiKhoan, matKhau, maChucVu) VALUES (N'" + txtTenTaiKhoan.Text + "',N'" + txtMatKhau.Text + "',N'sv')";
                    if (Public.ThucHienSQL(Public.sql) == true)
                    {
                        MessageBox.Show("Tạo tài khoản thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        frmDangNhap frm = new frmDangNhap();
                        frm.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

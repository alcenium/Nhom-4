using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormChinh
{
    public partial class frmQuenMK : Form
    {
        private frmDangNhap parent;
        private DataTable dtTaiKhoan;
        private int num1 = 0, num2 = 0;
        public frmQuenMK(frmDangNhap parent)
        {
            InitializeComponent();
            ReloadCaptcha();
            this.parent = parent;
        }

        private void ReloadCaptcha()
        {
            Random rd = new Random();
            num1 = rd.Next(1, 100);
            num2 = rd.Next(1, 100);
            lbQuestion.Text = $"{num1} + {num2} = ";
        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {
            if (tbAnswer.Text == $"{num1 + num2}")
            {
                dtTaiKhoan = Public.LayDuLieu(String.Format(HangSo.timTenTaiKhoan, tbTenTaiKhoan.Text));
                if (dtTaiKhoan.Rows.Count <= 0)
                {
                    MessageBox.Show("Sai tên tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ReloadCaptcha();
                    return;
                }

                MessageBox.Show(Text = $"Mật khẩu của bạn là: {dtTaiKhoan.Rows[0]["MatKhau"].ToString()}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Captcha không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ReloadCaptcha();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
    }
}

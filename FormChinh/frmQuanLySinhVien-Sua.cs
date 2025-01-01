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
    public partial class frmQuanLySinhVien_Sua : Form
    {
        String sql;
        frmQuanLySinhVien parent;

        public frmQuanLySinhVien_Sua(frmQuanLySinhVien parent, String msv, String hoTen, String lop, String gioiTinh, DateTime ngaySinh, String sdt, String email)
        {
            InitializeComponent();

            this.parent = parent;

            Public.GanNguonComboBox(cbLop, "maLop", "maLop", "SELECT * FROM Lop");

            tbMaSinhVien.Text   = msv;
            tbHoTen.Text        = hoTen;
            cbLop.DisplayMember = lop;
            dateNgaySinh.Value  = ngaySinh;
            tbSoDienThoai.Text  = sdt;
            tbEmail.Text        = email;
            if (gioiTinh == "Nam")
            {
                cbNam.Checked = true;
            }
            else
            {
                cbNu.Checked = true;
            }
        }

        private void bHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Update();
        }

        private void bXacNhan_Click(object sender, EventArgs e)
        {
            sql = $"UPDATE SinhVien SET hoTen = N'{tbHoTen.Text}', maLop = '{cbLop.Text}', gioiTinh = N'{(cbNam.Checked ? "Nam" : "Nữ")}', ngaySinh = '{dateNgaySinh.Value.ToString("yyyy-MM-dd")}', SDT = '{tbSoDienThoai.Text}', email = '{tbEmail.Text}' WHERE maSV = '{tbMaSinhVien.Text}'";
            Public.ThucHienSQL(sql);
            this.Close();
            parent.Update();
        }

        private void cbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNam.Checked) cbNu.Checked = false;
        }

        private void cbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNu.Checked) cbNam.Checked = false;
        }
    }
}

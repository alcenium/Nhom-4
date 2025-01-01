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
    public partial class frmTaiKhoanSinhVien : Form
    {
        private string maSinhVien;

        public frmTaiKhoanSinhVien(String maSinhVien)
        {
            InitializeComponent();
            this.maSinhVien = maSinhVien;

            LoadInfo();
            KhoaMo(true);
        }

        public void KhoaMo(bool b)
        {
            bSua.Visible     = b;
            bXacNhan.Visible = !b;
            bHuy.Visible     = !b;

            tbHoTen.Enabled    = !b;
            tbNgaySinh.Enabled = !b;
            tbEmail.Enabled    = !b;
            tbSDT.Enabled      = !b;
            cbNam.Enabled      = !b;
            cbNu.Enabled       = !b;
        }

        public void LoadInfo()
        {
            DataTable thongTin = Public.LayDuLieu(String.Format(Queries.layThongTinSinhVien, maSinhVien));
            tbHoTen.Text       = thongTin.Rows[0]["hoTen"].ToString();
            tbNgaySinh.Value   = DateTime.Parse(thongTin.Rows[0]["ngaySinh"].ToString());
            tbSDT.Text         = thongTin.Rows[0]["SDT"].ToString();
            tbEmail.Text       = thongTin.Rows[0]["email"].ToString();
            tbMSV.Text         = thongTin.Rows[0]["maSV"].ToString();
            tbLop.Text         = thongTin.Rows[0]["tenLop"].ToString();
            tbNganh.Text       = thongTin.Rows[0]["tenNganh"].ToString();
            switch (thongTin.Rows[0]["gioiTinh"].ToString())
            {
                case "Nam": cbNam.Checked = true; break;
                case "Nữ" : cbNu.Checked  = true; break;
            }
        }

        private void bSua_Click(object sender, EventArgs e)
        {
            KhoaMo(false);
        }

        private void bXacNhan_Click(object sender, EventArgs e)
        {
            string gioiTinh = cbNam.Checked ? "Nam" : "Nữ";

            Public.ThucHienSQL(String.Format(Queries.suaThongTinSinhVien, tbHoTen.Text, tbNgaySinh.Value, tbSDT.Text, tbEmail.Text, gioiTinh, maSinhVien));
            KhoaMo(true);
            LoadInfo();
        }

        private void bHuy_Click(object sender, EventArgs e)
        {
            KhoaMo(true);
        }

        private void bThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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

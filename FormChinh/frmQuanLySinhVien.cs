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
    public partial class frmQuanLySinhVien : Form
    {
        string maCu = "";
        MDIForm parent;

        public frmQuanLySinhVien(MDIForm parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        void LayNguon(String sql = "Select * From SinhVien")
        {
            Public.GanNguonDataGridView(dgSinhVien, sql);
        }

        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            LayNguon();
            Public.GanNguonComboBox(cbLop, "maLop", "maLop", "SELECT * FROM Lop");
            KhoaMo(true);
        }

        public void Update()
        {
            LayNguon();
            Public.GanNguonComboBox(cbLop, "maLop", "maLop", "SELECT * FROM Lop");
            KhoaMo(true);
        }

        public void KhoaMo(bool b)
        {
            dgSinhVien.Enabled     = b;
            tbMaSinhVien.ReadOnly  = b;
            tbHoTen.ReadOnly       = b;
            tbEmail.ReadOnly       = b;
            tbSoDienThoai.ReadOnly = b;
            dateNgaySinh.Enabled   = !b;
            cbNam.Enabled          = !b;
            cbNu.Enabled           = !b;
            cbLop.Enabled          = !b;
        }

        private void bThem_Click(object sender, EventArgs e)
        {
            if (tbHoTen.Text == "" || cbLop.Text == "" || tbMaSinhVien.Text == "" || tbSoDienThoai.Text == "" || tbEmail.Text == "" || (!cbNam.Checked && !cbNu.Checked))
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ Thông Tin!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String gioiTinh = cbNam.Checked ? "Nam" : "Nữ";

            if (Public.LayDuLieu(String.Format(HangSo.timMaSinhVien, tbMaSinhVien.Text)).Rows.Count > 0)
            {
                MessageBox.Show("Sinh viên với mã đó đã tồn tại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            maCu = "";
            Public.ThucHienSQL(String.Format(HangSo.themSinhVien, tbMaSinhVien.Text, tbHoTen.Text, dateNgaySinh.Value, cbLop.Text, gioiTinh, tbSoDienThoai.Text, tbEmail.Text));
            LayNguon();
        }

        private void bXoa_Click(object sender, EventArgs e)
        {
            if (maCu == "") return;
            Public.ThucHienSQL(String.Format(HangSo.xoaSinhVien, maCu));
            LayNguon();
            maCu = "";
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgSinhVien.Rows.Count <= 0) return;
            if (e == null) return;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgSinhVien.Rows[e.RowIndex];
                tbMaSinhVien.Text   = row.Cells[0].Value.ToString();
                cbLop.DisplayMember = row.Cells[1].Value.ToString();
                tbHoTen.Text        = row.Cells[2].Value.ToString();
                dateNgaySinh.Text   = row.Cells[3].Value.ToString();
                tbSoDienThoai.Text  = row.Cells[5].Value.ToString();
                tbEmail.Text        = row.Cells[6].Value.ToString();
                switch (row.Cells[4].Value.ToString())
                {
                    case "Nam":
                        cbNam.Checked = true;
                        break;
                    case "Nữ":
                        cbNu.Checked = true;
                        break;
                    default:
                        cbNam.Checked = true;
                        break;
                }
                maCu = tbMaSinhVien.Text;
            }
        }

        private void cbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNam.Checked) cbNu.Checked = false;
        }

        private void cbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNu.Checked) cbNam.Checked = false;
        }

        private void bThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSua_Click(object sender, EventArgs e)
        {
            if (maCu == "") return;
            frmQuanLySinhVien_Sua frm = new frmQuanLySinhVien_Sua(this, tbMaSinhVien.Text, tbHoTen.Text, cbLop.DisplayMember, cbNam.Checked ? "Nam" : "Nữ", dateNgaySinh.Value, tbSoDienThoai.Text, tbEmail.Text);
            frm.MdiParent = this.parent;
            frm.Show();
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            LayNguon(String.Format(HangSo.timSinhVien, tbTimKiem.Text));
        }
    }
}

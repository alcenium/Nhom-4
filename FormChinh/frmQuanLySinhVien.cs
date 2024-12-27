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
    public partial class frmQuanLySinhVien : Form
    {
        string sql;
        string maCu = "";
        public frmQuanLySinhVien()
        {
            InitializeComponent();
        }

        void LayNguon(String sql = "Select * From QuanLySinhVien")
        {
            Public.GanNguonDataGridView(dataGridView1, sql);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LayNguon();
        }

        private void bThem_Click(object sender, EventArgs e)
        {
            if (tbHoTen.Text == "" || tbLop.Text == "" || tbMaSinhVien.Text == "" || tbSoDienThoai.Text == "" || tbEmail.Text == "" || (!cbNam.Checked && !cbNu.Checked))
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ Thông Tin!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String gioiTinh = cbNam.Checked ? "M" : "F";

            sql = $"SELECT * FROM QuanLySinhVien WHERE maSV = '{tbMaSinhVien.Text}'";
            if (Public.LayDuLieu(sql).Rows.Count > 0)
            {
                MessageBox.Show("Sinh viên với mã đó đã tồn tại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sql = $"INSERT INTO QuanLySinhVien VALUES ('{tbMaSinhVien.Text}', '{tbHoTen.Text}', '{dateNgaySinh.Value}', '{tbLop.Text}', '{gioiTinh}', '{tbSoDienThoai.Text}', '{tbEmail.Text}')";
            Public.ThucHienSQL(sql);
            LayNguon();
        }

        private void bXoa_Click(object sender, EventArgs e)
        {
            if (maCu == "") return;
            sql = $"DELETE FROM QuanLySinhVien WHERE maSV='{maCu}'";
            Public.ThucHienSQL(sql);
            LayNguon();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0) return;
            if (e == null) return;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                tbMaSinhVien.Text = row.Cells[0].Value.ToString();
                tbHoTen.Text = row.Cells[1].Value.ToString();
                tbLop.Text = row.Cells[3].Value.ToString();
                dateNgaySinh.Text = row.Cells[4].Value.ToString();
                tbSoDienThoai.Text = row.Cells[5].Value.ToString();
                tbEmail.Text = row.Cells[6].Value.ToString();
                switch (row.Cells[2].Value.ToString())
                {
                    case "M":
                        cbNam.Checked = true;
                        break;
                    case "F":
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

        private void button1_Click(object sender, EventArgs e)
        {
            sql = $"SELECT * FROM QuanLySinhVien WHERE maSV LIKE '%{tbTimKiem.Text}%' OR hoTen LIKE '%{tbTimKiem.Text}%' OR maLop LIKE '%{tbTimKiem.Text}%'";
            LayNguon(sql);
        }

        private void bThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSua_Click(object sender, EventArgs e)
        {
            sql = $"SELECT * FROM QuanLySinhVien WHERE maSV = '{tbMaSinhVien.Text}'";
            if (Public.LayDuLieu(sql).Rows.Count != 1)
            {
                MessageBox.Show("Không có sinh viên với mã sinh viên tương ứng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbHoTen.Text == "" || tbLop.Text == "" || tbMaSinhVien.Text == "" || tbSoDienThoai.Text == "" || tbEmail.Text == "" || (!cbNam.Checked && !cbNu.Checked))
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ Thông Tin!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

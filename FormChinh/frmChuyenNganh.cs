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
    public partial class frmChuyenNganh : Form
    {
        private string hoatDong = "",
                       maCu     = "";

        public frmChuyenNganh()
        {
            InitializeComponent();
            KhoaMo(false);
            LayNguon();
        }

        public void LayNguon(String sql = "SELECT * FROM ChuyenNganh")
        {
            Public.GanNguonDataGridView(dgChuyenNganh, sql);
        }

        public void KhoaMo (bool b)
        {
            lbMaChuyenNganh.Visible  = b;
            lbTenChuyenNganh.Visible = b;
            tbMaChuyenNganh.Visible  = b;
            tbTenChuyenNganh.Visible = b;
            bXacNhan.Visible         = b;
            bHuy.Visible             = b;
        }

        private void bThem_Click(object sender, EventArgs e)
        {
            KhoaMo(true);
            hoatDong = "them";
            tbMaChuyenNganh.Clear();
            tbMaChuyenNganh.Focus();
            tbTenChuyenNganh.Clear();
            tbMaChuyenNganh.Enabled = true;
        }

        private void bSua_Click(object sender, EventArgs e)
        {
            KhoaMo(true);
            hoatDong = "sua";
            tbMaChuyenNganh.Focus();
            tbMaChuyenNganh.Enabled = false;
        }

        private void bXacNhan_Click(object sender, EventArgs e)
        {
            if (tbMaChuyenNganh.Text == "" || tbTenChuyenNganh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (Public.LayDuLieu(String.Format(HangSo.timMaChuyenNganh, tbMaChuyenNganh)).Rows.Count >= 1 && hoatDong == "them")
            {
                MessageBox.Show("Mã chuyên ngành đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                switch (hoatDong)
                {
                    case "them":
                        Public.ThucHienSQL(String.Format(HangSo.themChuyenNganh, tbMaChuyenNganh.Text, tbTenChuyenNganh.Text));
                        LayNguon();
                        break;
                    case "sua": 
                        Public.ThucHienSQL(String.Format(HangSo.suaChuyenNganh, tbTenChuyenNganh.Text, tbMaChuyenNganh.Text));
                        LayNguon();
                        break;
                }
            }
        }

        private void bHuy_Click(object sender, EventArgs e)
        {
            KhoaMo(false);
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            LayNguon(String.Format(HangSo.timChuyenNganh, tbMaChuyenNganh.Text, tbTenChuyenNganh.Text));
        }

        private void dgChuyenNganh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbMaChuyenNganh.Text  = maCu = dgChuyenNganh.CurrentRow.Cells[0].Value.ToString();
            tbTenChuyenNganh.Text = dgChuyenNganh.CurrentRow.Cells[1].Value.ToString();
        }

        private void bThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bXoa_Click(object sender, EventArgs e)
        {
            Public.ThucHienSQL(String.Format(HangSo.xoaChuyenNganh, tbMaChuyenNganh.Text));
            LayNguon();
            maCu = dgChuyenNganh.CurrentRow.Cells[0].Value.ToString();
        }
    }
}

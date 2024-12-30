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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormChinh
{
    public partial class frmQuanLyLopHoc : Form
    {
        SqlConnection conn;
        SqlDataAdapter daKhoaHoc, daLop, daKhoa, daNganh, da;
        DataTable dtKhoaHoc, dtLop, dtKhoa, dtNganh, dt;
        DataGridViewCellMouseEventArgs vt;
        string sql = "";
        bool KtThem = true;
        string makhoa = "";
        string macu = "";

        private void cmdToanBo_Click(object sender, EventArgs e)
        {
            makhoa = "";
            LayNguonLop();
        }

        private void cboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            makhoa = cboKhoaHoc.SelectedValue.ToString();
            LayNguonLop();
        }

          public void LayNguonLop()
        {
            if (makhoa == "")
                sql = "Select * from Lop";
            else
                sql = "Select * from Lop where makhoa =N'" + makhoa + "'";
            daLop = new SqlDataAdapter(sql, conn);
            dtLop = new DataTable();
            daLop.Fill(dtLop);
            dgDanhMuc.DataSource = dtLop;
        }
        private void dgDanhMuc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgDanhMuc.Rows.Count > 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        vt = e;
                        DataGridViewRow row = dgDanhMuc.Rows[e.RowIndex];
                        txtMaLop.Text = row.Cells[0].Value.ToString();
                        cboKhoa.SelectedValue = row.Cells[1].Value.ToString();
                        cboNganh.SelectedValue = row.Cells[2].Value.ToString();
                        txtLop.Text = row.Cells[3].Value.ToString();
                        txtGVCN.Text = row.Cells[4].Value.ToString();
                    }
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi " + ev.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            XoaTrang();
            KtThem = true;
            KhoaMo(false);
            txtMaLop.Focus();
            cmdSua.Visible = false;
            cmdXoa.Visible = false;
            cmdThoat.Visible = false;
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text == "") return;
            macu = txtMaLop.Text;
            KtThem = false;
            KhoaMo(false);
            txtMaLop.Focus();
            cmdThem.Visible = false;
            cmdXoa.Visible = false;
            cmdThoat.Visible = false;
        }

        private void cmdNhap_Click(object sender, EventArgs e)
        {
            if(txtMaLop.Text == "")
            {
                MessageBox.Show("Chưa nhập mã lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaLop.Focus();
                return;
            }
            if (txtLop.Text == "")
            {
                MessageBox.Show("Chưa nhập tên lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLop.Focus();
                return;
            }
            if (KtThem == true)
            {
                if (ktTrung_Them(txtMaLop.Text) == true)
                {
                    MessageBox.Show("Mã đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaLop.Focus();
                    return;
                }
            }
            else
            {
                if (ktTrung_Sua(txtMaLop.Text) == true)
                {
                    MessageBox.Show("Mã đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaLop.Focus();
                    return;
                }
            }
            if (KtThem == true)
                sql = "insert into lop(maLop, maKhoa, maNganh, tenLop, gvcn) values (N'" + txtMaLop.Text + "', N'" + cboKhoa.SelectedValue.ToString() +
                    "', N'" + cboNganh.SelectedValue.ToString() + "', N'" + txtLop.Text + "', N'" + txtGVCN.Text + "')";
            else
                sql = "update lop set malop = N'" + txtMaLop.Text + "', maKhoa = N'" + cboKhoa.SelectedValue.ToString() + 
                    "', maNganh = N'" + cboNganh.SelectedValue.ToString() + "', tenLop = N'" + txtLop.Text + "', gvcn = N'" + 
                    txtGVCN.Text + "' where malop = N'" + macu + "'";
            if (conn.State != ConnectionState.Open) conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            KhoaMo(true);
            XoaTrang();
            LayNguonLop();
            cmdSua.Visible = true;
            cmdThoat.Visible = true;
            cmdThem.Visible = true;
            cmdXoa.Visible = true;
        }

        public bool ktTrung_Them(string manhap)
        {
            sql = "Select * from lop where malop = N'" + manhap + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool ktTrung_Sua(string manhap)
        {
            sql = "Select * from lop where malop = N'" + manhap + "' and malop <> N'" + macu + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void cmdHuy_Click(object sender, EventArgs e)
        {
            KhoaMo(true);
            dgDanhMuc_CellMouseClick(sender, vt);
            cmdSua.Visible = true;
            cmdThoat.Visible = true;
            cmdThem.Visible = true;
            cmdXoa.Visible = true;
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text == "") return;
            DialogResult kq = MessageBox.Show("Xác nhận xoá lớp " + txtMaLop.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "Delete from lop where malop = N'" + txtMaLop.Text + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                XoaTrang();
                LayNguonLop();
            }
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmQuanLyLopHoc()
        {
            InitializeComponent();
        }

        private void frmQuanLyLopHoc_Load(object sender, EventArgs e)
        {
            conn = Public.ketNoi();
            LayNguonKhoaHoc();
            LayNguonKhoaHoc_Nganh();
            makhoa = "";
            LayNguonLop();
            KhoaMo(true);
        }

        public void KhoaMo(bool b)
        {
            cboKhoaHoc.Enabled = b;
            cmdToanBo.Enabled = b;
            dgDanhMuc.Enabled = b;

            txtMaLop.ReadOnly = b;
            txtLop.ReadOnly = b;
            txtGVCN.ReadOnly = b;
            cboKhoa.Enabled = !b;
            cboNganh.Enabled = !b;

            cmdThem.Enabled = b;
            cmdSua.Enabled = b;
            cmdThoat.Enabled = b;
            cmdNhap.Visible = !b;
            cmdHuy.Visible = !b;
        }
        public void XoaTrang()
        {
            txtMaLop.Text = ""; txtLop.Text = ""; txtGVCN.Text = "";
        }
        public void LayNguonKhoaHoc()
        {
            sql = "Select * from khoa";
            daKhoaHoc = new SqlDataAdapter(sql, conn);
            dtKhoaHoc = new DataTable();
            daKhoaHoc.Fill(dtKhoaHoc);

            cboKhoaHoc.DataSource = dtKhoaHoc;
            cboKhoaHoc.DisplayMember = "tenKhoa";
            cboKhoaHoc.ValueMember = "maKhoa";
        }
      
        public void LayNguonKhoaHoc_Nganh()
        {
            sql = "Select * from khoa";
            daKhoa = new SqlDataAdapter(sql, conn);
            dtKhoa = new DataTable();
            daKhoa.Fill(dtKhoa);

            cboKhoa.DataSource = dtKhoa;
            cboKhoa.DisplayMember = "tenKhoa";
            cboKhoa.ValueMember = "maKhoa";

            sql = "Select * from chuyennganh";
            daNganh = new SqlDataAdapter(sql, conn);
            dtNganh = new DataTable();
            daNganh.Fill(dtNganh);

            cboNganh.DataSource = dtNganh;
            cboNganh.DisplayMember = "tenNganh";
            cboNganh.ValueMember = "maNganh";
        }
    }
}

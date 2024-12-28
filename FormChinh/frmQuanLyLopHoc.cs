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
    public partial class frmQuanLyLopHoc : Form
    {
        SqlConnection conn;
        SqlDataAdapter daKhoaHoc, daLop, daKhoa, daNganh, da;
        DataTable dtKhoaHoc, dtLop, dtKhoa, dtNganh, dt;

        string sql = "";
        bool KtThem = true;
        string makhoa = "";

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
            makhoa = "";
            LayNguonLop();
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
    }
}

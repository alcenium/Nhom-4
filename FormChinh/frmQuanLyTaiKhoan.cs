using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FormChinh
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        SqlConnection conn;
        SqlDataAdapter daChucVu;
        DataTable dtChucVu;
        bool KtThem;
        string macu;
        string sql = "";
        DataGridViewCellMouseEventArgs vt;
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        void LayNguon(string sql = "Select tenTaiKhoan, matKhau, maChucVu From QuanLyTaiKhoan Order By tenTaiKhoan")
        {
            Public.GanNguonDataGridView(dgDanhMuc, sql);
        }

        public void KhoaMo(bool b)
        {
            dgDanhMuc.Enabled = b;
            txtTaiKhoan.ReadOnly = b;    
            txtMatKhau.ReadOnly = b;
            cboChucVu.Enabled = !b;

            cmdSua.Enabled = b;
            cmdThem.Enabled = b;
            cmdXoa.Enabled = b;
            cmdThoat.Enabled = b;

            cmdNhap.Enabled = !b;
            cmdHuy.Enabled = !b;
        }

        void XoaTrang()
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            conn = Public.ketNoi();
            KhoaMo(true);
            LayNguon();
            LayNguon_ChucVu();
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            KtThem = true;
            KhoaMo(false);
            XoaTrang();
            txtTaiKhoan.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "") return;
            KtThem = false;
            macu = txtTaiKhoan.Text;
            KhoaMo(false);
            txtTaiKhoan.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "") return;
            macu = txtTaiKhoan.Text;
            if (MessageBox.Show("Bạn có muốn xóa tài khoản " + macu + " không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Public.sql = "Delete From QuanLyTaiKhoan Where tenTaiKhoan='" + macu + "'";
                if (Public.ThucHienSQL(Public.sql) == true)
                {
                    MessageBox.Show("Đã xoá tài khoản "+ macu + ".", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XoaTrang();
                    LayNguon();
                }
            }
        }

        private void cmdHuy_Click(object sender, EventArgs e)
        {
            try
            {
                XoaTrang();
                KhoaMo(true);
                dgDanhMuc_CellMouseClick(sender, vt);
            }
            catch (Exception ex) { Console.WriteLine("Error : " + ex.Message.ToString()); }
        }

        private void dgDanhMuc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgDanhMuc.RowCount <= 0) return;
            if (e.RowIndex >= 0)
            {
                vt = e;
                DataGridViewRow row = dgDanhMuc.Rows[e.RowIndex];
                txtTaiKhoan.Text = row.Cells[0].Value.ToString();
                txtMatKhau.Text = row.Cells[1].Value.ToString();
                cboChucVu.SelectedValue = row.Cells[2].Value.ToString();
            }
        }


        private void cmdNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
                return;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }
            if (Public.ktTrungMa("tenTaiKhoan", "QuanLyTaiKhoan", KtThem, txtTaiKhoan.Text, macu) == true)
            {
                MessageBox.Show("Tài khoản bị trùng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Focus();
                return;
            }

            if (KtThem == true)
                Public.sql = "Insert into QuanLyTaiKhoan(tenTaiKhoan, matKhau, maChucVu) Values(N'" + txtTaiKhoan.Text + "',N'" + txtMatKhau.Text + "',N'" + cboChucVu.SelectedValue.ToString() + "')";
            else
                Public.sql = "Update QuanLyTaiKhoan Set tenTaiKhoan=N'" + txtTaiKhoan.Text + "', matKhau=N'" + txtMatKhau.Text + "', maChucVu = N'" + cboChucVu.SelectedValue.ToString() + "' Where tenTaiKhoan=N'" + macu + "'";
            if (Public.ThucHienSQL(Public.sql) == true)
            {
                MessageBox.Show("Cập nhật tài khoản thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                XoaTrang();
                KhoaMo(true);
                LayNguon();
                try
                {
                    dgDanhMuc_CellMouseClick(sender, vt);
                }
                catch (Exception ex) { Console.WriteLine("Lỗi: " + ex.Message.ToString()); }
            }
        }


        public void LayNguon_ChucVu()
        {
            sql = "Select * from ChucVu";
            daChucVu = new SqlDataAdapter(sql, conn);
            dtChucVu = new DataTable();
            daChucVu.Fill(dtChucVu);

            cboChucVu.DataSource = dtChucVu;
            cboChucVu.DisplayMember = "tenChucVu";
            cboChucVu.ValueMember = "maChucVu";
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            LayNguon($"SELECT * FROM QuanLyTaiKhoan WHERE tenTaiKhoan LIKE '%{tbTimKiem.Text}%' OR maChucVu LIKE '%{tbTimKiem.Text}%'");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormChinh
{
    internal class Public
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        static string sql;


        public static SqlConnection ketnoi()
        {
            string connString = "Data Source=WINDOW\\ALCENIUM;Initial Catalog=DiemDanh;Integrated Security=True;Encrypt=False";
            //string connString = "Data Source=LAPTOP-N5BUPLIL;Initial Catalog=DiemDanh;Integrated Security=True;Encrypt=False";
            //string connString = "Data Source=DESKTOP-1FODL3G\USTEAM;Initial Catalog=DiemDanh;Integrated Security=True;Encrypt=False";
            //string connString = "Data Source=LTANH59\\MSSQLSERVER01;Initial Catalog=DiemDanh;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }

        public static DataTable LayDuLieu(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, ketnoi());
            DataTable dt = new DataTable();
            da.Fill(dt);
            //conn.Close();
            return dt;
        }
        public static void GanNguonDataGridView(DataGridView dgName, string sql)
        {
            dgName.DataSource = LayDuLieu(sql);
        }

        public static void GanNguonComboBox(ComboBox cboName, string TableName, string DisplayField, string KeyField)
        {
            sql = $"Select {KeyField},{DisplayField} From {TableName}";
            cboName.DataSource = LayDuLieu(sql);
            cboName.DisplayMember = DisplayField;
            cboName.ValueMember = KeyField;
        }

        public static bool ThucHienSQL(string sql)
        {
            try
            {
                cmd = new SqlCommand(sql, ketnoi());
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực hiện truy vấn:" + ex.Message.ToString(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

    }
}

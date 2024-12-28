using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace FormChinh
{
    internal class Public
    {
        public static string sql, TenDN, MatKhau, HoTen;
        public static SqlConnection conn;
        public static SqlCommand cmd;



        public static SqlConnection ketNoi()
        {
            string connString = "Data Source=WINDOW\\ALCENIUM;Initial Catalog=DiemDanh;Integrated Security=True;Encrypt=False";
            //string connString = "Data Source=LAPTOP-N5BUPLIL;Initial Catalog=DiemDanh;Integrated Security=True;Encrypt=False";
            //string connString = @"Data Source=DESKTOP-1FODL3G\USTEAM;Initial Catalog=DiemDanh;Integrated Security=True;Encrypt=False";
            //string connString = "Data Source=LTANH59\\MSSQLSERVER01;Initial Catalog=DiemDanh;Integrated Security=True;Encrypt=False";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }

        public static DataTable LayDuLieu(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, ketNoi());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static bool ThucHienSQL(string sql)
        {
            try
            {
                cmd = new SqlCommand(sql, ketNoi());
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { Console.WriteLine("Error : " + ex.Message.ToString()); }
            return false;
        }
        public static void GanNguonDataGridView(DataGridView dgName, string sql)
        {
            dgName.DataSource = LayDuLieu(sql);
        }
        public static void GanNguonComboBox(ComboBox cboName, string DisplayField, string KeyField, string sql)
        {
            cboName.DataSource = LayDuLieu(sql);
            cboName.DisplayMember = DisplayField;
            cboName.ValueMember = KeyField;
        }
        public static bool ktTrungMa(string FieldName, string Table, bool ktThem, string ValueNew, string ValueOld)
        {
            DataTable dt;
            if (ktThem == true)
                sql = "Select " + FieldName + " From " + Table + " Where " + FieldName + " = '" + ValueNew + "'";
            else
                sql = "Select " + FieldName + " From " + Table + " Where " + FieldName + " = '" + ValueNew + "' and " + FieldName + " <> '" + ValueOld + "'";
            dt = LayDuLieu(sql);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static bool IsDate(String date)
        {
            try
            {
                DateTime Temp;
                if (DateTime.TryParse(date, out Temp) == true)
                    return true;
                else
                    return false;
            }
            catch (Exception ex) { ex.Message.ToString(); return false; }
        }

        public static bool IsUnicode(string input)
        {
            return Encoding.ASCII.GetByteCount(input) != Encoding.UTF8.GetByteCount(input);
        }
        public static bool IsNumber(string pText)
        {
            if (pText == "") return false;
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        public static bool IsBoolean(string pText)
        {
            if (pText.ToUpper() == "TRUE" || pText.ToUpper() == "FALSE")
                return true;
            else
                return false;
        }

        public static string TaoMaString(string FieldName, string Table)
        {
            double num = 1;
            sql = "Select Top 1 " + FieldName + " From " + Table + " Order By " + FieldName + " Desc";
            DataTable dt = LayDuLieu(sql);
            if (dt.Rows.Count > 0)
                num = double.Parse(dt.Rows[0][FieldName].ToString()) + 1;
            return num.ToString("0000000000");
        }

        public static int TaoMaID(string FieldName, string Table)
        {
            int num = 1;
            sql = "Select Top 1 " + FieldName + " From " + Table + " Order By " + FieldName + " Desc";
            DataTable dt = LayDuLieu(sql);
            if (dt.Rows.Count > 0)
                num = Int32.Parse(dt.Rows[0][FieldName].ToString()) + 1;
            return num;
        }

        public static void XuatFileExcel(DataGridView dataGridView1, string fileName)
        {
            /*khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
                - vào menu Project / chọn add reference..
                - chọn mục COM
                - tìm và tích chọn Microsoft Excel [xx.x] Object Library
                - nếu trước cài bản office cao hơn và bị báo lỗi Unable to cast COM object of type 'Microsoft.Office.Interop.Excel.ApplicationClass' to interface type 'Microsoft.Office.Interop.Excel._Application'. This operation failed because the QueryInterface call on the COM component for the interface with IID '{000208D5-0000-0000-C000-000000000046}
                    + vào run, gõ regedit để mở thanh ghi
                    + Computer\HKEY_CLASSES_ROOT\TypeLib\{00020813-0000-0000-C000-000000000046} xóa thư mục 1.9 giữ lại mục có nội dung Microsoft Excel [xx.x] Object Library
                    + Computer\HKEY_CLASSES_ROOT\TypeLib\{00020905-0000-0000-C000-000000000046} giữ lại mục có nội dung Microsoft Word xx.x Object Library
            */
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);//tạo mới một Workbooks bằng phương thức add()
                worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                //xuất danh sách tiêu đề cột
                for (int i = 0; i < dataGridView1.ColumnCount; i++)//tạo dòng tiêu đề từ cột trong DataGridView
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                //xuất danh sách nội dung dòng
                for (int i = 0; i < dataGridView1.RowCount; i++)//xuất nội dung các dòng tiếp theo
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = "'" + dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }

                workbook.SaveAs(fileName);//lưu tập tin                
                //workbook.Close();//đóng tập tin
                //excel.Quit();//thoát khỏi excel
                //Process.Start("Explorer.exe", fileName);//mở tập tin trên máy qua đường dẫn
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                worksheet = null;
                workbook = null;
            }
        }
        public static void XuatFileExcelLV(ListView listView1, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                //xuất danh sách tiêu đề cột
                for (int i = 0; i < listView1.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = listView1.Columns[i].Text;
                }
                //xuất danh sách nội dung dòng
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    int j = 0;
                    worksheet.Cells[i + 2, j + 1] = "'" + listView1.Items[i].Text;
                    for (j = 1; j < listView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = "'" + listView1.Items[i].SubItems[j].Text;
                    }
                }

                workbook.SaveAs(fileName);//lưu tập tin                
                //workbook.Close();//đóng tập tin
                //excel.Quit();//thoát khỏi excel
                //Process.Start("Explorer.exe", fileName);//mở tập tin trên máy qua đường dẫn
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                worksheet = null;
                workbook = null;
            }
        }
    }
}
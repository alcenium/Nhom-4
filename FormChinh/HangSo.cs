using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormChinh
{
    internal class HangSo
    {
        ////// Quản lý chuyên ngành \\\\\\
        public static string sqlChuyenNganh = "SELECT * FROM ChuyenNganh";
        public static string timChuyenNganh = "SELECT * FROM ChuyenNganh WHERE maNganh LIKE '%{0}%' OR tenNganh LIKE '%{1}%'";
        public static string themChuyenNganh = "INSERT INTO ChuyenNganh VALUES ('{0}', N'{1}')";
        public static string suaChuyenNganh = "UPDATE ChuyenNganh SET tenNganh = N'{0}' WHERE maNganh = '{1}'";
        public static string xoaChuyenNganh = "DELETE FROM ChuyenNganh WHERE maNganh = '{0}'";
        public static string timMaChuyenNganh = "SELECT * FROM ChuyenNganh WHERE maNganh = '{0}'";

        ////// MDI Form \\\\\\
        public static string loaiTaiKhoan = "SELECT tenChucVu FROM ChucVu WHERE maChucVu = '{0}'";
    }
}

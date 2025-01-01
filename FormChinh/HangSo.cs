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
        public static string sqlChuyenNganh   = "SELECT * FROM ChuyenNganh";
        public static string timChuyenNganh   = "SELECT * FROM ChuyenNganh WHERE maNganh LIKE '%{0}%' OR tenNganh LIKE '%{1}%'";
        public static string themChuyenNganh  = "INSERT INTO ChuyenNganh VALUES ('{0}', N'{1}')";
        public static string suaChuyenNganh   = "UPDATE ChuyenNganh SET tenNganh = N'{0}' WHERE maNganh = '{1}'";
        public static string xoaChuyenNganh   = "DELETE FROM ChuyenNganh WHERE maNganh = '{0}'";
        public static string timMaChuyenNganh = "SELECT * FROM ChuyenNganh WHERE maNganh = '{0}'";

        ////// MDI Form \\\\\\
        public static string loaiTaiKhoan     = "SELECT tenChucVu FROM ChucVu WHERE maChucVu = '{0}'";

        ////// Đăng nhập \\\\\\
        public static string timTaiKhoan      = "SELECT * FROM QuanLyTaiKhoan WHERE tenTaiKhoan = N'{0}' AND matKhau = N'{1}'";

        ////// Đổi mật khẩu \\\\\\
        public static string doiMatKhau       = "UPDATE QuanLyTaiKhoan SET matKhau = '{0}' WHERE tenTaiKhoan = '{1}'";

        ////// Quên mật khẩu \\\\\\
        public static string timTenTaiKhoan   = "SELECT * FROM QuanLyTaiKhoan WHERE tenTaiKhoan = '{0}'";

        ////// Quản lý sinh viên \\\\\\
        public static string timSinhVien      = "SELECT * FROM SinhVien WHERE maSV LIKE '%{0}%' OR hoTen LIKE '%{0}%' OR maLop LIKE '%{0}%'";
        public static string timMaSinhVien    = "SELECT * FROM SinhVien WHERE maSV = '{0}'";
        public static string themSinhVien     = "INSERT INTO SinhVien VALUES ('{0}', N'{1}', '{2}', '{3}', '{4}', '{5}', '{6}')";
        public static string xoaSinhVien      = "DELETE FROM SinhVien WHERE maSV='{0}'";
    }
}

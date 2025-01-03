USE [master]
GO
/****** Object:  Database [DiemDanh]    Script Date: 1/1/2025 9:31:58 AM ******/
CREATE DATABASE [DiemDanh]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DiemDanh', FILENAME = N'D:\DiemDanh.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DiemDanh_log', FILENAME = N'D:\DiemDanh_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DiemDanh] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DiemDanh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DiemDanh] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DiemDanh] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DiemDanh] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DiemDanh] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DiemDanh] SET ARITHABORT OFF 
GO
ALTER DATABASE [DiemDanh] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DiemDanh] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DiemDanh] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DiemDanh] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DiemDanh] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DiemDanh] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DiemDanh] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DiemDanh] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DiemDanh] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DiemDanh] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DiemDanh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DiemDanh] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DiemDanh] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DiemDanh] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DiemDanh] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DiemDanh] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DiemDanh] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DiemDanh] SET RECOVERY FULL 
GO
ALTER DATABASE [DiemDanh] SET  MULTI_USER 
GO
ALTER DATABASE [DiemDanh] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DiemDanh] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DiemDanh] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DiemDanh] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DiemDanh] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DiemDanh] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DiemDanh', N'ON'
GO
ALTER DATABASE [DiemDanh] SET QUERY_STORE = ON
GO
ALTER DATABASE [DiemDanh] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DiemDanh]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 1/1/2025 9:31:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[maChucVu] [nvarchar](50) NULL,
	[tenChucVu] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuyenNganh]    Script Date: 1/1/2025 9:31:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuyenNganh](
	[maNganh] [nvarchar](50) NOT NULL,
	[tenNganh] [nvarchar](255) NULL,
 CONSTRAINT [PK_ChuyenNganh] PRIMARY KEY CLUSTERED 
(
	[maNganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 1/1/2025 9:31:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[maGV] [nvarchar](50) NOT NULL,
	[hoTen] [nvarchar](255) NULL,
	[ngaySinh] [date] NULL,
	[gioiTinh] [nvarchar](16) NULL,
	[SDT] [nvarchar](16) NULL,
	[email] [nvarchar](255) NULL,
 CONSTRAINT [PK_GiangVien] PRIMARY KEY CLUSTERED 
(
	[maGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocPhan]    Script Date: 1/1/2025 9:31:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocPhan](
	[maHocPhan] [nvarchar](50) NOT NULL,
	[tenHocPhan] [nvarchar](255) NULL,
 CONSTRAINT [PK_HocPhan] PRIMARY KEY CLUSTERED 
(
	[maHocPhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 1/1/2025 9:31:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[maKhoa] [nvarchar](50) NOT NULL,
	[tenKhoa] [nvarchar](255) NULL,
	[nienKhoa] [nvarchar](50) NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[maKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 1/1/2025 9:31:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[maLop] [nvarchar](50) NOT NULL,
	[maKhoa] [nvarchar](50) NULL,
	[maNganh] [nvarchar](50) NULL,
	[tenLop] [nvarchar](50) NULL,
	[GVCN] [nvarchar](50) NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[maLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanLyDiemDanh]    Script Date: 1/1/2025 9:31:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanLyDiemDanh](
	[maLich] [nvarchar](50) NULL,
	[maSV] [nvarchar](50) NULL,
	[ngay] [date] NULL,
	[tinhTrang] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanLyLich]    Script Date: 1/1/2025 9:31:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanLyLich](
	[maLich] [nvarchar](50) NOT NULL,
	[maHocPhan] [nvarchar](50) NULL,
	[maLop] [nvarchar](50) NULL,
	[maGV] [nvarchar](50) NULL,
	[tietBatDau] [tinyint] NULL,
	[tietKetThuc] [tinyint] NULL,
	[ngayBatDau] [date] NULL,
	[ngayKetThuc] [date] NULL,
 CONSTRAINT [PK_QuanLyLich] PRIMARY KEY CLUSTERED 
(
	[maLich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanLyTaiKhoan]    Script Date: 1/1/2025 9:31:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanLyTaiKhoan](
	[tenTaiKhoan] [nvarchar](255) NOT NULL,
	[matKhau] [nvarchar](50) NULL,
	[chucVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_QuanLyTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[tenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 1/1/2025 9:31:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[maSV] [nvarchar](50) NOT NULL,
	[maLop] [nvarchar](50) NULL,
	[hoTen] [nvarchar](255) NULL,
	[ngaySinh] [date] NULL,
	[gioiTinh] [nvarchar](16) NULL,
	[SDT] [nvarchar](16) NULL,
	[email] [nvarchar](255) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[maSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVu]) VALUES (N'ql', N'Quản lý')
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVu]) VALUES (N'sv', N'Sinh viên')
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVu]) VALUES (N'gv', N'Giảng viên')
GO
INSERT [dbo].[ChuyenNganh] ([maNganh], [tenNganh]) VALUES (N'CNTT', N'CÔNG NGHỆ THÔNG TIN')
INSERT [dbo].[ChuyenNganh] ([maNganh], [tenNganh]) VALUES (N'HTTT', N'HỆ THỐNG THÔNG TIN')
INSERT [dbo].[ChuyenNganh] ([maNganh], [tenNganh]) VALUES (N'KDTM', N'KINH DANH THƯƠNG MẠI')
INSERT [dbo].[ChuyenNganh] ([maNganh], [tenNganh]) VALUES (N'KT', N'KẾ TOÁN')
INSERT [dbo].[ChuyenNganh] ([maNganh], [tenNganh]) VALUES (N'QTKD', N'QUẢN TRỊ KINH DOANH')
GO
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV000', N'Nguyễn Văn An', CAST(N'1985-03-15' AS Date), N'Nam', N'0901234567', N'nguyenvanan@example.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV001', N'Triệu Đình Mạnh', CAST(N'1990-01-01' AS Date), N'Nam', N'0311929035', N'GV001@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV002', N'Cao Xuân Hoàng', CAST(N'1990-01-02' AS Date), N'Nam', N'0991956418', N'GV002@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV003', N'Phạm Đức Anh', CAST(N'1990-01-03' AS Date), N'Nam', N'0966576739', N'GV003@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV004', N'Trần Duy Dũng', CAST(N'1990-01-04' AS Date), N'Nam', N'0940080808', N'GV004@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV005', N'Đoàn Thị Thanh Hằng', CAST(N'1990-01-05' AS Date), N'Nữ', N'0378933892', N'GV005@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV006', N'Vũ Thị Thu Hà', CAST(N'1990-01-06' AS Date), N'Nữ', N'0931613406', N'GV006@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV007', N'Lê Chí Luận', CAST(N'1990-01-07' AS Date), N'Nam', N'0399238666', N'GV007@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV008', N'Lê Thị Chi', CAST(N'1990-01-08' AS Date), N'Nữ', N'0318572910', N'GV008@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV009', N'Nguyễn Thị Kim Huệ', CAST(N'1990-01-09' AS Date), N'Nữ', N'0398587170', N'GV009@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV010', N'Đỗ Bảo Sơn', CAST(N'1990-01-10' AS Date), N'Nam', N'0372329533', N'GV010@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV011', N'Nguyễn Thái Sơn', CAST(N'1990-01-11' AS Date), N'Nam', N'0985509784', N'GV011@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV012', N'Lương Hoàng Anh', CAST(N'1990-01-12' AS Date), N'Nam', N'0929310879', N'GV012@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV013', N'Lê Thanh Tấn', CAST(N'1990-01-13' AS Date), N'Nam', N'0376787376', N'GV013@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV014', N'Bùi Thị Như', CAST(N'1990-01-14' AS Date), N'Nữ', N'0335808465', N'GV014@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV015', N'Phạm Trường Giang', CAST(N'1990-01-15' AS Date), N'Nữ', N'0347009848', N'GV015@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV016', N'Hoàng Thị Thúy', CAST(N'1990-01-16' AS Date), N'Nữ', N'0374281785', N'GV016@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV017', N'Vương Thị Hương', CAST(N'1990-01-17' AS Date), N'Nữ', N'0936749591', N'GV017@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV018', N'Nguyễn Thị Thu Hiền', CAST(N'1990-01-18' AS Date), N'Nữ', N'0968333028', N'GV018@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV019', N'Vũ Văn Linh', CAST(N'1990-01-19' AS Date), N'Nam', N'0363980698', N'GV019@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV020', N'Ngô Thị Thu Tình', CAST(N'1990-01-20' AS Date), N'Nữ', N'0371348840', N'GV020@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV021', N'Bùi Hải Đăng', CAST(N'1990-01-21' AS Date), N'Nam', N'0343312124', N'GV021@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV022', N'Hoàng Thế Phương', CAST(N'1990-01-22' AS Date), N'Nam', N'0925086388', N'GV022@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV023', N'Đỗ Xuân Thu', CAST(N'1990-01-23' AS Date), N'Nữ', N'0349585829', N'GV023@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV024', N'Nguyễn Công Nam', CAST(N'1990-01-24' AS Date), N'Nam', N'0339693067', N'GV024@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV025', N'Lê Thị Hà', CAST(N'1990-01-25' AS Date), N'Nữ', N'0315024572', N'GV025@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV026', N'Bùi Thị Nhung', CAST(N'1990-01-26' AS Date), N'Nữ', N'0926792419', N'GV026@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV027', N'Tô Hải Thiên', CAST(N'1990-01-27' AS Date), N'Nam', N'0376556448', N'GV027@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV028', N'Phan Như Minh', CAST(N'1990-01-28' AS Date), N'Nữ', N'0917391210', N'GV028@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV029', N'Trần Thị Phương Thanh', CAST(N'1990-01-29' AS Date), N'Nữ', N'0926016655', N'GV029@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV030', N'Lương Việt Trung', CAST(N'1990-01-30' AS Date), N'Nam', N'0958609773', N'GV030@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV031', N'Phạm Thị Thuận', CAST(N'1990-01-31' AS Date), N'Nữ', N'0339725137', N'GV031@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV032', N'Lê Trung Kiên', CAST(N'1990-02-01' AS Date), N'Nam', N'0953474424', N'GV032@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV033', N'Mạc Văn Quang', CAST(N'1990-02-02' AS Date), N'Nam', N'0958634656', N'GV033@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV034', N'Ngô Việt Phương', CAST(N'1990-02-03' AS Date), N'Nam', N'0322521496', N'GV034@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV035', N'Nguyễn Đình Nga', CAST(N'1990-02-04' AS Date), N'Nam', N'0991393455', N'GV035@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV036', N'Đặng Thị Kim Anh', CAST(N'1990-02-05' AS Date), N'Nữ', N'0363983448', N'GV036@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV037', N'Võ Thanh Được', CAST(N'1990-02-06' AS Date), N'Nam', N'0933929355', N'GV037@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV038', N'Nguyễn Văn Cường', CAST(N'1990-02-07' AS Date), N'Nam', N'0332958374', N'GV038@gmail.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV039', N'Khuất Thị Ngọc Ánh', CAST(N'1990-02-08' AS Date), N'Nữ', N'0370331857', N'GV039@gmail.com')
GO
INSERT [dbo].[HocPhan] ([maHocPhan], [tenHocPhan]) VALUES (N'HP001', N'Toán Đại Cương')
INSERT [dbo].[HocPhan] ([maHocPhan], [tenHocPhan]) VALUES (N'HP002', N'Lý Thuyết Xác Suất')
INSERT [dbo].[HocPhan] ([maHocPhan], [tenHocPhan]) VALUES (N'HP003', N'Tin Học Đại Cương')
INSERT [dbo].[HocPhan] ([maHocPhan], [tenHocPhan]) VALUES (N'HP004', N'Văn Học Việt Nam')
INSERT [dbo].[HocPhan] ([maHocPhan], [tenHocPhan]) VALUES (N'HP005', N'Toán Rời Rạc')
INSERT [dbo].[HocPhan] ([maHocPhan], [tenHocPhan]) VALUES (N'HP006', N'Ngôn Ngữ Lập Trình C')
INSERT [dbo].[HocPhan] ([maHocPhan], [tenHocPhan]) VALUES (N'HP007', N'Lập Trình Java Cơ Bản')
INSERT [dbo].[HocPhan] ([maHocPhan], [tenHocPhan]) VALUES (N'HP008', N'Java Nâng Cao')
INSERT [dbo].[HocPhan] ([maHocPhan], [tenHocPhan]) VALUES (N'HP009', N'Lập Trình Hướng Đối Tượng C++')
INSERT [dbo].[HocPhan] ([maHocPhan], [tenHocPhan]) VALUES (N'HP010', N'Lập Trình Trực Quan C#')
GO
INSERT [dbo].[Khoa] ([maKhoa], [tenKhoa], [nienKhoa]) VALUES (N'K001', N'K74', N'2024-2025')
INSERT [dbo].[Khoa] ([maKhoa], [tenKhoa], [nienKhoa]) VALUES (N'K002', N'K75', N'2025-2026')
INSERT [dbo].[Khoa] ([maKhoa], [tenKhoa], [nienKhoa]) VALUES (N'K003', N'K76', N'2026-2027')
INSERT [dbo].[Khoa] ([maKhoa], [tenKhoa], [nienKhoa]) VALUES (N'K1', N'K74', N'2024-2025')
INSERT [dbo].[Khoa] ([maKhoa], [tenKhoa], [nienKhoa]) VALUES (N'K2', N'K75', N'2025-2026')
INSERT [dbo].[Khoa] ([maKhoa], [tenKhoa], [nienKhoa]) VALUES (N'K3', N'K76', N'2026-2027')
GO
INSERT [dbo].[Lop] ([maLop], [maKhoa], [maNganh], [tenLop], [GVCN]) VALUES (N'74DCTT21', N'K001', N'CNTT', N'Lớp 74DCTT21', N'GV0001')
INSERT [dbo].[Lop] ([maLop], [maKhoa], [maNganh], [tenLop], [GVCN]) VALUES (N'74DCTT22', N'K002', N'CNTT', N'Lớp 74DCTT22', N'GV0001')
INSERT [dbo].[Lop] ([maLop], [maKhoa], [maNganh], [tenLop], [GVCN]) VALUES (N'74DCTT23', N'K003', N'CNTT', N'Lớp 74DCTT23', N'GV0001')
INSERT [dbo].[Lop] ([maLop], [maKhoa], [maNganh], [tenLop], [GVCN]) VALUES (N'75DCTT22', N'K2', N'HTTT', N'Lớp 74DCTT22', N'GV0002')
INSERT [dbo].[Lop] ([maLop], [maKhoa], [maNganh], [tenLop], [GVCN]) VALUES (N'75DCTT23', N'K2', N'KT', N'Lớp 75DCTT22', N'GV0003')
INSERT [dbo].[Lop] ([maLop], [maKhoa], [maNganh], [tenLop], [GVCN]) VALUES (N'76DDTT22', N'K3', N'KT', N'Lớp 76DDTT22', N'GV0003')
GO
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21009', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21046', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21067', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21097', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21102', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21112', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21169', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21181', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21186', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21198', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21247', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21321', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21328', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21344', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21347', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21393', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21394', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21449', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21525', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21539', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21556', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT21591', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22030', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22062', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22064', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22089', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22121', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22122', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22123', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22127', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22128', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22141', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22176', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22214', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22234', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22237', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22242', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22267', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22307', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22319', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22345', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22351', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22365', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22371', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22372', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22399', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22425', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22438', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22451', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22458', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22460', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22470', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22486', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22492', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22516', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22534', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22544', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22563', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22575', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22580', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22588', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'74DCTT22593', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'ad', N'1', N'ql')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'an', N'1', N'ql')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'GV0001', N'1', N'gv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'GV0002', N'1', N'gv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'GV0003', N'1', N'gv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'GV0004', N'1', N'gv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'GV0005', N'1', N'gv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'GV0006', N'1', N'gv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'GV0007', N'1', N'gv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'GV0008', N'1', N'gv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'GV0009', N'1', N'gv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'GV0010', N'1', N'gv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'Mạnh Hùng', N'1', N'ql')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'Thế Anh', N'1', N'ql')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [chucVu]) VALUES (N'Tuấn Anh', N'1', N'ql')
GO
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21009', N'74DCTT21', N'Trần Thượng Viện', CAST(N'2005-09-12' AS Date), N'Nam', N'0943343897', N'74DCTT21009@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21046', N'74DCTT21', N'Vũ Thanh Bình', CAST(N'2005-09-19' AS Date), N'Nam', N'0973237735', N'74DCTT21046@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21067', N'74DCTT21', N'Phạm Thị Ngọc Bích', CAST(N'2005-05-23' AS Date), N'Nữ', N'0952227538', N'74DCTT21067@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21097', N'74DCTT21', N'Vũ Hoàng Minh', CAST(N'2005-04-03' AS Date), N'Nam', N'0967264526', N'74DCTT21097@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21102', N'74DCTT21', N'Nguyễn Khánh Tùng', CAST(N'2005-01-24' AS Date), N'Nam', N'0921017870', N'74DCTT21102@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21112', N'74DCTT21', N'Bùi Đức Huy', CAST(N'2005-01-08' AS Date), N'Nam', N'0939411661', N'74DCTT21112@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21169', N'74DCTT21', N'Lương Thế Anh', CAST(N'2005-02-01' AS Date), N'Nam', N'0935975340', N'74DCTT21169@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21181', N'74DCTT21', N'Nguyễn Đức Tiến', CAST(N'2005-01-24' AS Date), N'Nam', N'0996086195', N'74DCTT21181@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21186', N'74DCTT21', N'Lê Mạnh Hùng', CAST(N'2005-05-24' AS Date), N'Nam', N'0973486895', N'74DCTT21186@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21198', N'74DCTT21', N'Phạm Trung Kiên', CAST(N'2005-03-23' AS Date), N'Nam', N'0969832376', N'74DCTT21198@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21247', N'74DCTT21', N'Nguyễn Văn Trung', CAST(N'2005-01-08' AS Date), N'Nam', N'0978066050', N'74DCTT21247@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21321', N'74DCTT21', N'Hoàng Hải Hưng', CAST(N'2005-09-23' AS Date), N'Nam', N'0951919371', N'74DCTT21321@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21328', N'74DCTT21', N'Vũ Nguyễn Song Khanh', CAST(N'2005-01-23' AS Date), N'Nam', N'0957003434', N'74DCTT21328@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21344', N'74DCTT21', N'Nguyễn Khắc Đức', CAST(N'2005-05-09' AS Date), N'Nam', N'0963875730', N'74DCTT21344@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21347', N'74DCTT21', N'Nguyễn Mạnh Hưng', CAST(N'2005-12-24' AS Date), N'Nam', N'0967313515', N'74DCTT21347@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21393', N'74DCTT21', N'Mai Văn Nguyễn Dương', CAST(N'2005-04-03' AS Date), N'Nam', N'0996754638', N'74DCTT21393@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21394', N'74DCTT21', N'Triệu Quang Ninh', CAST(N'2005-01-17' AS Date), N'Nam', N'0928566896', N'74DCTT21394@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21449', N'74DCTT21', N'Đinh Thị Như Quỳnh', CAST(N'2005-10-19' AS Date), N'Nữ', N'0952790066', N'74DCTT21449@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21525', N'74DCTT21', N'Lê Quảng An', CAST(N'2005-03-02' AS Date), N'Nam', N'0951706358', N'74DCTT21525@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21539', N'74DCTT21', N'Phạm Quang Huy', CAST(N'2005-06-06' AS Date), N'Nam', N'0962458027', N'74DCTT21539@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21556', N'74DCTT21', N'Mai Đức Hiếu', CAST(N'2005-12-24' AS Date), N'Nam', N'0988387372', N'74DCTT21556@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21591', N'74DCTT21', N'Hoàng Thị Ngoan', CAST(N'2005-12-12' AS Date), N'Nữ', N'0979953031', N'74DCTT21591@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22030', N'74DCTT21', N'Vũ Tiến Dũng', CAST(N'2005-01-01' AS Date), N'Nam', N'0912894924', N'74DCTT22030@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22062', N'74DCTT21', N'Phùng Mạnh Phúc', CAST(N'2005-03-29' AS Date), N'Nam', N'0952757885', N'74DCTT22062@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22064', N'74DCTT21', N'Nguyễn Xuân Lộc', CAST(N'2005-07-21' AS Date), N'Nam', N'0935179555', N'74DCTT22064@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22089', N'74DCTT21', N'Trần Nguyễn Hoàng', CAST(N'2005-01-08' AS Date), N'Nam', N'0918749860', N'74DCTT22089@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22121', N'74DCTT21', N'Nguyễn Mạnh Quỳnh', CAST(N'2005-09-19' AS Date), N'Nam', N'0931428885', N'74DCTT22121@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22122', N'74DCTT21', N'Lại Tuấn Anh', CAST(N'2005-12-27' AS Date), N'Nam', N'0976511197', N'74DCTT22122@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22123', N'74DCTT21', N'Phạm Phương Anh', CAST(N'2005-09-05' AS Date), N'Nữ', N'0962660947', N'74DCTT22123@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22127', N'74DCTT21', N'Nguyễn Minh Phong', CAST(N'2005-04-19' AS Date), N'Nam', N'0963758390', N'74DCTT22127@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22128', N'74DCTT21', N'Nguyễn Ngọc Quang Minh', CAST(N'2005-01-31' AS Date), N'Nam', N'0915615309', N'74DCTT22128@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22141', N'74DCTT21', N'Phạm Hoàng Trung Hiếu', CAST(N'2005-06-20' AS Date), N'Nam', N'0983044665', N'74DCTT22141@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22176', N'74DCTT21', N'Lê Hoàng Tuấn', CAST(N'2005-11-25' AS Date), N'Nam', N'0927460176', N'74DCTT22176@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22214', N'74DCTT21', N'Đoàn Mạnh Hùng', CAST(N'2005-10-18' AS Date), N'Nam', N'0974825302', N'74DCTT22214@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22234', N'74DCTT21', N'Lê Phương Minh', CAST(N'2005-10-06' AS Date), N'Nữ', N'0979209587', N'74DCTT22234@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22237', N'74DCTT21', N'Nguyễn Hồng Sơn', CAST(N'2005-12-31' AS Date), N'Nam', N'0911632055', N'74DCTT22237@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22242', N'74DCTT21', N'Nguyễn Thanh Bình', CAST(N'2005-10-13' AS Date), N'Nam', N'0912942562', N'74DCTT22242@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22267', N'74DCTT21', N'Phạm Quốc Hoàn', CAST(N'2005-09-09' AS Date), N'Nam', N'0937223111', N'74DCTT22267@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22307', N'74DCTT21', N'Lê Lương Thùy Dương', CAST(N'2005-09-20' AS Date), N'Nữ', N'0971940950', N'74DCTT22307@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22319', N'74DCTT21', N'Nguyễn Quang Anh', CAST(N'2005-05-04' AS Date), N'Nam', N'0993794361', N'74DCTT22319@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22345', N'74DCTT21', N'Vũ Đức Toàn', CAST(N'2005-09-04' AS Date), N'Nam', N'0956978470', N'74DCTT22345@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22351', N'74DCTT21', N'Trần Đình Định', CAST(N'2005-03-29' AS Date), N'Nam', N'0939548901', N'74DCTT22351@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22365', N'74DCTT21', N'Vũ Tuấn Minh', CAST(N'2005-11-29' AS Date), N'Nam', N'0999430493', N'74DCTT22365@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22371', N'74DCTT21', N'Nguyễn Minh Trí', CAST(N'2005-09-09' AS Date), N'Nam', N'0975384521', N'74DCTT22371@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22372', N'74DCTT21', N'Đặng Trần Minh Vũ', CAST(N'2005-06-26' AS Date), N'Nam', N'0992460244', N'74DCTT22372@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22399', N'74DCTT21', N'Trần Xuân Hiện', CAST(N'2005-11-25' AS Date), N'Nam', N'0988642727', N'74DCTT22399@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22425', N'74DCTT21', N'Nguyễn Trọng Tấn', CAST(N'2005-02-03' AS Date), N'Nam', N'0988298413', N'74DCTT22425@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22438', N'74DCTT21', N'Đặng Thành Tâm', CAST(N'2005-07-26' AS Date), N'Nam', N'0983280971', N'74DCTT22438@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22451', N'74DCTT21', N'Lê Đức Lương', CAST(N'2005-05-09' AS Date), N'Nam', N'0998553185', N'74DCTT22451@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22458', N'74DCTT21', N'Nguyễn Quang Minh', CAST(N'2005-02-01' AS Date), N'Nam', N'0932601226', N'74DCTT22458@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22460', N'74DCTT21', N'Nguyễn Duy Bảo', CAST(N'2005-03-15' AS Date), N'Nam', N'0952212701', N'74DCTT22460@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22470', N'74DCTT21', N'Phạm Tất Thịnh', CAST(N'2005-11-04' AS Date), N'Nam', N'0927279319', N'74DCTT22470@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22486', N'74DCTT21', N'Nguyễn Quốc Việt', CAST(N'2005-01-21' AS Date), N'Nam', N'0953873892', N'74DCTT22486@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22492', N'74DCTT21', N'Trương Thị Thùy Linh', CAST(N'2005-10-13' AS Date), N'Nữ', N'0960144039', N'74DCTT22492@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22516', N'74DCTT21', N'Nguyễn Nhật Minh', CAST(N'2005-09-19' AS Date), N'Nam', N'0917304410', N'74DCTT22516@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22534', N'74DCTT21', N'Lê Cao Cường', CAST(N'2005-01-17' AS Date), N'Nam', N'0977820671', N'74DCTT22534@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22544', N'74DCTT21', N'Đặng Lê Minh Đức', CAST(N'2005-10-09' AS Date), N'Nam', N'0931936963', N'74DCTT22544@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22563', N'74DCTT21', N'Nguyễn Đức Anh Tuấn', CAST(N'2005-05-12' AS Date), N'Nam', N'0997748957', N'74DCTT22563@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22575', N'74DCTT21', N'Thẩm Đức Trung', CAST(N'2005-10-08' AS Date), N'Nam', N'0972575090', N'74DCTT22575@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22580', N'74DCTT21', N'Kiều Minh Ánh', CAST(N'2005-07-28' AS Date), N'Nữ', N'0951329790', N'74DCTT22580@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22588', N'74DCTT21', N'Nguyễn Văn Anh Đức', CAST(N'2005-11-04' AS Date), N'Nam', N'0914295357', N'74DCTT22588@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22593', N'74DCTT21', N'Nguyễn Hoàng Hà', CAST(N'2005-07-20' AS Date), N'Nam', N'0928357230', N'74DCTT22593@gmail.com')
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_ChuyenNganh] FOREIGN KEY([maNganh])
REFERENCES [dbo].[ChuyenNganh] ([maNganh])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_ChuyenNganh]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_Khoa] FOREIGN KEY([maKhoa])
REFERENCES [dbo].[Khoa] ([maKhoa])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_Khoa]
GO
ALTER TABLE [dbo].[QuanLyDiemDanh]  WITH CHECK ADD  CONSTRAINT [FK_DiemDanh_Lich] FOREIGN KEY([maLich])
REFERENCES [dbo].[QuanLyLich] ([maLich])
GO
ALTER TABLE [dbo].[QuanLyDiemDanh] CHECK CONSTRAINT [FK_DiemDanh_Lich]
GO
ALTER TABLE [dbo].[QuanLyDiemDanh]  WITH CHECK ADD  CONSTRAINT [FK_DiemDanh_SinhVien] FOREIGN KEY([maSV])
REFERENCES [dbo].[SinhVien] ([maSV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuanLyDiemDanh] CHECK CONSTRAINT [FK_DiemDanh_SinhVien]
GO
ALTER TABLE [dbo].[QuanLyDiemDanh]  WITH CHECK ADD  CONSTRAINT [FK_QuanLyDiemDanh_SinhVien] FOREIGN KEY([maSV])
REFERENCES [dbo].[SinhVien] ([maSV])
GO
ALTER TABLE [dbo].[QuanLyDiemDanh] CHECK CONSTRAINT [FK_QuanLyDiemDanh_SinhVien]
GO
ALTER TABLE [dbo].[QuanLyLich]  WITH CHECK ADD  CONSTRAINT [FK_Lich_GiangVien] FOREIGN KEY([maGV])
REFERENCES [dbo].[GiangVien] ([maGV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuanLyLich] CHECK CONSTRAINT [FK_Lich_GiangVien]
GO
ALTER TABLE [dbo].[QuanLyLich]  WITH CHECK ADD  CONSTRAINT [FK_Lich_HocPhan] FOREIGN KEY([maHocPhan])
REFERENCES [dbo].[HocPhan] ([maHocPhan])
GO
ALTER TABLE [dbo].[QuanLyLich] CHECK CONSTRAINT [FK_Lich_HocPhan]
GO
ALTER TABLE [dbo].[QuanLyLich]  WITH CHECK ADD  CONSTRAINT [FK_Lich_Lop] FOREIGN KEY([maLop])
REFERENCES [dbo].[Lop] ([maLop])
GO
ALTER TABLE [dbo].[QuanLyLich] CHECK CONSTRAINT [FK_Lich_Lop]
GO
ALTER TABLE [dbo].[QuanLyLich]  WITH CHECK ADD  CONSTRAINT [FK_QuanLyLich_GiangVien] FOREIGN KEY([maGV])
REFERENCES [dbo].[GiangVien] ([maGV])
GO
ALTER TABLE [dbo].[QuanLyLich] CHECK CONSTRAINT [FK_QuanLyLich_GiangVien]
GO
USE [master]
GO
ALTER DATABASE [DiemDanh] SET  READ_WRITE 
GO

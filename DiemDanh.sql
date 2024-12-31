USE [master]
GO
/****** Object:  Database [DiemDanh]    Script Date: 1/1/2025 6:34:18 AM ******/
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
/****** Object:  Table [dbo].[ChucVu]    Script Date: 1/1/2025 6:34:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[maChucVu] [nvarchar](50) NOT NULL,
	[tenChucVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChucVy] PRIMARY KEY CLUSTERED 
(
	[maChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuyenNganh]    Script Date: 1/1/2025 6:34:18 AM ******/
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
/****** Object:  Table [dbo].[GiangVien]    Script Date: 1/1/2025 6:34:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[maGV] [nvarchar](50) NOT NULL,
	[hoTen] [nvarchar](255) NULL,
	[ngaySinh] [date] NULL,
	[gioiTinh] [bit] NULL,
	[SDT] [nvarchar](16) NULL,
	[email] [nvarchar](255) NULL,
 CONSTRAINT [PK_GiangVien] PRIMARY KEY CLUSTERED 
(
	[maGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocPhan]    Script Date: 1/1/2025 6:34:18 AM ******/
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
/****** Object:  Table [dbo].[Khoa]    Script Date: 1/1/2025 6:34:18 AM ******/
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
/****** Object:  Table [dbo].[Lop]    Script Date: 1/1/2025 6:34:18 AM ******/
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
/****** Object:  Table [dbo].[QuanLyDiemDanh]    Script Date: 1/1/2025 6:34:18 AM ******/
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
/****** Object:  Table [dbo].[QuanLyLich]    Script Date: 1/1/2025 6:34:18 AM ******/
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
/****** Object:  Table [dbo].[QuanLyTaiKhoan]    Script Date: 1/1/2025 6:34:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanLyTaiKhoan](
	[tenTaiKhoan] [nvarchar](255) NOT NULL,
	[matKhau] [nvarchar](50) NULL,
	[maChucVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_QuanLyTaiKhoan] PRIMARY KEY CLUSTERED 
(
	[tenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 1/1/2025 6:34:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[maSV] [nvarchar](50) NOT NULL,
	[maLop] [nvarchar](50) NULL,
	[hoTen] [nvarchar](255) NULL,
	[ngaySinh] [date] NULL,
	[gioiTinh] [bit] NULL,
	[SDT] [nvarchar](16) NULL,
	[email] [nvarchar](255) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[maSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVu]) VALUES (N'gv', N'Giảng Viên')
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVu]) VALUES (N'ql', N'Quản Lý')
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVu]) VALUES (N'sv', N'Sinh Viên')
GO
INSERT [dbo].[ChuyenNganh] ([maNganh], [tenNganh]) VALUES (N'CNTT', N'CÔNG NGHỆ THÔNG TIN')
INSERT [dbo].[ChuyenNganh] ([maNganh], [tenNganh]) VALUES (N'HTTT', N'HỆ THỐNG THÔNG TIN')
INSERT [dbo].[ChuyenNganh] ([maNganh], [tenNganh]) VALUES (N'KDTM', N'KINH DANH THƯƠNG MẠI')
INSERT [dbo].[ChuyenNganh] ([maNganh], [tenNganh]) VALUES (N'KT', N'KẾ TOÁN')
INSERT [dbo].[ChuyenNganh] ([maNganh], [tenNganh]) VALUES (N'QTKD', N'QUẢN TRỊ KINH DOANH')
GO
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV000', N'Nguyễn Văn An', CAST(N'1985-03-15' AS Date), 1, N'0901234567', N'nguyenvanan@example.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV001', N'Hoàng Minh Tuấn', CAST(N'1988-08-20' AS Date), 1, N'0945678901', N'hoangminhtuan@example.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV002', N'Trần Thị Bích', CAST(N'1990-06-25' AS Date), 0, N'0912345678', N'tranthibich@example.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV003', N'Phạm Văn Cường', CAST(N'1983-11-10' AS Date), 1, N'0923456789', N'phamvancuong@example.com')
INSERT [dbo].[GiangVien] ([maGV], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'GV004', N'Lê Thị Dung', CAST(N'1995-02-18' AS Date), 0, N'0934567890', N'lethidung@example.com')
GO
INSERT [dbo].[HocPhan] ([maHocPhan], [tenHocPhan]) VALUES (N'HP001', N'Toán Đại Cương')
INSERT [dbo].[HocPhan] ([maHocPhan], [tenHocPhan]) VALUES (N'HP002', N'Lý Thuyết Xác Suất')
INSERT [dbo].[HocPhan] ([maHocPhan], [tenHocPhan]) VALUES (N'HP003', N'Tin Học Đại Cương')
INSERT [dbo].[HocPhan] ([maHocPhan], [tenHocPhan]) VALUES (N'HP004', N'Văn Học Việt Nam')
GO
INSERT [dbo].[Khoa] ([maKhoa], [tenKhoa], [nienKhoa]) VALUES (N'K1', N'K74', N'2024-2025')
INSERT [dbo].[Khoa] ([maKhoa], [tenKhoa], [nienKhoa]) VALUES (N'K2', N'K75', N'2025-2026')
INSERT [dbo].[Khoa] ([maKhoa], [tenKhoa], [nienKhoa]) VALUES (N'K3', N'K76', N'2026-2027')
GO
INSERT [dbo].[Lop] ([maLop], [maKhoa], [maNganh], [tenLop], [GVCN]) VALUES (N'74DCTT21', N'K1', N'CNTT', N'Lớp 74DCTT21', N'An')
INSERT [dbo].[Lop] ([maLop], [maKhoa], [maNganh], [tenLop], [GVCN]) VALUES (N'74DCTT22', N'K1', N'QTKD', N'Lớp 74DCTT21', N'Nick')
INSERT [dbo].[Lop] ([maLop], [maKhoa], [maNganh], [tenLop], [GVCN]) VALUES (N'75DCTT22', N'K2', N'HTTT', N'Lớp 74DCTT22', N'Trung')
INSERT [dbo].[Lop] ([maLop], [maKhoa], [maNganh], [tenLop], [GVCN]) VALUES (N'75DCTT23', N'K2', N'KT', N'Lớp 75DCTT22', N'Me')
INSERT [dbo].[Lop] ([maLop], [maKhoa], [maNganh], [tenLop], [GVCN]) VALUES (N'76DCTT21', N'K1', N'CNTT', N'Lớp 74DCTT21', N'Lee Wang Ann')
GO
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [maChucVu]) VALUES (N'74DCTT21001', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [maChucVu]) VALUES (N'74DCTT21525', N'1', N'sv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [maChucVu]) VALUES (N'ad', N'1', N'ql')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [maChucVu]) VALUES (N'an', N'1', N'ql')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [maChucVu]) VALUES (N'GV1', N'1', N'gv')
INSERT [dbo].[QuanLyTaiKhoan] ([tenTaiKhoan], [matKhau], [maChucVu]) VALUES (N'gv2', N'1', N'gv')
GO
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21009', N'74DCTT21', N'Tran Thuong Vien', CAST(N'2005-09-12' AS Date), 1, N'0943343897', N'74DCTT21009@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21046', N'74DCTT21', N'Vu Thanh Binh', CAST(N'2005-09-19' AS Date), 1, N'0973237735', N'74DCTT21046@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21067', N'74DCTT21', N'Pham Thi Ngoc Bich', CAST(N'2005-05-23' AS Date), 1, N'0952227538', N'74DCTT21067@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21097', N'74DCTT21', N'Vu Hoang Minh', CAST(N'2005-04-03' AS Date), 1, N'0967264526', N'74DCTT21097@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21102', N'74DCTT21', N'Nguyen Khanh Tung', CAST(N'2005-01-24' AS Date), 1, N'0921017870', N'74DCTT21102@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21112', N'74DCTT21', N'Bui Duc Huy', CAST(N'2005-01-08' AS Date), 1, N'0939411661', N'74DCTT21112@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21169', N'74DCTT21', N'Luong The Anh', CAST(N'2005-02-01' AS Date), 1, N'0935975340', N'74DCTT21169@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21525', N'74DCTT21', N'Le Quang An', CAST(N'2005-03-02' AS Date), 0, N'0951706358', N'74DCTT21525@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21539', N'74DCTT22', N'Pham Quang Huy', CAST(N'2005-06-06' AS Date), 1, N'0962458027', N'74DCTT21539@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21556', N'74DCTT22', N'Mai Duc Hieu', CAST(N'2005-12-24' AS Date), 1, N'0988387372', N'74DCTT21556@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT21591', N'74DCTT22', N'Hoang Thi Ngoan', CAST(N'2005-12-12' AS Date), 0, N'0979953031', N'74DCTT21591@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22030', N'74DCTT22', N'Vu Tien Dung', CAST(N'2005-01-01' AS Date), 1, N'0912894924', N'74DCTT22030@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22062', N'74DCTT22', N'Phung Manh Phuc', CAST(N'2005-03-29' AS Date), 1, N'0952757885', N'74DCTT22062@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22064', N'74DCTT22', N'Nguyen Xuan Loc', CAST(N'2005-07-21' AS Date), 1, N'0935179555', N'74DCTT22064@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22089', N'74DCTT22', N'Tran Nguyen Hoang', CAST(N'2005-01-08' AS Date), 1, N'0918749860', N'74DCTT22089@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22121', N'74DCTT22', N'Nguyen Manh Quynh', CAST(N'2005-09-19' AS Date), 1, N'0931428885', N'74DCTT22121@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22122', N'74DCTT22', N'Lai Tuan Anh', CAST(N'2005-12-27' AS Date), 1, N'0976511197', N'74DCTT22122@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22123', N'74DCTT23', N'Pham Phuong Anh', CAST(N'2005-09-05' AS Date), 0, N'0962660947', N'74DCTT22123@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22127', N'74DCTT23', N'Nguyen Minh Phong', CAST(N'2005-04-19' AS Date), 1, N'0963758390', N'74DCTT22127@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22128', N'74DCTT23', N'Nguyen Ngoc Quang Minh', CAST(N'2005-01-31' AS Date), 1, N'0915615309', N'74DCTT22128@gmail.com')
INSERT [dbo].[SinhVien] ([maSV], [maLop], [hoTen], [ngaySinh], [gioiTinh], [SDT], [email]) VALUES (N'74DCTT22214', N'74DCTT23', N'Doan Manh Hung', CAST(N'2005-10-18' AS Date), 1, N'0974825302', N'74DCTT22214@gmail.com')
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_ChuyenNganh] FOREIGN KEY([maNganh])
REFERENCES [dbo].[ChuyenNganh] ([maNganh])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_ChuyenNganh]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_Khoa] FOREIGN KEY([maKhoa])
REFERENCES [dbo].[Khoa] ([maKhoa])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_Khoa]
GO
ALTER TABLE [dbo].[QuanLyDiemDanh]  WITH CHECK ADD  CONSTRAINT [FK_DiemDanh_Lich] FOREIGN KEY([maLich])
REFERENCES [dbo].[QuanLyLich] ([maLich])
ON UPDATE CASCADE
ON DELETE CASCADE
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
ALTER TABLE [dbo].[QuanLyLich]  WITH CHECK ADD  CONSTRAINT [FK_Lich_GiangVien] FOREIGN KEY([maGV])
REFERENCES [dbo].[GiangVien] ([maGV])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuanLyLich] CHECK CONSTRAINT [FK_Lich_GiangVien]
GO
ALTER TABLE [dbo].[QuanLyLich]  WITH CHECK ADD  CONSTRAINT [FK_Lich_HocPhan] FOREIGN KEY([maHocPhan])
REFERENCES [dbo].[HocPhan] ([maHocPhan])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuanLyLich] CHECK CONSTRAINT [FK_Lich_HocPhan]
GO
ALTER TABLE [dbo].[QuanLyLich]  WITH CHECK ADD  CONSTRAINT [FK_Lich_Lop] FOREIGN KEY([maLop])
REFERENCES [dbo].[Lop] ([maLop])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuanLyLich] CHECK CONSTRAINT [FK_Lich_Lop]
GO
ALTER TABLE [dbo].[QuanLyTaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_QuanLyTaiKhoan_ChucVu] FOREIGN KEY([maChucVu])
REFERENCES [dbo].[ChucVu] ([maChucVu])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[QuanLyTaiKhoan] CHECK CONSTRAINT [FK_QuanLyTaiKhoan_ChucVu]
GO
USE [master]
GO
ALTER DATABASE [DiemDanh] SET  READ_WRITE 
GO

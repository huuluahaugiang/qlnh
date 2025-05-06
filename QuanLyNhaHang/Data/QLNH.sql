CREATE DATABASE [QLNH]
CREATE TABLE [dbo].[BAN](
	[MaBan] [varchar](10) NOT NULL,
	[TenBan] [nvarchar](50) NULL,
	[SoGhe] [int] NULL,
	[TrangThai] [nvarchar](12) NULL,	
 CONSTRAINT [SINHVIEN_PK] PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

INSERT [dbo].[BAN] ([MaBan], [TenBan], [SoGhe], [TrangThai]) VALUES (N'B01', N'Bàn số 01', 4, N'0')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [SoGhe], [TrangThai]) VALUES (N'B02', N'Bàn số 02', 4, N'0')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [SoGhe], [TrangThai]) VALUES (N'B03', N'Bàn số 03', 4, N'0')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [SoGhe], [TrangThai]) VALUES (N'B04', N'Bàn số 04', 4, N'0')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [SoGhe], [TrangThai]) VALUES (N'B05', N'Bàn số 05', 4, N'0')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [SoGhe], [TrangThai]) VALUES (N'B06', N'Bàn số 06', 8, N'0')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [SoGhe], [TrangThai]) VALUES (N'B07', N'Bàn số 07', 8, N'0')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [SoGhe], [TrangThai]) VALUES (N'B08', N'Bàn số 08', 8, N'0')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [SoGhe], [TrangThai]) VALUES (N'B09', N'Bàn số 09', 10, N'0')
INSERT [dbo].[BAN] ([MaBan], [TenBan], [SoGhe], [TrangThai]) VALUES (N'B10', N'Bàn số 10', 10, N'0')

CREATE TABLE [dbo].[KHACHHANG](
	[MaHD] [int] identity(1,1) NOT NULL,	
	[MaBan] [varchar](10) NOT NULL,
	[TenBan] [varchar](50) NULL	
 CONSTRAINT [MaKHPK] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[MONAN](
	[MaMon] [varchar](10) NOT NULL,
	[TenMon] [nvarchar](50) NULL,
	[DVT] [nvarchar](50) NULL,
	[DonGia1] [int] NULL,
	[DonGia2] [int] NULL,	
	[DonGia3] [int] NULL,	
 CONSTRAINT [MaMon_PK] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DVT], [DonGia1], [DonGia2], [DonGia3] ) VALUES ('M01', N'Lẩu gà đá', N'Cái', 150000, 120000, 180000)
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DVT], [DonGia1], [DonGia2], [DonGia3] ) VALUES ('M02', N'Lẩu dê', N'Cái', 120000, 100000, 150000)
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DVT], [DonGia1], [DonGia2], [DonGia3] ) VALUES ('M03', N'Lẩu mắm', N'Cái', 180000, 150000, 200000)
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DVT], [DonGia1], [DonGia2], [DonGia3] ) VALUES ('M04', N'Lẩu gà ác', N'Cái', 130000, 120000, 150000)
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DVT], [DonGia1], [DonGia2], [DonGia3] ) VALUES ('M05', N'Dê quay', N'Dĩa', 100000, 800000, 120000)
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DVT], [DonGia1], [DonGia2], [DonGia3] ) VALUES ('M06', N'Cá lóc nướng truiL', N'Con', 50000, 45000, 55000)
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DVT], [DonGia1], [DonGia2], [DonGia3] ) VALUES ('M07', N'Rau muống xào tỏi', N'Dĩa', 30000, 25000, 35000)
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DVT], [DonGia1], [DonGia2], [DonGia3] ) VALUES ('M08', N'Bia Sài Gòn Larger', N'Lon', 12000, 11000, 13000)
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DVT], [DonGia1], [DonGia2], [DonGia3] ) VALUES ('M09', N'Bia Tiger', N'Lon', 15000, 14500, 15500)
INSERT [dbo].[MONAN] ([MaMon], [TenMon], [DVT], [DonGia1], [DonGia2], [DonGia3] ) VALUES ('M10', N'Rượu ngọc dương', N'Chai', 45000, 40000, 50000)


CREATE TABLE [dbo].[HoaDon](
	[ID] [int] identity(1,1) NOT NULL,
	[MaHD] [int] NOT NULL,
	[MaBan] [varchar](10) NULL,
	[MaMon] [varchar](10) NULL,
	[SoLuong] [int] NULL,	
 CONSTRAINT [MaHDPK] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

INSERT [dbo].[HOADON] ([MaBan], [MaMon], [SoLuong]) VALUES ('B01', 'M01', 1)
INSERT [dbo].[HOADON] ([MaBan], [MaMon], [SoLuong]) VALUES ('B01', 'M02', 1)
INSERT [dbo].[HOADON] ([MaBan], [MaMon], [SoLuong]) VALUES ('B01', 'M03', 1)
INSERT [dbo].[HOADON] ([MaBan], [MaMon], [SoLuong]) VALUES ('B01', 'M04', 1)
INSERT [dbo].[HOADON] ([MaBan], [MaMon], [SoLuong]) VALUES ('B01', 'M10', 1)
INSERT [dbo].[HOADON] ([MaBan], [MaMon], [SoLuong]) VALUES ('B02', 'M01', 1)
INSERT [dbo].[HOADON] ([MaBan], [MaMon], [SoLuong]) VALUES ('B02', 'M06', 1)
INSERT [dbo].[HOADON] ([MaBan], [MaMon], [SoLuong]) VALUES ('B02', 'M03', 1)
INSERT [dbo].[HOADON] ([MaBan], [MaMon], [SoLuong]) VALUES ('B02', 'M07', 1)
INSERT [dbo].[HOADON] ([MaBan], [MaMon], [SoLuong]) VALUES ('B02', 'M10', 1)

create procedure [dbo].[spHoaDon]
@MaHD int
as
begin
	select B.TenMon , b.DVT, a.SoLuong, b.DonGia1 as DonGia, a.SoLuong * b.DonGia1 as ThanhTien
	from HOADON a, MONAN b
	where (a.MaMon = b.MaMon) and (a.MaHD = @MaHD)
end
GO

update ban set trangthai  = '0'
delete from KHACHHANG
select * from HoaDon
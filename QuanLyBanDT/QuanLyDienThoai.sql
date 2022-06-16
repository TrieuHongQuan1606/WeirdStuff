create database QuanLyDienThoai
go
use QuanlyDienThoai
go


create table HangSX(
  MaHangSX nchar(20) not null  primary key ,
  TenHangSX nvarchar(50),
  DiaChi nvarchar(60),
)
go

create table KhachHang(
  MaKH char(6) not null primary key  CONSTRAINT IDKH DEFAULT dbo.AutoMaKH(),
  TenKH nvarchar(100),
  DiaChi nvarchar(200),
  SoDT nchar(15),
  NgaySinh date,
  Email nchar(50),
)

go
create table HoaDon(
  MaHD char(6) not null primary key  CONSTRAINT IDHD DEFAULT dbo.AutoMaHD(),
  MaKH char(6),
  NgayLapHD date,
  PTthanhToan nvarchar(10),
  constraint FK_MAKH foreign key (MaKH) references KhachHang(MaKH),
)
go
create table SanPham(
  MaSP char(6) not null primary key CONSTRAINT IDSP DEFAULT dbo.AutoMaSP(),
  TenSP nvarchar(100),
  MaHangSX	nchar(20),
  DonGia money,
  Ram nchar(10),
  Rom nchar(10),
  SoLuong int,
  XuatXu nvarchar(30),
  ThoiGianBH nvarchar(20),
    constraint FK_MaHangSX foreign key (MaHangSX) references HangSX(MaHangSX),
)
go
create table ChiTietHD(
  MaHD char(6) not null,
  MaSP char(6) not null,
  SoLuong int,
  DonGia money,
  constraint PK_ChiTietHD primary key(MaHD, MaSP),
   constraint FK_MaHD1 foreign key (MaHD) references HoaDon(MaHD),
	constraint FK_MaHangSX1 foreign key (MaSP) references SanPham(MaSP),
)

create table NguoiDung(
   TaiKhoan nvarchar(20) not null primary key,
   MatKhau nvarchar(20) not null,
 )



--------------------------Insert---------------------------------------

insert into KhachHang(TenKH, DiaChi, SoDT, NgaySinh, Email) values(N'Nguyễn Việt Anh', N'Bắc Ninh', '0369874589', '02/05/2002', 'vietanh@gmail.com')
insert into KhachHang(TenKH, DiaChi, SoDT, NgaySinh, Email) values(N'Nguyễn Anh Dũng', 'Hà Nội', '0345235987', '10/14/2002', 'anhdung@gmail.com')
insert into KhachHang(TenKH, DiaChi, SoDT, NgaySinh, Email) values(N'Vũ Danh Thường', N'Bắc Giang', '0341257841', '05/02/2002', 'danhthuong@gmail.com')
insert into KhachHang(TenKH, DiaChi, SoDT, NgaySinh, Email) values(N'Nguyễn Hữu Thành', N'Sơn La', '0321465478', '08/09/2002', 'huuthanh@gmail.com')
insert into KhachHang(TenKH, DiaChi, SoDT, NgaySinh, Email) values(N'Nguyễn Việt Anh', N'Hà Nội', '0325498741', '04/05/2002', 'vietanh1@gmail.com')
insert into KhachHang(TenKH, DiaChi, SoDT, NgaySinh, Email) values(N'Trần Trung Hiếu', N'Hà Nội', '0321452369', '04/08/2002', 'trunghieu@gmail.com')

insert into HangSX values('AP', N'Apple', N'Mỹ')
insert into HangSX values('SS', N'SamSung', N'Hàn Quốc')
insert into HangSX values('XM', N'Xiaomi', N'Trung Quốc')
insert into HangSX values('OP', N'Oppo', N'Trung Quốc')
insert into HangSX values('HW', N'Huawei', N'Trung Quốc')
insert into HangSX values('RM', N'Realme', N'Trung Quốc')
insert into HangSX values('VV', N'Vivo', N'Trung Quốc')

-- Cột xuất xứ thể hiện là nơi sản xuất ra toàn bộ hàng hoá hoặc thực hiện công đoạn chế biến cuối cùng
-- Cho nên Iphone có thể là ở Mỹ nhưng xuất xứ cũng có thể là Hàn Quốc
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'iPhone 7', 'AP', 3500000 , '3G', '32G', 8 , N'Mỹ', '6')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'iphone 7 Plus', 'AP', 4500000 , '4G', '64G', 5 , N'Hàn Quốc', '12')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'iphone Xs Max', 'AP', 10000000 , '6G', '125G', 11 , N'Mỹ', '8')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'Samsung Galaxy M51', 'SS', 8000000 , '8G', '125G', 9 , N'Việt Nam', '18')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'Samsung Galaxy A52s 5G', 'SS', 12000000 , '8G', '125G', 12, N'Hàn Quốc', '24')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'iPhone X', 'AP', 9000000 , '6G', '125G', 11 , N'Trung Quốc', '12')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'Samsung Galaxy Note 20', 'SS', 12000000 , '8G', '125G', 26 , N'Hàn Quốc', '18')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'Samsung Galaxy S21 Series', 'SS', 13500000 , '8G', '255G', 14, N'Việt Nam', '14')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'iPhone 11', 'AP', 11600000 , '6G', '64G', 11 , N'Mỹ', '12')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'iPhone 11 Pro', 'AP', 1400000 , '6G', '125G', 10  , N'Mỹ', '8')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'iPhone 11 Pro Max', 'AP', 18500000 , '8G', '255G', 6 , N'Mỹ', '12')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'Samsung Galaxy Z Flip3 5G', 'SS', 16000000 , '8G', '255G', 8 , N'Hàn Quốc', '8')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'Samsung Galaxy Z Fold3 5G', 'SS', 35000000, '12G', '512G', 5 , N'Hàn Quốc', '12')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'iPhone 12 Pro Max', 'AP', 25000000 , '8G', '255G', 3 , N'Hàn Quốc', '13')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'iPhone 12 Pro', 'AP', 18000000 , '6G', '64G', 8 , N'Mỹ', '14')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'OPPO Find X5 Pro', 'OP', 24000000 , '8G', '64G', 5, N'Trung Quốc', '12')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'OPPO Find X3 Pro 5G', 'OP', 18000000 , '6G', '125G', 6 , N'Trung Quốc', '14')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'Realme 5', 'RM', 8000000 , '8G', '125G', 4 , N'Trung Quốc', '12')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'OPPO Find X2 Pro', 'OP', 12000000 , '12G', '512G', 4 , N'Việt Nam', '14')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'Huawei Mate 20 Pro', 'HW', 14500000 , '12G', '225G', 5 , N'Trung Quốc', '16')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'Huawei Nova 5T', 'HW', 16000000, '12G', '512G', 6 , N'Trung Quốc', '17')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'vivo X70 Pro', 'VV', 15600000 , '8G', '125G', 7 , N'Việt Nam', '12')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'vivo X60 Pro', 'VV', 24000000 , '12G', '512G', 9 , N'Trung Quốc', '12')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'Xiaomi Redmi Note 11 Series', 'XM', 16000000, '6G', '125G', 8 , N'Trung Quốc', '8')
insert into SanPham(TenSP, MaHangSX, DonGia, Ram, Rom, SoLuong, XuatXu, ThoiGianBH) values(N'Xiaomi 12 Series', 'XM', 21000000 , '8G', '125G', 7 , N'Trung Quốc', '9')


insert into HoaDon(MaKH, NgayLapHD, PTthanhToan) values('KH0001', '05/20/2022', N'TM')
insert into HoaDon(MaKH, NgayLapHD, PTthanhToan) values('KH0005', '04/14/2022', N'CK')
insert into HoaDon(MaKH, NgayLapHD, PTthanhToan) values('KH0004', '06/12/2022', N'TM')
insert into HoaDon(MaKH, NgayLapHD, PTthanhToan) values('KH0002', '04/12/2022', N'CK')
insert into HoaDon(MaKH, NgayLapHD, PTthanhToan) values('KH0003', '04/02/2022', N'TM')
insert into HoaDon(MaKH, NgayLapHD, PTthanhToan) values('KH0006', '03/16/2022', N'TM')


insert into ChiTietHD values('HD0002', 'SP0010', 2 , 28000000 )
insert into ChiTietHD values('HD0001', 'SP0004', 1 , 8000000)
insert into ChiTietHD values('HD0003', 'SP0006', 3 , 18000000)
insert into ChiTietHD values('HD0004', 'SP0003', 2, 20000000)


insert into NguoiDung values('anh', 'dung')
insert into NguoiDung values('viet', 'anh')






--Phần tạo mã tự động
----------------------------------------Function----------------------------------------
-- Hàm để tạo mã khách hàng tự động 
CREATE FUNCTION  AutoMaKH()
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	IF (SELECT COUNT(MaKH) FROM KhachHang) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaKH, 4)) FROM KhachHang
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'KH000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'KH00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END

-- Hàm để tạo mã hoá đơn tự động
CREATE FUNCTION  AutoMaHD()
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	IF (SELECT COUNT(MaHD) FROM HoaDon) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaHD, 4)) FROM HoaDon
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'HD000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'HD00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END

-- Hàm để tạo mã sản phẩm tự động
CREATE FUNCTION  AutoMaSP()
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	IF (SELECT COUNT(MaSP) FROM SanPham) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaSP, 4)) FROM SanPham
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'SP000' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'SP00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
---------------------------------------Function------------------------------------




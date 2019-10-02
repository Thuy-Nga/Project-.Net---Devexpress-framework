CREATE DATABASE QLCAFE
GO

use QLCAFE
GO

CREATE TABLE TAIKHOAN
(
	tenTK nvarchar(50) primary key,
	tenHienThi nvarchar(50),
	matKhau nvarchar(50) not null,
	loaiTK bit
)
GO
CREATE TABLE LOAI
(
	idLoai int identity primary key,
	tenLoai nvarchar(50)not null
)
GO
CREATE TABLE NUOC
(
	idNuoc int identity primary key,
	tenNuoc nvarchar(50),
	idLoai int,
	gia float default 0,
	Foreign key (idLoai) references LOAI(idLoai)
)
GO
CREATE TABLE BAN
(
	idBan int identity primary key,
	ten nvarchar(20),
	trangThai nvarchar(10) default N'Trống',
	tongTien float default 0
)
GO
CREATE TABLE HOADON
(
	idHD int identity primary key,
	idBan int,
	ngayvao Datetime default getdate(),
	ngayra Datetime null,
	trangThai bit default 0, -- 0: Chưa thanh toán, 1: Đã thanh toán
	Foreign key (idBan) references BAN(idBan)
)
GO
CREATE TABLE CHITIETHOADON
(
	idCTHD int identity primary key,
	idHD int,
	idNuoc int,
	soluong int,
	Foreign key (idHD) references HOADON(idHD),
	Foreign key (idNuoc) references Nuoc(idNuoc)
)
GO
INSERT INTO TaiKhoan(TenTK, TenHienThi, MatKhau, LoaiTK)
VALUES(N'Nguyễn Thị Thúy Nga', N'Nguyễn Thị Thuý Nga',N'admin',1)
GO

INSERT INTO BAN (ten) VALUES(N'Bàn 1')
INSERT INTO BAN (ten) VALUES(N'Bàn 2')
INSERT INTO BAN (ten) VALUES(N'Bàn 3')
INSERT INTO BAN (ten) VALUES(N'Bàn 4')
INSERT INTO BAN (ten) VALUES(N'Bàn 5')
INSERT INTO BAN (ten) VALUES(N'Bàn 6')
INSERT INTO BAN (ten) VALUES(N'Bàn 7')
INSERT INTO BAN (ten) VALUES(N'Bàn 8')
INSERT INTO BAN (ten) VALUES(N'Bàn 9')
INSERT INTO BAN (ten) VALUES(N'Bàn 10')
INSERT INTO BAN (ten) VALUES(N'Bàn 11')
INSERT INTO BAN (ten) VALUES(N'Bàn 12')
INSERT INTO BAN (ten) VALUES(N'Bàn 13')
INSERT INTO BAN (ten) VALUES(N'Bàn 14')
INSERT INTO BAN (ten) VALUES(N'Bàn 15')
INSERT INTO BAN (ten) VALUES(N'Bàn 16')
INSERT INTO BAN (ten) VALUES(N'Bàn 17')
INSERT INTO BAN (ten) VALUES(N'Bàn 18')
INSERT INTO BAN (ten) VALUES(N'Bàn 19')
INSERT INTO BAN (ten) VALUES(N'Bàn 20')
GO 

--thêm nhóm nước uống
INSERT INTO Loai (tenLoai) VALUES(N'Trà - Cafe')
INSERT INTO Loai (tenLoai) VALUES(N'Nước ép')
INSERT INTO Loai (tenLoai) VALUES(N'Sinh tố')
INSERT INTO Loai (tenLoai) VALUES(N'Kem')
INSERT INTO Loai (tenLoai) VALUES(N'Bia - Coke')

--thêm nước nhóm 1
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Cafe đen',1,11000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Cafe đá',1,15000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Cafe sữa đá',1,20000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Cafe sữa nóng',1,22000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Sữa tươi',1,24000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Bạc xỉu',1,22000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Cacao đá',1,20000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Cacao nóng',1,18000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Trà Lipton',1,18000)

-- thêm nước nhóm 2
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Nước ép táo',2,29000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Nước ép cà rốt',2,29000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Nước ép dưa hấu',2,29000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Nước ép cà chua',2,29000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Nước ép dâu',2,29000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Cam vắt',2,29000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Chanh dây',2,29000)

-- thêm nước nhóm 3

INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Sinh tố dâu',3,35000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Sinh tố dưa hấu',3,35000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Sinh tố xoài',3,35000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Sinh tố bơ',3,35000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Sinh mãn cầu',3,35000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Sinh tố đu đủ',3,35000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Sinh tố mít',3,35000)

-- thêm nước nhóm 4
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Kem ly',4,30000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Sữa chua cafe',4,20000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Sữa chua bạc xỉu',4,20000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Sữa chua dâu',4,20000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Sữa chua việt quất',4,20000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Sữa ngô',4,15000)

-- thêm nước nhóm 5
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Bia Sài Gòn',5,19000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Bia Tiger',5,19000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Coca cola',5,13000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Pepsi',5,13000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Sting',5,13000)
INSERT INTO Nuoc(tenNuoc, idLoai, Gia) 
VALUES(N'Red Bull',5,15000)
GO



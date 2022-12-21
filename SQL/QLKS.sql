create database QUANLY_KHACHSAN
use QUANLY_KHACHSAN

create table LOAIPHONG
(
	MaLoaiPhong char(5) not null,
	TenLoaiPhong varchar(255),
	DonGiaTC money,
	SoLuong int,
	constraint pk_LOAIPHONG primary key (MaLoaiPhong),
)

create table DANHMUCPHONG
(
	MaPhong char(5) not null,
	TenPhong varchar(255),
	TinhTrang varchar(255),
	MaLoaiPhong char(5),
	GhiChu varchar(255),
	constraint pk_DANHMUCPHONG primary key (MaPhong),
	constraint fk_DANHMUCPHONG_LOAIPHONG foreign key (MaLoaiPhong) references LOAIPHONG(MaLoaiPhong),
)



create table LOAIKHACHHANG
(
	MaLoaiKH char(5) not null,
	TenLoaiKH varchar(50),
	HeSo decimal(11,2),
	constraint pk_LOAIKHACHHANG primary key (MaLoaiKH),
)

create table KHACHHANG
(
	MaKH char(5) not null,
	TenKH varchar(50),
	CMND int,
	DiaChi varchar(200),
	MaLoaiKH char(5),
	constraint pk_KHACHHANG primary key (MaKH),
	constraint fk_KHACHHANG_LOAIKHACHHANG foreign key (MaLoaiKH) references LOAIKHACHHANG(MaLoaiKH),
)

create table HOADON
(
	SoHD char(5) not null,
	TriGia money,
	TenKH varchar(200),
	DiaChi varchar(200),
	NgayLap smalldatetime,
	constraint pk_HOADON primary key (SoHD),
)

create table PHIEUTHUE
(
	MaPhieuThue char(5) not null,
	NgayBDThue smalldatetime,
	DonGia money,
	SoLuongKH int,
	MaPhong char(5),
	SoHD char(5),
	ThanhTien money,
	SoNgayThue int,
	constraint pk_PHIEUTHUE primary key (MaPhieuThue),
	constraint fk_PHIEUTHUE_HOADON foreign key (SoHD) references HOADON(SoHD),
	constraint fk_PHIEUTHUE_DANHMUCPHONG foreign key (MaPhong) references DANHMUCPHONG(MaPhong),
)

create table CT_PHIEUTHUE 
(
	MaPhieuThue char(5),
	MaKH char(5),
	constraint pk_CTPT primary key (MaPhieuThue, MaKH),
	constraint fk_CT_PHIEUTHUE_PHIEUTHUE foreign key (MaPhieuThue) references PHIEUTHUE(MaPhieuThue),
	constraint fk_CT_PHIEUTHUE_KHACHHANG foreign key (MaKH) references KHACHHANG(MaKH),
)


create table BAOCAO
(
	MaBaoCaoDT char(7) not null primary key,
	Thang int,
)

create table CT_BAOCAO 
(
	DoanhThu money,
	TiLe numeric(4,2),
	MaBaoCaoDT char(7),
	MaLoaiPhong char(5),
	constraint pk_CT_BAOCAO primary key (MaLoaiPhong, MaBaoCaoDT),
	constraint fk_CT_BAOCAO_LOAIPHONG foreign key (MaLoaiPhong) references LOAIPHONG(MaLoaiPhong),
	constraint fk_CT_BAOCAO_BAOCAO foreign key (MaBaoCaoDT) references BAOCAO(MaBaoCaoDT),
)

create table THAMSO
(
	TenTS varchar(20) not null primary key,
	GiaTri decimal(11,2)
)

create table ID
(
	MaLoaiPhong int,
	MaPhong int,
	MaLoaiKH int,
	MaKH int,
	SoHD int,
	MaPhieuThue int,
)
CREATE TABLE ID
(
	MaLoaiPhong char(5),
	MaPhong char(5),
	MaLoaiKH char(5),
	MaKH char(5),
	SoHD char(5),
	MaPhieuThue char(5),
)
DROP TABLE ID
INSERT INTO ID VALUES ('0','0','0','0','0','0')

ALTER TABLE DANHMUCPHONG
NOCHECK CONSTRAINT fk_DANHMUCPHONG_LOAIPHONG


SELECT * FROM LOAIPHONG
WHERE MaPhong LIKE '%' AND TenPhong LIKE '%' AND TenPhong LIKE '%' AND TinhTrang LIKE '%'


INSERT INTO LOAIPHONG VALUES('A','A',150000,0)
INSERT INTO LOAIPHONG VALUES('B','B',170000,0)
INSERT INTO LOAIPHONG VALUES('C','C',200000,0)

INSERT INTO DANHMUCPHONG VALUES('1223','24343','3646464','A','')

SELECT * FROM DANHMUCPHONG
SELECT * FROM LOAIPHONG


select tenphong, tenloaiphong, dongiaTC, tinhtrang from loaiphong lp, danhmucphong dmp where lp.MaLoaiPhong = dmp.MaLoaiPhong


select tenphong, tenloaiphong, dongiaTC, ghichu 
from loaiphong lp, danhmucphong dmp
where lp.MaLoaiPhong = dmp.MaLoaiPhong and TenPhong like '2%'
and TenLoaiPhong like '%' and DonGiaTC < 1500000000 and TinhTrang 
like '%'

SELECT * FROM ID
SELECT MaPhong FROM ID



SELECT MaPhong FROM IDCNT
INSERT INTO IDCNT VALUES (0,0,0,0,0,0)
SELECT * FROM DANHMUCPHONG
DELETE FROM DANHMUCPHONG WHERE MaPhong = '0'
DELETE FROM DANHMUCPHONG WHERE TenPhong = 'HATRONTAI'
SELECT * FROM LOAIPHONG
INSERT INTO LOAIPHONG VALUES ('0','BACHGA', 696969, 100)
DELETE FROM LOAIPHONG WHERE SoLuong = 100


SELECT MaLoaiPhong FROM LOAIPHONG WHERE TenLoaiPhong = 'A'
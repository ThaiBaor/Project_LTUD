--Thêm m?i HHK
go
create proc sp_themHANGHANGKHONG(@MAHANGHK nvarchar(10) ,@TENHANGHK nvarchar(25))
as
insert into HANGHANGKHONG(MAHANGHK,TENHANGHK)
values (@MAHANGHK, @TENHANGHK)
--Xóa HHK
go
create proc sp_xoaHANGHANGKHONG(@MAHANGHK nvarchar(10))
as 
Delete from HANGHANGKHONG where MAHANGHK = @MAHANGHK
--S?a HHK
go
create proc sp_suaHANGHANGKHONG(@MAHANGHK nvarchar(10) ,@TENHANGHK nvarchar(25))
as
Update HANGHANGKHONG set TENHANGHK = @TENHANGHK where MAHANGHK=@MAHANGHK
--L?y danh sách HHK
go
create proc sp_layDSHANGHANGKHONG
as 
select * from HANGHANGKHONG 

go
create proc sp_layTENHANGHANGKHONG_theoMACHUYENBAY(@MACHUYENBAY nvarchar(10))
as
select TENHANGHK
from HANGHANGKHONG,CHUYENBAY
where CHUYENBAY.MACHUYENBAY=@MACHUYENBAY AND HANGHANGKHONG.MAHANGHK=CHUYENBAY.MAHANGHK

go
create proc sp_laySOHIEUMAYBAY_theoMACHUYENBAY(@MACHUYENBAY nvarchar(10))
as
select SOHIEU
from CHUYENBAY,MAYBAY,HANGHANGKHONG
where CHUYENBAY.MACHUYENBAY=@MACHUYENBAY AND CHUYENBAY.MAHANGHK=HANGHANGKHONG.MAHANGHK AND HANGHANGKHONG.MAHANGHK=MAYBAY.MAHANGHK

--Thêm m?i Phòng ban
go
create proc sp_themPHONGBAN(@MAPHONG nvarchar(10),
						@MAHANGHK nvarchar(10),
						@TENPHG nvarchar(25),
						@TRPHG nvarchar(10))
as
insert into PHONGBAN(MAPHONG,MAHANGHK,TENPHG,TRPHG)
values (@MAPHONG,@MAHANGHK,@TENPHG,@TRPHG)
--Xóa PhongBan
go
create proc sp_xoaPHONGBAN(@MAPHONG nvarchar(10))
as 
Delete from PHONGBAN where MAPHONG = @MAPHONG 
--S?a PhongBan
go
create proc sp_suaPHONGBAN(@MAPHONG nvarchar(10),
						@MAHANGHK nvarchar(10),
						@TENPHG nvarchar(25),
						@TRPHG nvarchar(10))
as
Update PHONGBAN set TENPHG = @TENPHG, TRPHG = @TRPHG
	   where MAPHONG = @MAPHONG
--Thêm m?i Hành Khách
go
create proc sp_themHANHKHACH(	@MAHK nvarchar(10) ,
						@HOKH nvarchar(30) ,
						@TENHK nvarchar(15) ,
						@NAMSINHHK Datetime ,
						@QT nvarchar(15) ,
						@PHAI nvarchar(3) ,
						@SDTHK nvarchar(10) ,
						@DIACHIHK nvarchar(100) ,
						@SOHOCHIEU nvarchar(9))
as
insert into HANHKHACH(MAHK, HOKH, TENHK, NAMSINHHK, QT, PHAI, SDTHK, DIACHIHK, SOHOCHIEU)
values (@MAHK, @HOKH, @TENHK, @NAMSINHHK, @QT, @PHAI, @SDTHK, @DIACHIHK, @SOHOCHIEU)
--S?a hành khách
go
create proc sp_suaHANHKHACH(@MAHK nvarchar(10) ,
						@HOKH nvarchar(30) ,
						@TENHK nvarchar(15) ,
						@NAMSINHHK Datetime ,
						@QT nvarchar(15) ,
						@PHAI nvarchar(3) ,
						@SDTHK nvarchar(10) ,
						@DIACHIHK nvarchar(100) ,
						@SOHOCHIEU nvarchar(9))
as
Update HANHKHACH set HOKH = @HOKH, TENHK = @TENHK, NAMSINHHK = @NAMSINHHK, QT = @QT, PHAI = @PHAI, SDTHK = @SDTHK, DIACHIHK = @DIACHIHK, SOHOCHIEU = @SOHOCHIEU
		where MAHK = @MAHK 
--Xóa hành khách
go
create proc sp_xoaHANHKHACH(@MAHK nvarchar (10))
as
delete from HANHKHACH where MAHK = @MAHK

go
create proc sp_layDSHANHKHACH
as
select * from HANHKHACH 

go
create proc sp_layDSTENHANHKHACH
as
select CONCAT(HANHKHACH.HOKH,' ',HANHKHACH.TENHK) as 'HOTEN',MAHK from HANHKHACH 

go
create proc sp_layTENHANHKHACH_theoMAHK(@MAHK nvarchar(10))
as
select CONCAT(HANHKHACH.HOKH,' ',HANHKHACH.TENHK) as 'HOTEN' from HANHKHACH where MAHK=@MAHK

--Thêm m?i Chuy?n bay 
go
create proc sp_themCHUYENBAY(@MACHUYENBAY nvarchar(10),
						@SBKHOIHANH nvarchar(100),
						@DDIEMKHOIHANH nvarchar(100),
						@SBDEN nvarchar(100) ,
						@DDIEMDEN nvarchar(100) ,
						@SBTRUNGCHUYEN nvarchar(100) ,
						@MAHANGHK nvarchar(10))
as
insert into CHUYENBAY(MACHUYENBAY, SBKHOIHANH ,DDIEMKHOIHANH ,SBDEN, DDIEMDEN, SBTRUNGCHUYEN, MAHANGHK)
values (@MACHUYENBAY, @SBKHOIHANH ,@DDIEMKHOIHANH ,@SBDEN, @DDIEMDEN, @SBTRUNGCHUYEN, @MAHANGHK)
--S?a chuy?n bay
go
create proc sp_suaCHUYENBAY(@MACHUYENBAY nvarchar(10),
						@SBKHOIHANH nvarchar(100),
						@DDIEMKHOIHANH nvarchar(100),
						@SBDEN nvarchar(100) ,
						@DDIEMDEN nvarchar(100) ,
						@SBTRUNGCHUYEN nvarchar(100) ,
						@MAHANGHK nvarchar(10))
as 
Update CHUYENBAY set SBKHOIHANH = @SBKHOIHANH, DDIEMKHOIHANH = @DDIEMKHOIHANH, SBDEN = @SBDEN, DDIEMDEN = @DDIEMDEN, SBTRUNGCHUYEN = @SBTRUNGCHUYEN, MAHANGHK = @MAHANGHK
		where MACHUYENBAY = @MACHUYENBAY 
--L?y DS chuy?n bay
go
create proc sp_layDSCHUYENBAY
as
select * from CHUYENBAY 

go 
create proc sp_layDSCHUYENBAY_theoMAHANGHANGKHONG(@MAHANGHK nvarchar(10))
as
select MACHUYENBAY from CHUYENBAY where CHUYENBAY.MAHANGHK=@MAHANGHK

--Xóa chuy?n bay
go
create proc sp_xoaCHUYENBAY(@MACHUYENBAY nvarchar(10))
as
delete from CHUYENBAY where MACHUYENBAY = @MACHUYENBAY
								



-- bang NHANVIEN
go
create proc sp_themNV(@MANV nvarchar(10),
					  @MAPHG nvarchar(10),
					  @HONV nvarchar(30),
					  @TENNV nvarchar(15),
					  @NSINHNV datetime,
					  @SDTNV nvarchar(10),
					  @DIACHINV nvarchar(100),
					  @CCCD nvarchar(12),
					  @PHAI nvarchar(3),
					  @MANGQL nvarchar(10),
					  @PHANLOAI nvarchar(50),
					  @LUONG int) as
insert into NHANVIEN(MANV, MAPHG,HONV,TENNV,NSINHNV,SDTNV,DIACHINV,CCCD,PHAI,MANGQL,PHANLOAI,LUONG) 
values	(@MANV, @MAPHG,@HONV,@TENNV,@NSINHNV,@SDTNV,@DIACHINV,@CCCD,@PHAI,@MANGQL,@PHANLOAI,@LUONG)

go
create proc sp_xoaNV(@MANV nvarchar(10)) as
delete from NHANVIEN
where @MANV=NHANVIEN.MANV

go
create proc sp_suaNV(@MANV nvarchar(10),
					 @MAPHG nvarchar(10),
					 @HONV nvarchar(30),
					 @TENNV nvarchar(15),
					 @NSINHNV datetime,
					 @SDTNV nvarchar(10),
					 @DIACHINV nvarchar(100),
					 @CCCD nvarchar(12),
					 @PHAI nvarchar(3),
					 @MANGQL nvarchar(10),
					 @PHANLOAI nvarchar(50),
					 @LUONG int ) as
update NHANVIEN
set MAPHG=@MAPHG, HONV=@HONV, TENNV=@TENNV, NSINHNV=@NSINHNV, SDTNV=@SDTNV, DIACHINV=@DIACHINV, CCCD=@CCCD, PHAI=@PHAI, MANGQL=@MANGQL, PHANLOAI=@PHANLOAI, LUONG=@LUONG
where MANV=@MANV

go
create proc sp_layDSNV
as
select *
from NHANVIEN

go
create proc sp_layDSTENNV_theoMAHANGHANGKHONG(@MAHANGHK nvarchar(10))
as
select CONCAT(NHANVIEN.HONV,' ',NHANVIEN.TENNV) as 'HOTEN',NHANVIEN.MANV
from NHANVIEN,PHONGBAN,HANGHANGKHONG
where NHANVIEN.MANV not Like '%QL%' AND NHANVIEN.MAPHG=PHONGBAN.MAPHONG AND PHONGBAN.MAHANGHK=HANGHANGKHONG.MAHANGHK AND HANGHANGKHONG.MAHANGHK=@MAHANGHK



--bang LICHBAY
go
create proc sp_themLICHBAY (@MACHUYENBAY nvarchar(10),
							@GIOKHOIHANH nvarchar(5),
							@NGAYKHOIHANH DateTime,
							@SOHIEU nvarchar(11) ) as
insert into LICHBAY (MACHUYENBAY, GIOKHOIHANH,NGAYKHOIHANH,SOHIEU)
values (@MACHUYENBAY, @GIOKHOIHANH, @NGAYKHOIHANH, @SOHIEU)

go
create proc sp_xoaLICHBAY (@MACHUYENBAY nvarchar(10),
						   @GIOKHOIHANH nvarchar(5),
						   @NGAYKHOIHANH DateTime) as
delete from LICHBAY
where MACHUYENBAY=@MACHUYENBAY AND GIOKHOIHANH=@GIOKHOIHANH AND NGAYKHOIHANH=@NGAYKHOIHANH

go
create proc sp_suaLICHBAY(@MACHUYENBAY nvarchar(10),
						  @GIOKHOIHANH nvarchar(5),
						  @NGAYKHOIHANH DateTime,
						  @SOHIEU nvarchar(11)) as
update LICHBAY
set SOHIEU=@SOHIEU
where MACHUYENBAY=@MACHUYENBAY AND GIOKHOIHANH=@GIOKHOIHANH AND @NGAYKHOIHANH=@NGAYKHOIHANH

go
create proc sp_layDSLICHBAY as
select *
from LICHBAY

go
create proc sp_layDSGIOKHOIHANH_theoMACHUYENBAY(@MACHUYENBAY nvarchar(10)) as
select NGAYKHOIHANH,GIOKHOIHANH
from LICHBAY
where MACHUYENBAY=@MACHUYENBAY

create proc sp_layDSNGAYKHOIHANH_theoMACHUYENBAYVAGIOKHOIHANH(@MACHUYENBAY nvarchar(10),@GIOKHOIHANH nvarchar(5)) as
select NGAYKHOIHANH
from LICHBAY
where MACHUYENBAY=@MACHUYENBAY AND GIOKHOIHANH=@GIOKHOIHANH


-- bang MAYBAY
go
create proc sp_themMAYBAY (@SOHIEU nvarchar(11),
						    @MAHANGHK nvarchar(10)) as
insert into MAYBAY (SOHIEU,MAHANGHK)
values (@SOHIEU,@MAHANGHK)

go
create proc sp_xoaMAYBAY (@SOHIEU nvarchar(11)) as
delete from MAYBAY
where SOHIEU=@SOHIEU

go
create proc sp_suaMAYBAY (@SOHIEU nvarchar(11),
						  @MAHANGHK nvarchar(10)) as
update MAYBAY
set MAHANGHK=@MAHANGHK
where SOHIEU=@SOHIEU

go
create proc sp_layDSMAYBAY as
select *
from MAYBAY

go
create proc sp_layDSMAYBAY_theoHANGHANGKHONG(@MAHANGHK nvarchar(10)) as
select *
from MAYBAY where MAHANGHK=@MAHANGHK

-- bang LOAIVE
go
create proc sp_themLOAIVE (@MALOAIVE nvarchar(3),
						   @TENLOAIVE nvarchar(20)) as
insert into LOAIVE (MALOAIVE, TENLOAIVE)
values (@MALOAIVE,@TENLOAIVE)

go
create proc sp_xoaLOAIVE (@MALOAIVE nvarchar(3)) as
delete from LOAIVE
where MALOAIVE=@MALOAIVE

go
create proc sp_suaLOAIVE (@MALOAIVE nvarchar(3),
						  @TENLOAIVE nvarchar(20)) as
update LOAIVE
set TENLOAIVE=@TENLOAIVE
where MALOAIVE=@MALOAIVE

go
create proc sp_layDSLOAIVE as
select *
from LOAIVE

go
create proc sp_layTENLOAIVE(@MALOAIVE nvarchar(3)) as
select TENLOAIVE
from LOAIVE
where MALOAIVE=@MALOAIVE
-- bang VEMAYBAY
go
create proc sp_themVEMAYBAY (@MACHUYENBAY nvarchar(10), 
							 @MASOVE nvarchar(10),
							 @MALOAIVE nvarchar(3),
							 @GIAVE int,
							 @KLHL float,
							 @MAHK nvarchar(10),
							 @MASOGHE nvarchar(4),					 
							 @GIOKHOIHANH nvarchar(5),
							 @NGAYKHOIHANH DateTime) as
insert into VEMAYBAY (MACHUYENBAY ,MASOVE, MALOAIVE, GIAVE, KLHL, MAHK, MASOGHE, GIOKHOIHANH, NGAYKHOIHANH)
values (@MACHUYENBAY, @MASOVE, @MALOAIVE, @GIAVE, @KLHL, @MAHK, @MASOGHE, @GIOKHOIHANH, @NGAYKHOIHANH)

go
create proc sp_xoaVEMAYBAY (@MASOVE nvarchar(10)) as
delete from VEMAYBAY
where MASOVE=@MASOVE

go
create proc sp_suaVEMAYBAY (@MACHUYENBAY nvarchar(10), 
							@MASOVE nvarchar(10),
							@MALOAIVE nvarchar(3),
							@GIAVE int,
							@KLHL float,
							@MAHK nvarchar(10),
							@MASOGHE nvarchar(4),					 
							@GIOKHOIHANH nvarchar(5),
							@NGAYKHOIHANH DateTime) as
update VEMAYBAY
set MACHUYENBAY=@MACHUYENBAY, MALOAIVE=@MALOAIVE, GIAVE=@GIAVE, KLHL=@KLHL, MAHK=@MAHK, MASOGHE=@MASOGHE, GIOKHOIHANH=@GIOKHOIHANH, NGAYKHOIHANH=@NGAYKHOIHANH
where MASOVE=@MASOVE

go
create proc sp_layDSVEMAYBAY as
select *
from VEMAYBAY

-- bang PHANCONG
go
create proc sp_themPHANCONG (@MANV nvarchar(10),
							 @MACHUYENBAY nvarchar(10),
							 @GIOKHOIHANH nvarchar(5),
							 @NGAYKHOIHANH DateTime,
							 @SOGIOBAY int) as
insert into PHANCONG (MANV,MACHUYENBAY,GIOKHOIHANH,NGAYKHOIHANH,SOGIOBAY)
values (@MANV,@MACHUYENBAY,@GIOKHOIHANH,@NGAYKHOIHANH,@SOGIOBAY)

go
create proc sp_xoaPHANCONG (@MANV nvarchar(10),
							@MACHUYENBAY nvarchar(10),
							@GIOKHOIHANH nvarchar(5),
							@NGAYKHOIHANH DateTime) as
delete from PHANCONG
where MANV=@MANV AND MACHUYENBAY=@MACHUYENBAY AND GIOKHOIHANH=@GIOKHOIHANH AND NGAYKHOIHANH=@NGAYKHOIHANH

go
create proc sp_suaPHANCONG (@MANV nvarchar(10),
							@MACHUYENBAY nvarchar(10),
							@GIOKHOIHANH nvarchar(5),
							@NGAYKHOIHANH DateTime,
							@SOGIOBAY int) as
update PHANCONG
set SOGIOBAY=@SOGIOBAY
where MANV=@MANV AND MACHUYENBAY=@MACHUYENBAY AND GIOKHOIHANH=@GIOKHOIHANH AND NGAYKHOIHANH=@NGAYKHOIHANH

go
create proc sp_layDSPHANCONG as
select *
from PHANCONG
go
create proc sp_layTENHANGHANGKHONG_theoMAHANGHANGKHONG(@MAHANGHK nvarchar(10))
as
Select TENHANGHK
from HANGHANGKHONG
where MAHANGHK=@MAHANGHK

create proc sp_layDSPHONGBAN
as
select *
from PHONGBAN

create proc sp_layTENNHANVIEN_theoMANHANVIEN(@MANV nvarchar(10))
as
Select CONCAT(HONV,' ',TENNV)
from NHANVIEN
where MANV=@MANV

create proc sp_layDSNV_theoPHONGBAN_theoHANGHANGKHONG(@MAHANGHK nvarchar(10), @MAPHG nvarchar(10))
as
select CONCAT(HONV,' ',TENNV)
from NHANVIEN,PHONGBAN,HANGHANGKHONG
where NHANVIEN.MAPHG=PHONGBAN.MAPHONG AND PHONGBAN.MAHANGHK=HANGHANGKHONG.MAHANGHK AND NHANVIEN.MAPHG=@MAHANGHK AND HANGHANGKHONG.MAHANGHK=@MAPHG

create proc sp_layTENHHK_THEOMAPHONG(@MAPHG nvarchar(10))
as
select TENHANGHK
from PHONGBAN,HANGHANGKHONG
where PHONGBAN.MAPHONG=@MAPHG AND PHONGBAN.MAHANGHK=HANGHANGKHONG.MAHANGHK

create proc sp_layTENPHONGBAN_THEOMAPHONG(@MAPHG nvarchar(10))
as
select TENPHG
from PHONGBAN
where MAPHONG=@MAPHG
create proc sp_layDSPB_theoHHK(@MAHANGHK nvarchar(10))
as
select *
from PHONGBAN,HANGHANGKHONG
where PHONGBAN.MAHANGHK=HANGHANGKHONG.MAHANGHK AND HANGHANGKHONG.MAHANGHK=@MAHANGHK


create proc sp_layDSNGQL_theoHHK(@MAHANGHK nvarchar(10))
as
select CONCAT(NHANVIEN.HONV,' ',NHANVIEN.TENNV) as 'HOTEN',NHANVIEN.MANV
from NHANVIEN,PHONGBAN,HANGHANGKHONG
where NHANVIEN.MANV LIKE '%QL%' AND PHONGBAN.MAHANGHK=HANGHANGKHONG.MAHANGHK AND HANGHANGKHONG.MAHANGHK=@MAHANGHK AND PHONGBAN.MAPHONG=NHANVIEN.MAPHG

create proc sp_laySBKHOIHANH_theoMACHUYENBAY(@MACHUYENBAY nvarchar(10))
as
select 'SÂN BAY '+SBKHOIHANH+' - '+DDIEMKHOIHANH as 'NOIKH'
from CHUYENBAY
where MACHUYENBAY=@MACHUYENBAY

create proc sp_laySBDEN_theoMACHUYENBAY(@MACHUYENBAY nvarchar(10))
as
select 'SÂN BAY '+SBDEN+' - '+DDIEMDEN as 'NOIDEN'
from CHUYENBAY
where MACHUYENBAY=@MACHUYENBAY

create proc sp_laySBTC_theoMACHUYENBAY(@MACHUYENBAY nvarchar(10))
as
select 'SÂN BAY '+SBTRUNGCHUYEN as 'NOIDEN'
from CHUYENBAY
where MACHUYENBAY=@MACHUYENBAY










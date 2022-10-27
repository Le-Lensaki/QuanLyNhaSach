use master
drop database QLNS
go
create database QLNS
go
use QLNS
set dateformat DMY

create table SACH (
	MaSach int identity(1,1) not null,
	TenSach nvarchar(100) ,
	TheLoai nvarchar(50),
	TacGia nvarchar(100),
	SoLuong int,
	DonGiaNhap int,
	Primary key (MaSach)
)
go
create table NHAPSACH(
	MaSach int not null,
	NgayNhap datetime not null,
	SoLuong int
	CONSTRAINT PK_NHAPSACH PRIMARY KEY (MaSach,NgayNhap)
	CONSTRAINT FK_SACH_NHAPSACH FOREIGN KEY (MaSach)
    REFERENCES SACH(MaSach)
)
go
create table KHACHHANG(
	MaKH int identity(1,1) not null,
	TenKH nvarchar(100) ,
	DiaChi nvarchar(100),
	DienThoai nvarchar(20),
	Email nvarchar(50),
	SoTienNo int,
	primary key(MaKH)
)
go
create table HOADON(
	MaHD int identity(1,1) not null,
	TenKH nvarchar(100),
	DienThoai nvarchar(20),
	NgayHoaDon datetime,
	TongTien int,
	SoTienTra int,
	primary key (MaHD),
)
go
create table CTHD(
	MaHD int not null,
	MaSach int not null,
	SoLuongBan int,
	DonGiaBan int,
	constraint PK_CTHD primary key (MaHD,MaSach),
	constraint FK_HOADON_CTHD foreign key (MaHD) 
	references HOADON(MaHD),
	constraint FK_SACH_CTHD foreign key (MaSach) 
	references SACH(MaSach),
)
go
create table PHIEUTHUTIEN(
	MaPhieuThu int identity(1,1) not null,
	MaKH int,
	NgayThuTien datetime,
	SoTienThu int,
	primary key (MaPhieuThu),
	constraint FK_KHACHHANG_PHIEUTHUTIEN foreign key (MaKH)
	references KHACHHANG(MaKH)
)
go
create table BAOCAOTON(
	MaChiTietTon int identity(1,1) not null,
	Thang int,
	Nam int,
	MaSach int,
	TonDau int,
	TonPhatSinh int,
	TonCuoi int,
	primary key (MaChiTietTon),
	constraint FK_SACH_BAOCAOTON foreign key (MaSach) 
	references SACH(MaSach),
)
go
create table BAOCAOCONGNO(
	MaChiTietCongNo int identity(1,1) not null ,
	Thang int,
	Nam int,
	MaKH int,
	NoDau int,
	PhatSinh int,
	NoCuoi int,
	primary key (MaChiTietCongNo),
	constraint FK_KHACHHANG_BAOCAOCONGNO foreign key (MaKH) 
	references KHACHHANG(MaKH),
)
go
create table THAMSO(
	LuongNhapItNhat int,
	LuongTonToiDa int,
	NoToiDa int,
	LuongTonToiThieu int,
	KiemTraSoTienThu bit,
)
create table ADMINISTRATORS (
	HOTEN		nvarchar(100),
	USERNAME	varchar(20) primary key,
	PASSWORD	varchar(20),
	CHUCVU		nvarchar(50)
)



----------------------------------------
go
create procedure InsertNhapSach
@NgayNhap datetime, @TenSach nvarchar(100),@TheLoai nvarchar(50),@TacGia nvarchar(100),@SoLuong int,@DonGiaNhap int
as
begin
	declare @LuongNhapItNhat int
	set @LuongNhapItNhat = (select LuongNhapItNhat from THAMSO )
	if @SoLuong < @LuongNhapItNhat 
	begin
		print N'Số lượng sách nhập phải lớn hơn hoặc bằng ' + CAST(@LuongNhapItNhat as varchar)
		return
	end
	declare @MaSach int 
	set @MaSach = (select MaSach from SACH where TenSach =@TenSach and TheLoai= @TheLoai and TacGia=@TacGia)
	if @MaSach is NULL
	begin
		insert into SACH (TenSach,TacGia,TheLoai,SoLuong,DonGiaNhap) values (@TenSach,@TacGia,@TheLoai,@SoLuong,@DonGiaNhap)
		set @MaSach = (select MaSach from SACH where TenSach =@TenSach and TheLoai= @TheLoai and TacGia=@TacGia)
		insert into NHAPSACH (MaSach,NgayNhap,SoLuong) values (@MaSach,@NgayNhap,@SoLuong)
		print N'Nhập sách thành công'

	end
	else
	begin
		declare @LuongTonToiDa int
		set @LuongTonToiDa = (select LuongTonToiDa from THAMSO )
		declare @SoLuongSach int
		set @SoLuongSach = (select SoLuong from SACH where MaSach=@MaSach)
		if @SoLuongSach <= @LuongTonToiDa
			begin
				if exists(select * from NHAPSACH where MaSach = @MaSach and NgayNhap = @NgayNhap) 
					update NHAPSACH set SoLuong = SoLuong + @SoLuong where MaSach = @MaSach and NgayNhap = @NgayNhap
				else
					insert into NHAPSACH (MaSach,NgayNhap,SoLuong) values (@MaSach,@NgayNhap,@SoLuong)
				update SACH
				set SoLuong = SoLuong + @SoLuong , DonGiaNhap = @DonGiaNhap
				where MaSach=@MaSach
				print N'Nhập sách thành công'
			end
		else 
		begin
		print N'Không thể nhập sách có lượng tồn nhiều hơn ' + CAST(@LuongTonToiDa as varchar)
		return
		end
	end
end
go


go
create trigger ThemCTHD on CTHD for insert
as
	declare @masach int;
	declare @soluong int;
	declare @thang int;
	declare @nam int;

	select @soluong = SoLuongBan from inserted;
	select @masach = MaSach from inserted;
	select @thang = month(NgayHoaDon) from HOADON, inserted where HOADON.MaHD = inserted.MaHD
	select @nam = year(NgayHoaDon) from HOADON, inserted where HOADON.MaHD = inserted.MaHD
	-- Nếu đã có sách trong tháng đó
	if exists(
		select * from BAOCAOTON where MaSach = @masach and Thang = @thang and Nam = @nam
	)
	begin
		update BAOCAOTON
		set TonPhatSinh = TonPhatSinh - @soluong, TonCuoi = TonCuoi - @soluong where MaSach = @masach and Thang = @thang and Nam = @nam;
	end
	-- Nếu chưa có
	else 
	begin
		declare @tondau int;
		declare @thangTruoc int;
		declare @namTruoc int;

		if exists(select TonCuoi, MaChiTietTon, max(Nam * 100 + Thang) as thoigian from BAOCAOTON where (Nam * 100 + Thang) < @nam * 100 + @thang and MaSach = @masach group by MaChiTietTon, TonCuoi)
			select @tondau = temp.TonCuoi from (select TonCuoi, MaChiTietTon, max(Nam * 100 + Thang) as thoigian from BAOCAOTON where (Nam * 100 + Thang) < @nam * 100 + @thang and MaSach = @masach group by MaChiTietTon, TonCuoi) as temp;
		else set @tondau = 0;
		insert into BAOCAOTON values (@thang, @nam, @masach, @tondau, -@soluong, @tondau - @soluong);
	end
go

create trigger ThemHD on HOADON for insert
as
	declare @makh int;
	declare @sotien int;
	declare @thang int;
	declare @nam int;

	select @sotien = TongTien - SoTienTra from inserted;
	select @makh = MaKH from inserted, KHACHHANG where inserted.TenKH = KHACHHANG.TenKH and inserted.DienThoai = KHACHHANG.DienThoai;
	select @thang = month(NgayHoaDon) from inserted
	select @nam = year(NgayHoaDon) from inserted

	if exists(
		select * from BAOCAOCONGNO where MaKH = @makh and Thang = @thang and Nam = @nam
	)
	begin
		update BAOCAOCONGNO
		set PhatSinh = PhatSinh + @sotien, NoCuoi = NoCuoi + @sotien where MaKH = @makh and Thang = @thang and @nam = Nam;
	end
	else 
	begin
		declare @tondau int;		
		if exists(select NoCuoi, MaChiTietCongNo, max(Nam * 100 + Thang) as thoigian from BAOCAOCONGNO where (Nam * 100 + Thang) < @nam * 100 + @thang and MaKH = @makh group by MaChiTietCongNo, NoCuoi)
			select @tondau = temp.NoCuoi from (select NoCuoi, MaChiTietCongNo, max(Nam * 100 + Thang) as thoigian from BAOCAOCONGNO where (Nam * 100 + Thang) < @nam * 100 + @thang and MaKH = @makh group by MaChiTietCongNo, NoCuoi) as temp;
		else set @tondau = 0;
		insert into BAOCAOCONGNO values (@thang, @nam, @makh, @tondau, @sotien, @tondau + @sotien);
	end
go

create trigger ThemSach on NHAPSACH for insert
as
	declare @masach int;
	declare @soluong int;
	declare @thang int;
	declare @nam int;

	select @soluong = SoLuong from inserted;
	select @masach = MaSach from inserted;
	select @thang = month(NgayNhap) from inserted
	select @nam = year(NgayNhap) from inserted

	if exists(
		select * from BAOCAOTON where MaSach = @masach and Thang = @thang and Nam = @nam
	)
	begin
		update BAOCAOTON
		set TonPhatSinh = TonPhatSinh + @soluong, TonCuoi = TonCuoi + @soluong where MaSach = @masach and Thang = @thang and Nam = @nam;
	end
	else 
	begin
		declare @tondau int;
		if exists(select TonCuoi, MaChiTietTon, max(Nam * 100 + Thang) as thoigian from BAOCAOTON where (Nam * 100 + Thang) < @nam * 100 + @thang and MaSach = @masach group by MaChiTietTon, TonCuoi)
			select @tondau = temp.TonCuoi from (select TonCuoi, MaChiTietTon, max(Nam * 100 + Thang) as thoigian from BAOCAOTON where (Nam * 100 + Thang) < @nam * 100 + @thang and MaSach = @masach group by MaChiTietTon, TonCuoi) as temp;
		else set @tondau = 0;
		insert into BAOCAOTON values (@thang, @nam, @masach, @tondau, @soluong, @tondau + @soluong);
	end
go

create trigger ThemPhieuThuTien on PHIEUTHUTIEN for insert
as
	declare @makh int;
	declare @sotien int;
	declare @thang int;
	declare @nam int;

	select @sotien = SoTienThu from inserted;
	select @makh = MaKH from inserted
	select @thang = month(NgayThuTien) from inserted
	select @nam = year(NgayThuTien) from inserted

	if exists(
		select * from BAOCAOCONGNO where MaKH = @makh and Thang = @thang and Nam = @nam
	)
	begin
		update BAOCAOCONGNO
		set PhatSinh = PhatSinh - @sotien, NoCuoi = NoCuoi - @sotien where MaKH = @makh and Thang = @thang and Nam = @nam;
	end
	else 
	begin
		declare @tondau int;
		declare @thangTruoc int;
		declare @namTruoc int;

		set @thangTruoc = @thang - 1;
		set @namTruoc = @nam
		if @thangTruoc < 0
		begin
			set @thangTruoc = 12;
			set @namTruoc = @namTruoc - 1;
		end;
		
		if exists(select NoCuoi, MaChiTietCongNo, max(Nam * 100 + Thang) as thoigian from BAOCAOCONGNO where (Nam * 100 + Thang) < @nam * 100 + @thang and MaKH = @makh group by MaChiTietCongNo, NoCuoi)
			select @tondau = temp.NoCuoi from (select NoCuoi, MaChiTietCongNo, max(Nam * 100 + Thang) as thoigian from BAOCAOCONGNO where (Nam * 100 + Thang) < @nam * 100 + @thang and MaKH = @makh group by MaChiTietCongNo, NoCuoi) as temp;
		else set @tondau = 0;
		insert into BAOCAOCONGNO values (@thang, @nam, @makh, @tondau, -@sotien, @tondau - @sotien);
	end
go

create trigger DeletePhieuThuTien on PHIEUTHUTIEN
for delete 
as
begin
	declare @MaKH int 
	select  @MaKH = MaKH from deleted
	declare @NgayThuTien datetime
	set @NgayThuTien = (select TOP 1 NgayThuTien from deleted )
	declare @SoTienThu int
	set @SoTienThu = (select Top 1 SoTienThu from deleted)
	update BAOCAOCONGNO
	set NoCuoi = NoCuoi + @SoTienThu
	where MaKH = @MaKH and Thang = month(@NgayThuTien) and Nam = year(@NgayThuTien)
end
go
create trigger DeleteKhachHang on KHACHHANG 
instead of delete 
as
begin 
	declare @MaKH int 
	select  @MaKH = MaKH from deleted

	delete from PHIEUTHUTIEN where MaKH = @MaKH
	delete from BAOCAOCONGNO where MaKH = @MaKH
	delete from KHACHHANG where MaKH = @MaKH
end

go

insert into THAMSO values(150, 300, 20000, 20, 1)

insert into ADMINISTRATORS values (N'Lê Phương Hoàng', 'lephuonghoangx4', 'password', N'Quản lý') 
exec InsertNhapSach '25/12/2021', N'Cho tôi xin một vé đi tuổi thơ', N'Thiếu nhi', N'Nguyễn Nhật Ánh', 180, 9000
insert into ADMINISTRATORS values(N'Lương Ngọc Hải Đăng', 'haidang', 'abc', N'Nhân viên bán hàng')
exec InsertNhapSach '25/12/2021', N'Mắt biếc', N'Truyện dài', N'Nguyễn Nhật Ánh', 180, 9000
exec InsertNhapSach '25/12/2021', N'Harry Porter và Hòn đá Phù thuỷ', N'Tiểu thuyết', N'J. K. Rowling', 180, 9000



set dateformat DMY
insert KHACHHANG (TenKH,DiaChi,DienThoai,Email,SoTienNo) values ('Le Phuong Hoang','tphcm ','0971716200','Lephuonghoangx4@gmail.com',100000)
insert KHACHHANG (TenKH,DiaChi,DienThoai,Email,SoTienNo) values ('Luong Ngoc Hai Dang ','Long An ','0123456789','haidangtest@gmail.com',100000)
insert PHIEUTHUTIEN (MaKH,NgayThuTien,SoTienThu) values (1,'25/12/2021',10000)
insert PHIEUTHUTIEN (MaKH,NgayThuTien,SoTienThu) values (2,'26/12/2021',10000)
insert PHIEUTHUTIEN (MaKH,NgayThuTien,SoTienThu) values (2,'27/12/2021',100)
--delete from PHIEUTHUTIEN where MaKH = 1 
--delete from KHACHHANG where MaKH =2
--select * from PHIEUTHUTIEN
--select * from KHACHHANG
--select * from BAOCAOCONGNO
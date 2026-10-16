-- =========================================================================================
-- HỆ THỐNG CƠ SỞ DỮ LIỆU: QUẢN LÝ TOUR DU LỊCH & ĐĂNG KÝ TOUR - VĂN HÓA VIỆT TP.HCM
-- ĐẶC TẢ SQL SERVER 2019/2022 - CHUẨN HÓA 3NF (16 BẢNG HOÀN CHỈNH)
-- =========================================================================================

CREATE DATABASE QL_DuLich_VanHoaViet;
GO

USE QL_DuLich_VanHoaViet;
GO

-- 1. BẢNG TOUR DU LỊCH
CREATE TABLE TOUR (
    MaTour VARCHAR(20) PRIMARY KEY,
    TenTour NVARCHAR(250) NOT NULL,
    SoNgay INT NOT NULL CHECK (SoNgay > 0),
    SoDem INT NOT NULL CHECK (SoDem >= 0),
    DonGia DECIMAL(18, 2) NOT NULL CHECK (DonGia > 0),
    NoiKhoiHanh NVARCHAR(100) NOT NULL DEFAULT N'TP.HCM',
    MoTa NVARCHAR(MAX)
);

-- 2. BẢNG NƠI DỪNG CHÂN
CREATE TABLE NOI_DUNG_CHAN (
    MaNDC VARCHAR(20) PRIMARY KEY,
    MaTour VARCHAR(20) NOT NULL,
    TenNoiDungChan NVARCHAR(200) NOT NULL,
    ThuTuDung INT NOT NULL,
    DoiPhuongTien BIT NOT NULL DEFAULT 0,
    PhuongTienTiepTheo NVARCHAR(100),
    CoNoiAn BIT NOT NULL DEFAULT 1,
    CoKhachSan BIT NOT NULL DEFAULT 1,
    LoaiKhachSan NVARCHAR(50), -- 2 sao, 3 sao, 4 sao, 5 sao
    CONSTRAINT FK_NDC_Tour FOREIGN KEY (MaTour) REFERENCES TOUR(MaTour) ON DELETE CASCADE
);

-- 3. BẢNG ĐIỂM THAM QUAN
CREATE TABLE DIEM_THAM_QUAN (
    MaDTQ VARCHAR(20) PRIMARY KEY,
    MaNDC VARCHAR(20) NOT NULL,
    TenDiemThamQuan NVARCHAR(200) NOT NULL,
    DiaDiem NVARCHAR(250) NOT NULL,
    NoiDung NVARCHAR(MAX),
    YNghia NVARCHAR(MAX),
    CONSTRAINT FK_DTQ_NDC FOREIGN KEY (MaNDC) REFERENCES NOI_DUNG_CHAN(MaNDC) ON DELETE CASCADE
);

-- 4. BẢNG PHƯƠNG TIỆN
CREATE TABLE PHUONG_TIEN (
    MaPT VARCHAR(20) PRIMARY KEY,
    TenPhuongTien NVARCHAR(100) NOT NULL,
    LoaiPhuongTien NVARCHAR(100) NOT NULL -- Máy bay, Xe đò cao cấp, Tàu hỏa...
);

-- 5. BẢNG KHÁCH SẠN
CREATE TABLE KHACH_SAN (
    MaKS VARCHAR(20) PRIMARY KEY,
    TenKhachSan NVARCHAR(200) NOT NULL,
    HangSao INT CHECK (HangSao BETWEEN 2 AND 5),
    DiaChi NVARCHAR(250),
    DienThoai VARCHAR(20)
);

-- 6. BẢNG KHÁCH HÀNG (BASE CLASS)
CREATE TABLE KHACH_HANG (
    MaKH VARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(150) NOT NULL,
    SoDienThoai VARCHAR(20) NOT NULL,
    Email VARCHAR(100),
    DiaChi NVARCHAR(250),
    LoaiKhach NVARCHAR(20) NOT NULL CHECK (LoaiKhach IN (N'KhachDoan', N'KhachLe'))
);

-- 7. BẢNG KHÁCH ĐOÀN (INHERITANCE)
CREATE TABLE KHACH_DOAN (
    MaKH VARCHAR(20) PRIMARY KEY,
    TenCoQuan NVARCHAR(250) NOT NULL,
    NguoiDaiDien NVARCHAR(150) NOT NULL,
    DiaChiCoQuan NVARCHAR(250),
    DienThoaiCoQuan VARCHAR(20),
    CONSTRAINT FK_KD_KH FOREIGN KEY (MaKH) REFERENCES KHACH_HANG(MaKH) ON DELETE CASCADE
);

-- 8. BẢNG PHIẾU ĐĂNG KÝ ĐOÀN (> 12 NGƯỜI)
CREATE TABLE PHIEU_DANG_KY_DOAN (
    MaPhieuDoan VARCHAR(20) PRIMARY KEY,
    MaKH VARCHAR(20) NOT NULL,
    MaTour VARCHAR(20) NOT NULL,
    NgayDiTuChon DATE NOT NULL,
    NgayVe DATE NOT NULL,
    SoNguoiDi INT NOT NULL CHECK (SoNguoiDi > 12), -- Ràng buộc bắt buộc > 12 người
    CoMuaBaoHiem BIT NOT NULL DEFAULT 1,
    DiemDonYeuCau NVARCHAR(250) NOT NULL, -- Đón tận nơi theo yêu cầu của đoàn
    TienDatCoc DECIMAL(18, 2) NOT NULL CHECK (TienDatCoc > 0),
    TongKinhPhi DECIMAL(18, 2) NOT NULL,
    ChiPhiPhatSinh DECIMAL(18, 2) DEFAULT 0,
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'DaDatCoc', -- DaDatCoc, DangDiTour, DaKetThuc, DaHuy
    CONSTRAINT FK_PKD_KH FOREIGN KEY (MaKH) REFERENCES KHACH_HANG(MaKH),
    CONSTRAINT FK_PKD_Tour FOREIGN KEY (MaTour) REFERENCES TOUR(MaTour)
);

-- 9. BẢNG THÀNH VIÊN ĐOÀN (DANH SÁCH MUA BẢO HIỂM)
CREATE TABLE THANH_VIEN_DOAN (
    MaThanhVien VARCHAR(20) PRIMARY KEY,
    MaPhieuDoan VARCHAR(20) NOT NULL,
    HoTen NVARCHAR(150) NOT NULL,
    NgaySinh DATE NOT NULL,
    SoCCCD VARCHAR(20) NOT NULL,
    GioiTinh NVARCHAR(10),
    CONSTRAINT FK_TV_PKD FOREIGN KEY (MaPhieuDoan) REFERENCES PHIEU_DANG_KY_DOAN(MaPhieuDoan) ON DELETE CASCADE
);

-- 10. BẢNG CHUYẾN DU LỊCH (DÀNH CHO KHÁCH LẺ <= 12 NGƯỜI)
CREATE TABLE CHUYEN_DU_LICH (
    MaChuyen VARCHAR(20) PRIMARY KEY,
    MaTour VARCHAR(20) NOT NULL,
    NgayDi DATE NOT NULL,
    NgayVe DATE NOT NULL,
    SoChoToiDa INT NOT NULL DEFAULT 45,
    SoChoConTrong INT NOT NULL CHECK (SoChoConTrong >= 0),
    TrangThai NVARCHAR(50) DEFAULT N'MoBan',
    CONSTRAINT FK_Chuyen_Tour FOREIGN KEY (MaTour) REFERENCES TOUR(MaTour)
);

-- 11. BẢNG ĐIỂM BÁN VÉ
CREATE TABLE DIEM_BAN_VE (
    MaDiemBanVe VARCHAR(20) PRIMARY KEY,
    TenDiemBanVe NVARCHAR(200) NOT NULL,
    DiaChi NVARCHAR(250) NOT NULL,
    DienThoai VARCHAR(20)
);

-- 12. BẢNG ĐIỂM ĐÓN QUY ĐỊNH
CREATE TABLE DIEM_DON (
    MaDiemDon VARCHAR(20) PRIMARY KEY,
    TenDiemDon NVARCHAR(200) NOT NULL,
    DiaChi NVARCHAR(250) NOT NULL,
    GhiChu NVARCHAR(250)
);

-- 13. BẢNG VÉ DU LỊCH (KHÁCH LẺ THANH TOÁN 100%)
CREATE TABLE VE_DU_LICH (
    MaVe VARCHAR(20) PRIMARY KEY,
    MaChuyen VARCHAR(20) NOT NULL,
    MaKH VARCHAR(20) NOT NULL,
    MaDiemBanVe VARCHAR(20) NOT NULL,
    MaDiemDon VARCHAR(20) NOT NULL,
    GiaVe DECIMAL(18, 2) NOT NULL,
    NgayMua DATETIME NOT NULL DEFAULT GETDATE(),
    DaThanhToan BIT NOT NULL DEFAULT 1, -- Khách lẻ phải thanh toán ngay khi mua
    CONSTRAINT FK_Ve_Chuyen FOREIGN KEY (MaChuyen) REFERENCES CHUYEN_DU_LICH(MaChuyen),
    CONSTRAINT FK_Ve_KH FOREIGN KEY (MaKH) REFERENCES KHACH_HANG(MaKH),
    CONSTRAINT FK_Ve_DBV FOREIGN KEY (MaDiemBanVe) REFERENCES DIEM_BAN_VE(MaDiemBanVe),
    CONSTRAINT FK_Ve_DD FOREIGN KEY (MaDiemDon) REFERENCES DIEM_DON(MaDiemDon)
);

-- 14. BẢNG HƯỚNG DẪN VIÊN (HDV)
CREATE TABLE HUONG_DAN_VIEN (
    MaHDV VARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(150) NOT NULL,
    SoDienThoai VARCHAR(20) NOT NULL,
    ChuyenMon NVARCHAR(200),
    LuongCanBan DECIMAL(18, 2) NOT NULL DEFAULT 6500000,
    TrangThai NVARCHAR(50) DEFAULT N'SanSang'
);

-- 15. BẢNG PHÂN CÔNG HƯỚNG DẪN VIÊN & BỐ TRÍ XE
CREATE TABLE PHAN_CONG (
    MaPhanCong VARCHAR(20) PRIMARY KEY,
    MaHDV VARCHAR(20) NOT NULL,
    MaChuyen VARCHAR(20) NULL, -- Nếu phân công cho chuyến lẻ (1 HDV / chuyến)
    MaPhieuDoan VARCHAR(20) NULL, -- Nếu phân công cho đoàn (có thể nhiều HDV nếu đoàn đông)
    NgayBatDau DATE NOT NULL,
    NgayKetThuc DATE NOT NULL,
    VaiTro NVARCHAR(50) DEFAULT N'HDV Chinh',
    ThuLaoTour DECIMAL(18, 2) NOT NULL DEFAULT 3000000,
    SoXe NVARCHAR(100),
    TaiXe NVARCHAR(100),
    CONSTRAINT FK_PC_HDV FOREIGN KEY (MaHDV) REFERENCES HUONG_DAN_VIEN(MaHDV),
    CONSTRAINT FK_PC_Chuyen FOREIGN KEY (MaChuyen) REFERENCES CHUYEN_DU_LICH(MaChuyen),
    CONSTRAINT FK_PC_PKD FOREIGN KEY (MaPhieuDoan) REFERENCES PHIEU_DANG_KY_DOAN(MaPhieuDoan)
);

-- 16. BẢNG LƯƠNG HƯỚNG DẪN VIÊN
CREATE TABLE BANG_LUONG (
    MaBangLuong VARCHAR(20) PRIMARY KEY,
    MaHDV VARCHAR(20) NOT NULL,
    Thang INT NOT NULL CHECK (Thang BETWEEN 1 AND 12),
    Nam INT NOT NULL CHECK (Nam >= 2020),
    LuongCanBan DECIMAL(18, 2) NOT NULL,
    TongThuLaoTour DECIMAL(18, 2) NOT NULL DEFAULT 0,
    TongThucLinh AS (LuongCanBan + TongThuLaoTour) PERSISTED, -- Công thức tính lương theo yêu cầu
    NgayLap DATE DEFAULT GETDATE(),
    CONSTRAINT FK_BL_HDV FOREIGN KEY (MaHDV) REFERENCES HUONG_DAN_VIEN(MaHDV)
);

-- 17. BẢNG PHIẾU KHẢO SÁT CHẤT LƯỢNG
CREATE TABLE PHIEU_KHAO_SAT (
    MaKhaoSat VARCHAR(20) PRIMARY KEY,
    MaTour VARCHAR(20) NOT NULL,
    MaKH VARCHAR(20) NOT NULL,
    DanhGiaNoiAn NVARCHAR(50),
    DanhGiaKhachSan NVARCHAR(50),
    DanhGiaPhuongTien NVARCHAR(50),
    DanhGiaHDV NVARCHAR(50),
    YKienGopY NVARCHAR(MAX),
    NgayKhaoSat DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_KS_Tour FOREIGN KEY (MaTour) REFERENCES TOUR(MaTour),
    CONSTRAINT FK_KS_KH FOREIGN KEY (MaKH) REFERENCES KHACH_HANG(MaKH)
);
GO

-- =========================================================================================
-- DỮ LIỆU MẪU BAN ĐẦU (SEED DATA)
-- =========================================================================================

INSERT INTO TOUR VALUES 
('TOUR001', N'TP.HCM - Nha Trang - Đà Lạt', 4, 3, 4500000, N'TP.HCM', N'Khám phá biển xanh Nha Trang và hoa ngàn Đà Lạt'),
('TOUR002', N'TP.HCM - Đà Nẵng - Hội An - Huế', 5, 4, 6800000, N'TP.HCM', N'Hành trình di sản miền Trung'),
('TOUR003', N'TP.HCM - Phú Quốc Thiên Đường Biển', 3, 2, 3900000, N'TP.HCM', N'Nghỉ dưỡng đảo ngọc Phú Quốc');

INSERT INTO DIEM_BAN_VE VALUES
('DBV01', N'Phòng vé Trung tâm Q.1', N'123 Lê Duẩn, P. Bến Nghé, Quận 1', '028.38221144'),
('DBV02', N'Đại lý Bán vé Quận 5', N'456 Trần Hưng Đạo, Quận 5', '028.39235566'),
('DBV03', N'Đại lý Bán vé Gò Vấp', N'789 Quang Trung, Gò Vấp', '028.38947788');

INSERT INTO DIEM_DON VALUES
('DD01', N'Trụ sở Công ty Du lịch Văn Hóa Việt', N'123 Lê Duẩn, Quận 1, TP.HCM', N'Điểm tập trung chính'),
('DD02', N'Bến xe Miền Đông mới', N'Số 501 Hoàng Hữu Nam, TP. Thủ Đức', N'Đón khách hướng Đông'),
('DD03', N'Sân bay Tân Sơn Nhất', N'Cổng Ga Quốc nội, Quận Tân Bình', N'Dành cho khách đi tour bay');

INSERT INTO HUONG_DAN_VIEN VALUES
('HDV01', N'Trần Quốc Toản', '0988112233', N'Tour Biển Đảo & Miền Trung', 6500000, N'SanSang'),
('HDV02', N'Lê Thị Hồng Gấm', '0977445566', N'Tour Cao Nguyên & Di tích', 6500000, N'SanSang'),
('HDV03', N'Phạm Văn Đồng', '0966778899', N'Tour Tây Nam Bộ & Sông Nước', 7000000, N'SanSang');

INSERT INTO CHUYEN_DU_LICH VALUES
('CHUYEN01', 'TOUR001', '2026-10-20', '2026-10-24', 45, 10, N'MoBan'),
('CHUYEN02', 'TOUR002', '2026-10-25', '2026-10-30', 45, 17, N'MoBan');
GO
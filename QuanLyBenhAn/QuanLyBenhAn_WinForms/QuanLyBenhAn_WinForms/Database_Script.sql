-- =========================================================================================
-- HỆ THỐNG CƠ SỞ DỮ LIỆU: QUẢN LÝ HỒ SƠ BỆNH ÁN CỦA BỆNH NHÂN - BỆNH VIỆN ĐA KHOA QUỐC TẾ
-- ĐẠI HỌC CÔNG NGHỆ TP.HCM (HUTECH) - BÀI THỰC HÀNH 5 OOAD
-- ĐẶC TẢ SQL SERVER 2019/2022 - CHUẨN HÓA 3NF (12 BẢNG HOÀN CHỈNH)
-- =========================================================================================

CREATE DATABASE QL_BenhAn_QuocTe;
GO

USE QL_BenhAn_QuocTe;
GO

-- 1. BẢNG BỆNH NHÂN
CREATE TABLE BENH_NHAN (
    MaBenhNhan VARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(150) NOT NULL,
    NgaySinh DATE NOT NULL,
    GioiTinh NVARCHAR(10) NOT NULL CHECK (GioiTinh IN (N'Nam', N'Nữ')),
    DiaChi NVARCHAR(250) NOT NULL,
    SoDienThoai VARCHAR(20) NOT NULL,
    Anh3x4 NVARCHAR(250),
    NgayDangKy DATETIME NOT NULL DEFAULT GETDATE()
);

-- 2. BẢNG PHIẾU ĐĂNG KÝ (LẦN ĐẦU & LỆ PHÍ HÀNG NĂM)
CREATE TABLE PHIEU_DANG_KY (
    MaPhieuDK VARCHAR(20) PRIMARY KEY,
    MaBenhNhan VARCHAR(20) NOT NULL,
    NgayDangKy DATETIME NOT NULL DEFAULT GETDATE(),
    LePhiHangNam DECIMAL(18, 2) NOT NULL DEFAULT 1500000 CHECK (LePhiHangNam > 0),
    HanSuDung DATE NOT NULL,
    TrangThaiDongPhi BIT NOT NULL DEFAULT 1,
    CONSTRAINT FK_PDK_BN FOREIGN KEY (MaBenhNhan) REFERENCES BENH_NHAN(MaBenhNhan) ON DELETE CASCADE
);

-- 3. BẢNG HỒ SƠ BỆNH ÁN (HSBA - TRỌN ĐỜI CỦA MỖI BỆNH NHÂN)
CREATE TABLE HO_SO_BENH_AN (
    MaHoSo VARCHAR(20) PRIMARY KEY,
    MaBenhNhan VARCHAR(20) NOT NULL UNIQUE, -- 1 bệnh nhân có duy nhất 1 HSBA
    NgayCap DATE NOT NULL DEFAULT GETDATE(),
    SoTrang INT NOT NULL DEFAULT 1,
    TrangBiaThongTin NVARCHAR(MAX),
    TinhTrangHoSo NVARCHAR(50) DEFAULT N'Đang lưu trữ',
    CONSTRAINT FK_HSBA_BN FOREIGN KEY (MaBenhNhan) REFERENCES BENH_NHAN(MaBenhNhan)
);

-- 4. BẢNG KHOA ĐIỀU TRỊ
CREATE TABLE KHOA_DIEU_TRI (
    MaKhoa VARCHAR(20) PRIMARY KEY,
    TenKhoa NVARCHAR(150) NOT NULL,
    ViTri NVARCHAR(100),
    TruongKhoa NVARCHAR(150)
);

-- 5. BẢNG BÁC SĨ ĐIỀU TRỊ
CREATE TABLE BAC_SI (
    MaBacSi VARCHAR(20) PRIMARY KEY,
    MaKhoa VARCHAR(20) NOT NULL,
    HoTen NVARCHAR(150) NOT NULL,
    ChuyenKhoa NVARCHAR(100),
    HocHamHocVi NVARCHAR(50),
    SoDienThoai VARCHAR(20),
    CONSTRAINT FK_BS_Khoa FOREIGN KEY (MaKhoa) REFERENCES KHOA_DIEU_TRI(MaKhoa)
);

-- 6. BẢNG PHIẾU KHÁM BỆNH (CÁC ĐỢT KHÁM TRONG HỒ SƠ)
CREATE TABLE PHIEU_KHAM_BENH (
    MaPhieuKham VARCHAR(20) PRIMARY KEY,
    MaHoSo VARCHAR(20) NOT NULL,
    MaBacSi VARCHAR(20) NOT NULL,
    MaKhoa VARCHAR(20) NOT NULL,
    NgayGioKham DATETIME NOT NULL DEFAULT GETDATE(),
    TrieuChung NVARCHAR(MAX) NOT NULL, -- Nhức đầu, thân nhiệt, huyết áp...
    ChuanDoan NVARCHAR(MAX),
    LoaiKham NVARCHAR(50) NOT NULL DEFAULT N'Khám bệnh', -- Khám bệnh, Khám định kỳ theo quý
    DienBienBenh NVARCHAR(MAX),
    PhanUngPhuThuoc NVARCHAR(MAX),
    HieuQuaDieuTri NVARCHAR(100),
    CONSTRAINT FK_PKB_HSBA FOREIGN KEY (MaHoSo) REFERENCES HO_SO_BENH_AN(MaHoSo),
    CONSTRAINT FK_PKB_BS FOREIGN KEY (MaBacSi) REFERENCES BAC_SI(MaBacSi),
    CONSTRAINT FK_PKB_Khoa FOREIGN KEY (MaKhoa) REFERENCES KHOA_DIEU_TRI(MaKhoa)
);

-- 7. BẢNG LOẠI XÉT NGHIỆM CẬN LÂM SÀNG
CREATE TABLE LOAI_XET_NGHIEM (
    MaLoaiXN VARCHAR(20) PRIMARY KEY,
    TenLoaiXN NVARCHAR(200) NOT NULL,
    DonGia DECIMAL(18, 2) NOT NULL CHECK (DonGia >= 0),
    PhongThucHien NVARCHAR(100)
);

-- 8. BẢNG PHIẾU CHỈ ĐỊNH XÉT NGHIỆM
CREATE TABLE PHIEU_XET_NGHIEM (
    MaPhieuXN VARCHAR(20) PRIMARY KEY,
    MaPhieuKham VARCHAR(20) NOT NULL,
    NgayChiDinh DATETIME NOT NULL DEFAULT GETDATE(),
    NgayThucHien DATETIME,
    TrangThai NVARCHAR(50) DEFAULT N'Chờ thực hiện',
    CONSTRAINT FK_PXN_PKB FOREIGN KEY (MaPhieuKham) REFERENCES PHIEU_KHAM_BENH(MaPhieuKham)
);

-- 9. BẢNG CHI TIẾT KẾT QUẢ XÉT NGHIỆM
CREATE TABLE CHI_TIET_XET_NGHIEM (
    MaChiTietXN VARCHAR(20) PRIMARY KEY,
    MaPhieuXN VARCHAR(20) NOT NULL,
    MaLoaiXN VARCHAR(20) NOT NULL,
    KetQua NVARCHAR(200),
    ChiSoBinhThuong NVARCHAR(100),
    KetLuan NVARCHAR(100),
    CONSTRAINT FK_CTXN_PXN FOREIGN KEY (MaPhieuXN) REFERENCES PHIEU_XET_NGHIEM(MaPhieuXN) ON DELETE CASCADE,
    CONSTRAINT FK_CTXN_Loai FOREIGN KEY (MaLoaiXN) REFERENCES LOAI_XET_NGHIEM(MaLoaiXN)
);

-- 10. BẢNG DANH MỤC THUỐC
CREATE TABLE THUOC (
    MaThuoc VARCHAR(20) PRIMARY KEY,
    TenThuoc NVARCHAR(200) NOT NULL,
    HoatChat NVARCHAR(150),
    DonViTinh NVARCHAR(50) NOT NULL,
    DonGia DECIMAL(18, 2) NOT NULL CHECK (DonGia > 0),
    SoLuongTon INT NOT NULL DEFAULT 0,
    ChongChiDinh NVARCHAR(MAX)
);

-- 11. BẢNG TOA THUỐC
CREATE TABLE TOA_THUOC (
    MaToaThuoc VARCHAR(20) PRIMARY KEY,
    MaPhieuKham VARCHAR(20) NOT NULL UNIQUE,
    NgayKeToa DATETIME NOT NULL DEFAULT GETDATE(),
    LoiDanBacSi NVARCHAR(MAX),
    TongTienThuoc DECIMAL(18, 2) NOT NULL DEFAULT 0,
    CONSTRAINT FK_Toa_PKB FOREIGN KEY (MaPhieuKham) REFERENCES PHIEU_KHAM_BENH(MaPhieuKham)
);

-- 12. BẢNG CHI TIẾT TOA THUỐC
CREATE TABLE CHI_TIET_TOA_THUOC (
    MaChiTietToa VARCHAR(20) PRIMARY KEY,
    MaToaThuoc VARCHAR(20) NOT NULL,
    MaThuoc VARCHAR(20) NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    LieuLuong NVARCHAR(100) NOT NULL,
    CachDung NVARCHAR(150) NOT NULL,
    DonGia DECIMAL(18, 2) NOT NULL,
    ThanhTien AS (SoLuong * DonGia) PERSISTED,
    CONSTRAINT FK_CTToa_Toa FOREIGN KEY (MaToaThuoc) REFERENCES TOA_THUOC(MaToaThuoc) ON DELETE CASCADE,
    CONSTRAINT FK_CTToa_Thuoc FOREIGN KEY (MaThuoc) REFERENCES THUOC(MaThuoc)
);

-- 13. BẢNG LỊCH HẸN KHÁM ĐỊNH KỲ THEO QUÝ (MIỄN PHÍ)
CREATE TABLE LICH_HEN_DINH_KY (
    MaLichHen VARCHAR(20) PRIMARY KEY,
    MaHoSo VARCHAR(20) NOT NULL,
    QuyKham INT NOT NULL CHECK (QuyKham BETWEEN 1 AND 4),
    NamKham INT NOT NULL CHECK (NamKham >= 2020),
    NgayGioHen DATETIME NOT NULL,
    MaBacSi VARCHAR(20),
    MienPhi BIT NOT NULL DEFAULT 1, -- Khám định kỳ quý miễn phí
    TrangThai NVARCHAR(50) DEFAULT N'Đã đặt hẹn',
    CONSTRAINT FK_Hen_HSBA FOREIGN KEY (MaHoSo) REFERENCES HO_SO_BENH_AN(MaHoSo),
    CONSTRAINT FK_Hen_BS FOREIGN KEY (MaBacSi) REFERENCES BAC_SI(MaBacSi)
);

-- 14. BẢNG HÓA ĐƠN VIỆN PHÍ (XUẤT VIỆN)
CREATE TABLE HOA_DON_VIEN_PHI (
    MaHoaDon VARCHAR(20) PRIMARY KEY,
    MaPhieuKham VARCHAR(20) NOT NULL UNIQUE,
    NgayLap DATETIME NOT NULL DEFAULT GETDATE(),
    TienKham DECIMAL(18, 2) NOT NULL DEFAULT 0,
    TienXetNghiem DECIMAL(18, 2) NOT NULL DEFAULT 0,
    TienThuoc DECIMAL(18, 2) NOT NULL DEFAULT 0,
    TongTien AS (TienKham + TienXetNghiem + TienThuoc) PERSISTED,
    HinhThucThanhToan NVARCHAR(50) DEFAULT N'Tiền mặt',
    TrangThai NVARCHAR(50) DEFAULT N'Đã thanh toán',
    CONSTRAINT FK_HD_PKB FOREIGN KEY (MaPhieuKham) REFERENCES PHIEU_KHAM_BENH(MaPhieuKham)
);
GO

-- =========================================================================================
-- DỮ LIỆU MẪU BAN ĐẦU (SEED DATA)
-- =========================================================================================

INSERT INTO KHOA_DIEU_TRI VALUES
('KHOA01', N'Khoa Khám bệnh & Nội tổng quát', N'Tầng 1 - Khu A', N'BSCKII Lê Hoàng'),
('KHOA02', N'Khoa Tim mạch & Can thiệp mạch', N'Tầng 2 - Khu B', N'TS.BS Phạm Quốc Bảo'),
('KHOA03', N'Khoa Xét nghiệm & Chẩn đoán hình ảnh', N'Tầng 1 - Khu C', N'ThS.BS Nguyễn Thị Lan');

INSERT INTO BAC_SI VALUES
('BS001', 'KHOA01', N'Trần Văn Thành', N'Nội tổng quát', N'ThS.BS', '0903112233'),
('BS002', 'KHOA01', N'Lê Thị Hoa', N'Hô hấp & Truyền nhiễm', N'BSCKI', '0903445566'),
('BS003', 'KHOA02', N'Phạm Quốc Bảo', N'Tim mạch can thiệp', N'TS.BS', '0908778899');

INSERT INTO LOAI_XET_NGHIEM VALUES
('XN_MAU01', N'Xét nghiệm Công thức máu toàn phần (CBC)', 150000, N'Phòng Lab Huyết học'),
('XN_NT01', N'Xét nghiệm Tổng phân tích nước tiểu 10 chỉ số', 100000, N'Phòng Lab Sinh hóa'),
('XQ01', N'Chụp X-Quang Ngực thẳng kỹ thuật số', 200000, N'Phòng X-Quang 102'),
('SA01', N'Siêu âm Tim & Mạch máu màu Doppler', 350000, N'Phòng Siêu âm 205');

INSERT INTO THUOC VALUES
('TH001', N'Paracetamol 500mg', N'Paracetamol', N'Viên', 2500, 5000, N'Suy gan nặng'),
('TH002', N'Amlodipine 5mg', N'Amlodipine besylate', N'Viên', 4500, 2000, N'Huyết áp thấp'),
('TH003', N'Cefuroxime 500mg', N'Cefuroxime axetil', N'Viên', 15000, 1500, N'Dị ứng Cephalosporin'),
('TH004', N'Amoxicillin 500mg', N'Amoxicillin trihydrate', N'Viên', 5000, 3000, N'Dị ứng nhóm Penicillin'),
('TH005', N'Vitamin C 500mg', N'Acid ascorbic', N'Viên', 1500, 4000, N'Sỏi thận oxalat');

INSERT INTO BENH_NHAN VALUES
('BN001', N'Nguyễn Văn Hùng', '1982-05-12', N'Nam', N'123 Điện Biên Phủ, P.15, Q. Bình Thạnh, TP.HCM', '0908123456', N'3x4_NguyenVanHung.jpg', '2026-01-10');

INSERT INTO PHIEU_DANG_KY VALUES
('PDK001', 'BN001', '2026-01-10', 1500000, '2027-01-10', 1);

INSERT INTO HO_SO_BENH_AN VALUES
('HSBA00123', 'BN001', '2026-01-10', 5, N'Họ tên: Nguyễn Văn Hùng - Ngày sinh: 12/05/1982 - SĐT: 0908123456', N'Đang lưu trữ');
GO
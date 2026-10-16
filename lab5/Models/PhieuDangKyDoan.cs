using System;
using System.Collections.Generic;

namespace QuanLyTour_VanHoaViet.Models
{
    public class PhieuDangKyDoan
    {
        public string MaPhieuDoan { get; set; }
        public string MaTour { get; set; }
        public string TenCoQuan { get; set; }
        public string NguoiDaiDien { get; set; }
        public string DiaChiCoQuan { get; set; }
        public string DienThoai { get; set; }
        public DateTime NgayDiTuChon { get; set; }
        public DateTime NgayVe { get; set; }
        public int SoNguoiDi { get; set; } // Phai > 12 nguoi
        public bool CoMuaBaoHiem { get; set; }
        public string DiemDonYeuCau { get; set; }
        public decimal TienDatCoc { get; set; }
        public decimal TongKinhPhi { get; set; }
        public string TrangThai { get; set; } // "DaDatCoc", "DangDiTour", "DaKetThuc", "DaHuy"
    }

    public class ThanhVienDoan
    {
        public string MaThanhVien { get; set; }
        public string MaPhieuDoan { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SoCCCD { get; set; }
        public string GioiTinh { get; set; }
    }
}

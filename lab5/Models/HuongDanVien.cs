using System;

namespace QuanLyTour_VanHoaViet.Models
{
    public class HuongDanVien
    {
        public string MaHDV { get; set; }
        public string HoTen { get; set; }
        public string SoDienThoai { get; set; }
        public string ChuyenMon { get; set; }
        public decimal LuongCanBan { get; set; }
        public string TrangThai { get; set; } // "SanSang", "DangDiTour"
    }
}

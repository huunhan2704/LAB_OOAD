using System;

namespace QuanLyTour_VanHoaViet.Models
{
    public class VeKhachLe
    {
        public string MaVe { get; set; }
        public string MaChuyen { get; set; }
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public string MaDiemBanVe { get; set; }
        public string MaDiemDon { get; set; }
        public decimal GiaVe { get; set; }
        public DateTime NgayMua { get; set; }
        public bool DaThanhToan { get; set; }
    }
}

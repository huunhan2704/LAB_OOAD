using System;

namespace QuanLyTour_VanHoaViet.Models
{
    public class PhanCong
    {
        public string MaPhanCong { get; set; }
        public string MaHDV { get; set; }
        public string MaChuyen { get; set; }
        public string MaPhieuDoan { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string VaiTro { get; set; } // "HDV Chinh", "HDV Phu"
        public decimal ThuLaoTour { get; set; }
    }
}

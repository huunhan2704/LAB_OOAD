using System;

namespace QuanLyTour_VanHoaViet.Models
{
    public class Tour
    {
        public string MaTour { get; set; }
        public string TenTour { get; set; }
        public int SoNgay { get; set; }
        public int SoDem { get; set; }
        public decimal DonGia { get; set; }
        public string NoiKhoiHanh { get; set; } = "TP.HCM";
        public string MoTa { get; set; }
    }
}

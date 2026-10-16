using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyTour_VanHoaViet.Forms
{
    public partial class FrmQuanLyTour : Form
    {
        private DataTable dtTour;
        private DataTable dtNoiDungChan;
        private DataTable dtDiemThamQuan;

        public FrmQuanLyTour()
        {
            InitializeComponent();
            LoadMockData();
        }

        private void LoadMockData()
        {
            dtTour = new DataTable();
            dtTour.Columns.Add("MaTour");
            dtTour.Columns.Add("TenTour");
            dtTour.Columns.Add("SoNgay", typeof(int));
            dtTour.Columns.Add("SoDem", typeof(int));
            dtTour.Columns.Add("DonGia", typeof(decimal));
            dtTour.Columns.Add("KhoiHanh");

            dtTour.Rows.Add("TOUR001", "TP.HCM - Nha Trang - Đà Lạt", 4, 3, 4500000, "TP.HCM");
            dtTour.Rows.Add("TOUR002", "TP.HCM - Đà Nẵng - Hội An - Huế", 5, 4, 6800000, "TP.HCM");
            dtTour.Rows.Add("TOUR003", "TP.HCM - Phú Quốc Thiên Đường Biển", 3, 2, 3900000, "TP.HCM");
            dtTour.Rows.Add("TOUR004", "TP.HCM - Cần Thơ - Cà Mau Miền Tây", 3, 2, 2800000, "TP.HCM");

            dgvTour.DataSource = dtTour;

            dtNoiDungChan = new DataTable();
            dtNoiDungChan.Columns.Add("STT", typeof(int));
            dtNoiDungChan.Columns.Add("TenNoiDungChan");
            dtNoiDungChan.Columns.Add("DoiPhuongTien");
            dtNoiDungChan.Columns.Add("PhuongTienTiepTheo");
            dtNoiDungChan.Columns.Add("CoNoiAn");
            dtNoiDungChan.Columns.Add("CoKhachSan");
            dtNoiDungChan.Columns.Add("LoaiKhachSan");

            dtNoiDungChan.Rows.Add(1, "Nha Trang (Khánh Hòa)", "Có", "Xe đò cao cấp", "Có", "Có", "4 sao");
            dtNoiDungChan.Rows.Add(2, "Đà Lạt (Lâm Đồng)", "Có", "Máy bay về TP.HCM", "Có", "Có", "3 sao");
            dgvNoiDungChan.DataSource = dtNoiDungChan;

            dtDiemThamQuan = new DataTable();
            dtDiemThamQuan.Columns.Add("MaDTQ");
            dtDiemThamQuan.Columns.Add("TenDiemThamQuan");
            dtDiemThamQuan.Columns.Add("DiaDiem");
            dtDiemThamQuan.Columns.Add("Y Nghia / Noi Dung");

            dtDiemThamQuan.Rows.Add("DTQ01", "Tháp Bà Ponagar", "Nha Trang", "Di tích văn hóa Chăm Pa cổ kính");
            dtDiemThamQuan.Rows.Add("DTQ02", "Hồ Tuyền Lâm & Thiền Viện", "Đà Lạt", "Danh lam thắng cảnh và du lịch tâm linh");
            dgvDiemThamQuan.DataSource = dtDiemThamQuan;
        }

        private void btnThemTour_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTour.Text) || string.IsNullOrWhiteSpace(txtTenTour.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Tour và Tên Tour!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dtTour.Rows.Add(txtMaTour.Text.Trim(), txtTenTour.Text.Trim(), (int)numSoNgay.Value, (int)numSoDem.Value, numDonGia.Value, "TP.HCM");
            MessageBox.Show("Đã thêm Tour du lịch mới thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

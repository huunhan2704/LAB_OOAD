using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyTour_VanHoaViet.Forms
{
    public partial class FrmQuyetToanLuong : Form
    {
        private DataTable dtKhaoSat;
        private DataTable dtTourThucHien;

        public FrmQuyetToanLuong()
        {
            InitializeComponent();
            cboDoanQuyetToan.SelectedIndex = 0;
            cboHDV.SelectedIndex = 0;
            cboThangLuong.SelectedIndex = 0;
            LoadMockData();
            CalculateSettlement();
            CalculateSalary();
        }

        private void LoadMockData()
        {
            dtKhaoSat = new DataTable();
            dtKhaoSat.Columns.Add("MaKS");
            dtKhaoSat.Columns.Add("KhachHang_Doan");
            dtKhaoSat.Columns.Add("TourDaDi");
            dtKhaoSat.Columns.Add("DanhGiaNoiAn");
            dtKhaoSat.Columns.Add("DanhGiaKhachSan");
            dtKhaoSat.Columns.Add("DanhGiaPhuongTien");
            dtKhaoSat.Columns.Add("DanhGiaHDV");
            dtKhaoSat.Columns.Add("Y_Kien_GopY");

            dtKhaoSat.Rows.Add("KS001", "Cty Công nghệ ABC (Đoàn)", "TP.HCM - Nha Trang - Đà Lạt", "5 sao", "4 sao", "5 sao (xe êm)", "5 sao (HDV nhiệt tình)", "Chuyến đi tuyệt vời, bữa ăn rất ngon!");
            dtKhaoSat.Rows.Add("KS002", "Lê Thị Bích (Khách lẻ)", "TP.HCM - Nha Trang - Đà Lạt", "4 sao", "4 sao", "4 sao", "5 sao (HDV chu đáo)", "Rất hài lòng, sẽ tiếp tục ủng hộ công ty.");
            dgvLichSuKhaoSat.DataSource = dtKhaoSat;

            dtTourThucHien = new DataTable();
            dtTourThucHien.Columns.Add("MaTour");
            dtTourThucHien.Columns.Add("TenTourChuyen");
            dtTourThucHien.Columns.Add("ThoiGian");
            dtTourThucHien.Columns.Add("ThuLaoTour", typeof(decimal));

            dtTourThucHien.Rows.Add("TOUR001", "Nha Trang - Đà Lạt (Đoàn Cty ABC)", "05/10 - 09/10 (4N3Đ)", 3200000);
            dtTourThucHien.Rows.Add("TOUR002", "Đà Nẵng - Hội An (Chuyến lẻ 02)", "15/10 - 19/10 (5N4Đ)", 4000000);
            dtTourThucHien.Rows.Add("TOUR003", "Phú Quốc Thiên Đường (Chuyến lẻ 04)", "22/10 - 24/10 (3N2Đ)", 2500000);
            dgvTourThucHien.DataSource = dtTourThucHien;
        }

        private void cboDoanQuyetToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateSettlement();
        }

        private void numPhatSinh_ValueChanged(object sender, EventArgs e)
        {
            CalculateSettlement();
        }

        private void CalculateSettlement()
        {
            decimal tongKinhPhi = 112500000;
            decimal daDatCoc = 33750000;
            decimal phatSinh = numPhatSinh.Value;
            decimal conLaiPhaiTra = (tongKinhPhi - daDatCoc) + phatSinh;

            lblTongKinhPhiGoc.Text = string.Format("{0:N0} VNĐ", tongKinhPhi);
            lblDaDatCoc.Text = string.Format("{0:N0} VNĐ", daDatCoc);
            lblConLaiPhaiThu.Text = string.Format("{0:N0} VNĐ", conLaiPhaiTra);
        }

        private void btnXacNhanQuyetToan_Click(object sender, EventArgs e)
        {
            string msg = string.Format("QUYẾT TOÁN KINH PHÍ ĐOÀN THÀNH CÔNG!\n\n" +
                                       "• Đoàn thanh toán: {0}\n" +
                                       "• Tổng chi phí ban đầu: {1}\n" +
                                       "• Khoản tiền cọc đã cấn trừ: {2}\n" +
                                       "• Chi phí phát sinh: {3:N0} VNĐ\n" +
                                       "• SỐ TIỀN ĐOÀN ĐÃ THANH TOÁN HOÀN TẤT: {4}\n\n" +
                                       "* Đã in phiếu thu quyết toán và cập nhật trạng thái đoàn: ĐÃ HOÀN TẤT.",
                                       cboDoanQuyetToan.Text, lblTongKinhPhiGoc.Text, lblDaDatCoc.Text, numPhatSinh.Value, lblConLaiPhaiThu.Text);

            MessageBox.Show(msg, "Hoàn tất quyết toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuiKhaoSat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGopY.Text))
            {
                MessageBox.Show("Vui lòng nhập ý kiến góp ý của khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dtKhaoSat.Rows.Add("KS" + DateTime.Now.ToString("mmss"), cboKhachKhaoSat.Text, cboTourKhaoSat.Text, 
                               cboNoiAn.Text, cboKhachSan.Text, cboPhuongTien.Text, cboHDVRating.Text, txtGopY.Text);

            MessageBox.Show("GHI NHẬN Ý KIẾN KHẢO SÁT CHẤT LƯỢNG THÀNH CÔNG!\n\n" +
                            "Cảm ơn quý khách đã đóng góp ý kiến giúp công ty nâng cao chất lượng dịch vụ.",
                            "Khảo sát khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtGopY.Clear();
        }

        private void cboHDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateSalary();
        }

        private void CalculateSalary()
        {
            decimal luongCanBan = 6500000;
            decimal tongThuLaoTour = 0;
            foreach (DataRow r in dtTourThucHien.Rows)
            {
                tongThuLaoTour += Convert.ToDecimal(r["ThuLaoTour"]);
            }
            decimal tongThucLinh = luongCanBan + tongThuLaoTour;

            lblLuongCanBan.Text = string.Format("{0:N0} VNĐ", luongCanBan);
            lblTongThuLaoTour.Text = string.Format("{0:N0} VNĐ (3 tour trong tháng)", tongThuLaoTour);
            lblTongThucLinh.Text = string.Format("{0:N0} VNĐ", tongThucLinh);
        }

        private void btnInPhieuLuong_Click(object sender, EventArgs e)
        {
            string msg = string.Format("BẢNG LƯƠNG HƯỚNG DẪN VIÊN DU LỊCH\n\n" +
                                       "• Hướng dẫn viên: {0}\n" +
                                       "• Tháng tính lương: {1}\n" +
                                       "• Lương căn bản: {2}\n" +
                                       "• Lương theo từng tour thực hiện trong tháng: {3}\n" +
                                       "• TỔNG LƯƠNG THỰC LĨNH: {4}\n\n" +
                                       "* Quy chế lương: Lương HDV được tính theo lương căn bản + thù lao từng tour thực hiện.",
                                       cboHDV.Text, cboThangLuong.Text, lblLuongCanBan.Text, lblTongThuLaoTour.Text, lblTongThucLinh.Text);

            MessageBox.Show(msg, "Phiếu Lương Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

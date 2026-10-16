using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyTour_VanHoaViet.Forms
{
    public partial class FrmDangKyTourDoan : Form
    {
        private DataTable dtBaoHiem;
        private decimal donGiaTour = 4500000;

        public FrmDangKyTourDoan()
        {
            InitializeComponent();
            InitInsuranceTable();
            cboTour.SelectedIndex = 0;
            dtpNgayDi.Value = DateTime.Today.AddDays(15);
            CalculateTotals();
        }

        private void InitInsuranceTable()
        {
            dtBaoHiem = new DataTable();
            dtBaoHiem.Columns.Add("STT", typeof(int));
            dtBaoHiem.Columns.Add("HoTen");
            dtBaoHiem.Columns.Add("NgaySinh", typeof(DateTime));
            dtBaoHiem.Columns.Add("SoCCCD");
            dtBaoHiem.Columns.Add("GioiTinh");

            // Mock 2 thanh vien mau
            dtBaoHiem.Rows.Add(1, "Nguyễn Văn Hùng", new DateTime(1982, 5, 12), "079082001234", "Nam");
            dtBaoHiem.Rows.Add(2, "Trần Thị Mai", new DateTime(1986, 11, 24), "079186005678", "Nữ");

            dgvDanhSachBaoHiem.DataSource = dtBaoHiem;
        }

        private void numSoNguoiDi_ValueChanged(object sender, EventArgs e)
        {
            if (numSoNguoiDi.Value <= 12)
            {
                lblCanhBaoSoNguoi.Visible = true;
                lblCanhBaoSoNguoi.Text = "CẢNH BÁO: Đi từ 12 người trở xuống được xem là Khách Lẻ (vui lòng qua Form Khách Lẻ)!";
            }
            else
            {
                lblCanhBaoSoNguoi.Visible = false;
            }
            CalculateTotals();
        }

        private void chkMuaBaoHiem_CheckedChanged(object sender, EventArgs e)
        {
            pnlBaoHiem.Enabled = chkMuaBaoHiem.Checked;
            if (!chkMuaBaoHiem.Checked)
            {
                lblBaoHiemStatus.Text = "Đoàn tự chịu trách nhiệm nếu không mua bảo hiểm du lịch.";
            }
            else
            {
                lblBaoHiemStatus.Text = "Yêu cầu cung cấp đầy đủ họ tên, ngày sinh, CCCD của tất cả thành viên trong đoàn.";
            }
        }

        private void cboTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTour.SelectedIndex == 0) donGiaTour = 4500000;
            else if (cboTour.SelectedIndex == 1) donGiaTour = 6800000;
            else if (cboTour.SelectedIndex == 2) donGiaTour = 3900000;
            else donGiaTour = 2800000;

            lblDonGiaDisplay.Text = string.Format("{0:N0} VNĐ / khách", donGiaTour);
            CalculateTotals();
        }

        private void CalculateTotals()
        {
            int soNguoi = (int)numSoNguoiDi.Value;
            decimal tongTien = soNguoi * donGiaTour;
            decimal tienCoc = tongTien * 0.3m; // 30% dat coc

            lblTongChiPhi.Text = string.Format("{0:N0} VNĐ", tongTien);
            lblTienDatCoc.Text = string.Format("{0:N0} VNĐ (30%)", tienCoc);
        }

        private void btnLuuPhieu_Click(object sender, EventArgs e)
        {
            if (numSoNguoiDi.Value <= 12)
            {
                MessageBox.Show("Quy định công ty: Khách theo đoàn BẮT BUỘC phải đi TRÊN 12 NGƯỜI.\nĐoàn hiện tại có " + numSoNguoiDi.Value + " người, vui lòng đăng ký theo chuyến tại Form Khách Lẻ!", 
                                "Quy tắc nghiệp vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenCoQuan.Text) || string.IsNullOrWhiteSpace(txtNguoiDaiDien.Text) || string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ Tên cơ quan, Người đại diện và Điện thoại liên hệ!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDiemDon.Text))
            {
                MessageBox.Show("Vui lòng nhập Địa điểm đón cụ thể theo yêu cầu của đoàn!", "Điểm đón", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPhieu = "PKD" + DateTime.Now.ToString("yyMMddHHmm");
            string msg = string.Format("LẬP PHIẾU ĐĂNG KÝ TOUR THEO ĐOÀN THÀNH CÔNG!\n\n" +
                                       "• Mã phiếu đoàn: {0}\n" +
                                       "• Cơ quan / Đại diện: {1} ({2})\n" +
                                       "• Tour đã chọn: {3}\n" +
                                       "• Ngày đi tự chọn: {4:dd/MM/yyyy}\n" +
                                       "• Số lượng người đi: {5} người\n" +
                                       "• Điểm đón xe tận nơi: {6}\n" +
                                       "• Tiền cọc phải nộp: {7}\n\n" +
                                       "* LƯU Ý QUAN TRỌNG: Khách phải nộp khoản tiền cọc trước. Nếu không đi sẽ MẤT CỌC.\n" +
                                       "* Kinh phí còn lại sẽ thanh toán quyết toán sau khi kết thúc chuyến đi.",
                                       maPhieu, txtTenCoQuan.Text, txtNguoiDaiDien.Text, cboTour.Text, 
                                       dtpNgayDi.Value, numSoNguoiDi.Value, txtDiemDon.Text, lblTienDatCoc.Text);

            MessageBox.Show(msg, "Xác nhận Đăng ký Đoàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

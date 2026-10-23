using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBenhAn_WinForms.Forms
{
    public partial class FrmKhamBenh_KeToa : Form
    {
        private DataTable dtToaThuoc;

        public FrmKhamBenh_KeToa()
        {
            InitializeComponent();
            InitToaThuocTable();
            cboThuoc.SelectedIndex = 0;
            cboBacSi.SelectedIndex = 0;
            cboKhoa.SelectedIndex = 0;
        }

        private void InitToaThuocTable()
        {
            dtToaThuoc = new DataTable();
            dtToaThuoc.Columns.Add("MaThuoc");
            dtToaThuoc.Columns.Add("TenThuoc");
            dtToaThuoc.Columns.Add("SoLuong", typeof(int));
            dtToaThuoc.Columns.Add("LieuLuong");
            dtToaThuoc.Columns.Add("CachDung");
            dtToaThuoc.Columns.Add("DonGia", typeof(decimal));
            dtToaThuoc.Columns.Add("ThanhTien", typeof(decimal));

            // Mock 2 thuoc mau
            dtToaThuoc.Rows.Add("TH001", "Paracetamol 500mg", 10, "2 viên/ngày", "Uống sau ăn khi nhức đầu, sốt", 2500, 25000);
            dtToaThuoc.Rows.Add("TH002", "Amlodipine 5mg", 30, "1 viên/ngày", "Uống vào buổi sáng ổn định huyết áp", 4500, 135000);

            dgvToaThuoc.DataSource = dtToaThuoc;
            CapNhatTongTien();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã hồ sơ bệnh án (hoặc Họ tên, SĐT) để tra cứu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lblTenBN.Text = "Nguyễn Văn Hùng (Nam - 1982)";
            lblMaHSBADisplay.Text = "HSBA00123 (Có hiệu lực)";
            lblTienSuDiUng.Text = "Dị ứng Penicillin (Phát ban nhẹ năm 2024)";
            lblLichSuKham.Text = "Lịch sử: 15/06/2026: Khám định kỳ Quý 2 (Bình thường) | 12/02/2026: Cảm sốt siêu vi";
            MessageBox.Show("Đã trích xuất lý lịch bệnh án thành công! Bác sĩ có thể xem toàn bộ lịch sử sức khỏe để đưa ra phác đồ tối ưu.", "Tra cứu Bệnh án", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if (cboThuoc.Text.Contains("Amoxicillin") && lblTienSuDiUng.Text.Contains("Penicillin"))
            {
                DialogResult dr = MessageBox.Show("CẢNH BÁO NGUY HIỂM: Bệnh nhân có tiền sử DỊ ỨNG PENICILLIN!\nAmoxicillin thuộc nhóm Penicillin có thể gây phản ứng phụ sốc phản vệ!\nBạn có chắc chắn muốn kê thuốc này không?",
                                                  "Cảnh báo Dị ứng Thuốc", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No) return;
            }

            string maThuoc = "TH00" + (cboThuoc.SelectedIndex + 1);
            decimal donGia = 15000;
            int soLuong = (int)numSoLuong.Value;
            decimal thanhTien = soLuong * donGia;

            dtToaThuoc.Rows.Add(maThuoc, cboThuoc.Text, soLuong, txtLieuLuong.Text, txtCachDung.Text, donGia, thanhTien);
            CapNhatTongTien();
        }

        private void CapNhatTongTien()
        {
            decimal tong = 0;
            foreach (DataRow r in dtToaThuoc.Rows)
            {
                tong += Convert.ToDecimal(r["ThanhTien"]);
            }
            lblTongTienThuoc.Text = string.Format("{0:N0} VNĐ", tong);
        }

        private void btnChiDinhXN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ĐÃ CHỈ ĐỊNH CÁC XÉT NGHIỆM CẦN THIẾT:\n\n" +
                            "• Xét nghiệm Công thức máu toàn phần (XN_MAU01)\n" +
                            "• Chụp X-Quang Tim Phổi thẳng (XQ01)\n" +
                            "• Đo điện tim ECG (ECG01)\n\n" +
                            "Đã gửi chỉ định sang phòng Kỹ thuật viên xét nghiệm. Bệnh nhân sẽ quay lại phòng khám sau khi có kết quả.",
                            "Chỉ định Xét nghiệm Cận lâm sàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblTrangThaiXN.Text = "Đã chỉ định: 3 xét nghiệm (Đang chờ kết quả từ phòng Lab)";
        }

        private void btnLuuKham_Click(object sender, EventArgs e)
        {
            string msg = string.Format("LƯU PHIẾU KHÁM BỆNH & LẬP TOA THUỐC THÀNH CÔNG!\n\n" +
                                       "• Bệnh nhân: {0}\n" +
                                       "• Mã HSBA: {1}\n" +
                                       "• Bác sĩ khám: {2} - {3}\n" +
                                       "• Triệu chứng lâm sàng: {4}\n" +
                                       "• Kết luận chẩn đoán: {5}\n" +
                                       "• Tổng số thuốc trong toa: {6} loại (Tổng: {7})\n\n" +
                                       "* Thông tin đợt khám đã được chuyển đến phòng CSKH và Thu ngân để hoàn tất xuất viện.",
                                       lblTenBN.Text, lblMaHSBADisplay.Text, cboBacSi.Text, cboKhoa.Text,
                                       txtTrieuChung.Text, txtChuanDoan.Text, dtToaThuoc.Rows.Count, lblTongTienThuoc.Text);

            MessageBox.Show(msg, "Hoàn tất Khám & Kê Toa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

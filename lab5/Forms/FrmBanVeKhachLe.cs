using System;
using System.Windows.Forms;

namespace QuanLyTour_VanHoaViet.Forms
{
    public partial class FrmBanVeKhachLe : Form
    {
        private decimal giaVeChuyen = 4500000;

        public FrmBanVeKhachLe()
        {
            InitializeComponent();
            cboChuyenDi.SelectedIndex = 0;
            cboDiemBanVe.SelectedIndex = 0;
            cboDiemDonQuyDinh.SelectedIndex = 0;
            CalculateTotal();
        }

        private void cboChuyenDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChuyenDi.SelectedIndex == 0) giaVeChuyen = 4500000;
            else if (cboChuyenDi.SelectedIndex == 1) giaVeChuyen = 4500000;
            else if (cboChuyenDi.SelectedIndex == 2) giaVeChuyen = 6800000;
            else giaVeChuyen = 3900000;

            lblGiaVeHienThi.Text = string.Format("{0:N0} VNĐ / vé", giaVeChuyen);
            CalculateTotal();
        }

        private void numSoLuongVe_ValueChanged(object sender, EventArgs e)
        {
            if (numSoLuongVe.Value > 12)
            {
                MessageBox.Show("Khách đi TRÊN 12 NGƯỜI được tính là KHÁCH THEO ĐOÀN!\nVui lòng chuyển sang form Lập Phiếu Đăng Ký Đoàn để được tự chọn ngày đi và đón tận nơi.", 
                                "Quy tắc phân loại khách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numSoLuongVe.Value = 12;
            }
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            int soVe = (int)numSoLuongVe.Value;
            decimal tongTien = soVe * giaVeChuyen;
            lblTongThanhToan.Text = string.Format("{0:N0} VNĐ", tongTien);
        }

        private void btnXuatVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text) || string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên khách hàng và Số điện thoại liên hệ!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maVe = "VE" + DateTime.Now.ToString("yyMMddHHmm");
            string msg = string.Format("XUẤT VÉ TOUR KHÁCH LẺ THÀNH CÔNG!\n\n" +
                                       "• Mã vé: {0}\n" +
                                       "• Khách hàng: {1} (SĐT: {2})\n" +
                                       "• Chuyến đi: {3}\n" +
                                       "• Điểm bán vé: {4}\n" +
                                       "• Điểm đón quy định: {5}\n" +
                                       "• Số lượng vé: {6} vé\n" +
                                       "• Tổng tiền đã thanh toán: {7}\n\n" +
                                       "* QUY ĐỊNH KHÁCH LẺ: Khách lẻ đi theo chuyến cố định của công ty.\n" +
                                       "* Khách đã thanh toán 100% tiền vé ngay khi mua.\n" +
                                       "* Vui lòng có mặt tại điểm đón đúng giờ quy định.",
                                       maVe, txtTenKhachHang.Text, txtSoDienThoai.Text, cboChuyenDi.Text,
                                       cboDiemBanVe.Text, cboDiemDonQuyDinh.Text, numSoLuongVe.Value, lblTongThanhToan.Text);

            MessageBox.Show(msg, "Vé Du Lịch Điện Tử", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

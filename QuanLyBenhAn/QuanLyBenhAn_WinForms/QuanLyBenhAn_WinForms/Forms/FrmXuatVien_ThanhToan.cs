using System;
using System.Windows.Forms;

namespace QuanLyBenhAn_WinForms.Forms
{
    public partial class FrmXuatVien_ThanhToan : Form
    {
        public FrmXuatVien_ThanhToan()
        {
            InitializeComponent();
            cboHinhThuc.SelectedIndex = 0;
            CalculateTotal();
        }

        private void chkKhamDinhKy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKhamDinhKy.Checked)
            {
                lblTienKham.Text = "0 VNĐ (MIỄN PHÍ ĐỊNH KỲ QUÝ)";
            }
            else
            {
                lblTienKham.Text = "200,000 VNĐ";
            }
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal tienKham = chkKhamDinhKy.Checked ? 0 : 200000;
            decimal tienXN = 450000;
            decimal tienThuoc = 160000;
            decimal tong = tienKham + tienXN + tienThuoc;

            lblTongVienPhi.Text = string.Format("{0:N0} VNĐ", tong);
        }

        private void btnThanhToanXuatVien_Click(object sender, EventArgs e)
        {
            string msg = string.Format("THANH TOÁN VIỆN PHÍ & HOÀN TẤT THỦ TỤC XUẤT VIỆN!\n\n" +
                                       "• Bệnh nhân: {0} ({1})\n" +
                                       "• Tổng số tiền thanh toán: {2}\n" +
                                       "• Phương thức: {3}\n" +
                                       "• Ghi nhận diễn biến bệnh: {4}\n" +
                                       "• Phản ứng phụ do thuốc: {5}\n" +
                                       "• Đánh giá hiệu quả điều trị: {6}\n\n" +
                                       "* Phòng Chăm sóc & Theo dõi khách hàng đã lưu trữ toàn bộ đợt điều trị vào máy tính.\n" +
                                       "* Dữ liệu phục vụ theo dõi diễn biến lâu dài và kiểm tra trách nhiệm chuyên môn của Bác sĩ.",
                                       lblTenBN.Text, lblMaHSBA.Text, lblTongVienPhi.Text, cboHinhThuc.Text,
                                       txtDienBien.Text, txtPhanUngPhu.Text, cboHieuQua.Text);

            MessageBox.Show(msg, "Hoàn tất Xuất Viện", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

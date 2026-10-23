using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBenhAn_WinForms.Forms
{
    public partial class FrmDangKy_CapHSBA : Form
    {
        public FrmDangKy_CapHSBA()
        {
            InitializeComponent();
            dtpNgaySinh.Value = new DateTime(1990, 1, 1);
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtDuongDanAnh.Text = ofd.FileName;
                lblAnhPreview.Text = "[Ảnh 3x4: " + System.IO.Path.GetFileName(ofd.FileName) + "]";
            }
        }

        private void btnCapHSBA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ Họ tên và Số điện thoại liên lạc!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!chkDaDongPhi.Checked)
            {
                MessageBox.Show("Quy định bệnh viện: Bệnh nhân phải đóng lệ phí hàng năm mới được cấp phát Hồ sơ bệnh án và hưởng quyền lợi theo dõi sức khỏe!", 
                                "Chưa thu lệ phí", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maHSBA = "HSBA" + DateTime.Now.ToString("yyMMddHHmm");
            string msg = string.Format("CẤP PHÁT HỒ SƠ BỆNH ÁN THÀNH CÔNG!\n\n" +
                                       "• Mã hồ sơ bệnh án (HSBA): {0}\n" +
                                       "• Bệnh nhân: {1}\n" +
                                       "• Ngày sinh: {2:dd/MM/yyyy} - Giới tính: {3}\n" +
                                       "• Số điện thoại: {4}\n" +
                                       "• Địa chỉ: {5}\n" +
                                       "• Ảnh hồ sơ: Ảnh chân dung 3x4 đã lưu trữ\n" +
                                       "• Lệ phí quản lý & khám định kỳ 1 năm: {6:N0} VNĐ (ĐÃ THU)\n\n" +
                                       "* Lưu ý: Hồ sơ bệnh án được sử dụng theo dõi trọn đời tại bệnh viện.\n" +
                                       "* Lần sau khám bệnh chỉ cần BÁO MÃ HỒ SƠ '{0}' để trích xuất lý lịch điều trị.",
                                       maHSBA, txtHoTen.Text, dtpNgaySinh.Value, cboGioiTinh.Text,
                                       txtSoDienThoai.Text, txtDiaChi.Text, numLePhi.Value);

            MessageBox.Show(msg, "Trang Bìa Hồ Sơ Bệnh Án", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

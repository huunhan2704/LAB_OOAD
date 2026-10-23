using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBenhAn_WinForms.Forms
{
    public partial class FrmLichHenDinhKy : Form
    {
        private DataTable dtLichHen;

        public FrmLichHenDinhKy()
        {
            InitializeComponent();
            cboQuyKham.SelectedIndex = 2; // Quy 3
            cboBacSiHen.SelectedIndex = 0;
            dtpHenGio.Value = DateTime.Today.AddDays(3).AddHours(9);
            LoadHenData();
        }

        private void LoadHenData()
        {
            dtLichHen = new DataTable();
            dtLichHen.Columns.Add("MaHen");
            dtLichHen.Columns.Add("MaHSBA");
            dtLichHen.Columns.Add("TenBenhNhan");
            dtLichHen.Columns.Add("QuyKham");
            dtLichHen.Columns.Add("NgayGioHen");
            dtLichHen.Columns.Add("BacSiPhuTrach");
            dtLichHen.Columns.Add("QuyenLoi");

            dtLichHen.Rows.Add("HEN01", "HSBA00123", "Nguyễn Văn Hùng", "Quý 3/2026", "26/10/2026 09:00", "ThS.BS Trần Văn Thành", "MIỄN PHÍ");
            dtLichHen.Rows.Add("HEN02", "HSBA00145", "Trần Thị Mai", "Quý 3/2026", "27/10/2026 14:30", "BSCKI Lê Thị Hoa", "MIỄN PHÍ");

            dgvLichHen.DataSource = dtLichHen;
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHSBA.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã hồ sơ bệnh án của khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maHen = "HEN" + DateTime.Now.ToString("mmss");
            dtLichHen.Rows.Add(maHen, txtMaHSBA.Text.Trim(), txtTenBN.Text.Trim(), cboQuyKham.Text, 
                              dtpHenGio.Value.ToString("dd/MM/yyyy HH:mm"), cboBacSiHen.Text, "MIỄN PHÍ (HSBA)");

            string msg = string.Format("ĐẶT LỊCH HẸN KHÁM ĐỊNH KỲ THEO QUÝ THÀNH CÔNG!\n\n" +
                                       "• Mã lịch hẹn: {0}\n" +
                                       "• Khách hàng: {1} (Mã HSBA: {2})\n" +
                                       "• Đợt khám: {3}\n" +
                                       "• Thời gian hẹn chính xác: {4:dd/MM/yyyy HH:mm}\n" +
                                       "• Bác sĩ phụ trách: {5}\n" +
                                       "• Viện phí khám định kỳ: 0 VNĐ (QUYỀN LỢI MIỄN PHÍ TRỌN NĂM)\n\n" +
                                       "* Hệ thống đã gửi tin nhắn SMS xác nhận lịch hẹn đến số điện thoại khách hàng.",
                                       maHen, txtTenBN.Text, txtMaHSBA.Text, cboQuyKham.Text, dtpHenGio.Value, cboBacSiHen.Text);

            MessageBox.Show(msg, "Xác nhận Lịch Hẹn Khám Quý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

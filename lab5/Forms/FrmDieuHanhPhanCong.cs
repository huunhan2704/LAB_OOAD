using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyTour_VanHoaViet.Forms
{
    public partial class FrmDieuHanhPhanCong : Form
    {
        private DataTable dtHDV;
        private DataTable dtPhanCongHienTai;

        public FrmDieuHanhPhanCong()
        {
            InitializeComponent();
            cboLoaiPhanCong.SelectedIndex = 0;
            LoadHDVData();
        }

        private void LoadHDVData()
        {
            dtHDV = new DataTable();
            dtHDV.Columns.Add("Chon", typeof(bool));
            dtHDV.Columns.Add("MaHDV");
            dtHDV.Columns.Add("HoTen");
            dtHDV.Columns.Add("SoDienThoai");
            dtHDV.Columns.Add("ChuyenMon");
            dtHDV.Columns.Add("TrangThaiLich"); // "Rảnh lịch (Khả dụng)", "Đang bận tour"

            dtHDV.Rows.Add(false, "HDV01", "Trần Quốc Toản", "0988112233", "Tour Biển Đảo & Miền Trung", "Rảnh lịch (Khả dụng)");
            dtHDV.Rows.Add(false, "HDV02", "Lê Thị Hồng Gấm", "0977445566", "Tour Cao Nguyên & Di tích", "Rảnh lịch (Khả dụng)");
            dtHDV.Rows.Add(false, "HDV03", "Phạm Văn Đồng", "0966778899", "Tour Tây Nam Bộ & Sông Nước", "Đang bận tour (Trùng lịch)");
            dtHDV.Rows.Add(false, "HDV04", "Hoàng Thị Loan", "0911223344", "Tour Di sản & Văn hóa Huế", "Rảnh lịch (Khả dụng)");
            dtHDV.Rows.Add(false, "HDV05", "Võ Văn Kiệt", "0909556677", "Tour Tổng hợp & Teambuilding", "Rảnh lịch (Khả dụng)");

            dgvHDV.DataSource = dtHDV;

            dtPhanCongHienTai = new DataTable();
            dtPhanCongHienTai.Columns.Add("MaPC");
            dtPhanCongHienTai.Columns.Add("DoiTuong");
            dtPhanCongHienTai.Columns.Add("TenTourChuyen");
            dtPhanCongHienTai.Columns.Add("HDVPhanCong");
            dtPhanCongHienTai.Columns.Add("ThoiGian");
            dtPhanCongHienTai.Columns.Add("XeDon");

            dtPhanCongHienTai.Rows.Add("PC001", "Chuyến Lẻ CHUYEN01", "Nha Trang - Đà Lạt", "Trần Quốc Toản (1 HDV)", "20/10 - 24/10", "Xe 45 chỗ (Đón 3 điểm QĐ)");
            dtPhanCongHienTai.Rows.Add("PC002", "Đoàn Cty ABC (45 ng)", "Nha Trang - Đà Lạt", "Võ Văn Kiệt, Lê Thị Hồng Gấm (2 HDV)", "15/11 - 19/11", "Xe 45 chỗ (Đón tại 123 Điện Biên Phủ)");

            dgvPhanCongDaLuu.DataSource = dtPhanCongHienTai;
        }

        private void cboLoaiPhanCong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiPhanCong.SelectedIndex == 0) // Theo chuyến khách lẻ
            {
                lblQuyTacPhanCong.Text = "QUY TẮC: Mỗi chuyến khách lẻ phân công ĐÚNG 1 NHÂN VIÊN cụ thể. Điểm đón theo quy định công ty.";
                cboDoiTuong.Items.Clear();
                cboDoiTuong.Items.Add("CHUYEN01: Nha Trang - Đà Lạt (20/10 - 24/10) - 35 khách lẻ");
                cboDoiTuong.Items.Add("CHUYEN02: Đà Nẵng - Hội An (25/10 - 30/10) - 28 khách lẻ");
                cboDoiTuong.SelectedIndex = 0;
                lblDiemDonThucTe.Text = "Điểm đón: 3 Điểm đón quy định (Trụ sở Q.1, Bến xe Miền Đông, Sân bay Tân Sơn Nhất)";
            }
            else // Theo đoàn tour
            {
                lblQuyTacPhanCong.Text = "QUY TẮC: Khách theo đoàn có thể phân công NHIỀU NHÂN VIÊN nếu đoàn đi đông. Xe đón tận nơi theo yêu cầu.";
                cboDoiTuong.Items.Clear();
                cboDoiTuong.Items.Add("DOAN01: Cty Công nghệ ABC (45 người) - Đi 15/11/2026 - Đón tại 123 Điện Biên Phủ, Q. Bình Thạnh");
                cboDoiTuong.Items.Add("DOAN02: Cty May Tiến Bộ (60 người) - Đi 22/11/2026 - Đón tại KCN Tân Bình");
                cboDoiTuong.SelectedIndex = 0;
                lblDiemDonThucTe.Text = "Điểm đón: Theo yêu cầu của đoàn (Công ty điều xe riêng đến đón tận nơi)";
            }
        }

        private void btnKiemTraTrungLich_Click(object sender, EventArgs e)
        {
            int demRanh = 0;
            foreach (DataRow r in dtHDV.Rows)
            {
                if (r["TrangThaiLich"].ToString().Contains("Rảnh lịch")) demRanh++;
            }
            MessageBox.Show(string.Format("KIỂM TRA LỊCH CÔNG TÁC THÀNH CÔNG!\n\n" +
                                          "• Tổng số HDV khả dụng trong khoảng thời gian này: {0} HDV\n" +
                                          "• HDV Phạm Văn Đồng: ĐANG BẬN TOUR (Hệ thống tự động khóa để chống chồng chéo lịch)", demRanh),
                            "Kiểm tra Xung đột Lịch", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXacNhanPhanCong_Click(object sender, EventArgs e)
        {
            int soHDVDuocChon = 0;
            string danhSachHDV = "";
            foreach (DataRow r in dtHDV.Rows)
            {
                if (Convert.ToBoolean(r["Chon"]))
                {
                    if (r["TrangThaiLich"].ToString().Contains("Bận"))
                    {
                        MessageBox.Show("HDV " + r["HoTen"] + " đang bị TRÙNG LỊCH tour khác! Không thể phân công.", "Lỗi xung đột lịch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    soHDVDuocChon++;
                    danhSachHDV += r["HoTen"] + ", ";
                }
            }

            if (soHDVDuocChon == 0)
            {
                MessageBox.Show("Vui lòng tích chọn ít nhất 1 Hướng dẫn viên trong danh sách!", "Chưa chọn HDV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboLoaiPhanCong.SelectedIndex == 0 && soHDVDuocChon > 1)
            {
                MessageBox.Show("Quy định nghiệp vụ: Mỗi chuyến khách lẻ chỉ phân công CỤ THỂ 1 NHÂN VIÊN!\nBạn đang chọn " + soHDVDuocChon + " HDV.", 
                                "Quy tắc Chuyến lẻ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            danhSachHDV = danhSachHDV.TrimEnd(' ', ',');
            dtPhanCongHienTai.Rows.Add("PC" + DateTime.Now.ToString("mmss"), cboDoiTuong.Text.Substring(0, 8), cboDoiTuong.Text, danhSachHDV, "Thời gian chuẩn", txtSoXeTaiXe.Text);
            MessageBox.Show("ĐÃ PHÂN CÔNG HƯỚNG DẪN VIÊN & BỐ TRÍ XE THÀNH CÔNG!\n\nHDV đảm nhiệm: " + danhSachHDV + "\nBố trí xe: " + txtSoXeTaiXe.Text, 
                            "Hoàn tất phân công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBenhAn_WinForms.Forms
{
    public partial class FrmXetNghiem : Form
    {
        private DataTable dtXetNghiem;

        public FrmXetNghiem()
        {
            InitializeComponent();
            LoadXNData();
        }

        private void LoadXNData()
        {
            dtXetNghiem = new DataTable();
            dtXetNghiem.Columns.Add("MaXN");
            dtXetNghiem.Columns.Add("TenLoaiXN");
            dtXetNghiem.Columns.Add("ChiSoDoDuoc");
            dtXetNghiem.Columns.Add("ChiSoBinhThuong");
            dtXetNghiem.Columns.Add("DonVi");
            dtXetNghiem.Columns.Add("KetLuan");

            dtXetNghiem.Rows.Add("XN01", "Bạch cầu (WBC)", "11.5", "4.0 - 10.0", "K/uL", "Tăng nhẹ (Nhiễm khuẩn)");
            dtXetNghiem.Rows.Add("XN02", "Hồng cầu (RBC)", "4.8", "4.2 - 5.4", "M/uL", "Bình thường");
            dtXetNghiem.Rows.Add("XN03", "Tiểu cầu (PLT)", "250", "150 - 450", "K/uL", "Bình thường");
            dtXetNghiem.Rows.Add("XN04", "Đường huyết lúc đói (Glucose)", "5.4", "3.9 - 6.4", "mmol/L", "Bình thường");
            dtXetNghiem.Rows.Add("XN05", "Đo điện tim (ECG)", "Nhịp xoang đều 82 ck/ph", "Nhịp xoang 60-100", "ck/phút", "Bình thường");

            dgvKetQuaXN.DataSource = dtXetNghiem;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ĐÃ CẬP NHẬT KẾT QUẢ XÉT NGHIỆM VÀO HỒ SƠ BỆNH ÁN!\n\nKết quả đã được đồng bộ trực tuyến đến phòng khám của Bác sĩ điều trị.",
                            "Cập nhật thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

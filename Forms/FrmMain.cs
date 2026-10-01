using System;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // Bấm nút "Danh mục" (Designer đang gán tên hàm này)
        private void button1_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDanhMuc()) f.ShowDialog(this);
        }

        // Bấm nút "Phòng - Tiện nghi"
        private void btnPhong_Click(object sender, EventArgs e)
        {
            using (var f = new FrmPhongTienNghi()) f.ShowDialog(this);
        }

        // Bấm nút "Dat Phong"
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDatPhong()) f.ShowDialog(this);
        }

        // Bấm nút "Dich vu"
        private void btnDichVu_Click(object sender, EventArgs e)
        {
            using (var f = new FrmDichVu()) f.ShowDialog(this);
        }

        // Bấm nút "Tra Phong" (Designer đang gán tên hàm này)
        private void button5_Click(object sender, EventArgs e)
        {
            using (var f = new FrmTraPhong()) f.ShowDialog(this);
        }

        // Bấm nút "Thong ke"
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            using (var f = new FrmThongKe()) f.ShowDialog(this);
        }

        // Bấm nút "Thoat"
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
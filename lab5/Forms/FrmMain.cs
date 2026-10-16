using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyTour_VanHoaViet.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnQuanLyTour_Click(object sender, EventArgs e)
        {
            FrmQuanLyTour frm = new FrmQuanLyTour();
            frm.ShowDialog();
        }

        private void btnDangKyDoan_Click(object sender, EventArgs e)
        {
            FrmDangKyTourDoan frm = new FrmDangKyTourDoan();
            frm.ShowDialog();
        }

        private void btnBanVeLe_Click(object sender, EventArgs e)
        {
            FrmBanVeKhachLe frm = new FrmBanVeKhachLe();
            frm.ShowDialog();
        }

        private void btnDieuHanh_Click(object sender, EventArgs e)
        {
            FrmDieuHanhPhanCong frm = new FrmDieuHanhPhanCong();
            frm.ShowDialog();
        }

        private void btnQuyetToanLuong_Click(object sender, EventArgs e)
        {
            FrmQuyetToanLuong frm = new FrmQuyetToanLuong();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát hệ thống?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

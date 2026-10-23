using System;
using System.Windows.Forms;

namespace QuanLyBenhAn_WinForms.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            new FrmDangKy_CapHSBA().ShowDialog();
        }

        private void btnKhamBenh_Click(object sender, EventArgs e)
        {
            new FrmKhamBenh_KeToa().ShowDialog();
        }

        private void btnXetNghiem_Click(object sender, EventArgs e)
        {
            new FrmXetNghiem().ShowDialog();
        }

        private void btnLichHen_Click(object sender, EventArgs e)
        {
            new FrmLichHenDinhKy().ShowDialog();
        }

        private void btnXuatVien_Click(object sender, EventArgs e)
        {
            new FrmXuatVien_ThanhToan().ShowDialog();
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

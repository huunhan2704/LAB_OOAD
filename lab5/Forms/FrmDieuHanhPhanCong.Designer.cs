namespace QuanLyTour_VanHoaViet.Forms
{
    partial class FrmDieuHanhPhanCong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpThietLap;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.ComboBox cboLoaiPhanCong;
        private System.Windows.Forms.Label lblDoiTuong;
        private System.Windows.Forms.ComboBox cboDoiTuong;
        private System.Windows.Forms.Label lblQuyTacPhanCong;
        private System.Windows.Forms.Label lblDiemDonThucTe;
        private System.Windows.Forms.Label lblXeDon;
        private System.Windows.Forms.TextBox txtSoXeTaiXe;
        private System.Windows.Forms.GroupBox grpDanhSachHDV;
        private System.Windows.Forms.DataGridView dgvHDV;
        private System.Windows.Forms.Button btnKiemTraTrungLich;
        private System.Windows.Forms.Button btnXacNhanPhanCong;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.GroupBox grpPhanCongLuu;
        private System.Windows.Forms.DataGridView dgvPhanCongDaLuu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpThietLap = new System.Windows.Forms.GroupBox();
            this.txtSoXeTaiXe = new System.Windows.Forms.TextBox();
            this.lblXeDon = new System.Windows.Forms.Label();
            this.lblDiemDonThucTe = new System.Windows.Forms.Label();
            this.lblQuyTacPhanCong = new System.Windows.Forms.Label();
            this.cboDoiTuong = new System.Windows.Forms.ComboBox();
            this.lblDoiTuong = new System.Windows.Forms.Label();
            this.cboLoaiPhanCong = new System.Windows.Forms.ComboBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.grpDanhSachHDV = new System.Windows.Forms.GroupBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXacNhanPhanCong = new System.Windows.Forms.Button();
            this.btnKiemTraTrungLich = new System.Windows.Forms.Button();
            this.dgvHDV = new System.Windows.Forms.DataGridView();
            this.grpPhanCongLuu = new System.Windows.Forms.GroupBox();
            this.dgvPhanCongDaLuu = new System.Windows.Forms.DataGridView();
            this.grpThietLap.SuspendLayout();
            this.grpDanhSachHDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDV)).BeginInit();
            this.grpPhanCongLuu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCongDaLuu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(964, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐIỀU HÀNH CHUYẾN ĐI & PHÂN CÔNG HƯỚNG DẪN VIÊN (KIỂM TRA TRÙNG LỊCH)";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpThietLap
            // 
            this.grpThietLap.Controls.Add(this.txtSoXeTaiXe);
            this.grpThietLap.Controls.Add(this.lblXeDon);
            this.grpThietLap.Controls.Add(this.lblDiemDonThucTe);
            this.grpThietLap.Controls.Add(this.lblQuyTacPhanCong);
            this.grpThietLap.Controls.Add(this.cboDoiTuong);
            this.grpThietLap.Controls.Add(this.lblDoiTuong);
            this.grpThietLap.Controls.Add(this.cboLoaiPhanCong);
            this.grpThietLap.Controls.Add(this.lblLoai);
            this.grpThietLap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThietLap.Location = new System.Drawing.Point(10, 65);
            this.grpThietLap.Name = "grpThietLap";
            this.grpThietLap.Size = new System.Drawing.Size(964, 150);
            this.grpThietLap.TabIndex = 1;
            this.grpThietLap.TabStop = false;
            this.grpThietLap.Text = "THÔNG TIN CHUYẾN ĐI / ĐOÀN TOUR CẦN ĐIỀU HÀNH";
            // 
            // txtSoXeTaiXe
            // 
            this.txtSoXeTaiXe.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSoXeTaiXe.Location = new System.Drawing.Point(620, 27);
            this.txtSoXeTaiXe.Name = "txtSoXeTaiXe";
            this.txtSoXeTaiXe.Size = new System.Drawing.Size(325, 24);
            this.txtSoXeTaiXe.TabIndex = 7;
            this.txtSoXeTaiXe.Text = "Xe 45 chỗ (BS: 51B-889.99, Tài xế: Trần Nam)";
            // 
            // lblXeDon
            // 
            this.lblXeDon.AutoSize = true;
            this.lblXeDon.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblXeDon.Location = new System.Drawing.Point(520, 30);
            this.lblXeDon.Name = "lblXeDon";
            this.lblXeDon.Size = new System.Drawing.Size(94, 17);
            this.lblXeDon.TabIndex = 6;
            this.lblXeDon.Text = "Bố trí xe đón:";
            // 
            // lblDiemDonThucTe
            // 
            this.lblDiemDonThucTe.AutoSize = true;
            this.lblDiemDonThucTe.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDiemDonThucTe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblDiemDonThucTe.Location = new System.Drawing.Point(15, 115);
            this.lblDiemDonThucTe.Name = "lblDiemDonThucTe";
            this.lblDiemDonThucTe.Size = new System.Drawing.Size(460, 17);
            this.lblDiemDonThucTe.TabIndex = 5;
            this.lblDiemDonThucTe.Text = "Điểm đón: 3 Điểm đón quy định (Trụ sở Q.1, Bến xe Miền Đông, Sân bay Tân Sơn Nhất)";
            // 
            // lblQuyTacPhanCong
            // 
            this.lblQuyTacPhanCong.AutoSize = true;
            this.lblQuyTacPhanCong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblQuyTacPhanCong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblQuyTacPhanCong.Location = new System.Drawing.Point(15, 90);
            this.lblQuyTacPhanCong.Name = "lblQuyTacPhanCong";
            this.lblQuyTacPhanCong.Size = new System.Drawing.Size(610, 15);
            this.lblQuyTacPhanCong.TabIndex = 4;
            this.lblQuyTacPhanCong.Text = "QUY TẮC: Mỗi chuyến khách lẻ phân công ĐÚNG 1 NHÂN VIÊN cụ thể. Điểm đón theo quy định công ty.";
            // 
            // cboDoiTuong
            // 
            this.cboDoiTuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoiTuong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboDoiTuong.FormattingEnabled = true;
            this.cboDoiTuong.Location = new System.Drawing.Point(150, 60);
            this.cboDoiTuong.Name = "cboDoiTuong";
            this.cboDoiTuong.Size = new System.Drawing.Size(795, 24);
            this.cboDoiTuong.TabIndex = 3;
            // 
            // lblDoiTuong
            // 
            this.lblDoiTuong.AutoSize = true;
            this.lblDoiTuong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDoiTuong.Location = new System.Drawing.Point(15, 63);
            this.lblDoiTuong.Name = "lblDoiTuong";
            this.lblDoiTuong.Size = new System.Drawing.Size(124, 17);
            this.lblDoiTuong.TabIndex = 2;
            this.lblDoiTuong.Text = "Chọn Chuyến/Đoàn:";
            // 
            // cboLoaiPhanCong
            // 
            this.cboLoaiPhanCong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiPhanCong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboLoaiPhanCong.FormattingEnabled = true;
            this.cboLoaiPhanCong.Items.AddRange(new object[] {
            "Phân công theo Chuyến Khách Lẻ (1 HDV / chuyến)",
            "Phân công theo Đoàn Tour (Nhiều HDV nếu đoàn đông)"});
            this.cboLoaiPhanCong.Location = new System.Drawing.Point(150, 27);
            this.cboLoaiPhanCong.Name = "cboLoaiPhanCong";
            this.cboLoaiPhanCong.Size = new System.Drawing.Size(350, 24);
            this.cboLoaiPhanCong.TabIndex = 1;
            this.cboLoaiPhanCong.SelectedIndexChanged += new System.EventHandler(this.cboLoaiPhanCong_SelectedIndexChanged);
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLoai.Location = new System.Drawing.Point(15, 30);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(126, 17);
            this.lblLoai.TabIndex = 0;
            this.lblLoai.Text = "Loại hình thực hiện:";
            // 
            // grpDanhSachHDV
            // 
            this.grpDanhSachHDV.Controls.Add(this.btnDong);
            this.grpDanhSachHDV.Controls.Add(this.btnXacNhanPhanCong);
            this.grpDanhSachHDV.Controls.Add(this.btnKiemTraTrungLich);
            this.grpDanhSachHDV.Controls.Add(this.dgvHDV);
            this.grpDanhSachHDV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDanhSachHDV.Location = new System.Drawing.Point(10, 225);
            this.grpDanhSachHDV.Name = "grpDanhSachHDV";
            this.grpDanhSachHDV.Size = new System.Drawing.Size(964, 210);
            this.grpDanhSachHDV.TabIndex = 2;
            this.grpDanhSachHDV.TabStop = false;
            this.grpDanhSachHDV.Text = "DANH SÁCH HƯỚNG DẪN VIÊN (TÍCH CHỌN PHÂN CÔNG)";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.White;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Location = new System.Drawing.Point(825, 168);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 32);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXacNhanPhanCong
            // 
            this.btnXacNhanPhanCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnXacNhanPhanCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanPhanCong.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanPhanCong.Location = new System.Drawing.Point(600, 168);
            this.btnXacNhanPhanCong.Name = "btnXacNhanPhanCong";
            this.btnXacNhanPhanCong.Size = new System.Drawing.Size(215, 32);
            this.btnXacNhanPhanCong.TabIndex = 2;
            this.btnXacNhanPhanCong.Text = "XÁC NHẬN PHÂN CÔNG HDV";
            this.btnXacNhanPhanCong.UseVisualStyleBackColor = false;
            this.btnXacNhanPhanCong.Click += new System.EventHandler(this.btnXacNhanPhanCong_Click);
            // 
            // btnKiemTraTrungLich
            // 
            this.btnKiemTraTrungLich.BackColor = System.Drawing.Color.White;
            this.btnKiemTraTrungLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiemTraTrungLich.Location = new System.Drawing.Point(380, 168);
            this.btnKiemTraTrungLich.Name = "btnKiemTraTrungLich";
            this.btnKiemTraTrungLich.Size = new System.Drawing.Size(210, 32);
            this.btnKiemTraTrungLich.TabIndex = 1;
            this.btnKiemTraTrungLich.Text = "Kiểm tra Không trùng lịch";
            this.btnKiemTraTrungLich.UseVisualStyleBackColor = false;
            this.btnKiemTraTrungLich.Click += new System.EventHandler(this.btnKiemTraTrungLich_Click);
            // 
            // dgvHDV
            // 
            this.dgvHDV.AllowUserToAddRows = false;
            this.dgvHDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDV.BackgroundColor = System.Drawing.Color.White;
            this.dgvHDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvHDV.Location = new System.Drawing.Point(3, 21);
            this.dgvHDV.Name = "dgvHDV";
            this.dgvHDV.Size = new System.Drawing.Size(958, 135);
            this.dgvHDV.TabIndex = 0;
            // 
            // grpPhanCongLuu
            // 
            this.grpPhanCongLuu.Controls.Add(this.dgvPhanCongDaLuu);
            this.grpPhanCongLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpPhanCongLuu.Location = new System.Drawing.Point(10, 445);
            this.grpPhanCongLuu.Name = "grpPhanCongLuu";
            this.grpPhanCongLuu.Size = new System.Drawing.Size(964, 180);
            this.grpPhanCongLuu.TabIndex = 3;
            this.grpPhanCongLuu.TabStop = false;
            this.grpPhanCongLuu.Text = "LỊCH SỬ ĐIỀU HÀNH VÀ PHÂN CÔNG HIỆN TẠI (KHÔNG CHỒNG CHÉO)";
            // 
            // dgvPhanCongDaLuu
            // 
            this.dgvPhanCongDaLuu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhanCongDaLuu.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhanCongDaLuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanCongDaLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhanCongDaLuu.Location = new System.Drawing.Point(3, 21);
            this.dgvPhanCongDaLuu.Name = "dgvPhanCongDaLuu";
            this.dgvPhanCongDaLuu.Size = new System.Drawing.Size(958, 156);
            this.dgvPhanCongDaLuu.TabIndex = 0;
            // 
            // FrmDieuHanhPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 640);
            this.Controls.Add(this.grpPhanCongLuu);
            this.Controls.Add(this.grpDanhSachHDV);
            this.Controls.Add(this.grpThietLap);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "FrmDieuHanhPhanCong";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Điều Hành Chuyến Đi & Phân Công Hướng Dẫn Viên";
            this.grpThietLap.ResumeLayout(false);
            this.grpThietLap.PerformLayout();
            this.grpDanhSachHDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDV)).EndInit();
            this.grpPhanCongLuu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCongDaLuu)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

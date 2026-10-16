namespace QuanLyTour_VanHoaViet.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnQuanLyTour;
        private System.Windows.Forms.Button btnDangKyDoan;
        private System.Windows.Forms.Button btnBanVeLe;
        private System.Windows.Forms.Button btnDieuHanh;
        private System.Windows.Forms.Button btnQuyetToanLuong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.GroupBox grpThongKe;
        private System.Windows.Forms.Label lblStatTour;
        private System.Windows.Forms.Label lblStatDoan;
        private System.Windows.Forms.Label lblStatKhachLe;
        private System.Windows.Forms.Label lblStatHDV;

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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnQuanLyTour = new System.Windows.Forms.Button();
            this.btnDangKyDoan = new System.Windows.Forms.Button();
            this.btnBanVeLe = new System.Windows.Forms.Button();
            this.btnDieuHanh = new System.Windows.Forms.Button();
            this.btnQuyetToanLuong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.grpThongKe = new System.Windows.Forms.GroupBox();
            this.lblStatTour = new System.Windows.Forms.Label();
            this.lblStatDoan = new System.Windows.Forms.Label();
            this.lblStatKhachLe = new System.Windows.Forms.Label();
            this.lblStatHDV = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.grpThongKe.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.pnlHeader.Controls.Add(this.lblHeaderSub);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 15);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(630, 30);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "CÔNG TY DU LỊCH VĂN HÓA VIỆT TP.HCM - HỆ THỐNG QUẢN LÝ TOUR";
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(22, 48);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(520, 19);
            this.lblHeaderSub.TabIndex = 1;
            this.lblHeaderSub.Text = "Tin học hóa Đăng ký Tour - Điều hành Chuyến đi - Phân công HDV - Quyết toán & Lương";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.btnThoat);
            this.pnlMenu.Controls.Add(this.btnQuyetToanLuong);
            this.pnlMenu.Controls.Add(this.btnDieuHanh);
            this.pnlMenu.Controls.Add(this.btnBanVeLe);
            this.pnlMenu.Controls.Add(this.btnDangKyDoan);
            this.pnlMenu.Controls.Add(this.btnQuanLyTour);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 80);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(240, 520);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnQuanLyTour
            // 
            this.btnQuanLyTour.BackColor = System.Drawing.Color.White;
            this.btnQuanLyTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyTour.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuanLyTour.Location = new System.Drawing.Point(10, 20);
            this.btnQuanLyTour.Name = "btnQuanLyTour";
            this.btnQuanLyTour.Size = new System.Drawing.Size(218, 55);
            this.btnQuanLyTour.TabIndex = 0;
            this.btnQuanLyTour.Text = "1. Quản lý Tour & Lộ trình";
            this.btnQuanLyTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyTour.UseVisualStyleBackColor = false;
            this.btnQuanLyTour.Click += new System.EventHandler(this.btnQuanLyTour_Click);
            // 
            // btnDangKyDoan
            // 
            this.btnDangKyDoan.BackColor = System.Drawing.Color.White;
            this.btnDangKyDoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKyDoan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangKyDoan.Location = new System.Drawing.Point(10, 85);
            this.btnDangKyDoan.Name = "btnDangKyDoan";
            this.btnDangKyDoan.Size = new System.Drawing.Size(218, 55);
            this.btnDangKyDoan.TabIndex = 1;
            this.btnDangKyDoan.Text = "2. Phiếu Đăng ký Đoàn (>12)";
            this.btnDangKyDoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKyDoan.UseVisualStyleBackColor = false;
            this.btnDangKyDoan.Click += new System.EventHandler(this.btnDangKyDoan_Click);
            // 
            // btnBanVeLe
            // 
            this.btnBanVeLe.BackColor = System.Drawing.Color.White;
            this.btnBanVeLe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanVeLe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBanVeLe.Location = new System.Drawing.Point(10, 150);
            this.btnBanVeLe.Name = "btnBanVeLe";
            this.btnBanVeLe.Size = new System.Drawing.Size(218, 55);
            this.btnBanVeLe.TabIndex = 2;
            this.btnBanVeLe.Text = "3. Bán vé Khách lẻ (<=12)";
            this.btnBanVeLe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanVeLe.UseVisualStyleBackColor = false;
            this.btnBanVeLe.Click += new System.EventHandler(this.btnBanVeLe_Click);
            // 
            // btnDieuHanh
            // 
            this.btnDieuHanh.BackColor = System.Drawing.Color.White;
            this.btnDieuHanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDieuHanh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDieuHanh.Location = new System.Drawing.Point(10, 215);
            this.btnDieuHanh.Name = "btnDieuHanh";
            this.btnDieuHanh.Size = new System.Drawing.Size(218, 55);
            this.btnDieuHanh.TabIndex = 3;
            this.btnDieuHanh.Text = "4. Điều hành & Phân công HDV";
            this.btnDieuHanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDieuHanh.UseVisualStyleBackColor = false;
            this.btnDieuHanh.Click += new System.EventHandler(this.btnDieuHanh_Click);
            // 
            // btnQuyetToanLuong
            // 
            this.btnQuyetToanLuong.BackColor = System.Drawing.Color.White;
            this.btnQuyetToanLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuyetToanLuong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuyetToanLuong.Location = new System.Drawing.Point(10, 280);
            this.btnQuyetToanLuong.Name = "btnQuyetToanLuong";
            this.btnQuyetToanLuong.Size = new System.Drawing.Size(218, 55);
            this.btnQuyetToanLuong.TabIndex = 4;
            this.btnQuyetToanLuong.Text = "5. Quyết toán & Tính lương HDV";
            this.btnQuyetToanLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuyetToanLuong.UseVisualStyleBackColor = false;
            this.btnQuyetToanLuong.Click += new System.EventHandler(this.btnQuyetToanLuong_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnThoat.Location = new System.Drawing.Point(10, 440);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(218, 45);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát Hệ Thống";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.grpThongKe);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(240, 80);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(760, 520);
            this.pnlContent.TabIndex = 2;
            // 
            // grpThongKe
            // 
            this.grpThongKe.Controls.Add(this.lblStatHDV);
            this.grpThongKe.Controls.Add(this.lblStatKhachLe);
            this.grpThongKe.Controls.Add(this.lblStatDoan);
            this.grpThongKe.Controls.Add(this.lblStatTour);
            this.grpThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongKe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpThongKe.Location = new System.Drawing.Point(20, 20);
            this.grpThongKe.Name = "grpThongKe";
            this.grpThongKe.Size = new System.Drawing.Size(720, 180);
            this.grpThongKe.TabIndex = 0;
            this.grpThongKe.TabStop = false;
            this.grpThongKe.Text = "TỔNG QUAN TÌNH HÌNH HOẠT ĐỘNG DU LỊCH";
            // 
            // lblStatTour
            // 
            this.lblStatTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.lblStatTour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatTour.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblStatTour.Location = new System.Drawing.Point(30, 40);
            this.lblStatTour.Name = "lblStatTour";
            this.lblStatTour.Padding = new System.Windows.Forms.Padding(10);
            this.lblStatTour.Size = new System.Drawing.Size(300, 50);
            this.lblStatTour.TabIndex = 0;
            this.lblStatTour.Text = "Tổng số Tour đang mở: 12 Tour";
            this.lblStatTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatDoan
            // 
            this.lblStatDoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.lblStatDoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatDoan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblStatDoan.Location = new System.Drawing.Point(370, 40);
            this.lblStatDoan.Name = "lblStatDoan";
            this.lblStatDoan.Padding = new System.Windows.Forms.Padding(10);
            this.lblStatDoan.Size = new System.Drawing.Size(300, 50);
            this.lblStatDoan.TabIndex = 1;
            this.lblStatDoan.Text = "Đoàn đã đặt cọc: 8 Đoàn (>12 người)";
            this.lblStatDoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatKhachLe
            // 
            this.lblStatKhachLe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.lblStatKhachLe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatKhachLe.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblStatKhachLe.Location = new System.Drawing.Point(30, 105);
            this.lblStatKhachLe.Name = "lblStatKhachLe";
            this.lblStatKhachLe.Padding = new System.Windows.Forms.Padding(10);
            this.lblStatKhachLe.Size = new System.Drawing.Size(300, 50);
            this.lblStatKhachLe.TabIndex = 2;
            this.lblStatKhachLe.Text = "Vé khách lẻ đã bán: 145 Vé";
            this.lblStatKhachLe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatHDV
            // 
            this.lblStatHDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.lblStatHDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatHDV.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblStatHDV.Location = new System.Drawing.Point(370, 105);
            this.lblStatHDV.Name = "lblStatHDV";
            this.lblStatHDV.Padding = new System.Windows.Forms.Padding(10);
            this.lblStatHDV.Size = new System.Drawing.Size(300, 50);
            this.lblStatHDV.TabIndex = 3;
            this.lblStatHDV.Text = "HDV sẵn sàng công tác: 18 HDV";
            this.lblStatHDV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Tour Du lịch Văn Hóa Việt TP.HCM";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.grpThongKe.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}

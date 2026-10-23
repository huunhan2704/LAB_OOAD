namespace QuanLyBenhAn_WinForms.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSub;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnKhamBenh;
        private System.Windows.Forms.Button btnXetNghiem;
        private System.Windows.Forms.Button btnLichHen;
        private System.Windows.Forms.Button btnXuatVien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.GroupBox grpThongKe;
        private System.Windows.Forms.Label lblStat1;
        private System.Windows.Forms.Label lblStat2;
        private System.Windows.Forms.Label lblStat3;
        private System.Windows.Forms.Label lblStat4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSub = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnKhamBenh = new System.Windows.Forms.Button();
            this.btnXetNghiem = new System.Windows.Forms.Button();
            this.btnLichHen = new System.Windows.Forms.Button();
            this.btnXuatVien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.grpThongKe = new System.Windows.Forms.GroupBox();
            this.lblStat1 = new System.Windows.Forms.Label();
            this.lblStat2 = new System.Windows.Forms.Label();
            this.lblStat3 = new System.Windows.Forms.Label();
            this.lblStat4 = new System.Windows.Forms.Label();
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
            this.lblHeaderTitle.Size = new System.Drawing.Size(650, 30);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "BỆNH VIỆN ĐA KHOA QUỐC TẾ - HỆ THỐNG QUẢN LÝ BỆNH ÁN";
            // 
            // lblHeaderSub
            // 
            this.lblHeaderSub.AutoSize = true;
            this.lblHeaderSub.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblHeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblHeaderSub.Location = new System.Drawing.Point(22, 48);
            this.lblHeaderSub.Name = "lblHeaderSub";
            this.lblHeaderSub.Size = new System.Drawing.Size(560, 19);
            this.lblHeaderSub.TabIndex = 1;
            this.lblHeaderSub.Text = "Hồ sơ bệnh án điện tử - Xét nghiệm cận lâm sàng - Kê toa thuốc - Khám định kỳ theo quý";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.btnThoat);
            this.pnlMenu.Controls.Add(this.btnXuatVien);
            this.pnlMenu.Controls.Add(this.btnLichHen);
            this.pnlMenu.Controls.Add(this.btnXetNghiem);
            this.pnlMenu.Controls.Add(this.btnKhamBenh);
            this.pnlMenu.Controls.Add(this.btnDangKy);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 80);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(250, 520);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.White;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangKy.Location = new System.Drawing.Point(10, 20);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(228, 55);
            this.btnDangKy.TabIndex = 0;
            this.btnDangKy.Text = "1. Đăng ký BN mới & Cấp HSBA";
            this.btnDangKy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnKhamBenh
            // 
            this.btnKhamBenh.BackColor = System.Drawing.Color.White;
            this.btnKhamBenh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhamBenh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKhamBenh.Location = new System.Drawing.Point(10, 85);
            this.btnKhamBenh.Name = "btnKhamBenh";
            this.btnKhamBenh.Size = new System.Drawing.Size(228, 55);
            this.btnKhamBenh.TabIndex = 1;
            this.btnKhamBenh.Text = "2. Khám bệnh & Lập Toa thuốc";
            this.btnKhamBenh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhamBenh.UseVisualStyleBackColor = false;
            this.btnKhamBenh.Click += new System.EventHandler(this.btnKhamBenh_Click);
            // 
            // btnXetNghiem
            // 
            this.btnXetNghiem.BackColor = System.Drawing.Color.White;
            this.btnXetNghiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXetNghiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXetNghiem.Location = new System.Drawing.Point(10, 150);
            this.btnXetNghiem.Name = "btnXetNghiem";
            this.btnXetNghiem.Size = new System.Drawing.Size(228, 55);
            this.btnXetNghiem.TabIndex = 2;
            this.btnXetNghiem.Text = "3. Xét nghiệm Cận lâm sàng";
            this.btnXetNghiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXetNghiem.UseVisualStyleBackColor = false;
            this.btnXetNghiem.Click += new System.EventHandler(this.btnXetNghiem_Click);
            // 
            // btnLichHen
            // 
            this.btnLichHen.BackColor = System.Drawing.Color.White;
            this.btnLichHen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichHen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLichHen.Location = new System.Drawing.Point(10, 215);
            this.btnLichHen.Name = "btnLichHen";
            this.btnLichHen.Size = new System.Drawing.Size(228, 55);
            this.btnLichHen.TabIndex = 3;
            this.btnLichHen.Text = "4. Đặt hẹn Khám định kỳ Quý";
            this.btnLichHen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichHen.UseVisualStyleBackColor = false;
            this.btnLichHen.Click += new System.EventHandler(this.btnLichHen_Click);
            // 
            // btnXuatVien
            // 
            this.btnXuatVien.BackColor = System.Drawing.Color.White;
            this.btnXuatVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXuatVien.Location = new System.Drawing.Point(10, 280);
            this.btnXuatVien.Name = "btnXuatVien";
            this.btnXuatVien.Size = new System.Drawing.Size(228, 55);
            this.btnXuatVien.TabIndex = 4;
            this.btnXuatVien.Text = "5. Xuất viện & Viện phí";
            this.btnXuatVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatVien.UseVisualStyleBackColor = false;
            this.btnXuatVien.Click += new System.EventHandler(this.btnXuatVien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnThoat.Location = new System.Drawing.Point(10, 440);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(228, 45);
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
            this.pnlContent.Location = new System.Drawing.Point(250, 80);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(750, 520);
            this.pnlContent.TabIndex = 2;
            // 
            // grpThongKe
            // 
            this.grpThongKe.Controls.Add(this.lblStat4);
            this.grpThongKe.Controls.Add(this.lblStat3);
            this.grpThongKe.Controls.Add(this.lblStat2);
            this.grpThongKe.Controls.Add(this.lblStat1);
            this.grpThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongKe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpThongKe.Location = new System.Drawing.Point(20, 20);
            this.grpThongKe.Name = "grpThongKe";
            this.grpThongKe.Size = new System.Drawing.Size(710, 190);
            this.grpThongKe.TabIndex = 0;
            this.grpThongKe.TabStop = false;
            this.grpThongKe.Text = "TỔNG QUAN HOẠT ĐỘNG KHÁM CHỮA BỆNH";
            // 
            // lblStat1
            // 
            this.lblStat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.lblStat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStat1.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblStat1.Location = new System.Drawing.Point(25, 38);
            this.lblStat1.Name = "lblStat1";
            this.lblStat1.Padding = new System.Windows.Forms.Padding(10);
            this.lblStat1.Size = new System.Drawing.Size(310, 55);
            this.lblStat1.TabIndex = 0;
            this.lblStat1.Text = "Hồ sơ bệnh án đang quản lý: 1,248 HSBA";
            this.lblStat1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStat2
            // 
            this.lblStat2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.lblStat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStat2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblStat2.Location = new System.Drawing.Point(365, 38);
            this.lblStat2.Name = "lblStat2";
            this.lblStat2.Padding = new System.Windows.Forms.Padding(10);
            this.lblStat2.Size = new System.Drawing.Size(310, 55);
            this.lblStat2.TabIndex = 1;
            this.lblStat2.Text = "Lượt khám bệnh trong ngày: 86 ca";
            this.lblStat2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStat3
            // 
            this.lblStat3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.lblStat3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStat3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblStat3.Location = new System.Drawing.Point(25, 110);
            this.lblStat3.Name = "lblStat3";
            this.lblStat3.Padding = new System.Windows.Forms.Padding(10);
            this.lblStat3.Size = new System.Drawing.Size(310, 55);
            this.lblStat3.TabIndex = 2;
            this.lblStat3.Text = "Phiếu xét nghiệm chờ KQ: 14 phiếu";
            this.lblStat3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStat4
            // 
            this.lblStat4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.lblStat4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStat4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblStat4.Location = new System.Drawing.Point(365, 110);
            this.lblStat4.Name = "lblStat4";
            this.lblStat4.Padding = new System.Windows.Forms.Padding(10);
            this.lblStat4.Size = new System.Drawing.Size(310, 55);
            this.lblStat4.TabIndex = 3;
            this.lblStat4.Text = "Hẹn khám định kỳ quý (miễn phí): 32 ca";
            this.lblStat4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Bệnh án Bệnh nhân - Bệnh viện Đa khoa Quốc tế";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.grpThongKe.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}

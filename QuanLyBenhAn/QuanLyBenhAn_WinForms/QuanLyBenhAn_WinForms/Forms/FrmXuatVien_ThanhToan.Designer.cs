namespace QuanLyBenhAn_WinForms.Forms
{
    partial class FrmXuatVien_ThanhToan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpBN;
        private System.Windows.Forms.Label lblTenBN;
        private System.Windows.Forms.Label lblMaHSBA;
        private System.Windows.Forms.CheckBox chkKhamDinhKy;
        private System.Windows.Forms.GroupBox grpVienPhi;
        private System.Windows.Forms.Label lblTienKhamTitle;
        private System.Windows.Forms.Label lblTienKham;
        private System.Windows.Forms.Label lblTienXNTitle;
        private System.Windows.Forms.Label lblTienXN;
        private System.Windows.Forms.Label lblTienThuocTitle;
        private System.Windows.Forms.Label lblTienThuoc;
        private System.Windows.Forms.Label lblTongTitle;
        private System.Windows.Forms.Label lblTongVienPhi;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.ComboBox cboHinhThuc;
        private System.Windows.Forms.GroupBox grpCSKH;
        private System.Windows.Forms.Label lblDienBien;
        private System.Windows.Forms.TextBox txtDienBien;
        private System.Windows.Forms.Label lblPhanUngPhu;
        private System.Windows.Forms.TextBox txtPhanUngPhu;
        private System.Windows.Forms.Label lblHieuQua;
        private System.Windows.Forms.ComboBox cboHieuQua;
        private System.Windows.Forms.Button btnThanhToanXuatVien;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpBN = new System.Windows.Forms.GroupBox();
            this.chkKhamDinhKy = new System.Windows.Forms.CheckBox();
            this.lblMaHSBA = new System.Windows.Forms.Label();
            this.lblTenBN = new System.Windows.Forms.Label();
            this.grpVienPhi = new System.Windows.Forms.GroupBox();
            this.cboHinhThuc = new System.Windows.Forms.ComboBox();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.lblTongVienPhi = new System.Windows.Forms.Label();
            this.lblTongTitle = new System.Windows.Forms.Label();
            this.lblTienThuoc = new System.Windows.Forms.Label();
            this.lblTienThuocTitle = new System.Windows.Forms.Label();
            this.lblTienXN = new System.Windows.Forms.Label();
            this.lblTienXNTitle = new System.Windows.Forms.Label();
            this.lblTienKham = new System.Windows.Forms.Label();
            this.lblTienKhamTitle = new System.Windows.Forms.Label();
            this.grpCSKH = new System.Windows.Forms.GroupBox();
            this.cboHieuQua = new System.Windows.Forms.ComboBox();
            this.lblHieuQua = new System.Windows.Forms.Label();
            this.txtPhanUngPhu = new System.Windows.Forms.TextBox();
            this.lblPhanUngPhu = new System.Windows.Forms.Label();
            this.txtDienBien = new System.Windows.Forms.TextBox();
            this.lblDienBien = new System.Windows.Forms.Label();
            this.btnThanhToanXuatVien = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpBN.SuspendLayout();
            this.grpVienPhi.SuspendLayout();
            this.grpCSKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(864, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "XUẤT VIỆN, THANH TOÁN VIỆN PHÍ & GHI NHẬN HỒ SƠ THEO DÕI CSKH";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBN
            // 
            this.grpBN.Controls.Add(this.chkKhamDinhKy);
            this.grpBN.Controls.Add(this.lblMaHSBA);
            this.grpBN.Controls.Add(this.lblTenBN);
            this.grpBN.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpBN.Location = new System.Drawing.Point(10, 55);
            this.grpBN.Name = "grpBN";
            this.grpBN.Size = new System.Drawing.Size(864, 65);
            this.grpBN.TabIndex = 1;
            this.grpBN.TabStop = false;
            this.grpBN.Text = "BỆNH NHÂN XUẤT VIỆN";
            // 
            // chkKhamDinhKy
            // 
            this.chkKhamDinhKy.AutoSize = true;
            this.chkKhamDinhKy.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.chkKhamDinhKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.chkKhamDinhKy.Location = new System.Drawing.Point(520, 27);
            this.chkKhamDinhKy.Name = "chkKhamDinhKy";
            this.chkKhamDinhKy.Size = new System.Drawing.Size(320, 21);
            this.chkKhamDinhKy.TabIndex = 2;
            this.chkKhamDinhKy.Text = "Đợt Khám Sức Khỏe Định Kỳ Quý (Miễn phí tiền khám)";
            this.chkKhamDinhKy.UseVisualStyleBackColor = true;
            this.chkKhamDinhKy.CheckedChanged += new System.EventHandler(this.chkKhamDinhKy_CheckedChanged);
            // 
            // lblMaHSBA
            // 
            this.lblMaHSBA.AutoSize = true;
            this.lblMaHSBA.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMaHSBA.Location = new System.Drawing.Point(330, 28);
            this.lblMaHSBA.Name = "lblMaHSBA";
            this.lblMaHSBA.Size = new System.Drawing.Size(147, 17);
            this.lblMaHSBA.TabIndex = 1;
            this.lblMaHSBA.Text = "Mã hồ sơ: HSBA00123";
            // 
            // lblTenBN
            // 
            this.lblTenBN.AutoSize = true;
            this.lblTenBN.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTenBN.Location = new System.Drawing.Point(15, 26);
            this.lblTenBN.Name = "lblTenBN";
            this.lblTenBN.Size = new System.Drawing.Size(268, 19);
            this.lblTenBN.TabIndex = 0;
            this.lblTenBN.Text = "Bệnh nhân: Nguyễn Văn Hùng (Nam - 1982)";
            // 
            // grpVienPhi
            // 
            this.grpVienPhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.grpVienPhi.Controls.Add(this.cboHinhThuc);
            this.grpVienPhi.Controls.Add(this.lblHinhThuc);
            this.grpVienPhi.Controls.Add(this.lblTongVienPhi);
            this.grpVienPhi.Controls.Add(this.lblTongTitle);
            this.grpVienPhi.Controls.Add(this.lblTienThuoc);
            this.grpVienPhi.Controls.Add(this.lblTienThuocTitle);
            this.grpVienPhi.Controls.Add(this.lblTienXN);
            this.grpVienPhi.Controls.Add(this.lblTienXNTitle);
            this.grpVienPhi.Controls.Add(this.lblTienKham);
            this.grpVienPhi.Controls.Add(this.lblTienKhamTitle);
            this.grpVienPhi.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpVienPhi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpVienPhi.Location = new System.Drawing.Point(10, 120);
            this.grpVienPhi.Name = "grpVienPhi";
            this.grpVienPhi.Size = new System.Drawing.Size(864, 150);
            this.grpVienPhi.TabIndex = 2;
            this.grpVienPhi.TabStop = false;
            this.grpVienPhi.Text = "CHI TIẾT VIỆN PHÍ ĐỢT ĐIỀU TRỊ";
            // 
            // cboHinhThuc
            // 
            this.cboHinhThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThuc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboHinhThuc.FormattingEnabled = true;
            this.cboHinhThuc.Items.AddRange(new object[] { "Tiền mặt", "Thẻ tín dụng / Ghi nợ", "Chuyển khoản QR-Code" });
            this.cboHinhThuc.Location = new System.Drawing.Point(620, 107);
            this.cboHinhThuc.Name = "cboHinhThuc";
            this.cboHinhThuc.Size = new System.Drawing.Size(220, 24);
            this.cboHinhThuc.TabIndex = 9;
            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.AutoSize = true;
            this.lblHinhThuc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHinhThuc.Location = new System.Drawing.Point(480, 110);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(126, 17);
            this.lblHinhThuc.TabIndex = 8;
            this.lblHinhThuc.Text = "Hình thức thanh toán:";
            // 
            // lblTongVienPhi
            // 
            this.lblTongVienPhi.AutoSize = true;
            this.lblTongVienPhi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongVienPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTongVienPhi.Location = new System.Drawing.Point(190, 105);
            this.lblTongVienPhi.Name = "lblTongVienPhi";
            this.lblTongVienPhi.Size = new System.Drawing.Size(133, 25);
            this.lblTongVienPhi.TabIndex = 7;
            this.lblTongVienPhi.Text = "810,000 VNĐ";
            // 
            // lblTongTitle
            // 
            this.lblTongTitle.AutoSize = true;
            this.lblTongTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongTitle.Location = new System.Drawing.Point(15, 108);
            this.lblTongTitle.Name = "lblTongTitle";
            this.lblTongTitle.Size = new System.Drawing.Size(167, 20);
            this.lblTongTitle.TabIndex = 6;
            this.lblTongTitle.Text = "TỔNG TIỀN PHẢI TRẢ:";
            // 
            // lblTienThuoc
            // 
            this.lblTienThuoc.AutoSize = true;
            this.lblTienThuoc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTienThuoc.Location = new System.Drawing.Point(620, 68);
            this.lblTienThuoc.Name = "lblTienThuoc";
            this.lblTienThuoc.Size = new System.Drawing.Size(89, 17);
            this.lblTienThuoc.TabIndex = 5;
            this.lblTienThuoc.Text = "160,000 VNĐ";
            // 
            // lblTienThuocTitle
            // 
            this.lblTienThuocTitle.AutoSize = true;
            this.lblTienThuocTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTienThuocTitle.Location = new System.Drawing.Point(480, 68);
            this.lblTienThuocTitle.Name = "lblTienThuocTitle";
            this.lblTienThuocTitle.Size = new System.Drawing.Size(127, 17);
            this.lblTienThuocTitle.TabIndex = 4;
            this.lblTienThuocTitle.Text = "3. Tiền thuốc điều trị:";
            // 
            // lblTienXN
            // 
            this.lblTienXN.AutoSize = true;
            this.lblTienXN.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTienXN.Location = new System.Drawing.Point(190, 68);
            this.lblTienXN.Name = "lblTienXN";
            this.lblTienXN.Size = new System.Drawing.Size(89, 17);
            this.lblTienXN.TabIndex = 3;
            this.lblTienXN.Text = "450,000 VNĐ";
            // 
            // lblTienXNTitle
            // 
            this.lblTienXNTitle.AutoSize = true;
            this.lblTienXNTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTienXNTitle.Location = new System.Drawing.Point(15, 68);
            this.lblTienXNTitle.Name = "lblTienXNTitle";
            this.lblTienXNTitle.Size = new System.Drawing.Size(155, 17);
            this.lblTienXNTitle.TabIndex = 2;
            this.lblTienXNTitle.Text = "2. Tiền xét nghiệm cận LS:";
            // 
            // lblTienKham
            // 
            this.lblTienKham.AutoSize = true;
            this.lblTienKham.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTienKham.Location = new System.Drawing.Point(190, 30);
            this.lblTienKham.Name = "lblTienKham";
            this.lblTienKham.Size = new System.Drawing.Size(89, 17);
            this.lblTienKham.TabIndex = 1;
            this.lblTienKham.Text = "200,000 VNĐ";
            // 
            // lblTienKhamTitle
            // 
            this.lblTienKhamTitle.AutoSize = true;
            this.lblTienKhamTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTienKhamTitle.Location = new System.Drawing.Point(15, 30);
            this.lblTienKhamTitle.Name = "lblTienKhamTitle";
            this.lblTienKhamTitle.Size = new System.Drawing.Size(147, 17);
            this.lblTienKhamTitle.TabIndex = 0;
            this.lblTienKhamTitle.Text = "1. Tiền khám lâm sàng:";
            // 
            // grpCSKH
            // 
            this.grpCSKH.Controls.Add(this.btnDong);
            this.grpCSKH.Controls.Add(this.btnThanhToanXuatVien);
            this.grpCSKH.Controls.Add(this.cboHieuQua);
            this.grpCSKH.Controls.Add(this.lblHieuQua);
            this.grpCSKH.Controls.Add(this.txtPhanUngPhu);
            this.grpCSKH.Controls.Add(this.lblPhanUngPhu);
            this.grpCSKH.Controls.Add(this.txtDienBien);
            this.grpCSKH.Controls.Add(this.lblDienBien);
            this.grpCSKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCSKH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpCSKH.Location = new System.Drawing.Point(10, 270);
            this.grpCSKH.Name = "grpCSKH";
            this.grpCSKH.Size = new System.Drawing.Size(864, 210);
            this.grpCSKH.TabIndex = 3;
            this.grpCSKH.TabStop = false;
            this.grpCSKH.Text = "PHÒNG CHĂM SÓC KHÁCH HÀNG: THEO DÕI DIỄN BIẾN, PHẢN ỨNG THUỐC & TRÁCH NHIỆM BÁC SĨ";
            // 
            // lblDienBien
            // 
            this.lblDienBien.AutoSize = true;
            this.lblDienBien.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDienBien.Location = new System.Drawing.Point(15, 30);
            this.lblDienBien.Name = "lblDienBien";
            this.lblDienBien.Size = new System.Drawing.Size(126, 17);
            this.lblDienBien.TabIndex = 0;
            this.lblDienBien.Text = "Diễn biến của bệnh:";
            // 
            // txtDienBien
            // 
            this.txtDienBien.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDienBien.Location = new System.Drawing.Point(190, 27);
            this.txtDienBien.Name = "txtDienBien";
            this.txtDienBien.Size = new System.Drawing.Size(650, 24);
            this.txtDienBien.TabIndex = 1;
            this.txtDienBien.Text = "Sau dùng thuốc hạ sốt, thân nhiệt giảm về 37.1°C, huyết áp hạ về 125/80 mmHg, giảm nhức đầu";
            // 
            // lblPhanUngPhu
            // 
            this.lblPhanUngPhu.AutoSize = true;
            this.lblPhanUngPhu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPhanUngPhu.Location = new System.Drawing.Point(15, 68);
            this.lblPhanUngPhu.Name = "lblPhanUngPhu";
            this.lblPhanUngPhu.Size = new System.Drawing.Size(161, 17);
            this.lblPhanUngPhu.TabIndex = 2;
            this.lblPhanUngPhu.Text = "Phản ứng phụ của thuốc:";
            // 
            // txtPhanUngPhu
            // 
            this.txtPhanUngPhu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPhanUngPhu.Location = new System.Drawing.Point(190, 65);
            this.txtPhanUngPhu.Name = "txtPhanUngPhu";
            this.txtPhanUngPhu.Size = new System.Drawing.Size(650, 24);
            this.txtPhanUngPhu.TabIndex = 3;
            this.txtPhanUngPhu.Text = "Không có phản ứng phụ bất thường (Không buồn nôn, không phát ban da)";
            // 
            // lblHieuQua
            // 
            this.lblHieuQua.AutoSize = true;
            this.lblHieuQua.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHieuQua.Location = new System.Drawing.Point(15, 108);
            this.lblHieuQua.Name = "lblHieuQua";
            this.lblHieuQua.Size = new System.Drawing.Size(126, 17);
            this.lblHieuQua.TabIndex = 4;
            this.lblHieuQua.Text = "Hiệu quả điều trị:";
            // 
            // cboHieuQua
            // 
            this.cboHieuQua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHieuQua.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboHieuQua.FormattingEnabled = true;
            this.cboHieuQua.Items.AddRange(new object[] { "Rất tốt (Triệu chứng thuyên giảm rõ rệt)", "Tốt (Đáp ứng điều trị tốt)", "Trung bình (Cần tiếp tục theo dõi)", "Kém (Cần đổi phác đồ)" });
            this.cboHieuQua.Location = new System.Drawing.Point(190, 105);
            this.cboHieuQua.Name = "cboHieuQua";
            this.cboHieuQua.Size = new System.Drawing.Size(320, 24);
            this.cboHieuQua.TabIndex = 5;
            this.cboHieuQua.SelectedIndex = 0;
            // 
            // btnThanhToanXuatVien
            // 
            this.btnThanhToanXuatVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnThanhToanXuatVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToanXuatVien.ForeColor = System.Drawing.Color.White;
            this.btnThanhToanXuatVien.Location = new System.Drawing.Point(530, 145);
            this.btnThanhToanXuatVien.Name = "btnThanhToanXuatVien";
            this.btnThanhToanXuatVien.Size = new System.Drawing.Size(200, 42);
            this.btnThanhToanXuatVien.TabIndex = 6;
            this.btnThanhToanXuatVien.Text = "XÁC NHẬN XUẤT VIỆN";
            this.btnThanhToanXuatVien.UseVisualStyleBackColor = false;
            this.btnThanhToanXuatVien.Click += new System.EventHandler(this.btnThanhToanXuatVien_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.White;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Location = new System.Drawing.Point(740, 145);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 42);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmXuatVien_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 490);
            this.Controls.Add(this.grpCSKH);
            this.Controls.Add(this.grpVienPhi);
            this.Controls.Add(this.grpBN);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "FrmXuatVien_ThanhToan";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xuất Viện & Thanh Toán Viện Phí";
            this.grpBN.ResumeLayout(false);
            this.grpBN.PerformLayout();
            this.grpVienPhi.ResumeLayout(false);
            this.grpVienPhi.PerformLayout();
            this.grpCSKH.ResumeLayout(false);
            this.grpCSKH.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}

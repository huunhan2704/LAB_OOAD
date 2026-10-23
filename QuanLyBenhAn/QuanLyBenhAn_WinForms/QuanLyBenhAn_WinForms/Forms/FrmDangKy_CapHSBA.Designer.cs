namespace QuanLyBenhAn_WinForms.Forms
{
    partial class FrmDangKy_CapHSBA
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpPhieuDK;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.TextBox txtDuongDanAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Label lblAnhPreview;
        private System.Windows.Forms.GroupBox grpLePhi;
        private System.Windows.Forms.Label lblLePhiTitle;
        private System.Windows.Forms.NumericUpDown numLePhi;
        private System.Windows.Forms.CheckBox chkDaDongPhi;
        private System.Windows.Forms.Label lblQuyDinhLePhi;
        private System.Windows.Forms.Button btnCapHSBA;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpPhieuDK = new System.Windows.Forms.GroupBox();
            this.lblAnhPreview = new System.Windows.Forms.Label();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.txtDuongDanAnh = new System.Windows.Forms.TextBox();
            this.lblAnh = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.grpLePhi = new System.Windows.Forms.GroupBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnCapHSBA = new System.Windows.Forms.Button();
            this.lblQuyDinhLePhi = new System.Windows.Forms.Label();
            this.chkDaDongPhi = new System.Windows.Forms.CheckBox();
            this.numLePhi = new System.Windows.Forms.NumericUpDown();
            this.lblLePhiTitle = new System.Windows.Forms.Label();
            this.grpPhieuDK.SuspendLayout();
            this.grpLePhi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLePhi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(780, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PHIẾU ĐĂNG KÝ KHÁM BỆNH LẦN ĐẦU & CẤP HỒ SƠ BỆNH ÁN (HSBA)";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpPhieuDK
            // 
            this.grpPhieuDK.Controls.Add(this.lblAnhPreview);
            this.grpPhieuDK.Controls.Add(this.btnChonAnh);
            this.grpPhieuDK.Controls.Add(this.txtDuongDanAnh);
            this.grpPhieuDK.Controls.Add(this.lblAnh);
            this.grpPhieuDK.Controls.Add(this.txtDiaChi);
            this.grpPhieuDK.Controls.Add(this.lblDiaChi);
            this.grpPhieuDK.Controls.Add(this.txtSoDienThoai);
            this.grpPhieuDK.Controls.Add(this.lblSDT);
            this.grpPhieuDK.Controls.Add(this.cboGioiTinh);
            this.grpPhieuDK.Controls.Add(this.lblGioiTinh);
            this.grpPhieuDK.Controls.Add(this.dtpNgaySinh);
            this.grpPhieuDK.Controls.Add(this.lblNgaySinh);
            this.grpPhieuDK.Controls.Add(this.txtHoTen);
            this.grpPhieuDK.Controls.Add(this.lblHoTen);
            this.grpPhieuDK.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpPhieuDK.Location = new System.Drawing.Point(10, 65);
            this.grpPhieuDK.Name = "grpPhieuDK";
            this.grpPhieuDK.Size = new System.Drawing.Size(780, 240);
            this.grpPhieuDK.TabIndex = 1;
            this.grpPhieuDK.TabStop = false;
            this.grpPhieuDK.Text = "THÔNG TIN PHIẾU ĐĂNG KÝ BỆNH NHÂN LẦN ĐẦU";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHoTen.Location = new System.Drawing.Point(20, 35);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(70, 17);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtHoTen.Location = new System.Drawing.Point(110, 32);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(320, 24);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.Text = "Nguyễn Văn Hùng";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNgaySinh.Location = new System.Drawing.Point(460, 35);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(69, 17);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(540, 32);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(120, 24);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblGioiTinh.Location = new System.Drawing.Point(670, 35);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(32, 17);
            this.lblGioiTinh.TabIndex = 4;
            this.lblGioiTinh.Text = "Phái:";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cboGioiTinh.Location = new System.Drawing.Point(705, 32);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(60, 24);
            this.cboGioiTinh.TabIndex = 5;
            this.cboGioiTinh.SelectedIndex = 0;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSDT.Location = new System.Drawing.Point(20, 75);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(70, 17);
            this.lblSDT.TabIndex = 6;
            this.lblSDT.Text = "Điện thoại:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSoDienThoai.Location = new System.Drawing.Point(110, 72);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(180, 24);
            this.txtSoDienThoai.TabIndex = 7;
            this.txtSoDienThoai.Text = "0908123456";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDiaChi.Location = new System.Drawing.Point(310, 75);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(50, 17);
            this.lblDiaChi.TabIndex = 8;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDiaChi.Location = new System.Drawing.Point(370, 72);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(395, 24);
            this.txtDiaChi.TabIndex = 9;
            this.txtDiaChi.Text = "123 Điện Biên Phủ, P.15, Q. Bình Thạnh, TP.HCM";
            // 
            // lblAnh
            // 
            this.lblAnh.AutoSize = true;
            this.lblAnh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAnh.Location = new System.Drawing.Point(20, 120);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(84, 17);
            this.lblAnh.TabIndex = 10;
            this.lblAnh.Text = "Ảnh chụp 3x4:";
            // 
            // txtDuongDanAnh
            // 
            this.txtDuongDanAnh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDuongDanAnh.Location = new System.Drawing.Point(110, 117);
            this.txtDuongDanAnh.Name = "txtDuongDanAnh";
            this.txtDuongDanAnh.ReadOnly = true;
            this.txtDuongDanAnh.Size = new System.Drawing.Size(420, 24);
            this.txtDuongDanAnh.TabIndex = 11;
            this.txtDuongDanAnh.Text = "C:\\BenhAn\\Photos\\3x4_NguyenVanHung.jpg";
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackColor = System.Drawing.Color.White;
            this.btnChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnChonAnh.Location = new System.Drawing.Point(540, 115);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(100, 28);
            this.btnChonAnh.TabIndex = 12;
            this.btnChonAnh.Text = "Chọn ảnh...";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // lblAnhPreview
            // 
            this.lblAnhPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblAnhPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnhPreview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblAnhPreview.Location = new System.Drawing.Point(110, 155);
            this.lblAnhPreview.Name = "lblAnhPreview";
            this.lblAnhPreview.Size = new System.Drawing.Size(530, 65);
            this.lblAnhPreview.TabIndex = 13;
            this.lblAnhPreview.Text = "[Ảnh chân dung 3x4: Đã tải lên hệ thống và dán lên trang bìa Hồ sơ bệnh án]";
            this.lblAnhPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpLePhi
            // 
            this.grpLePhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.grpLePhi.Controls.Add(this.btnDong);
            this.grpLePhi.Controls.Add(this.btnCapHSBA);
            this.grpLePhi.Controls.Add(this.lblQuyDinhLePhi);
            this.grpLePhi.Controls.Add(this.chkDaDongPhi);
            this.grpLePhi.Controls.Add(this.numLePhi);
            this.grpLePhi.Controls.Add(this.lblLePhiTitle);
            this.grpLePhi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpLePhi.Location = new System.Drawing.Point(10, 315);
            this.grpLePhi.Name = "grpLePhi";
            this.grpLePhi.Size = new System.Drawing.Size(780, 140);
            this.grpLePhi.TabIndex = 2;
            this.grpLePhi.TabStop = false;
            this.grpLePhi.Text = "LỆ PHÍ HÀNG NĂM & CẤP HỒ SƠ BỆNH ÁN";
            // 
            // lblLePhiTitle
            // 
            this.lblLePhiTitle.AutoSize = true;
            this.lblLePhiTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLePhiTitle.Location = new System.Drawing.Point(20, 32);
            this.lblLePhiTitle.Name = "lblLePhiTitle";
            this.lblLePhiTitle.Size = new System.Drawing.Size(161, 17);
            this.lblLePhiTitle.TabIndex = 0;
            this.lblLePhiTitle.Text = "Lệ phí quản lý & khám/năm:";
            // 
            // numLePhi
            // 
            this.numLePhi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.numLePhi.Increment = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numLePhi.Location = new System.Drawing.Point(190, 29);
            this.numLePhi.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            this.numLePhi.Name = "numLePhi";
            this.numLePhi.Size = new System.Drawing.Size(160, 25);
            this.numLePhi.TabIndex = 1;
            this.numLePhi.ThousandsSeparator = true;
            this.numLePhi.Value = new decimal(new int[] { 1500000, 0, 0, 0 });
            // 
            // chkDaDongPhi
            // 
            this.chkDaDongPhi.AutoSize = true;
            this.chkDaDongPhi.Checked = true;
            this.chkDaDongPhi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDaDongPhi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.chkDaDongPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.chkDaDongPhi.Location = new System.Drawing.Point(375, 31);
            this.chkDaDongPhi.Name = "chkDaDongPhi";
            this.chkDaDongPhi.Size = new System.Drawing.Size(370, 23);
            this.chkDaDongPhi.TabIndex = 2;
            this.chkDaDongPhi.Text = "ĐÃ THU ĐỦ LỆ PHÍ NĂM (Xác nhận cấp phát HSBA)";
            this.chkDaDongPhi.UseVisualStyleBackColor = true;
            // 
            // lblQuyDinhLePhi
            // 
            this.lblQuyDinhLePhi.AutoSize = true;
            this.lblQuyDinhLePhi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblQuyDinhLePhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuyDinhLePhi.Location = new System.Drawing.Point(20, 65);
            this.lblQuyDinhLePhi.Name = "lblQuyDinhLePhi";
            this.lblQuyDinhLePhi.Size = new System.Drawing.Size(635, 15);
            this.lblQuyDinhLePhi.TabIndex = 3;
            this.lblQuyDinhLePhi.Text = "* Nhờ thông tin phiếu đăng ký và lệ phí đóng 1 năm, bệnh nhân được phát Hồ sơ bệnh án và quyền lợi khám sức khỏe định kỳ theo quý.";
            // 
            // btnCapHSBA
            // 
            this.btnCapHSBA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.btnCapHSBA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapHSBA.ForeColor = System.Drawing.Color.White;
            this.btnCapHSBA.Location = new System.Drawing.Point(450, 90);
            this.btnCapHSBA.Name = "btnCapHSBA";
            this.btnCapHSBA.Size = new System.Drawing.Size(200, 38);
            this.btnCapHSBA.TabIndex = 4;
            this.btnCapHSBA.Text = "CẤP HỒ SƠ BỆNH ÁN";
            this.btnCapHSBA.UseVisualStyleBackColor = false;
            this.btnCapHSBA.Click += new System.EventHandler(this.btnCapHSBA_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.White;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Location = new System.Drawing.Point(660, 90);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 38);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmDangKy_CapHSBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.grpLePhi);
            this.Controls.Add(this.grpPhieuDK);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "FrmDangKy_CapHSBA";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng Ký Bệnh Nhân Lần Đầu & Cấp Hồ Sơ Bệnh Án";
            this.grpPhieuDK.ResumeLayout(false);
            this.grpPhieuDK.PerformLayout();
            this.grpLePhi.ResumeLayout(false);
            this.grpLePhi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLePhi)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

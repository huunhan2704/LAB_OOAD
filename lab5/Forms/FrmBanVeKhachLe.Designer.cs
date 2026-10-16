namespace QuanLyTour_VanHoaViet.Forms
{
    partial class FrmBanVeKhachLe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpKhachHang;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.GroupBox grpChuyenDi;
        private System.Windows.Forms.Label lblChonChuyen;
        private System.Windows.Forms.ComboBox cboChuyenDi;
        private System.Windows.Forms.Label lblGiaVeTitle;
        private System.Windows.Forms.Label lblGiaVeHienThi;
        private System.Windows.Forms.Label lblDiemBanVe;
        private System.Windows.Forms.ComboBox cboDiemBanVe;
        private System.Windows.Forms.Label lblDiemDon;
        private System.Windows.Forms.ComboBox cboDiemDonQuyDinh;
        private System.Windows.Forms.Label lblSoLuongVe;
        private System.Windows.Forms.NumericUpDown numSoLuongVe;
        private System.Windows.Forms.Label lblGhiChuKhachLe;
        private System.Windows.Forms.GroupBox grpThanhToan;
        private System.Windows.Forms.Label lblTongTienTitle;
        private System.Windows.Forms.Label lblTongThanhToan;
        private System.Windows.Forms.Label lblQuyDinhThanhToan;
        private System.Windows.Forms.Button btnXuatVe;
        private System.Windows.Forms.Button btnDong;

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
            this.grpKhachHang = new System.Windows.Forms.GroupBox();
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.grpChuyenDi = new System.Windows.Forms.GroupBox();
            this.lblChonChuyen = new System.Windows.Forms.Label();
            this.cboChuyenDi = new System.Windows.Forms.ComboBox();
            this.lblGiaVeTitle = new System.Windows.Forms.Label();
            this.lblGiaVeHienThi = new System.Windows.Forms.Label();
            this.lblDiemBanVe = new System.Windows.Forms.Label();
            this.cboDiemBanVe = new System.Windows.Forms.ComboBox();
            this.lblDiemDon = new System.Windows.Forms.Label();
            this.cboDiemDonQuyDinh = new System.Windows.Forms.ComboBox();
            this.lblSoLuongVe = new System.Windows.Forms.Label();
            this.numSoLuongVe = new System.Windows.Forms.NumericUpDown();
            this.lblGhiChuKhachLe = new System.Windows.Forms.Label();
            this.grpThanhToan = new System.Windows.Forms.GroupBox();
            this.lblTongTienTitle = new System.Windows.Forms.Label();
            this.lblTongThanhToan = new System.Windows.Forms.Label();
            this.lblQuyDinhThanhToan = new System.Windows.Forms.Label();
            this.btnXuatVe = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpKhachHang.SuspendLayout();
            this.grpChuyenDi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongVe)).BeginInit();
            this.grpThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(864, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁN VÉ TOUR KHÁCH LẺ THEO CHUYẾN (DÀNH CHO KHÁCH DƯỚI 12 NGƯỜI)";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpKhachHang
            // 
            this.grpKhachHang.Controls.Add(this.txtCCCD);
            this.grpKhachHang.Controls.Add(this.lblCCCD);
            this.grpKhachHang.Controls.Add(this.txtSoDienThoai);
            this.grpKhachHang.Controls.Add(this.lblSDT);
            this.grpKhachHang.Controls.Add(this.txtTenKhachHang);
            this.grpKhachHang.Controls.Add(this.lblTenKhach);
            this.grpKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpKhachHang.Location = new System.Drawing.Point(10, 65);
            this.grpKhachHang.Name = "grpKhachHang";
            this.grpKhachHang.Size = new System.Drawing.Size(864, 75);
            this.grpKhachHang.TabIndex = 1;
            this.grpKhachHang.TabStop = false;
            this.grpKhachHang.Text = "THÔNG TIN KHÁCH HÀNG (CÁ NHÂN / BẠN BÈ)";
            // 
            // lblTenKhach
            // 
            this.lblTenKhach.AutoSize = true;
            this.lblTenKhach.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTenKhach.Location = new System.Drawing.Point(15, 30);
            this.lblTenKhach.Name = "lblTenKhach";
            this.lblTenKhach.Size = new System.Drawing.Size(70, 17);
            this.lblTenKhach.TabIndex = 0;
            this.lblTenKhach.Text = "Họ và tên:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTenKhachHang.Location = new System.Drawing.Point(90, 27);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(220, 24);
            this.txtTenKhachHang.TabIndex = 1;
            this.txtTenKhachHang.Text = "Lê Thị Bích";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSDT.Location = new System.Drawing.Point(330, 30);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(70, 17);
            this.lblSDT.TabIndex = 2;
            this.lblSDT.Text = "Điện thoại:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSoDienThoai.Location = new System.Drawing.Point(405, 27);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(150, 24);
            this.txtSoDienThoai.TabIndex = 3;
            this.txtSoDienThoai.Text = "0912345678";
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCCCD.Location = new System.Drawing.Point(580, 30);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(65, 17);
            this.lblCCCD.TabIndex = 4;
            this.lblCCCD.Text = "Số CCCD:";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCCCD.Location = new System.Drawing.Point(650, 27);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(190, 24);
            this.txtCCCD.TabIndex = 5;
            this.txtCCCD.Text = "079192004567";
            // 
            // grpChuyenDi
            // 
            this.grpChuyenDi.Controls.Add(this.lblGhiChuKhachLe);
            this.grpChuyenDi.Controls.Add(this.numSoLuongVe);
            this.grpChuyenDi.Controls.Add(this.lblSoLuongVe);
            this.grpChuyenDi.Controls.Add(this.cboDiemDonQuyDinh);
            this.grpChuyenDi.Controls.Add(this.lblDiemDon);
            this.grpChuyenDi.Controls.Add(this.cboDiemBanVe);
            this.grpChuyenDi.Controls.Add(this.lblDiemBanVe);
            this.grpChuyenDi.Controls.Add(this.lblGiaVeHienThi);
            this.grpChuyenDi.Controls.Add(this.lblGiaVeTitle);
            this.grpChuyenDi.Controls.Add(this.cboChuyenDi);
            this.grpChuyenDi.Controls.Add(this.lblChonChuyen);
            this.grpChuyenDi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpChuyenDi.Location = new System.Drawing.Point(10, 150);
            this.grpChuyenDi.Name = "grpChuyenDi";
            this.grpChuyenDi.Size = new System.Drawing.Size(864, 185);
            this.grpChuyenDi.TabIndex = 2;
            this.grpChuyenDi.TabStop = false;
            this.grpChuyenDi.Text = "CHỌN CHUYẾN ĐI CỐ ĐỊNH, ĐIỂM BÁN VÉ VÀ ĐIỂM ĐÓN QUY ĐỊNH";
            // 
            // lblChonChuyen
            // 
            this.lblChonChuyen.AutoSize = true;
            this.lblChonChuyen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblChonChuyen.Location = new System.Drawing.Point(15, 30);
            this.lblChonChuyen.Name = "lblChonChuyen";
            this.lblChonChuyen.Size = new System.Drawing.Size(126, 17);
            this.lblChonChuyen.TabIndex = 0;
            this.lblChonChuyen.Text = "Chuyến đi theo lịch:";
            // 
            // cboChuyenDi
            // 
            this.cboChuyenDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyenDi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboChuyenDi.FormattingEnabled = true;
            this.cboChuyenDi.Items.AddRange(new object[] {
            "CHUYEN01: Nha Trang - Đà Lạt (Khởi hành: 20/10/2026 - Về: 24/10/2026)",
            "CHUYEN02: Nha Trang - Đà Lạt (Khởi hành: 28/10/2026 - Về: 01/11/2026)",
            "CHUYEN03: Đà Nẵng - Hội An - Huế (Khởi hành: 25/10/2026 - Về: 30/10/2026)",
            "CHUYEN04: Phú Quốc Biển Đảo (Khởi hành: 22/10/2026 - Về: 25/10/2026)"});
            this.cboChuyenDi.Location = new System.Drawing.Point(150, 27);
            this.cboChuyenDi.Name = "cboChuyenDi";
            this.cboChuyenDi.Size = new System.Drawing.Size(430, 24);
            this.cboChuyenDi.TabIndex = 1;
            this.cboChuyenDi.SelectedIndexChanged += new System.EventHandler(this.cboChuyenDi_SelectedIndexChanged);
            // 
            // lblGiaVeTitle
            // 
            this.lblGiaVeTitle.AutoSize = true;
            this.lblGiaVeTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblGiaVeTitle.Location = new System.Drawing.Point(600, 30);
            this.lblGiaVeTitle.Name = "lblGiaVeTitle";
            this.lblGiaVeTitle.Size = new System.Drawing.Size(49, 17);
            this.lblGiaVeTitle.TabIndex = 2;
            this.lblGiaVeTitle.Text = "Giá vé:";
            // 
            // lblGiaVeHienThi
            // 
            this.lblGiaVeHienThi.AutoSize = true;
            this.lblGiaVeHienThi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGiaVeHienThi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblGiaVeHienThi.Location = new System.Drawing.Point(655, 29);
            this.lblGiaVeHienThi.Name = "lblGiaVeHienThi";
            this.lblGiaVeHienThi.Size = new System.Drawing.Size(139, 19);
            this.lblGiaVeHienThi.TabIndex = 3;
            this.lblGiaVeHienThi.Text = "4,500,000 VNĐ / vé";
            // 
            // lblDiemBanVe
            // 
            this.lblDiemBanVe.AutoSize = true;
            this.lblDiemBanVe.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDiemBanVe.Location = new System.Drawing.Point(15, 70);
            this.lblDiemBanVe.Name = "lblDiemBanVe";
            this.lblDiemBanVe.Size = new System.Drawing.Size(124, 17);
            this.lblDiemBanVe.TabIndex = 4;
            this.lblDiemBanVe.Text = "Điểm bán vé gần ở:";
            // 
            // cboDiemBanVe
            // 
            this.cboDiemBanVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiemBanVe.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboDiemBanVe.FormattingEnabled = true;
            this.cboDiemBanVe.Items.AddRange(new object[] {
            "Phòng vé Trung tâm: 123 Lê Duẩn, Quận 1",
            "Đại lý bán vé Quận 5: 456 Trần Hưng Đạo, Quận 5",
            "Đại lý bán vé Gò Vấp: 789 Quang Trung, Gò Vấp",
            "Đại lý bán vé Thủ Đức: 102 Võ Văn Ngân, TP. Thủ Đức",
            "Đại lý bán vé Bình Thạnh: 88 Bạch Đằng, Bình Thạnh"});
            this.cboDiemBanVe.Location = new System.Drawing.Point(150, 67);
            this.cboDiemBanVe.Name = "cboDiemBanVe";
            this.cboDiemBanVe.Size = new System.Drawing.Size(430, 24);
            this.cboDiemBanVe.TabIndex = 5;
            // 
            // lblDiemDon
            // 
            this.lblDiemDon.AutoSize = true;
            this.lblDiemDon.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDiemDon.Location = new System.Drawing.Point(15, 110);
            this.lblDiemDon.Name = "lblDiemDon";
            this.lblDiemDon.Size = new System.Drawing.Size(126, 17);
            this.lblDiemDon.TabIndex = 6;
            this.lblDiemDon.Text = "Điểm đón QUY ĐỊNH:";
            // 
            // cboDiemDonQuyDinh
            // 
            this.cboDiemDonQuyDinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiemDonQuyDinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboDiemDonQuyDinh.FormattingEnabled = true;
            this.cboDiemDonQuyDinh.Items.AddRange(new object[] {
            "Trụ sở Công ty Du lịch Văn Hóa Việt (123 Lê Duẩn, Q.1)",
            "Bến xe Miền Đông mới (TP. Thủ Đức)",
            "Bến xe Miền Tây (Quận Bình Tân)",
            "Cây xăng Hàng Xanh (Quận Bình Thạnh)",
            "Sân bay Quốc tế Tân Sơn Nhất (Ga quốc nội)"});
            this.cboDiemDonQuyDinh.Location = new System.Drawing.Point(150, 107);
            this.cboDiemDonQuyDinh.Name = "cboDiemDonQuyDinh";
            this.cboDiemDonQuyDinh.Size = new System.Drawing.Size(430, 24);
            this.cboDiemDonQuyDinh.TabIndex = 7;
            // 
            // lblSoLuongVe
            // 
            this.lblSoLuongVe.AutoSize = true;
            this.lblSoLuongVe.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSoLuongVe.Location = new System.Drawing.Point(600, 70);
            this.lblSoLuongVe.Name = "lblSoLuongVe";
            this.lblSoLuongVe.Size = new System.Drawing.Size(84, 17);
            this.lblSoLuongVe.TabIndex = 8;
            this.lblSoLuongVe.Text = "Số lượng vé:";
            // 
            // numSoLuongVe
            // 
            this.numSoLuongVe.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.numSoLuongVe.Location = new System.Drawing.Point(690, 67);
            this.numSoLuongVe.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            this.numSoLuongVe.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoLuongVe.Name = "numSoLuongVe";
            this.numSoLuongVe.Size = new System.Drawing.Size(70, 24);
            this.numSoLuongVe.TabIndex = 9;
            this.numSoLuongVe.Value = new decimal(new int[] { 2, 0, 0, 0 });
            this.numSoLuongVe.ValueChanged += new System.EventHandler(this.numSoLuongVe_ValueChanged);
            // 
            // lblGhiChuKhachLe
            // 
            this.lblGhiChuKhachLe.AutoSize = true;
            this.lblGhiChuKhachLe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblGhiChuKhachLe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGhiChuKhachLe.Location = new System.Drawing.Point(15, 150);
            this.lblGhiChuKhachLe.Name = "lblGhiChuKhachLe";
            this.lblGhiChuKhachLe.Size = new System.Drawing.Size(680, 15);
            this.lblGhiChuKhachLe.TabIndex = 10;
            this.lblGhiChuKhachLe.Text = "* Quy định: Khách lẻ đăng ký dưới 12 người, đi theo chuyến cố định có ngày đi/về của công ty, đón tại điểm đón theo quy định.";
            // 
            // grpThanhToan
            // 
            this.grpThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.grpThanhToan.Controls.Add(this.btnDong);
            this.grpThanhToan.Controls.Add(this.btnXuatVe);
            this.grpThanhToan.Controls.Add(this.lblQuyDinhThanhToan);
            this.grpThanhToan.Controls.Add(this.lblTongThanhToan);
            this.grpThanhToan.Controls.Add(this.lblTongTienTitle);
            this.grpThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThanhToan.Location = new System.Drawing.Point(10, 350);
            this.grpThanhToan.Name = "grpThanhToan";
            this.grpThanhToan.Size = new System.Drawing.Size(864, 110);
            this.grpThanhToan.TabIndex = 3;
            this.grpThanhToan.TabStop = false;
            this.grpThanhToan.Text = "THANH TOÁN TIỀN VÉ DU LỊCH";
            // 
            // lblTongTienTitle
            // 
            this.lblTongTienTitle.AutoSize = true;
            this.lblTongTienTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTongTienTitle.Location = new System.Drawing.Point(15, 30);
            this.lblTongTienTitle.Name = "lblTongTienTitle";
            this.lblTongTienTitle.Size = new System.Drawing.Size(158, 19);
            this.lblTongTienTitle.TabIndex = 0;
            this.lblTongTienTitle.Text = "Tổng tiền THANH TOÁN:";
            // 
            // lblTongThanhToan
            // 
            this.lblTongThanhToan.AutoSize = true;
            this.lblTongThanhToan.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.lblTongThanhToan.Location = new System.Drawing.Point(180, 26);
            this.lblTongThanhToan.Name = "lblTongThanhToan";
            this.lblTongThanhToan.Size = new System.Drawing.Size(153, 25);
            this.lblTongThanhToan.TabIndex = 1;
            this.lblTongThanhToan.Text = "9,000,000 VNĐ";
            // 
            // lblQuyDinhThanhToan
            // 
            this.lblQuyDinhThanhToan.AutoSize = true;
            this.lblQuyDinhThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblQuyDinhThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuyDinhThanhToan.Location = new System.Drawing.Point(15, 65);
            this.lblQuyDinhThanhToan.Name = "lblQuyDinhThanhToan";
            this.lblQuyDinhThanhToan.Size = new System.Drawing.Size(560, 15);
            this.lblQuyDinhThanhToan.TabIndex = 2;
            this.lblQuyDinhThanhToan.Text = "* Khách lẻ đi theo chuyến thì mua và thanh toán 100% tiền vé ngay cho tour đó (xuất vé điện tử).";
            // 
            // btnXuatVe
            // 
            this.btnXuatVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.btnXuatVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatVe.ForeColor = System.Drawing.Color.White;
            this.btnXuatVe.Location = new System.Drawing.Point(580, 25);
            this.btnXuatVe.Name = "btnXuatVe";
            this.btnXuatVe.Size = new System.Drawing.Size(150, 45);
            this.btnXuatVe.TabIndex = 3;
            this.btnXuatVe.Text = "XUẤT VÉ & THU TIỀN";
            this.btnXuatVe.UseVisualStyleBackColor = false;
            this.btnXuatVe.Click += new System.EventHandler(this.btnXuatVe_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.White;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Location = new System.Drawing.Point(740, 25);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 45);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmBanVeKhachLe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 480);
            this.Controls.Add(this.grpThanhToan);
            this.Controls.Add(this.grpChuyenDi);
            this.Controls.Add(this.grpKhachHang);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "FrmBanVeKhachLe";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bán Vé Tour Khách Lẻ (<= 12 Người)";
            this.grpKhachHang.ResumeLayout(false);
            this.grpKhachHang.PerformLayout();
            this.grpChuyenDi.ResumeLayout(false);
            this.grpChuyenDi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongVe)).EndInit();
            this.grpThanhToan.ResumeLayout(false);
            this.grpThanhToan.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}

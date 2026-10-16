namespace QuanLyTour_VanHoaViet.Forms
{
    partial class FrmDangKyTourDoan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpThongTinDoan;
        private System.Windows.Forms.Label lblTenCoQuan;
        private System.Windows.Forms.TextBox txtTenCoQuan;
        private System.Windows.Forms.Label lblNguoiDaiDien;
        private System.Windows.Forms.TextBox txtNguoiDaiDien;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.GroupBox grpTourDoan;
        private System.Windows.Forms.Label lblChonTour;
        private System.Windows.Forms.ComboBox cboTour;
        private System.Windows.Forms.Label lblDonGiaTitle;
        private System.Windows.Forms.Label lblDonGiaDisplay;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayDi;
        private System.Windows.Forms.Label lblSoNguoi;
        private System.Windows.Forms.NumericUpDown numSoNguoiDi;
        private System.Windows.Forms.Label lblCanhBaoSoNguoi;
        private System.Windows.Forms.Label lblDiemDon;
        private System.Windows.Forms.TextBox txtDiemDon;
        private System.Windows.Forms.CheckBox chkMuaBaoHiem;
        private System.Windows.Forms.Panel pnlBaoHiem;
        private System.Windows.Forms.Label lblBaoHiemStatus;
        private System.Windows.Forms.DataGridView dgvDanhSachBaoHiem;
        private System.Windows.Forms.GroupBox grpThanhToan;
        private System.Windows.Forms.Label lblTongChiPhiTitle;
        private System.Windows.Forms.Label lblTongChiPhi;
        private System.Windows.Forms.Label lblTienDatCocTitle;
        private System.Windows.Forms.Label lblTienDatCoc;
        private System.Windows.Forms.Label lblQuyDinhCoc;
        private System.Windows.Forms.Button btnLuuPhieu;
        private System.Windows.Forms.Button btnHuy;

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
            this.grpThongTinDoan = new System.Windows.Forms.GroupBox();
            this.lblTenCoQuan = new System.Windows.Forms.Label();
            this.txtTenCoQuan = new System.Windows.Forms.TextBox();
            this.lblNguoiDaiDien = new System.Windows.Forms.Label();
            this.txtNguoiDaiDien = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.grpTourDoan = new System.Windows.Forms.GroupBox();
            this.lblChonTour = new System.Windows.Forms.Label();
            this.cboTour = new System.Windows.Forms.ComboBox();
            this.lblDonGiaTitle = new System.Windows.Forms.Label();
            this.lblDonGiaDisplay = new System.Windows.Forms.Label();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.dtpNgayDi = new System.Windows.Forms.DateTimePicker();
            this.lblSoNguoi = new System.Windows.Forms.Label();
            this.numSoNguoiDi = new System.Windows.Forms.NumericUpDown();
            this.lblCanhBaoSoNguoi = new System.Windows.Forms.Label();
            this.lblDiemDon = new System.Windows.Forms.Label();
            this.txtDiemDon = new System.Windows.Forms.TextBox();
            this.chkMuaBaoHiem = new System.Windows.Forms.CheckBox();
            this.pnlBaoHiem = new System.Windows.Forms.Panel();
            this.lblBaoHiemStatus = new System.Windows.Forms.Label();
            this.dgvDanhSachBaoHiem = new System.Windows.Forms.DataGridView();
            this.grpThanhToan = new System.Windows.Forms.GroupBox();
            this.lblTongChiPhiTitle = new System.Windows.Forms.Label();
            this.lblTongChiPhi = new System.Windows.Forms.Label();
            this.lblTienDatCocTitle = new System.Windows.Forms.Label();
            this.lblTienDatCoc = new System.Windows.Forms.Label();
            this.lblQuyDinhCoc = new System.Windows.Forms.Label();
            this.btnLuuPhieu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.grpThongTinDoan.SuspendLayout();
            this.grpTourDoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoiDi)).BeginInit();
            this.pnlBaoHiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBaoHiem)).BeginInit();
            this.grpThanhToan.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(964, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PHIẾU ĐĂNG KÝ TOUR THEO ĐOÀN (DÀNH CHO ĐOÀN TRÊN 12 NGƯỜI)";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpThongTinDoan
            // 
            this.grpThongTinDoan.Controls.Add(this.txtDienThoai);
            this.grpThongTinDoan.Controls.Add(this.lblDienThoai);
            this.grpThongTinDoan.Controls.Add(this.txtDiaChi);
            this.grpThongTinDoan.Controls.Add(this.lblDiaChi);
            this.grpThongTinDoan.Controls.Add(this.txtNguoiDaiDien);
            this.grpThongTinDoan.Controls.Add(this.lblNguoiDaiDien);
            this.grpThongTinDoan.Controls.Add(this.txtTenCoQuan);
            this.grpThongTinDoan.Controls.Add(this.lblTenCoQuan);
            this.grpThongTinDoan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTinDoan.Location = new System.Drawing.Point(10, 65);
            this.grpThongTinDoan.Name = "grpThongTinDoan";
            this.grpThongTinDoan.Size = new System.Drawing.Size(964, 100);
            this.grpThongTinDoan.TabIndex = 1;
            this.grpThongTinDoan.TabStop = false;
            this.grpThongTinDoan.Text = "THÔNG TIN CƠ QUAN / ĐẠI DIỆN GIA ĐÌNH";
            // 
            // lblTenCoQuan
            // 
            this.lblTenCoQuan.AutoSize = true;
            this.lblTenCoQuan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTenCoQuan.Location = new System.Drawing.Point(15, 30);
            this.lblTenCoQuan.Name = "lblTenCoQuan";
            this.lblTenCoQuan.Size = new System.Drawing.Size(83, 17);
            this.lblTenCoQuan.TabIndex = 0;
            this.lblTenCoQuan.Text = "Tên Cơ quan:";
            // 
            // txtTenCoQuan
            // 
            this.txtTenCoQuan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTenCoQuan.Location = new System.Drawing.Point(105, 27);
            this.txtTenCoQuan.Name = "txtTenCoQuan";
            this.txtTenCoQuan.Size = new System.Drawing.Size(350, 24);
            this.txtTenCoQuan.TabIndex = 1;
            this.txtTenCoQuan.Text = "Công ty Cổ phần Công nghệ ABC";
            // 
            // lblNguoiDaiDien
            // 
            this.lblNguoiDaiDien.AutoSize = true;
            this.lblNguoiDaiDien.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNguoiDaiDien.Location = new System.Drawing.Point(480, 30);
            this.lblNguoiDaiDien.Name = "lblNguoiDaiDien";
            this.lblNguoiDaiDien.Size = new System.Drawing.Size(99, 17);
            this.lblNguoiDaiDien.TabIndex = 2;
            this.lblNguoiDaiDien.Text = "Người đại diện:";
            // 
            // txtNguoiDaiDien
            // 
            this.txtNguoiDaiDien.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNguoiDaiDien.Location = new System.Drawing.Point(585, 27);
            this.txtNguoiDaiDien.Name = "txtNguoiDaiDien";
            this.txtNguoiDaiDien.Size = new System.Drawing.Size(350, 24);
            this.txtNguoiDaiDien.TabIndex = 3;
            this.txtNguoiDaiDien.Text = "Nguyễn Văn Hùng";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDiaChi.Location = new System.Drawing.Point(15, 65);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(50, 17);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDiaChi.Location = new System.Drawing.Point(105, 62);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(350, 24);
            this.txtDiaChi.TabIndex = 5;
            this.txtDiaChi.Text = "123 Điện Biên Phủ, P.15, Q. Bình Thạnh, TP.HCM";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDienThoai.Location = new System.Drawing.Point(480, 65);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(70, 17);
            this.lblDienThoai.TabIndex = 6;
            this.lblDienThoai.Text = "Điện thoại:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDienThoai.Location = new System.Drawing.Point(585, 62);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(350, 24);
            this.txtDienThoai.TabIndex = 7;
            this.txtDienThoai.Text = "0908123456";
            // 
            // grpTourDoan
            // 
            this.grpTourDoan.Controls.Add(this.txtDiemDon);
            this.grpTourDoan.Controls.Add(this.lblDiemDon);
            this.grpTourDoan.Controls.Add(this.lblCanhBaoSoNguoi);
            this.grpTourDoan.Controls.Add(this.numSoNguoiDi);
            this.grpTourDoan.Controls.Add(this.lblSoNguoi);
            this.grpTourDoan.Controls.Add(this.dtpNgayDi);
            this.grpTourDoan.Controls.Add(this.lblNgayDi);
            this.grpTourDoan.Controls.Add(this.lblDonGiaDisplay);
            this.grpTourDoan.Controls.Add(this.lblDonGiaTitle);
            this.grpTourDoan.Controls.Add(this.cboTour);
            this.grpTourDoan.Controls.Add(this.lblChonTour);
            this.grpTourDoan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpTourDoan.Location = new System.Drawing.Point(10, 175);
            this.grpTourDoan.Name = "grpTourDoan";
            this.grpTourDoan.Size = new System.Drawing.Size(964, 135);
            this.grpTourDoan.TabIndex = 2;
            this.grpTourDoan.TabStop = false;
            this.grpTourDoan.Text = "ĐĂNG KÝ TOUR VÀ LỊCH TRÌNH TỰ CHỌN";
            // 
            // lblChonTour
            // 
            this.lblChonTour.AutoSize = true;
            this.lblChonTour.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblChonTour.Location = new System.Drawing.Point(15, 30);
            this.lblChonTour.Name = "lblChonTour";
            this.lblChonTour.Size = new System.Drawing.Size(73, 17);
            this.lblChonTour.TabIndex = 0;
            this.lblChonTour.Text = "Chọn Tour:";
            // 
            // cboTour
            // 
            this.cboTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTour.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboTour.FormattingEnabled = true;
            this.cboTour.Items.AddRange(new object[] {
            "TOUR001 - TP.HCM - Nha Trang - Đà Lạt (4N3Đ)",
            "TOUR002 - TP.HCM - Đà Nẵng - Hội An - Huế (5N4Đ)",
            "TOUR003 - TP.HCM - Phú Quốc Thiên Đường Biển (3N2Đ)",
            "TOUR004 - TP.HCM - Cần Thơ - Cà Mau Miền Tây (3N2Đ)"});
            this.cboTour.Location = new System.Drawing.Point(105, 27);
            this.cboTour.Name = "cboTour";
            this.cboTour.Size = new System.Drawing.Size(420, 24);
            this.cboTour.TabIndex = 1;
            this.cboTour.SelectedIndexChanged += new System.EventHandler(this.cboTour_SelectedIndexChanged);
            // 
            // lblDonGiaTitle
            // 
            this.lblDonGiaTitle.AutoSize = true;
            this.lblDonGiaTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDonGiaTitle.Location = new System.Drawing.Point(560, 30);
            this.lblDonGiaTitle.Name = "lblDonGiaTitle";
            this.lblDonGiaTitle.Size = new System.Drawing.Size(57, 17);
            this.lblDonGiaTitle.TabIndex = 2;
            this.lblDonGiaTitle.Text = "Đơn giá:";
            // 
            // lblDonGiaDisplay
            // 
            this.lblDonGiaDisplay.AutoSize = true;
            this.lblDonGiaDisplay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDonGiaDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblDonGiaDisplay.Location = new System.Drawing.Point(625, 29);
            this.lblDonGiaDisplay.Name = "lblDonGiaDisplay";
            this.lblDonGiaDisplay.Size = new System.Drawing.Size(155, 19);
            this.lblDonGiaDisplay.TabIndex = 3;
            this.lblDonGiaDisplay.Text = "4,500,000 VNĐ / khách";
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNgayDi.Location = new System.Drawing.Point(15, 68);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(130, 17);
            this.lblNgayDi.TabIndex = 4;
            this.lblNgayDi.Text = "Ngày đi (TỰ CHỌN):";
            // 
            // dtpNgayDi
            // 
            this.dtpNgayDi.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDi.Location = new System.Drawing.Point(155, 64);
            this.dtpNgayDi.Name = "dtpNgayDi";
            this.dtpNgayDi.Size = new System.Drawing.Size(130, 24);
            this.dtpNgayDi.TabIndex = 5;
            // 
            // lblSoNguoi
            // 
            this.lblSoNguoi.AutoSize = true;
            this.lblSoNguoi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSoNguoi.Location = new System.Drawing.Point(310, 68);
            this.lblSoNguoi.Name = "lblSoNguoi";
            this.lblSoNguoi.Size = new System.Drawing.Size(117, 17);
            this.lblSoNguoi.TabIndex = 6;
            this.lblSoNguoi.Text = "Số người (>12 ng):";
            // 
            // numSoNguoiDi
            // 
            this.numSoNguoiDi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.numSoNguoiDi.Location = new System.Drawing.Point(435, 64);
            this.numSoNguoiDi.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            this.numSoNguoiDi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoNguoiDi.Name = "numSoNguoiDi";
            this.numSoNguoiDi.Size = new System.Drawing.Size(90, 24);
            this.numSoNguoiDi.TabIndex = 7;
            this.numSoNguoiDi.Value = new decimal(new int[] { 25, 0, 0, 0 });
            this.numSoNguoiDi.ValueChanged += new System.EventHandler(this.numSoNguoiDi_ValueChanged);
            // 
            // lblCanhBaoSoNguoi
            // 
            this.lblCanhBaoSoNguoi.AutoSize = true;
            this.lblCanhBaoSoNguoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblCanhBaoSoNguoi.ForeColor = System.Drawing.Color.Red;
            this.lblCanhBaoSoNguoi.Location = new System.Drawing.Point(540, 68);
            this.lblCanhBaoSoNguoi.Name = "lblCanhBaoSoNguoi";
            this.lblCanhBaoSoNguoi.Size = new System.Drawing.Size(340, 15);
            this.lblCanhBaoSoNguoi.TabIndex = 8;
            this.lblCanhBaoSoNguoi.Text = "Hợp lệ: Khách đoàn đi trên 12 người";
            // 
            // lblDiemDon
            // 
            this.lblDiemDon.AutoSize = true;
            this.lblDiemDon.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDiemDon.Location = new System.Drawing.Point(15, 102);
            this.lblDiemDon.Name = "lblDiemDon";
            this.lblDiemDon.Size = new System.Drawing.Size(185, 17);
            this.lblDiemDon.TabIndex = 9;
            this.lblDiemDon.Text = "Điểm đón xe THEO YÊU CẦU:";
            // 
            // txtDiemDon
            // 
            this.txtDiemDon.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDiemDon.Location = new System.Drawing.Point(210, 99);
            this.txtDiemDon.Name = "txtDiemDon";
            this.txtDiemDon.Size = new System.Drawing.Size(725, 24);
            this.txtDiemDon.TabIndex = 10;
            this.txtDiemDon.Text = "Tại trụ sở Công ty ABC: Số 123 Điện Biên Phủ, P.15, Q. Bình Thạnh";
            // 
            // chkMuaBaoHiem
            // 
            this.chkMuaBaoHiem.AutoSize = true;
            this.chkMuaBaoHiem.Checked = true;
            this.chkMuaBaoHiem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMuaBaoHiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.chkMuaBaoHiem.Location = new System.Drawing.Point(15, 320);
            this.chkMuaBaoHiem.Name = "chkMuaBaoHiem";
            this.chkMuaBaoHiem.Size = new System.Drawing.Size(380, 23);
            this.chkMuaBaoHiem.TabIndex = 3;
            this.chkMuaBaoHiem.Text = "Có mua Bảo hiểm Du lịch (kèm danh sách người cùng đi)";
            this.chkMuaBaoHiem.UseVisualStyleBackColor = true;
            this.chkMuaBaoHiem.CheckedChanged += new System.EventHandler(this.chkMuaBaoHiem_CheckedChanged);
            // 
            // pnlBaoHiem
            // 
            this.pnlBaoHiem.Controls.Add(this.dgvDanhSachBaoHiem);
            this.pnlBaoHiem.Controls.Add(this.lblBaoHiemStatus);
            this.pnlBaoHiem.Location = new System.Drawing.Point(10, 345);
            this.pnlBaoHiem.Name = "pnlBaoHiem";
            this.pnlBaoHiem.Size = new System.Drawing.Size(964, 150);
            this.pnlBaoHiem.TabIndex = 4;
            // 
            // lblBaoHiemStatus
            // 
            this.lblBaoHiemStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaoHiemStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblBaoHiemStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBaoHiemStatus.Location = new System.Drawing.Point(0, 0);
            this.lblBaoHiemStatus.Name = "lblBaoHiemStatus";
            this.lblBaoHiemStatus.Size = new System.Drawing.Size(964, 25);
            this.lblBaoHiemStatus.TabIndex = 0;
            this.lblBaoHiemStatus.Text = "Danh sách những người cùng đi để công ty mua bảo hiểm du lịch:";
            // 
            // dgvDanhSachBaoHiem
            // 
            this.dgvDanhSachBaoHiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachBaoHiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachBaoHiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBaoHiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachBaoHiem.Location = new System.Drawing.Point(0, 25);
            this.dgvDanhSachBaoHiem.Name = "dgvDanhSachBaoHiem";
            this.dgvDanhSachBaoHiem.Size = new System.Drawing.Size(964, 125);
            this.dgvDanhSachBaoHiem.TabIndex = 1;
            // 
            // grpThanhToan
            // 
            this.grpThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.grpThanhToan.Controls.Add(this.btnHuy);
            this.grpThanhToan.Controls.Add(this.btnLuuPhieu);
            this.grpThanhToan.Controls.Add(this.lblQuyDinhCoc);
            this.grpThanhToan.Controls.Add(this.lblTienDatCoc);
            this.grpThanhToan.Controls.Add(this.lblTienDatCocTitle);
            this.grpThanhToan.Controls.Add(this.lblTongChiPhi);
            this.grpThanhToan.Controls.Add(this.lblTongChiPhiTitle);
            this.grpThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThanhToan.Location = new System.Drawing.Point(10, 505);
            this.grpThanhToan.Name = "grpThanhToan";
            this.grpThanhToan.Size = new System.Drawing.Size(964, 110);
            this.grpThanhToan.TabIndex = 5;
            this.grpThanhToan.TabStop = false;
            this.grpThanhToan.Text = "KINH PHÍ VÀ ĐẶT CỌC TOUR ĐOÀN";
            // 
            // lblTongChiPhiTitle
            // 
            this.lblTongChiPhiTitle.AutoSize = true;
            this.lblTongChiPhiTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTongChiPhiTitle.Location = new System.Drawing.Point(15, 30);
            this.lblTongChiPhiTitle.Name = "lblTongChiPhiTitle";
            this.lblTongChiPhiTitle.Size = new System.Drawing.Size(126, 17);
            this.lblTongChiPhiTitle.TabIndex = 0;
            this.lblTongChiPhiTitle.Text = "Tổng chi phí dự kiến:";
            // 
            // lblTongChiPhi
            // 
            this.lblTongChiPhi.AutoSize = true;
            this.lblTongChiPhi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongChiPhi.Location = new System.Drawing.Point(150, 26);
            this.lblTongChiPhi.Name = "lblTongChiPhi";
            this.lblTongChiPhi.Size = new System.Drawing.Size(148, 21);
            this.lblTongChiPhi.TabIndex = 1;
            this.lblTongChiPhi.Text = "112,500,000 VNĐ";
            // 
            // lblTienDatCocTitle
            // 
            this.lblTienDatCocTitle.AutoSize = true;
            this.lblTienDatCocTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTienDatCocTitle.Location = new System.Drawing.Point(340, 30);
            this.lblTienDatCocTitle.Name = "lblTienDatCocTitle";
            this.lblTienDatCocTitle.Size = new System.Drawing.Size(137, 17);
            this.lblTienDatCocTitle.TabIndex = 2;
            this.lblTienDatCocTitle.Text = "Tiền cọc PHẢI NỘP:";
            // 
            // lblTienDatCoc
            // 
            this.lblTienDatCoc.AutoSize = true;
            this.lblTienDatCoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTienDatCoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTienDatCoc.Location = new System.Drawing.Point(485, 26);
            this.lblTienDatCoc.Name = "lblTienDatCoc";
            this.lblTienDatCoc.Size = new System.Drawing.Size(185, 21);
            this.lblTienDatCoc.TabIndex = 3;
            this.lblTienDatCoc.Text = "33,750,000 VNĐ (30%)";
            // 
            // lblQuyDinhCoc
            // 
            this.lblQuyDinhCoc.AutoSize = true;
            this.lblQuyDinhCoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblQuyDinhCoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblQuyDinhCoc.Location = new System.Drawing.Point(15, 65);
            this.lblQuyDinhCoc.Name = "lblQuyDinhCoc";
            this.lblQuyDinhCoc.Size = new System.Drawing.Size(640, 15);
            this.lblQuyDinhCoc.TabIndex = 4;
            this.lblQuyDinhCoc.Text = "* Quy định: Khách đặt cọc trước khoản tiền này, nếu không đi sẽ MẤT CỌC. Kinh phí còn lại thanh toán sau khi kết thúc tour.";
            // 
            // btnLuuPhieu
            // 
            this.btnLuuPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.btnLuuPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuPhieu.ForeColor = System.Drawing.Color.White;
            this.btnLuuPhieu.Location = new System.Drawing.Point(680, 25);
            this.btnLuuPhieu.Name = "btnLuuPhieu";
            this.btnLuuPhieu.Size = new System.Drawing.Size(150, 45);
            this.btnLuuPhieu.TabIndex = 5;
            this.btnLuuPhieu.Text = "LẬP PHIẾU ĐOÀN";
            this.btnLuuPhieu.UseVisualStyleBackColor = false;
            this.btnLuuPhieu.Click += new System.EventHandler(this.btnLuuPhieu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Location = new System.Drawing.Point(840, 25);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 45);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FrmDangKyTourDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 630);
            this.Controls.Add(this.grpThanhToan);
            this.Controls.Add(this.pnlBaoHiem);
            this.Controls.Add(this.chkMuaBaoHiem);
            this.Controls.Add(this.grpTourDoan);
            this.Controls.Add(this.grpThongTinDoan);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "FrmDangKyTourDoan";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lập Phiếu Đăng Ký Tour Theo Đoàn (> 12 Người)";
            this.grpThongTinDoan.ResumeLayout(false);
            this.grpThongTinDoan.PerformLayout();
            this.grpTourDoan.ResumeLayout(false);
            this.grpTourDoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoiDi)).EndInit();
            this.pnlBaoHiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBaoHiem)).EndInit();
            this.grpThanhToan.ResumeLayout(false);
            this.grpThanhToan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

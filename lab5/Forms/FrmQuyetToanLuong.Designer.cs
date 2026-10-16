namespace QuanLyTour_VanHoaViet.Forms
{
    partial class FrmQuyetToanLuong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabQuyetToan;
        private System.Windows.Forms.TabPage tabKhaoSat;
        private System.Windows.Forms.TabPage tabTinhLuong;
        private System.Windows.Forms.GroupBox grpQuyetToanDoan;
        private System.Windows.Forms.Label lblDoan;
        private System.Windows.Forms.ComboBox cboDoanQuyetToan;
        private System.Windows.Forms.Label lblTongKinhPhiGocTitle;
        private System.Windows.Forms.Label lblTongKinhPhiGoc;
        private System.Windows.Forms.Label lblDaDatCocTitle;
        private System.Windows.Forms.Label lblDaDatCoc;
        private System.Windows.Forms.Label lblPhatSinh;
        private System.Windows.Forms.NumericUpDown numPhatSinh;
        private System.Windows.Forms.Label lblConLaiTitle;
        private System.Windows.Forms.Label lblConLaiPhaiThu;
        private System.Windows.Forms.Button btnXacNhanQuyetToan;
        private System.Windows.Forms.Label lblGhiChuQuyetToan;
        private System.Windows.Forms.GroupBox grpKhaoSat;
        private System.Windows.Forms.Label lblKhachKS;
        private System.Windows.Forms.ComboBox cboKhachKhaoSat;
        private System.Windows.Forms.Label lblTourKS;
        private System.Windows.Forms.ComboBox cboTourKhaoSat;
        private System.Windows.Forms.Label lblNoiAn;
        private System.Windows.Forms.ComboBox cboNoiAn;
        private System.Windows.Forms.Label lblKhachSan;
        private System.Windows.Forms.ComboBox cboKhachSan;
        private System.Windows.Forms.Label lblPhuongTien;
        private System.Windows.Forms.ComboBox cboPhuongTien;
        private System.Windows.Forms.Label lblHDVRate;
        private System.Windows.Forms.ComboBox cboHDVRating;
        private System.Windows.Forms.Label lblGopY;
        private System.Windows.Forms.TextBox txtGopY;
        private System.Windows.Forms.Button btnGuiKhaoSat;
        private System.Windows.Forms.DataGridView dgvLichSuKhaoSat;
        private System.Windows.Forms.GroupBox grpHDVLuong;
        private System.Windows.Forms.Label lblChonHDV;
        private System.Windows.Forms.ComboBox cboHDV;
        private System.Windows.Forms.Label lblThangLuong;
        private System.Windows.Forms.ComboBox cboThangLuong;
        private System.Windows.Forms.Label lblLuongCBTitle;
        private System.Windows.Forms.Label lblLuongCanBan;
        private System.Windows.Forms.Label lblTongThuLaoTitle;
        private System.Windows.Forms.Label lblTongThuLaoTour;
        private System.Windows.Forms.Label lblTongThucLinhTitle;
        private System.Windows.Forms.Label lblTongThucLinh;
        private System.Windows.Forms.DataGridView dgvTourThucHien;
        private System.Windows.Forms.Button btnInPhieuLuong;
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabQuyetToan = new System.Windows.Forms.TabPage();
            this.grpQuyetToanDoan = new System.Windows.Forms.GroupBox();
            this.lblGhiChuQuyetToan = new System.Windows.Forms.Label();
            this.btnXacNhanQuyetToan = new System.Windows.Forms.Button();
            this.lblConLaiPhaiThu = new System.Windows.Forms.Label();
            this.lblConLaiTitle = new System.Windows.Forms.Label();
            this.numPhatSinh = new System.Windows.Forms.NumericUpDown();
            this.lblPhatSinh = new System.Windows.Forms.Label();
            this.lblDaDatCoc = new System.Windows.Forms.Label();
            this.lblDaDatCocTitle = new System.Windows.Forms.Label();
            this.lblTongKinhPhiGoc = new System.Windows.Forms.Label();
            this.lblTongKinhPhiGocTitle = new System.Windows.Forms.Label();
            this.cboDoanQuyetToan = new System.Windows.Forms.ComboBox();
            this.lblDoan = new System.Windows.Forms.Label();
            this.tabKhaoSat = new System.Windows.Forms.TabPage();
            this.dgvLichSuKhaoSat = new System.Windows.Forms.DataGridView();
            this.grpKhaoSat = new System.Windows.Forms.GroupBox();
            this.btnGuiKhaoSat = new System.Windows.Forms.Button();
            this.txtGopY = new System.Windows.Forms.TextBox();
            this.lblGopY = new System.Windows.Forms.Label();
            this.cboHDVRating = new System.Windows.Forms.ComboBox();
            this.lblHDVRate = new System.Windows.Forms.Label();
            this.cboPhuongTien = new System.Windows.Forms.ComboBox();
            this.lblPhuongTien = new System.Windows.Forms.Label();
            this.cboKhachSan = new System.Windows.Forms.ComboBox();
            this.lblKhachSan = new System.Windows.Forms.Label();
            this.cboNoiAn = new System.Windows.Forms.ComboBox();
            this.lblNoiAn = new System.Windows.Forms.Label();
            this.cboTourKhaoSat = new System.Windows.Forms.ComboBox();
            this.lblTourKS = new System.Windows.Forms.Label();
            this.cboKhachKhaoSat = new System.Windows.Forms.ComboBox();
            this.lblKhachKS = new System.Windows.Forms.Label();
            this.tabTinhLuong = new System.Windows.Forms.TabPage();
            this.btnInPhieuLuong = new System.Windows.Forms.Button();
            this.dgvTourThucHien = new System.Windows.Forms.DataGridView();
            this.grpHDVLuong = new System.Windows.Forms.GroupBox();
            this.lblTongThucLinh = new System.Windows.Forms.Label();
            this.lblTongThucLinhTitle = new System.Windows.Forms.Label();
            this.lblTongThuLaoTour = new System.Windows.Forms.Label();
            this.lblTongThuLaoTitle = new System.Windows.Forms.Label();
            this.lblLuongCanBan = new System.Windows.Forms.Label();
            this.lblLuongCBTitle = new System.Windows.Forms.Label();
            this.cboThangLuong = new System.Windows.Forms.ComboBox();
            this.lblThangLuong = new System.Windows.Forms.Label();
            this.cboHDV = new System.Windows.Forms.ComboBox();
            this.lblChonHDV = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabQuyetToan.SuspendLayout();
            this.grpQuyetToanDoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhatSinh)).BeginInit();
            this.tabKhaoSat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuKhaoSat)).BeginInit();
            this.grpKhaoSat.SuspendLayout();
            this.tabTinhLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourThucHien)).BeginInit();
            this.grpHDVLuong.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(964, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUYẾT TOÁN ĐOÀN - KHẢO SÁT CHẤT LƯỢNG - TÍNH LƯƠNG HƯỚNG DẪN VIÊN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabQuyetToan);
            this.tabMain.Controls.Add(this.tabKhaoSat);
            this.tabMain.Controls.Add(this.tabTinhLuong);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabMain.Location = new System.Drawing.Point(10, 55);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(964, 520);
            this.tabMain.TabIndex = 1;
            // 
            // tabQuyetToan
            // 
            this.tabQuyetToan.Controls.Add(this.grpQuyetToanDoan);
            this.tabQuyetToan.Location = new System.Drawing.Point(4, 26);
            this.tabQuyetToan.Name = "tabQuyetToan";
            this.tabQuyetToan.Padding = new System.Windows.Forms.Padding(10);
            this.tabQuyetToan.Size = new System.Drawing.Size(956, 490);
            this.tabQuyetToan.TabIndex = 0;
            this.tabQuyetToan.Text = "1. Quyết toán kinh phí Đoàn tour (Sau khi kết thúc)";
            this.tabQuyetToan.UseVisualStyleBackColor = true;
            // 
            // grpQuyetToanDoan
            // 
            this.grpQuyetToanDoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.grpQuyetToanDoan.Controls.Add(this.lblGhiChuQuyetToan);
            this.grpQuyetToanDoan.Controls.Add(this.btnXacNhanQuyetToan);
            this.grpQuyetToanDoan.Controls.Add(this.lblConLaiPhaiThu);
            this.grpQuyetToanDoan.Controls.Add(this.lblConLaiTitle);
            this.grpQuyetToanDoan.Controls.Add(this.numPhatSinh);
            this.grpQuyetToanDoan.Controls.Add(this.lblPhatSinh);
            this.grpQuyetToanDoan.Controls.Add(this.lblDaDatCoc);
            this.grpQuyetToanDoan.Controls.Add(this.lblDaDatCocTitle);
            this.grpQuyetToanDoan.Controls.Add(this.lblTongKinhPhiGoc);
            this.grpQuyetToanDoan.Controls.Add(this.lblTongKinhPhiGocTitle);
            this.grpQuyetToanDoan.Controls.Add(this.cboDoanQuyetToan);
            this.grpQuyetToanDoan.Controls.Add(this.lblDoan);
            this.grpQuyetToanDoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpQuyetToanDoan.Location = new System.Drawing.Point(10, 10);
            this.grpQuyetToanDoan.Name = "grpQuyetToanDoan";
            this.grpQuyetToanDoan.Size = new System.Drawing.Size(936, 320);
            this.grpQuyetToanDoan.TabIndex = 0;
            this.grpQuyetToanDoan.TabStop = false;
            this.grpQuyetToanDoan.Text = "HỒ SƠ QUYẾT TOÁN KINH PHÍ ĐOÀN THAM QUAN";
            // 
            // lblDoan
            // 
            this.lblDoan.AutoSize = true;
            this.lblDoan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDoan.Location = new System.Drawing.Point(20, 35);
            this.lblDoan.Name = "lblDoan";
            this.lblDoan.Size = new System.Drawing.Size(183, 19);
            this.lblDoan.TabIndex = 0;
            this.lblDoan.Text = "Chọn Đoàn đã kết thúc tour:";
            // 
            // cboDoanQuyetToan
            // 
            this.cboDoanQuyetToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoanQuyetToan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboDoanQuyetToan.FormattingEnabled = true;
            this.cboDoanQuyetToan.Items.AddRange(new object[] {
            "DOAN01: Cty Công nghệ ABC (Tour Nha Trang - Đà Lạt 4N3Đ) - 25 người",
            "DOAN02: Cty May Tiến Bộ (Tour Đà Nẵng - Hội An 5N4Đ) - 40 người"});
            this.cboDoanQuyetToan.Location = new System.Drawing.Point(215, 32);
            this.cboDoanQuyetToan.Name = "cboDoanQuyetToan";
            this.cboDoanQuyetToan.Size = new System.Drawing.Size(650, 24);
            this.cboDoanQuyetToan.TabIndex = 1;
            this.cboDoanQuyetToan.SelectedIndexChanged += new System.EventHandler(this.cboDoanQuyetToan_SelectedIndexChanged);
            // 
            // lblTongKinhPhiGocTitle
            // 
            this.lblTongKinhPhiGocTitle.AutoSize = true;
            this.lblTongKinhPhiGocTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTongKinhPhiGocTitle.Location = new System.Drawing.Point(20, 80);
            this.lblTongKinhPhiGocTitle.Name = "lblTongKinhPhiGocTitle";
            this.lblTongKinhPhiGocTitle.Size = new System.Drawing.Size(147, 19);
            this.lblTongKinhPhiGocTitle.TabIndex = 2;
            this.lblTongKinhPhiGocTitle.Text = "Tổng chi phí ban đầu:";
            // 
            // lblTongKinhPhiGoc
            // 
            this.lblTongKinhPhiGoc.AutoSize = true;
            this.lblTongKinhPhiGoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongKinhPhiGoc.Location = new System.Drawing.Point(215, 80);
            this.lblTongKinhPhiGoc.Name = "lblTongKinhPhiGoc";
            this.lblTongKinhPhiGoc.Size = new System.Drawing.Size(129, 20);
            this.lblTongKinhPhiGoc.TabIndex = 3;
            this.lblTongKinhPhiGoc.Text = "112,500,000 VNĐ";
            // 
            // lblDaDatCocTitle
            // 
            this.lblDaDatCocTitle.AutoSize = true;
            this.lblDaDatCocTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDaDatCocTitle.Location = new System.Drawing.Point(20, 120);
            this.lblDaDatCocTitle.Name = "lblDaDatCocTitle";
            this.lblDaDatCocTitle.Size = new System.Drawing.Size(175, 19);
            this.lblDaDatCocTitle.TabIndex = 4;
            this.lblDaDatCocTitle.Text = "Khoản tiền cọc ĐÃ NỘP:";
            // 
            // lblDaDatCoc
            // 
            this.lblDaDatCoc.AutoSize = true;
            this.lblDaDatCoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDaDatCoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblDaDatCoc.Location = new System.Drawing.Point(215, 120);
            this.lblDaDatCoc.Name = "lblDaDatCoc";
            this.lblDaDatCoc.Size = new System.Drawing.Size(158, 20);
            this.lblDaDatCoc.TabIndex = 5;
            this.lblDaDatCoc.Text = "33,750,000 VNĐ (30%)";
            // 
            // lblPhatSinh
            // 
            this.lblPhatSinh.AutoSize = true;
            this.lblPhatSinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhatSinh.Location = new System.Drawing.Point(20, 160);
            this.lblPhatSinh.Name = "lblPhatSinh";
            this.lblPhatSinh.Size = new System.Drawing.Size(175, 19);
            this.lblPhatSinh.TabIndex = 6;
            this.lblPhatSinh.Text = "Chi phí phát sinh trong tour:";
            // 
            // numPhatSinh
            // 
            this.numPhatSinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numPhatSinh.Increment = new decimal(new int[] { 500000, 0, 0, 0 });
            this.numPhatSinh.Location = new System.Drawing.Point(215, 158);
            this.numPhatSinh.Maximum = new decimal(new int[] { 50000000, 0, 0, 0 });
            this.numPhatSinh.Name = "numPhatSinh";
            this.numPhatSinh.Size = new System.Drawing.Size(160, 24);
            this.numPhatSinh.TabIndex = 7;
            this.numPhatSinh.ThousandsSeparator = true;
            this.numPhatSinh.ValueChanged += new System.EventHandler(this.numPhatSinh_ValueChanged);
            // 
            // lblConLaiTitle
            // 
            this.lblConLaiTitle.AutoSize = true;
            this.lblConLaiTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblConLaiTitle.Location = new System.Drawing.Point(20, 205);
            this.lblConLaiTitle.Name = "lblConLaiTitle";
            this.lblConLaiTitle.Size = new System.Drawing.Size(193, 20);
            this.lblConLaiTitle.TabIndex = 8;
            this.lblConLaiTitle.Text = "SỐ TIỀN CÒN PHẢI THU:";
            // 
            // lblConLaiPhaiThu
            // 
            this.lblConLaiPhaiThu.AutoSize = true;
            this.lblConLaiPhaiThu.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblConLaiPhaiThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblConLaiPhaiThu.Location = new System.Drawing.Point(215, 200);
            this.lblConLaiPhaiThu.Name = "lblConLaiPhaiThu";
            this.lblConLaiPhaiThu.Size = new System.Drawing.Size(168, 28);
            this.lblConLaiPhaiThu.TabIndex = 9;
            this.lblConLaiPhaiThu.Text = "78,750,000 VNĐ";
            // 
            // btnXacNhanQuyetToan
            // 
            this.btnXacNhanQuyetToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnXacNhanQuyetToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanQuyetToan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanQuyetToan.Location = new System.Drawing.Point(520, 195);
            this.btnXacNhanQuyetToan.Name = "btnXacNhanQuyetToan";
            this.btnXacNhanQuyetToan.Size = new System.Drawing.Size(280, 42);
            this.btnXacNhanQuyetToan.TabIndex = 10;
            this.btnXacNhanQuyetToan.Text = "XÁC NHẬN THU TIỀN QUYẾT TOÁN";
            this.btnXacNhanQuyetToan.UseVisualStyleBackColor = false;
            this.btnXacNhanQuyetToan.Click += new System.EventHandler(this.btnXacNhanQuyetToan_Click);
            // 
            // lblGhiChuQuyetToan
            // 
            this.lblGhiChuQuyetToan.AutoSize = true;
            this.lblGhiChuQuyetToan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblGhiChuQuyetToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGhiChuQuyetToan.Location = new System.Drawing.Point(20, 260);
            this.lblGhiChuQuyetToan.Name = "lblGhiChuQuyetToan";
            this.lblGhiChuQuyetToan.Size = new System.Drawing.Size(700, 15);
            this.lblGhiChuQuyetToan.TabIndex = 11;
            this.lblGhiChuQuyetToan.Text = "* Quy định công ty: Kinh phí tham quan của đoàn sẽ được quyết toán và thanh toán đầy đủ sau khi chuyến đi kết thúc.";
            // 
            // tabKhaoSat
            // 
            this.tabKhaoSat.Controls.Add(this.dgvLichSuKhaoSat);
            this.tabKhaoSat.Controls.Add(this.grpKhaoSat);
            this.tabKhaoSat.Location = new System.Drawing.Point(4, 26);
            this.tabKhaoSat.Name = "tabKhaoSat";
            this.tabKhaoSat.Padding = new System.Windows.Forms.Padding(10);
            this.tabKhaoSat.Size = new System.Drawing.Size(956, 490);
            this.tabKhaoSat.TabIndex = 1;
            this.tabKhaoSat.Text = "2. Phiếu khảo sát chất lượng dịch vụ & Góp ý";
            this.tabKhaoSat.UseVisualStyleBackColor = true;
            // 
            // dgvLichSuKhaoSat
            // 
            this.dgvLichSuKhaoSat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSuKhaoSat.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSuKhaoSat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuKhaoSat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichSuKhaoSat.Location = new System.Drawing.Point(10, 220);
            this.dgvLichSuKhaoSat.Name = "dgvLichSuKhaoSat";
            this.dgvLichSuKhaoSat.Size = new System.Drawing.Size(936, 260);
            this.dgvLichSuKhaoSat.TabIndex = 1;
            // 
            // grpKhaoSat
            // 
            this.grpKhaoSat.Controls.Add(this.btnGuiKhaoSat);
            this.grpKhaoSat.Controls.Add(this.txtGopY);
            this.grpKhaoSat.Controls.Add(this.lblGopY);
            this.grpKhaoSat.Controls.Add(this.cboHDVRating);
            this.grpKhaoSat.Controls.Add(this.lblHDVRate);
            this.grpKhaoSat.Controls.Add(this.cboPhuongTien);
            this.grpKhaoSat.Controls.Add(this.lblPhuongTien);
            this.grpKhaoSat.Controls.Add(this.cboKhachSan);
            this.grpKhaoSat.Controls.Add(this.lblKhachSan);
            this.grpKhaoSat.Controls.Add(this.cboNoiAn);
            this.grpKhaoSat.Controls.Add(this.lblNoiAn);
            this.grpKhaoSat.Controls.Add(this.cboTourKhaoSat);
            this.grpKhaoSat.Controls.Add(this.lblTourKS);
            this.grpKhaoSat.Controls.Add(this.cboKhachKhaoSat);
            this.grpKhaoSat.Controls.Add(this.lblKhachKS);
            this.grpKhaoSat.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpKhaoSat.Location = new System.Drawing.Point(10, 10);
            this.grpKhaoSat.Name = "grpKhaoSat";
            this.grpKhaoSat.Size = new System.Drawing.Size(936, 210);
            this.grpKhaoSat.TabIndex = 0;
            this.grpKhaoSat.TabStop = false;
            this.grpKhaoSat.Text = "GHI NHẬN Ý KIẾN KHẢO SÁT CHẤT LƯỢNG DỊCH VỤ";
            // 
            // lblKhachKS
            // 
            this.lblKhachKS.AutoSize = true;
            this.lblKhachKS.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblKhachKS.Location = new System.Drawing.Point(15, 25);
            this.lblKhachKS.Name = "lblKhachKS";
            this.lblKhachKS.Size = new System.Drawing.Size(126, 17);
            this.lblKhachKS.TabIndex = 0;
            this.lblKhachKS.Text = "Khách hàng / Đoàn:";
            // 
            // cboKhachKhaoSat
            // 
            this.cboKhachKhaoSat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachKhaoSat.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboKhachKhaoSat.FormattingEnabled = true;
            this.cboKhachKhaoSat.Items.AddRange(new object[] {
            "Cty Công nghệ ABC (Đại diện: Nguyễn Văn Hùng)",
            "Lê Thị Bích (Khách lẻ CHUYEN01)",
            "Trần Minh Quang (Khách lẻ CHUYEN01)"});
            this.cboKhachKhaoSat.Location = new System.Drawing.Point(150, 22);
            this.cboKhachKhaoSat.Name = "cboKhachKhaoSat";
            this.cboKhachKhaoSat.Size = new System.Drawing.Size(320, 24);
            this.cboKhachKhaoSat.TabIndex = 1;
            // 
            // lblTourKS
            // 
            this.lblTourKS.AutoSize = true;
            this.lblTourKS.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTourKS.Location = new System.Drawing.Point(490, 25);
            this.lblTourKS.Name = "lblTourKS";
            this.lblTourKS.Size = new System.Drawing.Size(89, 17);
            this.lblTourKS.TabIndex = 2;
            this.lblTourKS.Text = "Tour vừa đi:";
            // 
            // cboTourKhaoSat
            // 
            this.cboTourKhaoSat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTourKhaoSat.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboTourKhaoSat.FormattingEnabled = true;
            this.cboTourKhaoSat.Items.AddRange(new object[] {
            "TOUR001 - TP.HCM - Nha Trang - Đà Lạt",
            "TOUR002 - TP.HCM - Đà Nẵng - Hội An - Huế"});
            this.cboTourKhaoSat.Location = new System.Drawing.Point(585, 22);
            this.cboTourKhaoSat.Name = "cboTourKhaoSat";
            this.cboTourKhaoSat.Size = new System.Drawing.Size(330, 24);
            this.cboTourKhaoSat.TabIndex = 3;
            // 
            // lblNoiAn
            // 
            this.lblNoiAn.AutoSize = true;
            this.lblNoiAn.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNoiAn.Location = new System.Drawing.Point(15, 60);
            this.lblNoiAn.Name = "lblNoiAn";
            this.lblNoiAn.Size = new System.Drawing.Size(124, 17);
            this.lblNoiAn.TabIndex = 4;
            this.lblNoiAn.Text = "Chất lượng nơi ăn:";
            // 
            // cboNoiAn
            // 
            this.cboNoiAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNoiAn.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboNoiAn.FormattingEnabled = true;
            this.cboNoiAn.Items.AddRange(new object[] { "5 sao (Rất hài lòng)", "4 sao (Hài lòng)", "3 sao (Bình thường)", "2 sao (Kém)", "1 sao (Rất tệ)" });
            this.cboNoiAn.Location = new System.Drawing.Point(150, 57);
            this.cboNoiAn.Name = "cboNoiAn";
            this.cboNoiAn.Size = new System.Drawing.Size(160, 24);
            this.cboNoiAn.TabIndex = 5;
            // 
            // lblKhachSan
            // 
            this.lblKhachSan.AutoSize = true;
            this.lblKhachSan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblKhachSan.Location = new System.Drawing.Point(325, 60);
            this.lblKhachSan.Name = "lblKhachSan";
            this.lblKhachSan.Size = new System.Drawing.Size(71, 17);
            this.lblKhachSan.TabIndex = 6;
            this.lblKhachSan.Text = "Khách sạn:";
            // 
            // cboKhachSan
            // 
            this.cboKhachSan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachSan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboKhachSan.FormattingEnabled = true;
            this.cboKhachSan.Items.AddRange(new object[] { "5 sao (Rất hài lòng)", "4 sao (Hài lòng)", "3 sao (Bình thường)", "2 sao (Kém)", "1 sao (Rất tệ)" });
            this.cboKhachSan.Location = new System.Drawing.Point(400, 57);
            this.cboKhachSan.Name = "cboKhachSan";
            this.cboKhachSan.Size = new System.Drawing.Size(150, 24);
            this.cboKhachSan.TabIndex = 7;
            // 
            // lblPhuongTien
            // 
            this.lblPhuongTien.AutoSize = true;
            this.lblPhuongTien.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPhuongTien.Location = new System.Drawing.Point(565, 60);
            this.lblPhuongTien.Name = "lblPhuongTien";
            this.lblPhuongTien.Size = new System.Drawing.Size(84, 17);
            this.lblPhuongTien.TabIndex = 8;
            this.lblPhuongTien.Text = "Phương tiện:";
            // 
            // cboPhuongTien
            // 
            this.cboPhuongTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhuongTien.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboPhuongTien.FormattingEnabled = true;
            this.cboPhuongTien.Items.AddRange(new object[] { "5 sao (Rất hài lòng)", "4 sao (Hài lòng)", "3 sao (Bình thường)", "2 sao (Kém)", "1 sao (Rất tệ)" });
            this.cboPhuongTien.Location = new System.Drawing.Point(655, 57);
            this.cboPhuongTien.Name = "cboPhuongTien";
            this.cboPhuongTien.Size = new System.Drawing.Size(150, 24);
            this.cboPhuongTien.TabIndex = 9;
            // 
            // lblHDVRate
            // 
            this.lblHDVRate.AutoSize = true;
            this.lblHDVRate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHDVRate.Location = new System.Drawing.Point(15, 95);
            this.lblHDVRate.Name = "lblHDVRate";
            this.lblHDVRate.Size = new System.Drawing.Size(117, 17);
            this.lblHDVRate.TabIndex = 10;
            this.lblHDVRate.Text = "Thái độ của HDV:";
            // 
            // cboHDVRating
            // 
            this.cboHDVRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHDVRating.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboHDVRating.FormattingEnabled = true;
            this.cboHDVRating.Items.AddRange(new object[] { "5 sao (Nhiệt tình, chu đáo)", "4 sao (Tốt)", "3 sao (Bình thường)", "2 sao (Thiếu nhiệt tình)", "1 sao (Thất vọng)" });
            this.cboHDVRating.Location = new System.Drawing.Point(150, 92);
            this.cboHDVRating.Name = "cboHDVRating";
            this.cboHDVRating.Size = new System.Drawing.Size(200, 24);
            this.cboHDVRating.TabIndex = 11;
            // 
            // lblGopY
            // 
            this.lblGopY.AutoSize = true;
            this.lblGopY.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblGopY.Location = new System.Drawing.Point(15, 130);
            this.lblGopY.Name = "lblGopY";
            this.lblGopY.Size = new System.Drawing.Size(114, 17);
            this.lblGopY.TabIndex = 12;
            this.lblGopY.Text = "Ý kiến góp ý khác:";
            // 
            // txtGopY
            // 
            this.txtGopY.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtGopY.Location = new System.Drawing.Point(150, 127);
            this.txtGopY.Multiline = true;
            this.txtGopY.Name = "txtGopY";
            this.txtGopY.Size = new System.Drawing.Size(610, 65);
            this.txtGopY.TabIndex = 13;
            // 
            // btnGuiKhaoSat
            // 
            this.btnGuiKhaoSat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnGuiKhaoSat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuiKhaoSat.ForeColor = System.Drawing.Color.White;
            this.btnGuiKhaoSat.Location = new System.Drawing.Point(775, 127);
            this.btnGuiKhaoSat.Name = "btnGuiKhaoSat";
            this.btnGuiKhaoSat.Size = new System.Drawing.Size(140, 65);
            this.btnGuiKhaoSat.TabIndex = 14;
            this.btnGuiKhaoSat.Text = "LƯU Ý KIẾN GÓP Ý";
            this.btnGuiKhaoSat.UseVisualStyleBackColor = false;
            this.btnGuiKhaoSat.Click += new System.EventHandler(this.btnGuiKhaoSat_Click);
            // 
            // tabTinhLuong
            // 
            this.tabTinhLuong.Controls.Add(this.btnInPhieuLuong);
            this.tabTinhLuong.Controls.Add(this.dgvTourThucHien);
            this.tabTinhLuong.Controls.Add(this.grpHDVLuong);
            this.tabTinhLuong.Location = new System.Drawing.Point(4, 26);
            this.tabTinhLuong.Name = "tabTinhLuong";
            this.tabTinhLuong.Padding = new System.Windows.Forms.Padding(10);
            this.tabTinhLuong.Size = new System.Drawing.Size(956, 490);
            this.tabTinhLuong.TabIndex = 2;
            this.tabTinhLuong.Text = "3. Bảng tính lương HDV (Lương căn bản + Thù lao tour)";
            this.tabTinhLuong.UseVisualStyleBackColor = true;
            // 
            // grpHDVLuong
            // 
            this.grpHDVLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.grpHDVLuong.Controls.Add(this.lblTongThucLinh);
            this.grpHDVLuong.Controls.Add(this.lblTongThucLinhTitle);
            this.grpHDVLuong.Controls.Add(this.lblTongThuLaoTour);
            this.grpHDVLuong.Controls.Add(this.lblTongThuLaoTitle);
            this.grpHDVLuong.Controls.Add(this.lblLuongCanBan);
            this.grpHDVLuong.Controls.Add(this.lblLuongCBTitle);
            this.grpHDVLuong.Controls.Add(this.cboThangLuong);
            this.grpHDVLuong.Controls.Add(this.lblThangLuong);
            this.grpHDVLuong.Controls.Add(this.cboHDV);
            this.grpHDVLuong.Controls.Add(this.lblChonHDV);
            this.grpHDVLuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpHDVLuong.Location = new System.Drawing.Point(10, 10);
            this.grpHDVLuong.Name = "grpHDVLuong";
            this.grpHDVLuong.Size = new System.Drawing.Size(936, 170);
            this.grpHDVLuong.TabIndex = 0;
            this.grpHDVLuong.TabStop = false;
            this.grpHDVLuong.Text = "TÍNH LƯƠNG NHÂN VIÊN HƯỚNG DẪN VIÊN TRONG THÁNG";
            // 
            // lblChonHDV
            // 
            this.lblChonHDV.AutoSize = true;
            this.lblChonHDV.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblChonHDV.Location = new System.Drawing.Point(15, 30);
            this.lblChonHDV.Name = "lblChonHDV";
            this.lblChonHDV.Size = new System.Drawing.Size(71, 17);
            this.lblChonHDV.TabIndex = 0;
            this.lblChonHDV.Text = "Chọn HDV:";
            // 
            // cboHDV
            // 
            this.cboHDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHDV.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboHDV.FormattingEnabled = true;
            this.cboHDV.Items.AddRange(new object[] {
            "HDV01 - Trần Quốc Toản",
            "HDV02 - Lê Thị Hồng Gấm",
            "HDV03 - Phạm Văn Đồng",
            "HDV04 - Hoàng Thị Loan",
            "HDV05 - Võ Văn Kiệt"});
            this.cboHDV.Location = new System.Drawing.Point(100, 27);
            this.cboHDV.Name = "cboHDV";
            this.cboHDV.Size = new System.Drawing.Size(240, 24);
            this.cboHDV.TabIndex = 1;
            this.cboHDV.SelectedIndexChanged += new System.EventHandler(this.cboHDV_SelectedIndexChanged);
            // 
            // lblThangLuong
            // 
            this.lblThangLuong.AutoSize = true;
            this.lblThangLuong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblThangLuong.Location = new System.Drawing.Point(370, 30);
            this.lblThangLuong.Name = "lblThangLuong";
            this.lblThangLuong.Size = new System.Drawing.Size(46, 17);
            this.lblThangLuong.TabIndex = 2;
            this.lblThangLuong.Text = "Tháng:";
            // 
            // cboThangLuong
            // 
            this.cboThangLuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThangLuong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboThangLuong.FormattingEnabled = true;
            this.cboThangLuong.Items.AddRange(new object[] { "Tháng 10/2026", "Tháng 09/2026", "Tháng 08/2026" });
            this.cboThangLuong.Location = new System.Drawing.Point(430, 27);
            this.cboThangLuong.Name = "cboThangLuong";
            this.cboThangLuong.Size = new System.Drawing.Size(140, 24);
            this.cboThangLuong.TabIndex = 3;
            // 
            // lblLuongCBTitle
            // 
            this.lblLuongCBTitle.AutoSize = true;
            this.lblLuongCBTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLuongCBTitle.Location = new System.Drawing.Point(15, 75);
            this.lblLuongCBTitle.Name = "lblLuongCBTitle";
            this.lblLuongCBTitle.Size = new System.Drawing.Size(126, 19);
            this.lblLuongCBTitle.TabIndex = 4;
            this.lblLuongCBTitle.Text = "Lương CĂN BẢN:";
            // 
            // lblLuongCanBan
            // 
            this.lblLuongCanBan.AutoSize = true;
            this.lblLuongCanBan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLuongCanBan.Location = new System.Drawing.Point(150, 74);
            this.lblLuongCanBan.Name = "lblLuongCanBan";
            this.lblLuongCanBan.Size = new System.Drawing.Size(111, 20);
            this.lblLuongCanBan.TabIndex = 5;
            this.lblLuongCanBan.Text = "6,500,000 VNĐ";
            // 
            // lblTongThuLaoTitle
            // 
            this.lblTongThuLaoTitle.AutoSize = true;
            this.lblTongThuLaoTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTongThuLaoTitle.Location = new System.Drawing.Point(370, 75);
            this.lblTongThuLaoTitle.Name = "lblTongThuLaoTitle";
            this.lblTongThuLaoTitle.Size = new System.Drawing.Size(209, 19);
            this.lblTongThuLaoTitle.TabIndex = 6;
            this.lblTongThuLaoTitle.Text = "Lương theo các TOUR đã đi:";
            // 
            // lblTongThuLaoTour
            // 
            this.lblTongThuLaoTour.AutoSize = true;
            this.lblTongThuLaoTour.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongThuLaoTour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblTongThuLaoTour.Location = new System.Drawing.Point(590, 74);
            this.lblTongThuLaoTour.Name = "lblTongThuLaoTour";
            this.lblTongThuLaoTour.Size = new System.Drawing.Size(111, 20);
            this.lblTongThuLaoTour.TabIndex = 7;
            this.lblTongThuLaoTour.Text = "9,700,000 VNĐ";
            // 
            // lblTongThucLinhTitle
            // 
            this.lblTongThucLinhTitle.AutoSize = true;
            this.lblTongThucLinhTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongThucLinhTitle.Location = new System.Drawing.Point(15, 120);
            this.lblTongThucLinhTitle.Name = "lblTongThucLinhTitle";
            this.lblTongThucLinhTitle.Size = new System.Drawing.Size(183, 20);
            this.lblTongThucLinhTitle.TabIndex = 8;
            this.lblTongThucLinhTitle.Text = "TỔNG LƯƠNG THỰC LĨNH:";
            // 
            // lblTongThucLinh
            // 
            this.lblTongThucLinh.AutoSize = true;
            this.lblTongThucLinh.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTongThucLinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTongThucLinh.Location = new System.Drawing.Point(215, 114);
            this.lblTongThucLinh.Name = "lblTongThucLinh";
            this.lblTongThucLinh.Size = new System.Drawing.Size(168, 28);
            this.lblTongThucLinh.TabIndex = 9;
            this.lblTongThucLinh.Text = "16,200,000 VNĐ";
            // 
            // dgvTourThucHien
            // 
            this.dgvTourThucHien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTourThucHien.BackgroundColor = System.Drawing.Color.White;
            this.dgvTourThucHien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourThucHien.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTourThucHien.Location = new System.Drawing.Point(10, 180);
            this.dgvTourThucHien.Name = "dgvTourThucHien";
            this.dgvTourThucHien.Size = new System.Drawing.Size(936, 230);
            this.dgvTourThucHien.TabIndex = 1;
            // 
            // btnInPhieuLuong
            // 
            this.btnInPhieuLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.btnInPhieuLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInPhieuLuong.ForeColor = System.Drawing.Color.White;
            this.btnInPhieuLuong.Location = new System.Drawing.Point(740, 425);
            this.btnInPhieuLuong.Name = "btnInPhieuLuong";
            this.btnInPhieuLuong.Size = new System.Drawing.Size(200, 45);
            this.btnInPhieuLuong.TabIndex = 2;
            this.btnInPhieuLuong.Text = "XUẤT PHIẾU LƯƠNG";
            this.btnInPhieuLuong.UseVisualStyleBackColor = false;
            this.btnInPhieuLuong.Click += new System.EventHandler(this.btnInPhieuLuong_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.White;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDong.Location = new System.Drawing.Point(850, 580);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 35);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmQuyetToanLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 625);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "FrmQuyetToanLuong";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quyết Toán Đoàn - Khảo Sát Chất Lượng - Tính Lương Hướng Dẫn Viên";
            this.tabMain.ResumeLayout(false);
            this.tabQuyetToan.ResumeLayout(false);
            this.grpQuyetToanDoan.ResumeLayout(false);
            this.grpQuyetToanDoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPhatSinh)).EndInit();
            this.tabKhaoSat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuKhaoSat)).EndInit();
            this.grpKhaoSat.ResumeLayout(false);
            this.grpKhaoSat.PerformLayout();
            this.tabTinhLuong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourThucHien)).EndInit();
            this.grpHDVLuong.ResumeLayout(false);
            this.grpHDVLuong.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}

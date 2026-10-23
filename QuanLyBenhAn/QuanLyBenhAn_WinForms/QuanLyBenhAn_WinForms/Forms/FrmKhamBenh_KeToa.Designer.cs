namespace QuanLyBenhAn_WinForms.Forms
{
    partial class FrmKhamBenh_KeToa
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpTraCuu;
        private System.Windows.Forms.Label lblNhapTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblTenBN;
        private System.Windows.Forms.Label lblMaHSBADisplay;
        private System.Windows.Forms.Label lblTienSuDiUng;
        private System.Windows.Forms.Label lblLichSuKham;
        private System.Windows.Forms.GroupBox grpKhamBenh;
        private System.Windows.Forms.Label lblBacSi;
        private System.Windows.Forms.ComboBox cboBacSi;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label lblTrieuChung;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Label lblChuanDoan;
        private System.Windows.Forms.TextBox txtChuanDoan;
        private System.Windows.Forms.Button btnChiDinhXN;
        private System.Windows.Forms.Label lblTrangThaiXN;
        private System.Windows.Forms.GroupBox grpKeToa;
        private System.Windows.Forms.Label lblThuoc;
        private System.Windows.Forms.ComboBox cboThuoc;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label lblLieuLuong;
        private System.Windows.Forms.TextBox txtLieuLuong;
        private System.Windows.Forms.Label lblCachDung;
        private System.Windows.Forms.TextBox txtCachDung;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.DataGridView dgvToaThuoc;
        private System.Windows.Forms.Label lblTongTienTitle;
        private System.Windows.Forms.Label lblTongTienThuoc;
        private System.Windows.Forms.Button btnLuuKham;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpTraCuu = new System.Windows.Forms.GroupBox();
            this.lblLichSuKham = new System.Windows.Forms.Label();
            this.lblTienSuDiUng = new System.Windows.Forms.Label();
            this.lblMaHSBADisplay = new System.Windows.Forms.Label();
            this.lblTenBN = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblNhapTim = new System.Windows.Forms.Label();
            this.grpKhamBenh = new System.Windows.Forms.GroupBox();
            this.lblTrangThaiXN = new System.Windows.Forms.Label();
            this.btnChiDinhXN = new System.Windows.Forms.Button();
            this.txtChuanDoan = new System.Windows.Forms.TextBox();
            this.lblChuanDoan = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.lblTrieuChung = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cboBacSi = new System.Windows.Forms.ComboBox();
            this.lblBacSi = new System.Windows.Forms.Label();
            this.grpKeToa = new System.Windows.Forms.GroupBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuuKham = new System.Windows.Forms.Button();
            this.lblTongTienThuoc = new System.Windows.Forms.Label();
            this.lblTongTienTitle = new System.Windows.Forms.Label();
            this.dgvToaThuoc = new System.Windows.Forms.DataGridView();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.txtCachDung = new System.Windows.Forms.TextBox();
            this.lblCachDung = new System.Windows.Forms.Label();
            this.txtLieuLuong = new System.Windows.Forms.TextBox();
            this.lblLieuLuong = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.cboThuoc = new System.Windows.Forms.ComboBox();
            this.lblThuoc = new System.Windows.Forms.Label();
            this.grpTraCuu.SuspendLayout();
            this.grpKhamBenh.SuspendLayout();
            this.grpKeToa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
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
            this.lblTitle.Text = "KHÁM BỆNH LÂM SÀNG, CHỈ ĐỊNH XÉT NGHIỆM VÀ LẬP TOA THUỐC ĐIỀU TRỊ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpTraCuu
            // 
            this.grpTraCuu.Controls.Add(this.lblLichSuKham);
            this.grpTraCuu.Controls.Add(this.lblTienSuDiUng);
            this.grpTraCuu.Controls.Add(this.lblMaHSBADisplay);
            this.grpTraCuu.Controls.Add(this.lblTenBN);
            this.grpTraCuu.Controls.Add(this.btnTimKiem);
            this.grpTraCuu.Controls.Add(this.txtTimKiem);
            this.grpTraCuu.Controls.Add(this.lblNhapTim);
            this.grpTraCuu.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTraCuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpTraCuu.Location = new System.Drawing.Point(10, 55);
            this.grpTraCuu.Name = "grpTraCuu";
            this.grpTraCuu.Size = new System.Drawing.Size(964, 110);
            this.grpTraCuu.TabIndex = 1;
            this.grpTraCuu.TabStop = false;
            this.grpTraCuu.Text = "1. TRA CỨU HỒ SƠ BỆNH ÁN CŨ / THÔNG TIN BỆNH NHÂN";
            // 
            // lblNhapTim
            // 
            this.lblNhapTim.AutoSize = true;
            this.lblNhapTim.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNhapTim.Location = new System.Drawing.Point(15, 28);
            this.lblNhapTim.Name = "lblNhapTim";
            this.lblNhapTim.Size = new System.Drawing.Size(168, 17);
            this.lblNhapTim.TabIndex = 0;
            this.lblNhapTim.Text = "Mã hồ sơ / SĐT / Họ tên BN:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTimKiem.Location = new System.Drawing.Point(190, 25);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 24);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.Text = "HSBA00123";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnTimKiem.Location = new System.Drawing.Point(400, 23);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 28);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Hồ Sơ";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblTenBN
            // 
            this.lblTenBN.AutoSize = true;
            this.lblTenBN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTenBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.lblTenBN.Location = new System.Drawing.Point(530, 27);
            this.lblTenBN.Name = "lblTenBN";
            this.lblTenBN.Size = new System.Drawing.Size(250, 20);
            this.lblTenBN.TabIndex = 3;
            this.lblTenBN.Text = "Nguyễn Văn Hùng (Nam - 1982)";
            // 
            // lblMaHSBADisplay
            // 
            this.lblMaHSBADisplay.AutoSize = true;
            this.lblMaHSBADisplay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblMaHSBADisplay.Location = new System.Drawing.Point(790, 28);
            this.lblMaHSBADisplay.Name = "lblMaHSBADisplay";
            this.lblMaHSBADisplay.Size = new System.Drawing.Size(155, 17);
            this.lblMaHSBADisplay.TabIndex = 4;
            this.lblMaHSBADisplay.Text = "Mã HSBA: HSBA00123";
            // 
            // lblTienSuDiUng
            // 
            this.lblTienSuDiUng.AutoSize = true;
            this.lblTienSuDiUng.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTienSuDiUng.ForeColor = System.Drawing.Color.Red;
            this.lblTienSuDiUng.Location = new System.Drawing.Point(15, 60);
            this.lblTienSuDiUng.Name = "lblTienSuDiUng";
            this.lblTienSuDiUng.Size = new System.Drawing.Size(370, 17);
            this.lblTienSuDiUng.TabIndex = 5;
            this.lblTienSuDiUng.Text = "Cảnh báo tiền sử: Dị ứng Penicillin (Phát ban nhẹ năm 2024)";
            // 
            // lblLichSuKham
            // 
            this.lblLichSuKham.AutoSize = true;
            this.lblLichSuKham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblLichSuKham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLichSuKham.Location = new System.Drawing.Point(15, 85);
            this.lblLichSuKham.Name = "lblLichSuKham";
            this.lblLichSuKham.Size = new System.Drawing.Size(550, 15);
            this.lblLichSuKham.TabIndex = 6;
            this.lblLichSuKham.Text = "Lịch sử: 15/06/2026: Khám định kỳ Quý 2 (Bình thường) | 12/02/2026: Cảm sốt siêu vi, huyết áp ổn định";
            // 
            // grpKhamBenh
            // 
            this.grpKhamBenh.Controls.Add(this.lblTrangThaiXN);
            this.grpKhamBenh.Controls.Add(this.btnChiDinhXN);
            this.grpKhamBenh.Controls.Add(this.txtChuanDoan);
            this.grpKhamBenh.Controls.Add(this.lblChuanDoan);
            this.grpKhamBenh.Controls.Add(this.txtTrieuChung);
            this.grpKhamBenh.Controls.Add(this.lblTrieuChung);
            this.grpKhamBenh.Controls.Add(this.cboKhoa);
            this.grpKhamBenh.Controls.Add(this.lblKhoa);
            this.grpKhamBenh.Controls.Add(this.cboBacSi);
            this.grpKhamBenh.Controls.Add(this.lblBacSi);
            this.grpKhamBenh.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpKhamBenh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpKhamBenh.Location = new System.Drawing.Point(10, 165);
            this.grpKhamBenh.Name = "grpKhamBenh";
            this.grpKhamBenh.Size = new System.Drawing.Size(964, 140);
            this.grpKhamBenh.TabIndex = 2;
            this.grpKhamBenh.TabStop = false;
            this.grpKhamBenh.Text = "2. KHÁM LÂM SÀNG, GHI NHẬN TRIỆU CHỨNG & CHỈ ĐỊNH XÉT NGHIỆM";
            // 
            // lblBacSi
            // 
            this.lblBacSi.AutoSize = true;
            this.lblBacSi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBacSi.Location = new System.Drawing.Point(15, 30);
            this.lblBacSi.Name = "lblBacSi";
            this.lblBacSi.Size = new System.Drawing.Size(89, 17);
            this.lblBacSi.TabIndex = 0;
            this.lblBacSi.Text = "Bác sĩ điều trị:";
            // 
            // cboBacSi
            // 
            this.cboBacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBacSi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboBacSi.FormattingEnabled = true;
            this.cboBacSi.Items.AddRange(new object[] { "BS001 - ThS.BS Trần Văn Thành", "BS002 - BSCKI Lê Thị Hoa", "BS003 - TS.BS Phạm Quốc Bảo" });
            this.cboBacSi.Location = new System.Drawing.Point(110, 27);
            this.cboBacSi.Name = "cboBacSi";
            this.cboBacSi.Size = new System.Drawing.Size(250, 24);
            this.cboBacSi.TabIndex = 1;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblKhoa.Location = new System.Drawing.Point(380, 30);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(89, 17);
            this.lblKhoa.TabIndex = 2;
            this.lblKhoa.Text = "Khoa điều trị:";
            // 
            // cboKhoa
            // 
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Items.AddRange(new object[] { "KHOA01 - Khoa Khám bệnh & Nội tổng quát", "KHOA02 - Khoa Tim mạch & Huyết áp", "KHOA03 - Khoa Thần kinh & Cơ xương khớp" });
            this.cboKhoa.Location = new System.Drawing.Point(475, 27);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(260, 24);
            this.cboKhoa.TabIndex = 3;
            // 
            // lblTrieuChung
            // 
            this.lblTrieuChung.AutoSize = true;
            this.lblTrieuChung.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTrieuChung.Location = new System.Drawing.Point(15, 65);
            this.lblTrieuChung.Name = "lblTrieuChung";
            this.lblTrieuChung.Size = new System.Drawing.Size(81, 17);
            this.lblTrieuChung.TabIndex = 4;
            this.lblTrieuChung.Text = "Triệu chứng:";
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTrieuChung.Location = new System.Drawing.Point(110, 62);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(625, 24);
            this.txtTrieuChung.TabIndex = 5;
            this.txtTrieuChung.Text = "Nhức đầu vùng trán, thân nhiệt 38.2°C, huyết áp 140/90 mmHg, mệt mỏi 2 ngày nay";
            // 
            // lblChuanDoan
            // 
            this.lblChuanDoan.AutoSize = true;
            this.lblChuanDoan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblChuanDoan.Location = new System.Drawing.Point(15, 102);
            this.lblChuanDoan.Name = "lblChuanDoan";
            this.lblChuanDoan.Size = new System.Drawing.Size(81, 17);
            this.lblChuanDoan.TabIndex = 6;
            this.lblChuanDoan.Text = "Chẩn đoán:";
            // 
            // txtChuanDoan
            // 
            this.txtChuanDoan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtChuanDoan.Location = new System.Drawing.Point(110, 99);
            this.txtChuanDoan.Name = "txtChuanDoan";
            this.txtChuanDoan.Size = new System.Drawing.Size(625, 24);
            this.txtChuanDoan.TabIndex = 7;
            this.txtChuanDoan.Text = "Tăng huyết áp độ 1 - Sốt nhiễm khuẩn đường hô hấp trên / Theo dõi tiền sử dị ứng";
            // 
            // btnChiDinhXN
            // 
            this.btnChiDinhXN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.btnChiDinhXN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiDinhXN.ForeColor = System.Drawing.Color.White;
            this.btnChiDinhXN.Location = new System.Drawing.Point(750, 25);
            this.btnChiDinhXN.Name = "btnChiDinhXN";
            this.btnChiDinhXN.Size = new System.Drawing.Size(195, 45);
            this.btnChiDinhXN.TabIndex = 8;
            this.btnChiDinhXN.Text = "Chỉ Định Xét Nghiệm";
            this.btnChiDinhXN.UseVisualStyleBackColor = false;
            this.btnChiDinhXN.Click += new System.EventHandler(this.btnChiDinhXN_Click);
            // 
            // lblTrangThaiXN
            // 
            this.lblTrangThaiXN.AutoSize = true;
            this.lblTrangThaiXN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblTrangThaiXN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblTrangThaiXN.Location = new System.Drawing.Point(747, 80);
            this.lblTrangThaiXN.Name = "lblTrangThaiXN";
            this.lblTrangThaiXN.Size = new System.Drawing.Size(200, 30);
            this.lblTrangThaiXN.TabIndex = 9;
            this.lblTrangThaiXN.Text = "Kết quả XN: Bạch cầu hơi tăng nhẹ,
điện tim ECG bình thường.";
            // 
            // grpKeToa
            // 
            this.grpKeToa.Controls.Add(this.btnDong);
            this.grpKeToa.Controls.Add(this.btnLuuKham);
            this.grpKeToa.Controls.Add(this.lblTongTienThuoc);
            this.grpKeToa.Controls.Add(this.lblTongTienTitle);
            this.grpKeToa.Controls.Add(this.dgvToaThuoc);
            this.grpKeToa.Controls.Add(this.btnThemThuoc);
            this.grpKeToa.Controls.Add(this.txtCachDung);
            this.grpKeToa.Controls.Add(this.lblCachDung);
            this.grpKeToa.Controls.Add(this.txtLieuLuong);
            this.grpKeToa.Controls.Add(this.lblLieuLuong);
            this.grpKeToa.Controls.Add(this.numSoLuong);
            this.grpKeToa.Controls.Add(this.lblSoLuong);
            this.grpKeToa.Controls.Add(this.cboThuoc);
            this.grpKeToa.Controls.Add(this.lblThuoc);
            this.grpKeToa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpKeToa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpKeToa.Location = new System.Drawing.Point(10, 305);
            this.grpKeToa.Name = "grpKeToa";
            this.grpKeToa.Size = new System.Drawing.Size(964, 300);
            this.grpKeToa.TabIndex = 3;
            this.grpKeToa.TabStop = false;
            this.grpKeToa.Text = "3. LẬP TOA THUỐC ĐIỀU TRỊ CHO TRIỆU CHỨNG TRÊN";
            // 
            // lblThuoc
            // 
            this.lblThuoc.AutoSize = true;
            this.lblThuoc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblThuoc.Location = new System.Drawing.Point(15, 28);
            this.lblThuoc.Name = "lblThuoc";
            this.lblThuoc.Size = new System.Drawing.Size(78, 17);
            this.lblThuoc.TabIndex = 0;
            this.lblThuoc.Text = "Chọn thuốc:";
            // 
            // cboThuoc
            // 
            this.cboThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThuoc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboThuoc.FormattingEnabled = true;
            this.cboThuoc.Items.AddRange(new object[] {
            "Paracetamol 500mg (Hạ sốt, giảm nhức đầu)",
            "Amlodipine 5mg (Hạ huyết áp)",
            "Cefuroxime 500mg (Kháng sinh thế hệ 2)",
            "Amoxicillin 500mg (Nhóm Penicillin - Cần thận trọng)",
            "Vitamin C 500mg (Tăng đề kháng)"});
            this.cboThuoc.Location = new System.Drawing.Point(95, 25);
            this.cboThuoc.Name = "cboThuoc";
            this.cboThuoc.Size = new System.Drawing.Size(280, 24);
            this.cboThuoc.TabIndex = 1;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSoLuong.Location = new System.Drawing.Point(385, 28);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(64, 17);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numSoLuong.Location = new System.Drawing.Point(455, 25);
            this.numSoLuong.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(60, 24);
            this.numSoLuong.TabIndex = 3;
            this.numSoLuong.Value = new decimal(new int[] { 14, 0, 0, 0 });
            // 
            // lblLieuLuong
            // 
            this.lblLieuLuong.AutoSize = true;
            this.lblLieuLuong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLieuLuong.Location = new System.Drawing.Point(525, 28);
            this.lblLieuLuong.Name = "lblLieuLuong";
            this.lblLieuLuong.Size = new System.Drawing.Size(73, 17);
            this.lblLieuLuong.TabIndex = 4;
            this.lblLieuLuong.Text = "Liều lượng:";
            // 
            // txtLieuLuong
            // 
            this.txtLieuLuong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtLieuLuong.Location = new System.Drawing.Point(600, 25);
            this.txtLieuLuong.Name = "txtLieuLuong";
            this.txtLieuLuong.Size = new System.Drawing.Size(120, 24);
            this.txtLieuLuong.TabIndex = 5;
            this.txtLieuLuong.Text = "2 viên / ngày";
            // 
            // lblCachDung
            // 
            this.lblCachDung.AutoSize = true;
            this.lblCachDung.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCachDung.Location = new System.Drawing.Point(15, 62);
            this.lblCachDung.Name = "lblCachDung";
            this.lblCachDung.Size = new System.Drawing.Size(71, 17);
            this.lblCachDung.TabIndex = 6;
            this.lblCachDung.Text = "Cách dùng:";
            // 
            // txtCachDung
            // 
            this.txtCachDung.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCachDung.Location = new System.Drawing.Point(95, 59);
            this.txtCachDung.Name = "txtCachDung";
            this.txtCachDung.Size = new System.Drawing.Size(625, 24);
            this.txtCachDung.TabIndex = 7;
            this.txtCachDung.Text = "Sáng 1 viên sau ăn, Chiều 1 viên sau ăn. Uống nhiều nước ấm.";
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.BackColor = System.Drawing.Color.White;
            this.btnThemThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemThuoc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnThemThuoc.Location = new System.Drawing.Point(750, 25);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(195, 58);
            this.btnThemThuoc.TabIndex = 8;
            this.btnThemThuoc.Text = "+ Thêm Thuốc Vào Toa";
            this.btnThemThuoc.UseVisualStyleBackColor = false;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
            // 
            // dgvToaThuoc
            // 
            this.dgvToaThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvToaThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgvToaThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToaThuoc.Location = new System.Drawing.Point(15, 95);
            this.dgvToaThuoc.Name = "dgvToaThuoc";
            this.dgvToaThuoc.Size = new System.Drawing.Size(930, 145);
            this.dgvToaThuoc.TabIndex = 9;
            // 
            // lblTongTienTitle
            // 
            this.lblTongTienTitle.AutoSize = true;
            this.lblTongTienTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTongTienTitle.Location = new System.Drawing.Point(15, 255);
            this.lblTongTienTitle.Name = "lblTongTienTitle";
            this.lblTongTienTitle.Size = new System.Drawing.Size(117, 19);
            this.lblTongTienTitle.TabIndex = 10;
            this.lblTongTienTitle.Text = "Tổng tiền toa thuốc:";
            // 
            // lblTongTienThuoc
            // 
            this.lblTongTienThuoc.AutoSize = true;
            this.lblTongTienThuoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongTienThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTongTienThuoc.Location = new System.Drawing.Point(140, 253);
            this.lblTongTienThuoc.Name = "lblTongTienThuoc";
            this.lblTongTienThuoc.Size = new System.Drawing.Size(111, 21);
            this.lblTongTienThuoc.TabIndex = 11;
            this.lblTongTienThuoc.Text = "160,000 VNĐ";
            // 
            // btnLuuKham
            // 
            this.btnLuuKham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnLuuKham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuKham.ForeColor = System.Drawing.Color.White;
            this.btnLuuKham.Location = new System.Drawing.Point(630, 248);
            this.btnLuuKham.Name = "btnLuuKham";
            this.btnLuuKham.Size = new System.Drawing.Size(215, 38);
            this.btnLuuKham.TabIndex = 12;
            this.btnLuuKham.Text = "LƯU KHÁM & KÊ TOA THUỐC";
            this.btnLuuKham.UseVisualStyleBackColor = false;
            this.btnLuuKham.Click += new System.EventHandler(this.btnLuuKham_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.White;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Location = new System.Drawing.Point(855, 248);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(90, 38);
            this.btnDong.TabIndex = 13;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmKhamBenh_KeToa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 615);
            this.Controls.Add(this.grpKeToa);
            this.Controls.Add(this.grpKhamBenh);
            this.Controls.Add(this.grpTraCuu);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "FrmKhamBenh_KeToa";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khám Bệnh Lâm Sàng & Lập Toa Thuốc Điều Trị";
            this.grpTraCuu.ResumeLayout(false);
            this.grpTraCuu.PerformLayout();
            this.grpKhamBenh.ResumeLayout(false);
            this.grpKhamBenh.PerformLayout();
            this.grpKeToa.ResumeLayout(false);
            this.grpKeToa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

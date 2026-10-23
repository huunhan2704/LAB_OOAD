namespace QuanLyBenhAn_WinForms.Forms
{
    partial class FrmLichHenDinhKy
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpDatHen;
        private System.Windows.Forms.Label lblMaHSBA;
        private System.Windows.Forms.TextBox txtMaHSBA;
        private System.Windows.Forms.Label lblTenBN;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.Label lblQuyKham;
        private System.Windows.Forms.ComboBox cboQuyKham;
        private System.Windows.Forms.Label lblNgayGioHen;
        private System.Windows.Forms.DateTimePicker dtpHenGio;
        private System.Windows.Forms.Label lblBacSi;
        private System.Windows.Forms.ComboBox cboBacSiHen;
        private System.Windows.Forms.Label lblMienPhiGhiChu;
        private System.Windows.Forms.Button btnDatLich;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvLichHen;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpDatHen = new System.Windows.Forms.GroupBox();
            this.lblMienPhiGhiChu = new System.Windows.Forms.Label();
            this.cboBacSiHen = new System.Windows.Forms.ComboBox();
            this.lblBacSi = new System.Windows.Forms.Label();
            this.dtpHenGio = new System.Windows.Forms.DateTimePicker();
            this.lblNgayGioHen = new System.Windows.Forms.Label();
            this.cboQuyKham = new System.Windows.Forms.ComboBox();
            this.lblQuyKham = new System.Windows.Forms.Label();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.lblTenBN = new System.Windows.Forms.Label();
            this.txtMaHSBA = new System.Windows.Forms.TextBox();
            this.lblMaHSBA = new System.Windows.Forms.Label();
            this.btnDatLich = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvLichHen = new System.Windows.Forms.DataGridView();
            this.grpDatHen.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(864, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐẶT LỊCH HẸN KHÁM SỨC KHỎE ĐỊNH KỲ THEO QUÝ (QUYỀN LỢI MIỄN PHÍ)";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDatHen
            // 
            this.grpDatHen.Controls.Add(this.btnDong);
            this.grpDatHen.Controls.Add(this.btnDatLich);
            this.grpDatHen.Controls.Add(this.lblMienPhiGhiChu);
            this.grpDatHen.Controls.Add(this.cboBacSiHen);
            this.grpDatHen.Controls.Add(this.lblBacSi);
            this.grpDatHen.Controls.Add(this.dtpHenGio);
            this.grpDatHen.Controls.Add(this.lblNgayGioHen);
            this.grpDatHen.Controls.Add(this.cboQuyKham);
            this.grpDatHen.Controls.Add(this.lblQuyKham);
            this.grpDatHen.Controls.Add(this.txtTenBN);
            this.grpDatHen.Controls.Add(this.lblTenBN);
            this.grpDatHen.Controls.Add(this.txtMaHSBA);
            this.grpDatHen.Controls.Add(this.lblMaHSBA);
            this.grpDatHen.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDatHen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDatHen.Location = new System.Drawing.Point(10, 55);
            this.grpDatHen.Name = "grpDatHen";
            this.grpDatHen.Size = new System.Drawing.Size(864, 185);
            this.grpDatHen.TabIndex = 1;
            this.grpDatHen.TabStop = false;
            this.grpDatHen.Text = "TIẾP NHẬN CUỘC GỌI KHÁCH HÀNG & THIẾT LẬP LỊCH HẸN KHÁM THEO QUÝ";
            // 
            // lblMaHSBA
            // 
            this.lblMaHSBA.AutoSize = true;
            this.lblMaHSBA.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMaHSBA.Location = new System.Drawing.Point(15, 30);
            this.lblMaHSBA.Name = "lblMaHSBA";
            this.lblMaHSBA.Size = new System.Drawing.Size(126, 17);
            this.lblMaHSBA.TabIndex = 0;
            this.lblMaHSBA.Text = "Mã hồ sơ bệnh án:";
            // 
            // txtMaHSBA
            // 
            this.txtMaHSBA.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaHSBA.Location = new System.Drawing.Point(145, 27);
            this.txtMaHSBA.Name = "txtMaHSBA";
            this.txtMaHSBA.Size = new System.Drawing.Size(150, 24);
            this.txtMaHSBA.TabIndex = 1;
            this.txtMaHSBA.Text = "HSBA00123";
            // 
            // lblTenBN
            // 
            this.lblTenBN.AutoSize = true;
            this.lblTenBN.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTenBN.Location = new System.Drawing.Point(320, 30);
            this.lblTenBN.Name = "lblTenBN";
            this.lblTenBN.Size = new System.Drawing.Size(96, 17);
            this.lblTenBN.TabIndex = 2;
            this.lblTenBN.Text = "Tên bệnh nhân:";
            // 
            // txtTenBN
            // 
            this.txtTenBN.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTenBN.Location = new System.Drawing.Point(420, 27);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(260, 24);
            this.txtTenBN.TabIndex = 3;
            this.txtTenBN.Text = "Nguyễn Văn Hùng";
            // 
            // lblQuyKham
            // 
            this.lblQuyKham.AutoSize = true;
            this.lblQuyKham.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblQuyKham.Location = new System.Drawing.Point(15, 70);
            this.lblQuyKham.Name = "lblQuyKham";
            this.lblQuyKham.Size = new System.Drawing.Size(71, 17);
            this.lblQuyKham.TabIndex = 4;
            this.lblQuyKham.Text = "Đợt khám:";
            // 
            // cboQuyKham
            // 
            this.cboQuyKham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuyKham.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboQuyKham.FormattingEnabled = true;
            this.cboQuyKham.Items.AddRange(new object[] { "Quý 1 / 2026", "Quý 2 / 2026", "Quý 3 / 2026", "Quý 4 / 2026" });
            this.cboQuyKham.Location = new System.Drawing.Point(145, 67);
            this.cboQuyKham.Name = "cboQuyKham";
            this.cboQuyKham.Size = new System.Drawing.Size(150, 24);
            this.cboQuyKham.TabIndex = 5;
            // 
            // lblNgayGioHen
            // 
            this.lblNgayGioHen.AutoSize = true;
            this.lblNgayGioHen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNgayGioHen.Location = new System.Drawing.Point(320, 70);
            this.lblNgayGioHen.Name = "lblNgayGioHen";
            this.lblNgayGioHen.Size = new System.Drawing.Size(147, 17);
            this.lblNgayGioHen.TabIndex = 6;
            this.lblNgayGioHen.Text = "Ngày giờ hẹn (Tự chọn):";
            // 
            // dtpHenGio
            // 
            this.dtpHenGio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpHenGio.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpHenGio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHenGio.Location = new System.Drawing.Point(475, 67);
            this.dtpHenGio.Name = "dtpHenGio";
            this.dtpHenGio.Size = new System.Drawing.Size(160, 24);
            this.dtpHenGio.TabIndex = 7;
            // 
            // lblBacSi
            // 
            this.lblBacSi.AutoSize = true;
            this.lblBacSi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBacSi.Location = new System.Drawing.Point(15, 110);
            this.lblBacSi.Name = "lblBacSi";
            this.lblBacSi.Size = new System.Drawing.Size(103, 17);
            this.lblBacSi.TabIndex = 8;
            this.lblBacSi.Text = "Bác sĩ phụ trách:";
            // 
            // cboBacSiHen
            // 
            this.cboBacSiHen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBacSiHen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboBacSiHen.FormattingEnabled = true;
            this.cboBacSiHen.Items.AddRange(new object[] { "BS001 - ThS.BS Trần Văn Thành", "BS002 - BSCKI Lê Thị Hoa" });
            this.cboBacSiHen.Location = new System.Drawing.Point(145, 107);
            this.cboBacSiHen.Name = "cboBacSiHen";
            this.cboBacSiHen.Size = new System.Drawing.Size(260, 24);
            this.cboBacSiHen.TabIndex = 9;
            // 
            // lblMienPhiGhiChu
            // 
            this.lblMienPhiGhiChu.AutoSize = true;
            this.lblMienPhiGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblMienPhiGhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblMienPhiGhiChu.Location = new System.Drawing.Point(15, 150);
            this.lblMienPhiGhiChu.Name = "lblMienPhiGhiChu";
            this.lblMienPhiGhiChu.Size = new System.Drawing.Size(730, 15);
            this.lblMienPhiGhiChu.TabIndex = 10;
            this.lblMienPhiGhiChu.Text = "* Quyền lợi: Bệnh nhân có hồ sơ bệnh án được khám sức khỏe định kỳ theo quý MIỄN PHÍ (không phải đóng tiền) để tầm soát mầm bệnh sớm.";
            // 
            // btnDatLich
            // 
            this.btnDatLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.btnDatLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLich.ForeColor = System.Drawing.Color.White;
            this.btnDatLich.Location = new System.Drawing.Point(690, 60);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(155, 38);
            this.btnDatLich.TabIndex = 11;
            this.btnDatLich.Text = "XÁC NHẬN ĐẶT HẸN";
            this.btnDatLich.UseVisualStyleBackColor = false;
            this.btnDatLich.Click += new System.EventHandler(this.btnDatLich_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.White;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Location = new System.Drawing.Point(690, 105);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(155, 38);
            this.btnDong.TabIndex = 12;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dgvLichHen);
            this.grpDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.Location = new System.Drawing.Point(10, 240);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(864, 250);
            this.grpDanhSach.TabIndex = 2;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "DANH SÁCH LỊCH HẸN KHÁM ĐỊNH KỲ ĐÃ ĐĂNG KÝ";
            // 
            // dgvLichHen
            // 
            this.dgvLichHen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichHen.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichHen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichHen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichHen.Location = new System.Drawing.Point(3, 21);
            this.dgvLichHen.Name = "dgvLichHen";
            this.dgvLichHen.Size = new System.Drawing.Size(858, 226);
            this.dgvLichHen.TabIndex = 0;
            // 
            // FrmLichHenDinhKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 500);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpDatHen);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "FrmLichHenDinhKy";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đặt Lịch Hẹn Khám Sức Khỏe Định Kỳ Theo Quý";
            this.grpDatHen.ResumeLayout(false);
            this.grpDatHen.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichHen)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

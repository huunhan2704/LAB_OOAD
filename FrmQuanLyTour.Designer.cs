namespace QuanLyTour_VanHoaViet.Forms
{
    partial class FrmQuanLyTour
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpThongTinTour;
        private System.Windows.Forms.Label lblMaTour;
        private System.Windows.Forms.TextBox txtMaTour;
        private System.Windows.Forms.Label lblTenTour;
        private System.Windows.Forms.TextBox txtTenTour;
        private System.Windows.Forms.Label lblSoNgay;
        private System.Windows.Forms.NumericUpDown numSoNgay;
        private System.Windows.Forms.Label lblSoDem;
        private System.Windows.Forms.NumericUpDown numSoDem;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private System.Windows.Forms.Label lblKhoiHanh;
        private System.Windows.Forms.TextBox txtKhoiHanh;
        private System.Windows.Forms.Button btnThemTour;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvTour;
        private System.Windows.Forms.TabControl tabChiTiet;
        private System.Windows.Forms.TabPage tabNoiDungChan;
        private System.Windows.Forms.DataGridView dgvNoiDungChan;
        private System.Windows.Forms.TabPage tabDiemThamQuan;
        private System.Windows.Forms.DataGridView dgvDiemThamQuan;

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
            this.grpThongTinTour = new System.Windows.Forms.GroupBox();
            this.lblMaTour = new System.Windows.Forms.Label();
            this.txtMaTour = new System.Windows.Forms.TextBox();
            this.lblTenTour = new System.Windows.Forms.Label();
            this.txtTenTour = new System.Windows.Forms.TextBox();
            this.lblSoNgay = new System.Windows.Forms.Label();
            this.numSoNgay = new System.Windows.Forms.NumericUpDown();
            this.lblSoDem = new System.Windows.Forms.Label();
            this.numSoDem = new System.Windows.Forms.NumericUpDown();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.numDonGia = new System.Windows.Forms.NumericUpDown();
            this.lblKhoiHanh = new System.Windows.Forms.Label();
            this.txtKhoiHanh = new System.Windows.Forms.TextBox();
            this.btnThemTour = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.tabChiTiet = new System.Windows.Forms.TabControl();
            this.tabNoiDungChan = new System.Windows.Forms.TabPage();
            this.dgvNoiDungChan = new System.Windows.Forms.DataGridView();
            this.tabDiemThamQuan = new System.Windows.Forms.TabPage();
            this.dgvDiemThamQuan = new System.Windows.Forms.DataGridView();
            this.grpThongTinTour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoDem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            this.tabChiTiet.SuspendLayout();
            this.tabNoiDungChan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoiDungChan)).BeginInit();
            this.tabDiemThamQuan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemThamQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThongTinTour
            // 
            this.grpThongTinTour.Controls.Add(this.btnDong);
            this.grpThongTinTour.Controls.Add(this.btnThemTour);
            this.grpThongTinTour.Controls.Add(this.txtKhoiHanh);
            this.grpThongTinTour.Controls.Add(this.lblKhoiHanh);
            this.grpThongTinTour.Controls.Add(this.numDonGia);
            this.grpThongTinTour.Controls.Add(this.lblDonGia);
            this.grpThongTinTour.Controls.Add(this.numSoDem);
            this.grpThongTinTour.Controls.Add(this.lblSoDem);
            this.grpThongTinTour.Controls.Add(this.numSoNgay);
            this.grpThongTinTour.Controls.Add(this.lblSoNgay);
            this.grpThongTinTour.Controls.Add(this.txtTenTour);
            this.grpThongTinTour.Controls.Add(this.lblTenTour);
            this.grpThongTinTour.Controls.Add(this.txtMaTour);
            this.grpThongTinTour.Controls.Add(this.lblMaTour);
            this.grpThongTinTour.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTinTour.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTinTour.Location = new System.Drawing.Point(10, 10);
            this.grpThongTinTour.Name = "grpThongTinTour";
            this.grpThongTinTour.Size = new System.Drawing.Size(964, 150);
            this.grpThongTinTour.TabIndex = 0;
            this.grpThongTinTour.TabStop = false;
            this.grpThongTinTour.Text = "THÔNG TIN TOUR DU LỊCH";
            // 
            // lblMaTour
            // 
            this.lblMaTour.AutoSize = true;
            this.lblMaTour.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblMaTour.Location = new System.Drawing.Point(15, 30);
            this.lblMaTour.Name = "lblMaTour";
            this.lblMaTour.Size = new System.Drawing.Size(59, 17);
            this.lblMaTour.TabIndex = 0;
            this.lblMaTour.Text = "Mã Tour:";
            // 
            // txtMaTour
            // 
            this.txtMaTour.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaTour.Location = new System.Drawing.Point(80, 27);
            this.txtMaTour.Name = "txtMaTour";
            this.txtMaTour.Size = new System.Drawing.Size(120, 24);
            this.txtMaTour.TabIndex = 1;
            // 
            // lblTenTour
            // 
            this.lblTenTour.AutoSize = true;
            this.lblTenTour.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTenTour.Location = new System.Drawing.Point(220, 30);
            this.lblTenTour.Name = "lblTenTour";
            this.lblTenTour.Size = new System.Drawing.Size(62, 17);
            this.lblTenTour.TabIndex = 2;
            this.lblTenTour.Text = "Tên Tour:";
            // 
            // txtTenTour
            // 
            this.txtTenTour.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTenTour.Location = new System.Drawing.Point(288, 27);
            this.txtTenTour.Name = "txtTenTour";
            this.txtTenTour.Size = new System.Drawing.Size(350, 24);
            this.txtTenTour.TabIndex = 3;
            // 
            // lblSoNgay
            // 
            this.lblSoNgay.AutoSize = true;
            this.lblSoNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSoNgay.Location = new System.Drawing.Point(660, 30);
            this.lblSoNgay.Name = "lblSoNgay";
            this.lblSoNgay.Size = new System.Drawing.Size(60, 17);
            this.lblSoNgay.TabIndex = 4;
            this.lblSoNgay.Text = "Số ngày:";
            // 
            // numSoNgay
            // 
            this.numSoNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numSoNgay.Location = new System.Drawing.Point(725, 27);
            this.numSoNgay.Name = "numSoNgay";
            this.numSoNgay.Size = new System.Drawing.Size(60, 24);
            this.numSoNgay.TabIndex = 5;
            this.numSoNgay.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lblSoDem
            // 
            this.lblSoDem.AutoSize = true;
            this.lblSoDem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSoDem.Location = new System.Drawing.Point(800, 30);
            this.lblSoDem.Name = "lblSoDem";
            this.lblSoDem.Size = new System.Drawing.Size(56, 17);
            this.lblSoDem.TabIndex = 6;
            this.lblSoDem.Text = "Số đêm:";
            // 
            // numSoDem
            // 
            this.numSoDem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numSoDem.Location = new System.Drawing.Point(862, 27);
            this.numSoDem.Name = "numSoDem";
            this.numSoDem.Size = new System.Drawing.Size(60, 24);
            this.numSoDem.TabIndex = 7;
            this.numSoDem.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDonGia.Location = new System.Drawing.Point(15, 75);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(109, 17);
            this.lblDonGia.TabIndex = 8;
            this.lblDonGia.Text = "Đơn giá / 1 khách:";
            // 
            // numDonGia
            // 
            this.numDonGia.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.numDonGia.Increment = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numDonGia.Location = new System.Drawing.Point(130, 72);
            this.numDonGia.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numDonGia.Name = "numDonGia";
            this.numDonGia.Size = new System.Drawing.Size(160, 24);
            this.numDonGia.TabIndex = 9;
            this.numDonGia.ThousandsSeparator = true;
            this.numDonGia.Value = new decimal(new int[] { 3500000, 0, 0, 0 });
            // 
            // lblKhoiHanh
            // 
            this.lblKhoiHanh.AutoSize = true;
            this.lblKhoiHanh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblKhoiHanh.Location = new System.Drawing.Point(310, 75);
            this.lblKhoiHanh.Name = "lblKhoiHanh";
            this.lblKhoiHanh.Size = new System.Drawing.Size(95, 17);
            this.lblKhoiHanh.TabIndex = 10;
            this.lblKhoiHanh.Text = "Nơi khởi hành:";
            // 
            // txtKhoiHanh
            // 
            this.txtKhoiHanh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtKhoiHanh.Location = new System.Drawing.Point(410, 72);
            this.txtKhoiHanh.Name = "txtKhoiHanh";
            this.txtKhoiHanh.ReadOnly = true;
            this.txtKhoiHanh.Size = new System.Drawing.Size(120, 24);
            this.txtKhoiHanh.TabIndex = 11;
            this.txtKhoiHanh.Text = "TP.HCM";
            // 
            // btnThemTour
            // 
            this.btnThemTour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.btnThemTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTour.ForeColor = System.Drawing.Color.White;
            this.btnThemTour.Location = new System.Drawing.Point(660, 68);
            this.btnThemTour.Name = "btnThemTour";
            this.btnThemTour.Size = new System.Drawing.Size(130, 32);
            this.btnThemTour.TabIndex = 12;
            this.btnThemTour.Text = "Lưu Tour Mới";
            this.btnThemTour.UseVisualStyleBackColor = false;
            this.btnThemTour.Click += new System.EventHandler(this.btnThemTour_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.White;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Location = new System.Drawing.Point(800, 68);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 32);
            this.btnDong.TabIndex = 13;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // dgvTour
            // 
            this.dgvTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTour.BackgroundColor = System.Drawing.Color.White;
            this.dgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTour.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTour.Location = new System.Drawing.Point(10, 160);
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.Size = new System.Drawing.Size(964, 160);
            this.dgvTour.TabIndex = 1;
            // 
            // tabChiTiet
            // 
            this.tabChiTiet.Controls.Add(this.tabNoiDungChan);
            this.tabChiTiet.Controls.Add(this.tabDiemThamQuan);
            this.tabChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabChiTiet.Location = new System.Drawing.Point(10, 320);
            this.tabChiTiet.Name = "tabChiTiet";
            this.tabChiTiet.SelectedIndex = 0;
            this.tabChiTiet.Size = new System.Drawing.Size(964, 250);
            this.tabChiTiet.TabIndex = 2;
            // 
            // tabNoiDungChan
            // 
            this.tabNoiDungChan.Controls.Add(this.dgvNoiDungChan);
            this.tabNoiDungChan.Location = new System.Drawing.Point(4, 25);
            this.tabNoiDungChan.Name = "tabNoiDungChan";
            this.tabNoiDungChan.Padding = new System.Windows.Forms.Padding(5);
            this.tabNoiDungChan.Size = new System.Drawing.Size(956, 221);
            this.tabNoiDungChan.TabIndex = 0;
            this.tabNoiDungChan.Text = "Nơi dừng chân & Phương tiện / Khách sạn (2,3,4,5 sao)";
            this.tabNoiDungChan.UseVisualStyleBackColor = true;
            // 
            // dgvNoiDungChan
            // 
            this.dgvNoiDungChan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNoiDungChan.BackgroundColor = System.Drawing.Color.White;
            this.dgvNoiDungChan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoiDungChan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNoiDungChan.Location = new System.Drawing.Point(5, 5);
            this.dgvNoiDungChan.Name = "dgvNoiDungChan";
            this.dgvNoiDungChan.Size = new System.Drawing.Size(946, 211);
            this.dgvNoiDungChan.TabIndex = 0;
            // 
            // tabDiemThamQuan
            // 
            this.tabDiemThamQuan.Controls.Add(this.dgvDiemThamQuan);
            this.tabDiemThamQuan.Location = new System.Drawing.Point(4, 25);
            this.tabDiemThamQuan.Name = "tabDiemThamQuan";
            this.tabDiemThamQuan.Padding = new System.Windows.Forms.Padding(5);
            this.tabDiemThamQuan.Size = new System.Drawing.Size(956, 221);
            this.tabDiemThamQuan.TabIndex = 1;
            this.tabDiemThamQuan.Text = "Điểm tham quan (Khu di tích lịch sử, danh lam thắng cảnh)";
            this.tabDiemThamQuan.UseVisualStyleBackColor = true;
            // 
            // dgvDiemThamQuan
            // 
            this.dgvDiemThamQuan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiemThamQuan.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiemThamQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemThamQuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiemThamQuan.Location = new System.Drawing.Point(5, 5);
            this.dgvDiemThamQuan.Name = "dgvDiemThamQuan";
            this.dgvDiemThamQuan.Size = new System.Drawing.Size(946, 211);
            this.dgvDiemThamQuan.TabIndex = 0;
            // 
            // FrmQuanLyTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 580);
            this.Controls.Add(this.tabChiTiet);
            this.Controls.Add(this.dgvTour);
            this.Controls.Add(this.grpThongTinTour);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "FrmQuanLyTour";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý Thông tin Tour Du lịch - Văn Hóa Việt TP.HCM";
            this.grpThongTinTour.ResumeLayout(false);
            this.grpThongTinTour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoDem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            this.tabChiTiet.ResumeLayout(false);
            this.tabNoiDungChan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoiDungChan)).EndInit();
            this.tabDiemThamQuan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemThamQuan)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

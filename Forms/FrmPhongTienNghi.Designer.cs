namespace QuanLyKhachSan.Forms
{
    partial class FrmPhongTienNghi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPhong = new System.Windows.Forms.TabPage();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.cboKhu = new System.Windows.Forms.ComboBox();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.lblPhong = new System.Windows.Forms.Label();
            this.lblKhu = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.tabTN = new System.Windows.Forms.TabPage();
            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.txtMaTN = new System.Windows.Forms.TextBox();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.numSTT = new System.Windows.Forms.NumericUpDown();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.btnThemTN = new System.Windows.Forms.Button();
            this.lblMaTN = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblSTT = new System.Windows.Forms.Label();
            this.lblTT = new System.Windows.Forms.Label();
            this.tabLD = new System.Windows.Forms.TabPage();
            this.dgvLD = new System.Windows.Forms.DataGridView();
            this.txtSoLD = new System.Windows.Forms.TextBox();
            this.cboTN = new System.Windows.Forms.ComboBox();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.txtTTLD = new System.Windows.Forms.TextBox();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnLapDat = new System.Windows.Forms.Button();
            this.lblSoLD = new System.Windows.Forms.Label();
            this.lblTN = new System.Windows.Forms.Label();
            this.lblPhongLD = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblTTLD = new System.Windows.Forms.Label();
            this.lblNV = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            this.tabTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).BeginInit();
            this.tabLD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPhong);
            this.tabControl1.Controls.Add(this.tabTN);
            this.tabControl1.Controls.Add(this.tabLD);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(880, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPhong
            // 
            this.tabPhong.Controls.Add(this.lblGia);
            this.tabPhong.Controls.Add(this.lblMax);
            this.tabPhong.Controls.Add(this.lblKhu);
            this.tabPhong.Controls.Add(this.lblPhong);
            this.tabPhong.Controls.Add(this.btnThemPhong);
            this.tabPhong.Controls.Add(this.numGia);
            this.tabPhong.Controls.Add(this.numMax);
            this.tabPhong.Controls.Add(this.cboKhu);
            this.tabPhong.Controls.Add(this.txtPhong);
            this.tabPhong.Controls.Add(this.dgvPhong);
            this.tabPhong.Location = new System.Drawing.Point(4, 25);
            this.tabPhong.Name = "tabPhong";
            this.tabPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhong.Size = new System.Drawing.Size(872, 471);
            this.tabPhong.TabIndex = 0;
            this.tabPhong.Text = "Phòng";
            this.tabPhong.UseVisualStyleBackColor = true;
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPhong.Location = new System.Drawing.Point(3, 3);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.Size = new System.Drawing.Size(866, 330);
            this.dgvPhong.TabIndex = 0;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(100, 360);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(120, 22);
            this.txtPhong.TabIndex = 1;
            // 
            // cboKhu
            // 
            this.cboKhu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhu.FormattingEnabled = true;
            this.cboKhu.Location = new System.Drawing.Point(320, 360);
            this.cboKhu.Name = "cboKhu";
            this.cboKhu.Size = new System.Drawing.Size(150, 24);
            this.cboKhu.TabIndex = 2;
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(100, 410);
            this.numMax.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(120, 22);
            this.numMax.TabIndex = 3;
            this.numMax.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // numGia
            // 
            this.numGia.Location = new System.Drawing.Point(320, 410);
            this.numGia.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numGia.Name = "numGia";
            this.numGia.Size = new System.Drawing.Size(150, 22);
            this.numGia.TabIndex = 4;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(540, 375);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(120, 45);
            this.btnThemPhong.TabIndex = 5;
            this.btnThemPhong.Text = "Thêm phòng";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(20, 363);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(68, 16);
            this.lblPhong.TabIndex = 6;
            this.lblPhong.Text = "Số phòng:";
            // 
            // lblKhu
            // 
            this.lblKhu.AutoSize = true;
            this.lblKhu.Location = new System.Drawing.Point(250, 363);
            this.lblKhu.Name = "lblKhu";
            this.lblKhu.Size = new System.Drawing.Size(56, 16);
            this.lblKhu.TabIndex = 7;
            this.lblKhu.Text = "Khu vực:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(20, 413);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(64, 16);
            this.lblMax.TabIndex = 8;
            this.lblMax.Text = "Sức chứa:";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(250, 413);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(56, 16);
            this.lblGia.TabIndex = 9;
            this.lblGia.Text = "Đơn giá:";
            // 
            // tabTN
            // 
            this.tabTN.Controls.Add(this.lblTT);
            this.tabTN.Controls.Add(this.lblSTT);
            this.tabTN.Controls.Add(this.lblLoai);
            this.tabTN.Controls.Add(this.lblMaTN);
            this.tabTN.Controls.Add(this.btnThemTN);
            this.tabTN.Controls.Add(this.txtTinhTrang);
            this.tabTN.Controls.Add(this.numSTT);
            this.tabTN.Controls.Add(this.cboLoai);
            this.tabTN.Controls.Add(this.txtMaTN);
            this.tabTN.Controls.Add(this.dgvTN);
            this.tabTN.Location = new System.Drawing.Point(4, 25);
            this.tabTN.Name = "tabTN";
            this.tabTN.Padding = new System.Windows.Forms.Padding(3);
            this.tabTN.Size = new System.Drawing.Size(872, 471);
            this.tabTN.TabIndex = 1;
            this.tabTN.Text = "Tiện nghi";
            this.tabTN.UseVisualStyleBackColor = true;
            // 
            // dgvTN
            // 
            this.dgvTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTN.Location = new System.Drawing.Point(3, 3);
            this.dgvTN.Name = "dgvTN";
            this.dgvTN.RowHeadersWidth = 51;
            this.dgvTN.Size = new System.Drawing.Size(866, 330);
            this.dgvTN.TabIndex = 0;
            // 
            // txtMaTN
            // 
            this.txtMaTN.Location = new System.Drawing.Point(100, 360);
            this.txtMaTN.Name = "txtMaTN";
            this.txtMaTN.Size = new System.Drawing.Size(120, 22);
            this.txtMaTN.TabIndex = 1;
            // 
            // cboLoai
            // 
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(320, 360);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(150, 24);
            this.cboLoai.TabIndex = 2;
            // 
            // numSTT
            // 
            this.numSTT.Location = new System.Drawing.Point(100, 410);
            this.numSTT.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSTT.Name = "numSTT";
            this.numSTT.Size = new System.Drawing.Size(120, 22);
            this.numSTT.TabIndex = 3;
            this.numSTT.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(320, 410);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(150, 22);
            this.txtTinhTrang.TabIndex = 4;
            // 
            // btnThemTN
            // 
            this.btnThemTN.Location = new System.Drawing.Point(540, 375);
            this.btnThemTN.Name = "btnThemTN";
            this.btnThemTN.Size = new System.Drawing.Size(120, 45);
            this.btnThemTN.TabIndex = 5;
            this.btnThemTN.Text = "Thêm tiện nghi";
            this.btnThemTN.UseVisualStyleBackColor = true;
            this.btnThemTN.Click += new System.EventHandler(this.btnThemTN_Click);
            // 
            // lblMaTN
            // 
            this.lblMaTN.AutoSize = true;
            this.lblMaTN.Location = new System.Drawing.Point(20, 363);
            this.lblMaTN.Name = "lblMaTN";
            this.lblMaTN.Size = new System.Drawing.Size(51, 16);
            this.lblMaTN.TabIndex = 6;
            this.lblMaTN.Text = "Mã TN:";
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(250, 363);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(56, 16);
            this.lblLoai.TabIndex = 7;
            this.lblLoai.Text = "Loại TN:";
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.Location = new System.Drawing.Point(20, 413);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(37, 16);
            this.lblSTT.TabIndex = 8;
            this.lblSTT.Text = "STT:";
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.Location = new System.Drawing.Point(240, 413);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(69, 16);
            this.lblTT.TabIndex = 9;
            this.lblTT.Text = "Tình trạng:";
            // 
            // tabLD
            // 
            this.tabLD.Controls.Add(this.lblGhiChu);
            this.tabLD.Controls.Add(this.lblNV);
            this.tabLD.Controls.Add(this.lblTTLD);
            this.tabLD.Controls.Add(this.lblNgay);
            this.tabLD.Controls.Add(this.lblPhongLD);
            this.tabLD.Controls.Add(this.lblTN);
            this.tabLD.Controls.Add(this.lblSoLD);
            this.tabLD.Controls.Add(this.btnLapDat);
            this.tabLD.Controls.Add(this.txtGhiChu);
            this.tabLD.Controls.Add(this.cboNV);
            this.tabLD.Controls.Add(this.txtTTLD);
            this.tabLD.Controls.Add(this.dtNgay);
            this.tabLD.Controls.Add(this.cboPhong);
            this.tabLD.Controls.Add(this.cboTN);
            this.tabLD.Controls.Add(this.txtSoLD);
            this.tabLD.Controls.Add(this.dgvLD);
            this.tabLD.Location = new System.Drawing.Point(4, 25);
            this.tabLD.Name = "tabLD";
            this.tabLD.Size = new System.Drawing.Size(872, 471);
            this.tabLD.TabIndex = 2;
            this.tabLD.Text = "Lắp đặt / luân chuyển";
            this.tabLD.UseVisualStyleBackColor = true;
            // 
            // dgvLD
            // 
            this.dgvLD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLD.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLD.Location = new System.Drawing.Point(0, 0);
            this.dgvLD.Name = "dgvLD";
            this.dgvLD.RowHeadersWidth = 51;
            this.dgvLD.Size = new System.Drawing.Size(872, 280);
            this.dgvLD.TabIndex = 0;
            // 
            // txtSoLD
            // 
            this.txtSoLD.Location = new System.Drawing.Point(90, 300);
            this.txtSoLD.Name = "txtSoLD";
            this.txtSoLD.Size = new System.Drawing.Size(120, 22);
            this.txtSoLD.TabIndex = 1;
            // 
            // cboTN
            // 
            this.cboTN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTN.FormattingEnabled = true;
            this.cboTN.Location = new System.Drawing.Point(310, 300);
            this.cboTN.Name = "cboTN";
            this.cboTN.Size = new System.Drawing.Size(140, 24);
            this.cboTN.TabIndex = 2;
            // 
            // cboPhong
            // 
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(540, 300);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(120, 24);
            this.cboPhong.TabIndex = 3;
            // 
            // dtNgay
            // 
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(740, 300);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(120, 22);
            this.dtNgay.TabIndex = 4;
            // 
            // txtTTLD
            // 
            this.txtTTLD.Location = new System.Drawing.Point(90, 350);
            this.txtTTLD.Name = "txtTTLD";
            this.txtTTLD.Size = new System.Drawing.Size(120, 22);
            this.txtTTLD.TabIndex = 5;
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(310, 350);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(140, 24);
            this.cboNV.TabIndex = 6;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(540, 350);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(320, 22);
            this.txtGhiChu.TabIndex = 7;
            // 
            // btnLapDat
            // 
            this.btnLapDat.Location = new System.Drawing.Point(370, 405);
            this.btnLapDat.Name = "btnLapDat";
            this.btnLapDat.Size = new System.Drawing.Size(140, 45);
            this.btnLapDat.TabIndex = 8;
            this.btnLapDat.Text = "Lập phiếu lắp đặt";
            this.btnLapDat.UseVisualStyleBackColor = true;
            this.btnLapDat.Click += new System.EventHandler(this.btnLapDat_Click);
            // 
            // lblSoLD
            // 
            this.lblSoLD.AutoSize = true;
            this.lblSoLD.Location = new System.Drawing.Point(20, 303);
            this.lblSoLD.Name = "lblSoLD";
            this.lblSoLD.Size = new System.Drawing.Size(63, 16);
            this.lblSoLD.TabIndex = 9;
            this.lblSoLD.Text = "Số phiếu:";
            // 
            // lblTN
            // 
            this.lblTN.AutoSize = true;
            this.lblTN.Location = new System.Drawing.Point(240, 303);
            this.lblTN.Name = "lblTN";
            this.lblTN.Size = new System.Drawing.Size(65, 16);
            this.lblTN.TabIndex = 10;
            this.lblTN.Text = "Tiện nghi:";
            // 
            // lblPhongLD
            // 
            this.lblPhongLD.AutoSize = true;
            this.lblPhongLD.Location = new System.Drawing.Point(480, 303);
            this.lblPhongLD.Name = "lblPhongLD";
            this.lblPhongLD.Size = new System.Drawing.Size(49, 16);
            this.lblPhongLD.TabIndex = 11;
            this.lblPhongLD.Text = "Phòng:";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(680, 303);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(43, 16);
            this.lblNgay.TabIndex = 12;
            this.lblNgay.Text = "Ngày:";
            // 
            // lblTTLD
            // 
            this.lblTTLD.AutoSize = true;
            this.lblTTLD.Location = new System.Drawing.Point(20, 353);
            this.lblTTLD.Name = "lblTTLD";
            this.lblTTLD.Size = new System.Drawing.Size(69, 16);
            this.lblTTLD.TabIndex = 13;
            this.lblTTLD.Text = "Tình trạng:";
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Location = new System.Drawing.Point(240, 353);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(70, 16);
            this.lblNV.TabIndex = 14;
            this.lblNV.Text = "Nhân viên:";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(480, 353);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(54, 16);
            this.lblGhiChu.TabIndex = 15;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(760, 510);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 35);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmPhongTienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 555);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmPhongTienNghi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Phòng - Tiện nghi";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPhong.ResumeLayout(false);
            this.tabPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            this.tabTN.ResumeLayout(false);
            this.tabTN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).EndInit();
            this.tabLD.ResumeLayout(false);
            this.tabLD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPhong;
        private System.Windows.Forms.TabPage tabTN;
        private System.Windows.Forms.TabPage tabLD;

        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.ComboBox cboKhu;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblKhu;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblGia;

        private System.Windows.Forms.DataGridView dgvTN;
        private System.Windows.Forms.TextBox txtMaTN;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.NumericUpDown numSTT;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Button btnThemTN;
        private System.Windows.Forms.Label lblMaTN;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.Label lblTT;

        private System.Windows.Forms.DataGridView dgvLD;
        private System.Windows.Forms.TextBox txtSoLD;
        private System.Windows.Forms.ComboBox cboTN;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.TextBox txtTTLD;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnLapDat;
        private System.Windows.Forms.Label lblSoLD;
        private System.Windows.Forms.Label lblTN;
        private System.Windows.Forms.Label lblPhongLD;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblTTLD;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.Label lblGhiChu;

        private System.Windows.Forms.Button btnDong;
    }
}
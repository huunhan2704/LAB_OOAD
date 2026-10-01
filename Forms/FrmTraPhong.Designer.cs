namespace QuanLyKhachSan.Forms
{
    partial class FrmTraPhong
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
            this.lblDat = new System.Windows.Forms.Label();
            this.cboDat = new System.Windows.Forms.ComboBox();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.txtSoDB = new System.Windows.Forms.TextBox();
            this.txtMucDo = new System.Windows.Forms.TextBox();
            this.numDenBu = new System.Windows.Forms.NumericUpDown();
            this.btnThemDB = new System.Windows.Forms.Button();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.btnLapDB = new System.Windows.Forms.Button();
            this.dgvDBChon = new System.Windows.Forms.DataGridView();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.numSoNgay = new System.Windows.Forms.NumericUpDown();
            this.cboNV2 = new System.Windows.Forms.ComboBox();
            this.btnLapHD = new System.Windows.Forms.Button();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.txtHDChon = new System.Windows.Forms.TextBox();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.cboHT = new System.Windows.Forms.ComboBox();
            this.numTienTT = new System.Windows.Forms.NumericUpDown();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDat
            // 
            this.lblDat.AutoSize = true;
            this.lblDat.Location = new System.Drawing.Point(20, 20);
            this.lblDat.Name = "lblDat";
            this.lblDat.Size = new System.Drawing.Size(89, 16);
            this.lblDat.TabIndex = 0;
            this.lblDat.Text = "Phiếu đang ở:";
            // 
            // cboDat
            // 
            this.cboDat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDat.FormattingEnabled = true;
            this.cboDat.Location = new System.Drawing.Point(120, 17);
            this.cboDat.Name = "cboDat";
            this.cboDat.Size = new System.Drawing.Size(160, 24);
            this.cboDat.TabIndex = 1;
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(20, 55);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.Size = new System.Drawing.Size(260, 160);
            this.dgvPhong.TabIndex = 2;
            this.dgvPhong.SelectionChanged += new System.EventHandler(this.dgvPhong_SelectionChanged);
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(300, 17);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.ReadOnly = true;
            this.txtPhong.Size = new System.Drawing.Size(80, 22);
            this.txtPhong.TabIndex = 3;
            // 
            // dgvTN
            // 
            this.dgvTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTN.Location = new System.Drawing.Point(300, 55);
            this.dgvTN.Name = "dgvTN";
            this.dgvTN.RowHeadersWidth = 51;
            this.dgvTN.Size = new System.Drawing.Size(320, 160);
            this.dgvTN.TabIndex = 4;
            // 
            // txtSoDB
            // 
            this.txtSoDB.Location = new System.Drawing.Point(640, 17);
            this.txtSoDB.Name = "txtSoDB";
            this.txtSoDB.Size = new System.Drawing.Size(100, 22);
            this.txtSoDB.TabIndex = 5;
            // 
            // txtMucDo
            // 
            this.txtMucDo.Location = new System.Drawing.Point(640, 55);
            this.txtMucDo.Name = "txtMucDo";
            this.txtMucDo.Size = new System.Drawing.Size(120, 22);
            this.txtMucDo.TabIndex = 6;
            // 
            // numDenBu
            // 
            this.numDenBu.Location = new System.Drawing.Point(770, 55);
            this.numDenBu.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numDenBu.Name = "numDenBu";
            this.numDenBu.Size = new System.Drawing.Size(120, 22);
            this.numDenBu.TabIndex = 7;
            // 
            // btnThemDB
            // 
            this.btnThemDB.Location = new System.Drawing.Point(900, 50);
            this.btnThemDB.Name = "btnThemDB";
            this.btnThemDB.Size = new System.Drawing.Size(70, 32);
            this.btnThemDB.TabIndex = 8;
            this.btnThemDB.Text = "Thêm";
            this.btnThemDB.UseVisualStyleBackColor = true;
            this.btnThemDB.Click += new System.EventHandler(this.btnThemDB_Click);
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(760, 17);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(130, 24);
            this.cboNV.TabIndex = 9;
            // 
            // btnLapDB
            // 
            this.btnLapDB.Location = new System.Drawing.Point(900, 12);
            this.btnLapDB.Name = "btnLapDB";
            this.btnLapDB.Size = new System.Drawing.Size(70, 32);
            this.btnLapDB.TabIndex = 10;
            this.btnLapDB.Text = "Lập ĐB";
            this.btnLapDB.UseVisualStyleBackColor = true;
            this.btnLapDB.Click += new System.EventHandler(this.btnLapDB_Click);
            // 
            // dgvDBChon
            // 
            this.dgvDBChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDBChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDBChon.Location = new System.Drawing.Point(640, 90);
            this.dgvDBChon.Name = "dgvDBChon";
            this.dgvDBChon.RowHeadersWidth = 51;
            this.dgvDBChon.Size = new System.Drawing.Size(330, 125);
            this.dgvDBChon.TabIndex = 11;
            // 
            // txtSoHD
            // 
            this.txtSoHD.Location = new System.Drawing.Point(20, 235);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(100, 22);
            this.txtSoHD.TabIndex = 12;
            // 
            // numSoNgay
            // 
            this.numSoNgay.Location = new System.Drawing.Point(135, 235);
            this.numSoNgay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoNgay.Name = "numSoNgay";
            this.numSoNgay.Size = new System.Drawing.Size(65, 22);
            this.numSoNgay.TabIndex = 13;
            this.numSoNgay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboNV2
            // 
            this.cboNV2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV2.FormattingEnabled = true;
            this.cboNV2.Location = new System.Drawing.Point(215, 235);
            this.cboNV2.Name = "cboNV2";
            this.cboNV2.Size = new System.Drawing.Size(140, 24);
            this.cboNV2.TabIndex = 14;
            // 
            // btnLapHD
            // 
            this.btnLapHD.Location = new System.Drawing.Point(370, 230);
            this.btnLapHD.Name = "btnLapHD";
            this.btnLapHD.Size = new System.Drawing.Size(110, 32);
            this.btnLapHD.TabIndex = 15;
            this.btnLapHD.Text = "Lập hóa đơn";
            this.btnLapHD.UseVisualStyleBackColor = true;
            this.btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);
            // 
            // dgvHD
            // 
            this.dgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Location = new System.Drawing.Point(20, 275);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.RowHeadersWidth = 51;
            this.dgvHD.Size = new System.Drawing.Size(950, 180);
            this.dgvHD.TabIndex = 16;
            this.dgvHD.SelectionChanged += new System.EventHandler(this.dgvHD_SelectionChanged);
            // 
            // txtHDChon
            // 
            this.txtHDChon.Location = new System.Drawing.Point(20, 480);
            this.txtHDChon.Name = "txtHDChon";
            this.txtHDChon.ReadOnly = true;
            this.txtHDChon.Size = new System.Drawing.Size(100, 22);
            this.txtHDChon.TabIndex = 17;
            // 
            // txtMaTT
            // 
            this.txtMaTT.Location = new System.Drawing.Point(140, 480);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(100, 22);
            this.txtMaTT.TabIndex = 18;
            // 
            // cboHT
            // 
            this.cboHT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHT.FormattingEnabled = true;
            this.cboHT.Location = new System.Drawing.Point(260, 480);
            this.cboHT.Name = "cboHT";
            this.cboHT.Size = new System.Drawing.Size(130, 24);
            this.cboHT.TabIndex = 19;
            // 
            // numTienTT
            // 
            this.numTienTT.Location = new System.Drawing.Point(410, 480);
            this.numTienTT.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numTienTT.Name = "numTienTT";
            this.numTienTT.Size = new System.Drawing.Size(130, 22);
            this.numTienTT.TabIndex = 20;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(560, 475);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(110, 32);
            this.btnThanhToan.TabIndex = 21;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Location = new System.Drawing.Point(690, 475);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(140, 32);
            this.btnTraPhong.TabIndex = 22;
            this.btnTraPhong.Text = "Hoàn tất trả phòng";
            this.btnTraPhong.UseVisualStyleBackColor = true;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(850, 475);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(90, 32);
            this.btnDong.TabIndex = 23;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 525);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.numTienTT);
            this.Controls.Add(this.cboHT);
            this.Controls.Add(this.txtMaTT);
            this.Controls.Add(this.txtHDChon);
            this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.btnLapHD);
            this.Controls.Add(this.cboNV2);
            this.Controls.Add(this.numSoNgay);
            this.Controls.Add(this.txtSoHD);
            this.Controls.Add(this.dgvDBChon);
            this.Controls.Add(this.btnLapDB);
            this.Controls.Add(this.cboNV);
            this.Controls.Add(this.btnThemDB);
            this.Controls.Add(this.numDenBu);
            this.Controls.Add(this.txtMucDo);
            this.Controls.Add(this.txtSoDB);
            this.Controls.Add(this.dgvTN);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.cboDat);
            this.Controls.Add(this.lblDat);
            this.Name = "FrmTraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả phòng và Thanh toán";
            this.Load += new System.EventHandler(this.Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDat;
        private System.Windows.Forms.ComboBox cboDat;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.DataGridView dgvTN;

        private System.Windows.Forms.TextBox txtSoDB;
        private System.Windows.Forms.TextBox txtMucDo;
        private System.Windows.Forms.NumericUpDown numDenBu;
        private System.Windows.Forms.Button btnThemDB;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Button btnLapDB;
        private System.Windows.Forms.DataGridView dgvDBChon;

        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.NumericUpDown numSoNgay;
        private System.Windows.Forms.ComboBox cboNV2;
        private System.Windows.Forms.Button btnLapHD;
        private System.Windows.Forms.DataGridView dgvHD;

        private System.Windows.Forms.TextBox txtHDChon;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.ComboBox cboHT;
        private System.Windows.Forms.NumericUpDown numTienTT;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnDong;
    }
}
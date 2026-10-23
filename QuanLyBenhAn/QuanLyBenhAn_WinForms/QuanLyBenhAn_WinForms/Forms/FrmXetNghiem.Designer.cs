namespace QuanLyBenhAn_WinForms.Forms
{
    partial class FrmXetNghiem
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblPhieuXN;
        private System.Windows.Forms.Label lblBenhNhan;
        private System.Windows.Forms.Label lblBSChiDinh;
        private System.Windows.Forms.DataGridView dgvKetQuaXN;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblBSChiDinh = new System.Windows.Forms.Label();
            this.lblBenhNhan = new System.Windows.Forms.Label();
            this.lblPhieuXN = new System.Windows.Forms.Label();
            this.dgvKetQuaXN = new System.Windows.Forms.DataGridView();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaXN)).BeginInit();
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
            this.lblTitle.Text = "KHOA XÉT NGHIỆM CẬN LÂM SÀNG - CẬP NHẬT CHỈ SỐ ĐO LƯỜNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblBSChiDinh);
            this.grpThongTin.Controls.Add(this.lblBenhNhan);
            this.grpThongTin.Controls.Add(this.lblPhieuXN);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.Location = new System.Drawing.Point(10, 55);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(864, 70);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "THÔNG TIN PHIẾU CHỈ ĐỊNH XÉT NGHIỆM";
            // 
            // lblPhieuXN
            // 
            this.lblPhieuXN.AutoSize = true;
            this.lblPhieuXN.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPhieuXN.Location = new System.Drawing.Point(15, 30);
            this.lblPhieuXN.Name = "lblPhieuXN";
            this.lblPhieuXN.Size = new System.Drawing.Size(134, 17);
            this.lblPhieuXN.TabIndex = 0;
            this.lblPhieuXN.Text = "Mã phiếu: PXN202610";
            // 
            // lblBenhNhan
            // 
            this.lblBenhNhan.AutoSize = true;
            this.lblBenhNhan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblBenhNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.lblBenhNhan.Location = new System.Drawing.Point(220, 30);
            this.lblBenhNhan.Name = "lblBenhNhan";
            this.lblBenhNhan.Size = new System.Drawing.Size(275, 17);
            this.lblBenhNhan.TabIndex = 1;
            this.lblBenhNhan.Text = "Bệnh nhân: Nguyễn Văn Hùng (HSBA00123)";
            // 
            // lblBSChiDinh
            // 
            this.lblBSChiDinh.AutoSize = true;
            this.lblBSChiDinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblBSChiDinh.Location = new System.Drawing.Point(530, 30);
            this.lblBSChiDinh.Name = "lblBSChiDinh";
            this.lblBSChiDinh.Size = new System.Drawing.Size(275, 17);
            this.lblBSChiDinh.TabIndex = 2;
            this.lblBSChiDinh.Text = "Bác sĩ chỉ định: ThS.BS Trần Văn Thành (Nội)";
            // 
            // dgvKetQuaXN
            // 
            this.dgvKetQuaXN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQuaXN.BackgroundColor = System.Drawing.Color.White;
            this.dgvKetQuaXN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQuaXN.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvKetQuaXN.Location = new System.Drawing.Point(10, 125);
            this.dgvKetQuaXN.Name = "dgvKetQuaXN";
            this.dgvKetQuaXN.Size = new System.Drawing.Size(864, 270);
            this.dgvKetQuaXN.TabIndex = 2;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(92)))));
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(550, 410);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(210, 42);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "LƯU KẾT QUẢ XÉT NGHIỆM";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.White;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDong.Location = new System.Drawing.Point(770, 410);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 42);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmXetNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 465);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.dgvKetQuaXN);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Name = "FrmXetNghiem";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khoa Xét Nghiệm Cận Lâm Sàng";
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQuaXN)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

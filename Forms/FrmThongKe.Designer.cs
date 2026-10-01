namespace QuanLyKhachSan.Forms
{
    partial class FrmThongKe
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
            this.lblTu = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.btnTK = new System.Windows.Forms.Button();
            this.dgvTongHop = new System.Windows.Forms.DataGridView();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Location = new System.Drawing.Point(30, 25);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(59, 16);
            this.lblTu.TabIndex = 0;
            this.lblTu.Text = "Từ ngày:";
            // 
            // dtTu
            // 
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTu.Location = new System.Drawing.Point(100, 22);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(140, 22);
            this.dtTu.TabIndex = 1;
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(270, 25);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(67, 16);
            this.lblDen.TabIndex = 2;
            this.lblDen.Text = "Đến ngày:";
            // 
            // dtDen
            // 
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(350, 22);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(140, 22);
            this.dtDen.TabIndex = 3;
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(520, 17);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(120, 32);
            this.btnTK.TabIndex = 4;
            this.btnTK.Text = "Thống kê";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // dgvTongHop
            // 
            this.dgvTongHop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTongHop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongHop.Location = new System.Drawing.Point(30, 70);
            this.dgvTongHop.Name = "dgvTongHop";
            this.dgvTongHop.RowHeadersWidth = 51;
            this.dgvTongHop.Size = new System.Drawing.Size(740, 160);
            this.dgvTongHop.TabIndex = 5;
            // 
            // dgvDV
            // 
            this.dgvDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Location = new System.Drawing.Point(30, 250);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowHeadersWidth = 51;
            this.dgvDV.Size = new System.Drawing.Size(740, 200);
            this.dgvDV.TabIndex = 6;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(670, 465);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 35);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvDV);
            this.Controls.Add(this.dgvTongHop);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.lblTu);
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.DataGridView dgvTongHop;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.Button btnDong;
    }
}
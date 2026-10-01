namespace QuanLyKhachSan.Forms
{
    partial class FrmDanhMuc
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
            this.tabKhu = new System.Windows.Forms.TabPage();
            this.lblKhuTen = new System.Windows.Forms.Label();
            this.lblKhuMa = new System.Windows.Forms.Label();
            this.btnThemKhu = new System.Windows.Forms.Button();
            this.txtKhuTen = new System.Windows.Forms.TextBox();
            this.txtKhuMa = new System.Windows.Forms.TextBox();
            this.dgvKhu = new System.Windows.Forms.DataGridView();
            this.tabNV = new System.Windows.Forms.TabPage();
            this.lblNVSDT = new System.Windows.Forms.Label();
            this.lblNVVT = new System.Windows.Forms.Label();
            this.lblNVTen = new System.Windows.Forms.Label();
            this.lblNVMa = new System.Windows.Forms.Label();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.txtNVSDT = new System.Windows.Forms.TextBox();
            this.txtNVVaiTro = new System.Windows.Forms.TextBox();
            this.txtNVTen = new System.Windows.Forms.TextBox();
            this.txtNVMa = new System.Windows.Forms.TextBox();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.tabLoaiTN = new System.Windows.Forms.TabPage();
            this.lblLTNTen = new System.Windows.Forms.Label();
            this.lblLTNMa = new System.Windows.Forms.Label();
            this.btnThemLoaiTN = new System.Windows.Forms.Button();
            this.txtLoaiTen = new System.Windows.Forms.TextBox();
            this.txtLoaiMa = new System.Windows.Forms.TextBox();
            this.dgvLoaiTN = new System.Windows.Forms.DataGridView();
            this.tabDV = new System.Windows.Forms.TabPage();
            this.lblDVGia = new System.Windows.Forms.Label();
            this.lblDVDVT = new System.Windows.Forms.Label();
            this.lblDVTen = new System.Windows.Forms.Label();
            this.lblDVMa = new System.Windows.Forms.Label();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.numDVGia = new System.Windows.Forms.NumericUpDown();
            this.txtDVDVT = new System.Windows.Forms.TextBox();
            this.txtDVTen = new System.Windows.Forms.TextBox();
            this.txtDVMa = new System.Windows.Forms.TextBox();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.tabQD = new System.Windows.Forms.TabPage();
            this.lblQDTien = new System.Windows.Forms.Label();
            this.lblQDMuc = new System.Windows.Forms.Label();
            this.lblQDLoai = new System.Windows.Forms.Label();
            this.lblQDMa = new System.Windows.Forms.Label();
            this.btnThemQD = new System.Windows.Forms.Button();
            this.numQDTien = new System.Windows.Forms.NumericUpDown();
            this.txtQDMucDo = new System.Windows.Forms.TextBox();
            this.cboQDLoai = new System.Windows.Forms.ComboBox();
            this.txtQDMa = new System.Windows.Forms.TextBox();
            this.dgvQD = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabKhu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).BeginInit();
            this.tabNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.tabLoaiTN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).BeginInit();
            this.tabDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.tabQD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabKhu);
            this.tabControl1.Controls.Add(this.tabNV);
            this.tabControl1.Controls.Add(this.tabLoaiTN);
            this.tabControl1.Controls.Add(this.tabDV);
            this.tabControl1.Controls.Add(this.tabQD);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 480);
            this.tabControl1.TabIndex = 0;
            // 
            // tabKhu
            // 
            this.tabKhu.Controls.Add(this.lblKhuTen);
            this.tabKhu.Controls.Add(this.lblKhuMa);
            this.tabKhu.Controls.Add(this.btnThemKhu);
            this.tabKhu.Controls.Add(this.txtKhuTen);
            this.tabKhu.Controls.Add(this.txtKhuMa);
            this.tabKhu.Controls.Add(this.dgvKhu);
            this.tabKhu.Location = new System.Drawing.Point(4, 25);
            this.tabKhu.Name = "tabKhu";
            this.tabKhu.Padding = new System.Windows.Forms.Padding(3);
            this.tabKhu.Size = new System.Drawing.Size(776, 451);
            this.tabKhu.TabIndex = 0;
            this.tabKhu.Text = "Khu vực";
            this.tabKhu.UseVisualStyleBackColor = true;
            // 
            // lblKhuTen
            // 
            this.lblKhuTen.AutoSize = true;
            this.lblKhuTen.Location = new System.Drawing.Point(300, 353);
            this.lblKhuTen.Name = "lblKhuTen";
            this.lblKhuTen.Size = new System.Drawing.Size(58, 16);
            this.lblKhuTen.TabIndex = 0;
            this.lblKhuTen.Text = "Tên khu:";
            // 
            // lblKhuMa
            // 
            this.lblKhuMa.AutoSize = true;
            this.lblKhuMa.Location = new System.Drawing.Point(30, 353);
            this.lblKhuMa.Name = "lblKhuMa";
            this.lblKhuMa.Size = new System.Drawing.Size(53, 16);
            this.lblKhuMa.TabIndex = 1;
            this.lblKhuMa.Text = "Mã khu:";
            // 
            // btnThemKhu
            // 
            this.btnThemKhu.Location = new System.Drawing.Point(620, 345);
            this.btnThemKhu.Name = "btnThemKhu";
            this.btnThemKhu.Size = new System.Drawing.Size(100, 32);
            this.btnThemKhu.TabIndex = 3;
            this.btnThemKhu.Text = "Thêm khu";
            this.btnThemKhu.UseVisualStyleBackColor = true;
            this.btnThemKhu.Click += new System.EventHandler(this.btnThemKhu_Click);
            // 
            // txtKhuTen
            // 
            this.txtKhuTen.Location = new System.Drawing.Point(380, 350);
            this.txtKhuTen.Name = "txtKhuTen";
            this.txtKhuTen.Size = new System.Drawing.Size(200, 22);
            this.txtKhuTen.TabIndex = 2;
            // 
            // txtKhuMa
            // 
            this.txtKhuMa.Location = new System.Drawing.Point(89, 350);
            this.txtKhuMa.Name = "txtKhuMa";
            this.txtKhuMa.Size = new System.Drawing.Size(150, 22);
            this.txtKhuMa.TabIndex = 1;
            // 
            // dgvKhu
            // 
            this.dgvKhu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvKhu.Location = new System.Drawing.Point(3, 3);
            this.dgvKhu.Name = "dgvKhu";
            this.dgvKhu.RowHeadersWidth = 51;
            this.dgvKhu.Size = new System.Drawing.Size(770, 323);
            this.dgvKhu.TabIndex = 0;
            // 
            // tabNV
            // 
            this.tabNV.Controls.Add(this.lblNVSDT);
            this.tabNV.Controls.Add(this.lblNVVT);
            this.tabNV.Controls.Add(this.lblNVTen);
            this.tabNV.Controls.Add(this.lblNVMa);
            this.tabNV.Controls.Add(this.btnThemNV);
            this.tabNV.Controls.Add(this.txtNVSDT);
            this.tabNV.Controls.Add(this.txtNVVaiTro);
            this.tabNV.Controls.Add(this.txtNVTen);
            this.tabNV.Controls.Add(this.txtNVMa);
            this.tabNV.Controls.Add(this.dgvNV);
            this.tabNV.Location = new System.Drawing.Point(4, 25);
            this.tabNV.Name = "tabNV";
            this.tabNV.Padding = new System.Windows.Forms.Padding(3);
            this.tabNV.Size = new System.Drawing.Size(776, 451);
            this.tabNV.TabIndex = 1;
            this.tabNV.Text = "Nhân viên";
            this.tabNV.UseVisualStyleBackColor = true;
            // 
            // lblNVSDT
            // 
            this.lblNVSDT.AutoSize = true;
            this.lblNVSDT.Location = new System.Drawing.Point(250, 383);
            this.lblNVSDT.Name = "lblNVSDT";
            this.lblNVSDT.Size = new System.Drawing.Size(37, 16);
            this.lblNVSDT.TabIndex = 8;
            this.lblNVSDT.Text = "SĐT:";
            // 
            // lblNVVT
            // 
            this.lblNVVT.AutoSize = true;
            this.lblNVVT.Location = new System.Drawing.Point(20, 383);
            this.lblNVVT.Name = "lblNVVT";
            this.lblNVVT.Size = new System.Drawing.Size(48, 16);
            this.lblNVVT.TabIndex = 7;
            this.lblNVVT.Text = "Vai trò:";
            // 
            // lblNVTen
            // 
            this.lblNVTen.AutoSize = true;
            this.lblNVTen.Location = new System.Drawing.Point(250, 333);
            this.lblNVTen.Name = "lblNVTen";
            this.lblNVTen.Size = new System.Drawing.Size(49, 16);
            this.lblNVTen.TabIndex = 9;
            this.lblNVTen.Text = "Họ tên:";
            // 
            // lblNVMa
            // 
            this.lblNVMa.AutoSize = true;
            this.lblNVMa.Location = new System.Drawing.Point(20, 333);
            this.lblNVMa.Name = "lblNVMa";
            this.lblNVMa.Size = new System.Drawing.Size(51, 16);
            this.lblNVMa.TabIndex = 6;
            this.lblNVMa.Text = "Mã NV:";
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(560, 345);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(120, 45);
            this.btnThemNV.TabIndex = 5;
            this.btnThemNV.Text = "Thêm nhân viên";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // txtNVSDT
            // 
            this.txtNVSDT.Location = new System.Drawing.Point(320, 380);
            this.txtNVSDT.Name = "txtNVSDT";
            this.txtNVSDT.Size = new System.Drawing.Size(180, 22);
            this.txtNVSDT.TabIndex = 4;
            // 
            // txtNVVaiTro
            // 
            this.txtNVVaiTro.Location = new System.Drawing.Point(100, 380);
            this.txtNVVaiTro.Name = "txtNVVaiTro";
            this.txtNVVaiTro.Size = new System.Drawing.Size(120, 22);
            this.txtNVVaiTro.TabIndex = 3;
            // 
            // txtNVTen
            // 
            this.txtNVTen.Location = new System.Drawing.Point(320, 330);
            this.txtNVTen.Name = "txtNVTen";
            this.txtNVTen.Size = new System.Drawing.Size(180, 22);
            this.txtNVTen.TabIndex = 2;
            // 
            // txtNVMa
            // 
            this.txtNVMa.Location = new System.Drawing.Point(100, 330);
            this.txtNVMa.Name = "txtNVMa";
            this.txtNVMa.Size = new System.Drawing.Size(120, 22);
            this.txtNVMa.TabIndex = 1;
            // 
            // dgvNV
            // 
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvNV.Location = new System.Drawing.Point(3, 3);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.Size = new System.Drawing.Size(770, 300);
            this.dgvNV.TabIndex = 0;
            // 
            // tabLoaiTN
            // 
            this.tabLoaiTN.Controls.Add(this.lblLTNTen);
            this.tabLoaiTN.Controls.Add(this.lblLTNMa);
            this.tabLoaiTN.Controls.Add(this.btnThemLoaiTN);
            this.tabLoaiTN.Controls.Add(this.txtLoaiTen);
            this.tabLoaiTN.Controls.Add(this.txtLoaiMa);
            this.tabLoaiTN.Controls.Add(this.dgvLoaiTN);
            this.tabLoaiTN.Location = new System.Drawing.Point(4, 25);
            this.tabLoaiTN.Name = "tabLoaiTN";
            this.tabLoaiTN.Size = new System.Drawing.Size(776, 451);
            this.tabLoaiTN.TabIndex = 2;
            this.tabLoaiTN.Text = "Loại tiện nghi";
            this.tabLoaiTN.UseVisualStyleBackColor = true;
            // 
            // lblLTNTen
            // 
            this.lblLTNTen.AutoSize = true;
            this.lblLTNTen.Location = new System.Drawing.Point(300, 353);
            this.lblLTNTen.Name = "lblLTNTen";
            this.lblLTNTen.Size = new System.Drawing.Size(59, 16);
            this.lblLTNTen.TabIndex = 5;
            this.lblLTNTen.Text = "Tên loại:";
            // 
            // lblLTNMa
            // 
            this.lblLTNMa.AutoSize = true;
            this.lblLTNMa.Location = new System.Drawing.Point(30, 353);
            this.lblLTNMa.Name = "lblLTNMa";
            this.lblLTNMa.Size = new System.Drawing.Size(54, 16);
            this.lblLTNMa.TabIndex = 4;
            this.lblLTNMa.Text = "Mã loại:";
            // 
            // btnThemLoaiTN
            // 
            this.btnThemLoaiTN.Location = new System.Drawing.Point(620, 345);
            this.btnThemLoaiTN.Name = "btnThemLoaiTN";
            this.btnThemLoaiTN.Size = new System.Drawing.Size(100, 32);
            this.btnThemLoaiTN.TabIndex = 3;
            this.btnThemLoaiTN.Text = "Thêm loại";
            this.btnThemLoaiTN.UseVisualStyleBackColor = true;
            this.btnThemLoaiTN.Click += new System.EventHandler(this.btnThemLoaiTN_Click);
            // 
            // txtLoaiTen
            // 
            this.txtLoaiTen.Location = new System.Drawing.Point(380, 350);
            this.txtLoaiTen.Name = "txtLoaiTen";
            this.txtLoaiTen.Size = new System.Drawing.Size(200, 22);
            this.txtLoaiTen.TabIndex = 2;
            // 
            // txtLoaiMa
            // 
            this.txtLoaiMa.Location = new System.Drawing.Point(120, 350);
            this.txtLoaiMa.Name = "txtLoaiMa";
            this.txtLoaiMa.Size = new System.Drawing.Size(150, 22);
            this.txtLoaiMa.TabIndex = 1;
            // 
            // dgvLoaiTN
            // 
            this.dgvLoaiTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLoaiTN.Location = new System.Drawing.Point(0, 0);
            this.dgvLoaiTN.Name = "dgvLoaiTN";
            this.dgvLoaiTN.RowHeadersWidth = 51;
            this.dgvLoaiTN.Size = new System.Drawing.Size(776, 320);
            this.dgvLoaiTN.TabIndex = 0;
            // 
            // tabDV
            // 
            this.tabDV.Controls.Add(this.lblDVGia);
            this.tabDV.Controls.Add(this.lblDVDVT);
            this.tabDV.Controls.Add(this.lblDVTen);
            this.tabDV.Controls.Add(this.lblDVMa);
            this.tabDV.Controls.Add(this.btnThemDV);
            this.tabDV.Controls.Add(this.numDVGia);
            this.tabDV.Controls.Add(this.txtDVDVT);
            this.tabDV.Controls.Add(this.txtDVTen);
            this.tabDV.Controls.Add(this.txtDVMa);
            this.tabDV.Controls.Add(this.dgvDV);
            this.tabDV.Location = new System.Drawing.Point(4, 25);
            this.tabDV.Name = "tabDV";
            this.tabDV.Size = new System.Drawing.Size(776, 451);
            this.tabDV.TabIndex = 3;
            this.tabDV.Text = "Dịch vụ";
            this.tabDV.UseVisualStyleBackColor = true;
            // 
            // lblDVGia
            // 
            this.lblDVGia.AutoSize = true;
            this.lblDVGia.Location = new System.Drawing.Point(240, 383);
            this.lblDVGia.Name = "lblDVGia";
            this.lblDVGia.Size = new System.Drawing.Size(56, 16);
            this.lblDVGia.TabIndex = 9;
            this.lblDVGia.Text = "Đơn giá:";
            // 
            // lblDVDVT
            // 
            this.lblDVDVT.AutoSize = true;
            this.lblDVDVT.Location = new System.Drawing.Point(20, 383);
            this.lblDVDVT.Name = "lblDVDVT";
            this.lblDVDVT.Size = new System.Drawing.Size(37, 16);
            this.lblDVDVT.TabIndex = 8;
            this.lblDVDVT.Text = "ĐVT:";
            // 
            // lblDVTen
            // 
            this.lblDVTen.AutoSize = true;
            this.lblDVTen.Location = new System.Drawing.Point(240, 333);
            this.lblDVTen.Name = "lblDVTen";
            this.lblDVTen.Size = new System.Drawing.Size(56, 16);
            this.lblDVTen.TabIndex = 7;
            this.lblDVTen.Text = "Tên DV:";
            // 
            // lblDVMa
            // 
            this.lblDVMa.AutoSize = true;
            this.lblDVMa.Location = new System.Drawing.Point(20, 333);
            this.lblDVMa.Name = "lblDVMa";
            this.lblDVMa.Size = new System.Drawing.Size(51, 16);
            this.lblDVMa.TabIndex = 6;
            this.lblDVMa.Text = "Mã DV:";
            // 
            // btnThemDV
            // 
            this.btnThemDV.Location = new System.Drawing.Point(560, 345);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(120, 45);
            this.btnThemDV.TabIndex = 5;
            this.btnThemDV.Text = "Thêm dịch vụ";
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // numDVGia
            // 
            this.numDVGia.Location = new System.Drawing.Point(320, 380);
            this.numDVGia.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numDVGia.Name = "numDVGia";
            this.numDVGia.Size = new System.Drawing.Size(180, 22);
            this.numDVGia.TabIndex = 4;
            // 
            // txtDVDVT
            // 
            this.txtDVDVT.Location = new System.Drawing.Point(90, 380);
            this.txtDVDVT.Name = "txtDVDVT";
            this.txtDVDVT.Size = new System.Drawing.Size(120, 22);
            this.txtDVDVT.TabIndex = 3;
            // 
            // txtDVTen
            // 
            this.txtDVTen.Location = new System.Drawing.Point(320, 330);
            this.txtDVTen.Name = "txtDVTen";
            this.txtDVTen.Size = new System.Drawing.Size(180, 22);
            this.txtDVTen.TabIndex = 2;
            // 
            // txtDVMa
            // 
            this.txtDVMa.Location = new System.Drawing.Point(90, 330);
            this.txtDVMa.Name = "txtDVMa";
            this.txtDVMa.Size = new System.Drawing.Size(120, 22);
            this.txtDVMa.TabIndex = 1;
            // 
            // dgvDV
            // 
            this.dgvDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDV.Location = new System.Drawing.Point(0, 0);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowHeadersWidth = 51;
            this.dgvDV.Size = new System.Drawing.Size(776, 300);
            this.dgvDV.TabIndex = 0;
            // 
            // tabQD
            // 
            this.tabQD.Controls.Add(this.lblQDTien);
            this.tabQD.Controls.Add(this.lblQDMuc);
            this.tabQD.Controls.Add(this.lblQDLoai);
            this.tabQD.Controls.Add(this.lblQDMa);
            this.tabQD.Controls.Add(this.btnThemQD);
            this.tabQD.Controls.Add(this.numQDTien);
            this.tabQD.Controls.Add(this.txtQDMucDo);
            this.tabQD.Controls.Add(this.cboQDLoai);
            this.tabQD.Controls.Add(this.txtQDMa);
            this.tabQD.Controls.Add(this.dgvQD);
            this.tabQD.Location = new System.Drawing.Point(4, 25);
            this.tabQD.Name = "tabQD";
            this.tabQD.Size = new System.Drawing.Size(776, 451);
            this.tabQD.TabIndex = 4;
            this.tabQD.Text = "Quy định đền bù";
            this.tabQD.UseVisualStyleBackColor = true;
            // 
            // lblQDTien
            // 
            this.lblQDTien.AutoSize = true;
            this.lblQDTien.Location = new System.Drawing.Point(240, 383);
            this.lblQDTien.Name = "lblQDTien";
            this.lblQDTien.Size = new System.Drawing.Size(51, 16);
            this.lblQDTien.TabIndex = 9;
            this.lblQDTien.Text = "Số tiền:";
            // 
            // lblQDMuc
            // 
            this.lblQDMuc.AutoSize = true;
            this.lblQDMuc.Location = new System.Drawing.Point(20, 383);
            this.lblQDMuc.Name = "lblQDMuc";
            this.lblQDMuc.Size = new System.Drawing.Size(54, 16);
            this.lblQDMuc.TabIndex = 8;
            this.lblQDMuc.Text = "Mức độ:";
            // 
            // lblQDLoai
            // 
            this.lblQDLoai.AutoSize = true;
            this.lblQDLoai.Location = new System.Drawing.Point(240, 333);
            this.lblQDLoai.Name = "lblQDLoai";
            this.lblQDLoai.Size = new System.Drawing.Size(58, 16);
            this.lblQDLoai.TabIndex = 7;
            this.lblQDLoai.Text = "Loại TN:";
            // 
            // lblQDMa
            // 
            this.lblQDMa.AutoSize = true;
            this.lblQDMa.Location = new System.Drawing.Point(20, 333);
            this.lblQDMa.Name = "lblQDMa";
            this.lblQDMa.Size = new System.Drawing.Size(51, 16);
            this.lblQDMa.TabIndex = 6;
            this.lblQDMa.Text = "Mã QĐ:";
            // 
            // btnThemQD
            // 
            this.btnThemQD.Location = new System.Drawing.Point(560, 345);
            this.btnThemQD.Name = "btnThemQD";
            this.btnThemQD.Size = new System.Drawing.Size(120, 45);
            this.btnThemQD.TabIndex = 5;
            this.btnThemQD.Text = "Thêm quy định";
            this.btnThemQD.UseVisualStyleBackColor = true;
            this.btnThemQD.Click += new System.EventHandler(this.btnThemQD_Click);
            // 
            // numQDTien
            // 
            this.numQDTien.Location = new System.Drawing.Point(320, 380);
            this.numQDTien.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numQDTien.Name = "numQDTien";
            this.numQDTien.Size = new System.Drawing.Size(180, 22);
            this.numQDTien.TabIndex = 4;
            // 
            // txtQDMucDo
            // 
            this.txtQDMucDo.Location = new System.Drawing.Point(90, 380);
            this.txtQDMucDo.Name = "txtQDMucDo";
            this.txtQDMucDo.Size = new System.Drawing.Size(120, 22);
            this.txtQDMucDo.TabIndex = 3;
            // 
            // cboQDLoai
            // 
            this.cboQDLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQDLoai.FormattingEnabled = true;
            this.cboQDLoai.Location = new System.Drawing.Point(320, 330);
            this.cboQDLoai.Name = "cboQDLoai";
            this.cboQDLoai.Size = new System.Drawing.Size(180, 24);
            this.cboQDLoai.TabIndex = 2;
            // 
            // txtQDMa
            // 
            this.txtQDMa.Location = new System.Drawing.Point(90, 330);
            this.txtQDMa.Name = "txtQDMa";
            this.txtQDMa.Size = new System.Drawing.Size(120, 22);
            this.txtQDMa.TabIndex = 1;
            // 
            // dgvQD
            // 
            this.dgvQD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQD.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvQD.Location = new System.Drawing.Point(0, 0);
            this.dgvQD.Name = "dgvQD";
            this.dgvQD.RowHeadersWidth = 51;
            this.dgvQD.Size = new System.Drawing.Size(776, 300);
            this.dgvQD.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(670, 490);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(90, 30);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 530);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Danh mục";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabKhu.ResumeLayout(false);
            this.tabKhu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).EndInit();
            this.tabNV.ResumeLayout(false);
            this.tabNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.tabLoaiTN.ResumeLayout(false);
            this.tabLoaiTN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).EndInit();
            this.tabDV.ResumeLayout(false);
            this.tabDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.tabQD.ResumeLayout(false);
            this.tabQD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabKhu;
        private System.Windows.Forms.TabPage tabNV;
        private System.Windows.Forms.TabPage tabLoaiTN;
        private System.Windows.Forms.TabPage tabDV;
        private System.Windows.Forms.TabPage tabQD;

        private System.Windows.Forms.DataGridView dgvKhu;
        private System.Windows.Forms.TextBox txtKhuMa;
        private System.Windows.Forms.TextBox txtKhuTen;
        private System.Windows.Forms.Button btnThemKhu;
        private System.Windows.Forms.Label lblKhuMa;
        private System.Windows.Forms.Label lblKhuTen;

        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.TextBox txtNVMa;
        private System.Windows.Forms.TextBox txtNVTen;
        private System.Windows.Forms.TextBox txtNVVaiTro;
        private System.Windows.Forms.TextBox txtNVSDT;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Label lblNVMa;
        private System.Windows.Forms.Label lblNVTen;
        private System.Windows.Forms.Label lblNVVT;
        private System.Windows.Forms.Label lblNVSDT;

        private System.Windows.Forms.DataGridView dgvLoaiTN;
        private System.Windows.Forms.TextBox txtLoaiMa;
        private System.Windows.Forms.TextBox txtLoaiTen;
        private System.Windows.Forms.Button btnThemLoaiTN;
        private System.Windows.Forms.Label lblLTNMa;
        private System.Windows.Forms.Label lblLTNTen;

        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.TextBox txtDVMa;
        private System.Windows.Forms.TextBox txtDVTen;
        private System.Windows.Forms.TextBox txtDVDVT;
        private System.Windows.Forms.NumericUpDown numDVGia;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Label lblDVMa;
        private System.Windows.Forms.Label lblDVTen;
        private System.Windows.Forms.Label lblDVDVT;
        private System.Windows.Forms.Label lblDVGia;

        private System.Windows.Forms.DataGridView dgvQD;
        private System.Windows.Forms.TextBox txtQDMa;
        private System.Windows.Forms.ComboBox cboQDLoai;
        private System.Windows.Forms.TextBox txtQDMucDo;
        private System.Windows.Forms.NumericUpDown numQDTien;
        private System.Windows.Forms.Button btnThemQD;
        private System.Windows.Forms.Label lblQDMa;
        private System.Windows.Forms.Label lblQDLoai;
        private System.Windows.Forms.Label lblQDMuc;
        private System.Windows.Forms.Label lblQDTien;

        private System.Windows.Forms.Button btnDong;
    }
}
namespace QuanLyKhachSan.Forms
{
    partial class FrmDatPhong
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
            this.tabKH = new System.Windows.Forms.TabPage();
            this.dgvKhach = new System.Windows.Forms.DataGridView();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtQT = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnThemKhach = new System.Windows.Forms.Button();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblQT = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.tabDP = new System.Windows.Forms.TabPage();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.cboKhach = new System.Windows.Forms.ComboBox();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.cboKenh = new System.Windows.Forms.ComboBox();
            this.dtLap = new System.Windows.Forms.DateTimePicker();
            this.dtNhan = new System.Windows.Forms.DateTimePicker();
            this.dtTra = new System.Windows.Forms.DateTimePicker();
            this.numCoc = new System.Windows.Forms.NumericUpDown();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.numSoNguoi = new System.Windows.Forms.NumericUpDown();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.btnBoPhong = new System.Windows.Forms.Button();
            this.dgvChon = new System.Windows.Forms.DataGridView();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.lblSoP = new System.Windows.Forms.Label();
            this.lblKhach = new System.Windows.Forms.Label();
            this.lblNVL = new System.Windows.Forms.Label();
            this.lblKenh = new System.Windows.Forms.Label();
            this.lblNgayL = new System.Windows.Forms.Label();
            this.lblNgayN = new System.Windows.Forms.Label();
            this.lblNgayT = new System.Windows.Forms.Label();
            this.lblCoc = new System.Windows.Forms.Label();
            this.tabNP = new System.Windows.Forms.TabPage();
            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            this.txtPhieuChon = new System.Windows.Forms.TextBox();
            this.dgvCT = new System.Windows.Forms.DataGridView();
            this.dgvNguoi = new System.Windows.Forms.DataGridView();
            this.txtNguoiPhong = new System.Windows.Forms.TextBox();
            this.txtNguoiTen = new System.Windows.Forms.TextBox();
            this.txtNguoiCMND = new System.Windows.Forms.TextBox();
            this.txtNguoiQT = new System.Windows.Forms.TextBox();
            this.btnThemNguoi = new System.Windows.Forms.Button();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.btnNoShow = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            this.tabDP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).BeginInit();
            this.tabNP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabKH);
            this.tabControl1.Controls.Add(this.tabDP);
            this.tabControl1.Controls.Add(this.tabNP);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(980, 560);
            this.tabControl1.TabIndex = 0;
            // 
            // tabKH
            // 
            this.tabKH.Controls.Add(this.lblSDT);
            this.tabKH.Controls.Add(this.lblQT);
            this.tabKH.Controls.Add(this.lblCMND);
            this.tabKH.Controls.Add(this.lblTenKH);
            this.tabKH.Controls.Add(this.lblMaKH);
            this.tabKH.Controls.Add(this.btnThemKhach);
            this.tabKH.Controls.Add(this.txtSDT);
            this.tabKH.Controls.Add(this.txtQT);
            this.tabKH.Controls.Add(this.txtCMND);
            this.tabKH.Controls.Add(this.txtTenKH);
            this.tabKH.Controls.Add(this.txtMaKH);
            this.tabKH.Controls.Add(this.dgvKhach);
            this.tabKH.Location = new System.Drawing.Point(4, 25);
            this.tabKH.Name = "tabKH";
            this.tabKH.Padding = new System.Windows.Forms.Padding(3);
            this.tabKH.Size = new System.Drawing.Size(972, 531);
            this.tabKH.TabIndex = 0;
            this.tabKH.Text = "Khách hàng";
            this.tabKH.UseVisualStyleBackColor = true;
            // 
            // dgvKhach
            // 
            this.dgvKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhach.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvKhach.Location = new System.Drawing.Point(3, 3);
            this.dgvKhach.Name = "dgvKhach";
            this.dgvKhach.RowHeadersWidth = 51;
            this.dgvKhach.Size = new System.Drawing.Size(966, 380);
            this.dgvKhach.TabIndex = 0;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(90, 410);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(120, 22);
            this.txtMaKH.TabIndex = 1;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(300, 410);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(180, 22);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(580, 410);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(150, 22);
            this.txtCMND.TabIndex = 3;
            // 
            // txtQT
            // 
            this.txtQT.Location = new System.Drawing.Point(90, 460);
            this.txtQT.Name = "txtQT";
            this.txtQT.Size = new System.Drawing.Size(120, 22);
            this.txtQT.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(300, 460);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(180, 22);
            this.txtSDT.TabIndex = 5;
            // 
            // btnThemKhach
            // 
            this.btnThemKhach.Location = new System.Drawing.Point(580, 450);
            this.btnThemKhach.Name = "btnThemKhach";
            this.btnThemKhach.Size = new System.Drawing.Size(150, 40);
            this.btnThemKhach.TabIndex = 6;
            this.btnThemKhach.Text = "Lưu khách hàng";
            this.btnThemKhach.UseVisualStyleBackColor = true;
            this.btnThemKhach.Click += new System.EventHandler(this.btnThemKhach_Click);
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(20, 413);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(51, 16);
            this.lblMaKH.TabIndex = 7;
            this.lblMaKH.Text = "Mã KH:";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(230, 413);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(49, 16);
            this.lblTenKH.TabIndex = 8;
            this.lblTenKH.Text = "Họ tên:";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(510, 413);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(48, 16);
            this.lblCMND.TabIndex = 9;
            this.lblCMND.Text = "CMND:";
            // 
            // lblQT
            // 
            this.lblQT.AutoSize = true;
            this.lblQT.Location = new System.Drawing.Point(20, 463);
            this.lblQT.Name = "lblQT";
            this.lblQT.Size = new System.Drawing.Size(65, 16);
            this.lblQT.TabIndex = 10;
            this.lblQT.Text = "Quốc tịch:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(230, 463);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(37, 16);
            this.lblSDT.TabIndex = 11;
            this.lblSDT.Text = "SĐT:";
            // 
            // tabDP
            // 
            this.tabDP.Controls.Add(this.btnLapPhieu);
            this.tabDP.Controls.Add(this.dgvChon);
            this.tabDP.Controls.Add(this.btnBoPhong);
            this.tabDP.Controls.Add(this.btnThemPhong);
            this.tabDP.Controls.Add(this.numSoNguoi);
            this.tabDP.Controls.Add(this.dgvPhong);
            this.tabDP.Controls.Add(this.numCoc);
            this.tabDP.Controls.Add(this.dtTra);
            this.tabDP.Controls.Add(this.dtNhan);
            this.tabDP.Controls.Add(this.dtLap);
            this.tabDP.Controls.Add(this.cboKenh);
            this.tabDP.Controls.Add(this.cboNV);
            this.tabDP.Controls.Add(this.cboKhach);
            this.tabDP.Controls.Add(this.txtSoPhieu);
            this.tabDP.Controls.Add(this.lblCoc);
            this.tabDP.Controls.Add(this.lblNgayT);
            this.tabDP.Controls.Add(this.lblNgayN);
            this.tabDP.Controls.Add(this.lblNgayL);
            this.tabDP.Controls.Add(this.lblKenh);
            this.tabDP.Controls.Add(this.lblNVL);
            this.tabDP.Controls.Add(this.lblKhach);
            this.tabDP.Controls.Add(this.lblSoP);
            this.tabDP.Location = new System.Drawing.Point(4, 25);
            this.tabDP.Name = "tabDP";
            this.tabDP.Padding = new System.Windows.Forms.Padding(3);
            this.tabDP.Size = new System.Drawing.Size(972, 531);
            this.tabDP.TabIndex = 1;
            this.tabDP.Text = "Đặt phòng";
            this.tabDP.UseVisualStyleBackColor = true;
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(90, 20);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(120, 22);
            this.txtSoPhieu.TabIndex = 0;
            // 
            // cboKhach
            // 
            this.cboKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhach.FormattingEnabled = true;
            this.cboKhach.Location = new System.Drawing.Point(300, 20);
            this.cboKhach.Name = "cboKhach";
            this.cboKhach.Size = new System.Drawing.Size(160, 24);
            this.cboKhach.TabIndex = 1;
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(550, 20);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(150, 24);
            this.cboNV.TabIndex = 2;
            // 
            // cboKenh
            // 
            this.cboKenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKenh.FormattingEnabled = true;
            this.cboKenh.Location = new System.Drawing.Point(790, 20);
            this.cboKenh.Name = "cboKenh";
            this.cboKenh.Size = new System.Drawing.Size(140, 24);
            this.cboKenh.TabIndex = 3;
            // 
            // dtLap
            // 
            this.dtLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtLap.Location = new System.Drawing.Point(90, 70);
            this.dtLap.Name = "dtLap";
            this.dtLap.Size = new System.Drawing.Size(120, 22);
            this.dtLap.TabIndex = 4;
            // 
            // dtNhan
            // 
            this.dtNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNhan.Location = new System.Drawing.Point(300, 70);
            this.dtNhan.Name = "dtNhan";
            this.dtNhan.Size = new System.Drawing.Size(160, 22);
            this.dtNhan.TabIndex = 5;
            // 
            // dtTra
            // 
            this.dtTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTra.Location = new System.Drawing.Point(550, 70);
            this.dtTra.Name = "dtTra";
            this.dtTra.Size = new System.Drawing.Size(150, 22);
            this.dtTra.TabIndex = 6;
            // 
            // numCoc
            // 
            this.numCoc.Location = new System.Drawing.Point(790, 70);
            this.numCoc.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numCoc.Name = "numCoc";
            this.numCoc.Size = new System.Drawing.Size(140, 22);
            this.numCoc.TabIndex = 7;
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(20, 120);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.Size = new System.Drawing.Size(420, 320);
            this.dgvPhong.TabIndex = 8;
            // 
            // numSoNguoi
            // 
            this.numSoNguoi.Location = new System.Drawing.Point(460, 180);
            this.numSoNguoi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoNguoi.Name = "numSoNguoi";
            this.numSoNguoi.Size = new System.Drawing.Size(70, 22);
            this.numSoNguoi.TabIndex = 9;
            this.numSoNguoi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(460, 220);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(70, 35);
            this.btnThemPhong.TabIndex = 10;
            this.btnThemPhong.Text = ">>";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // btnBoPhong
            // 
            this.btnBoPhong.Location = new System.Drawing.Point(460, 270);
            this.btnBoPhong.Name = "btnBoPhong";
            this.btnBoPhong.Size = new System.Drawing.Size(70, 35);
            this.btnBoPhong.TabIndex = 11;
            this.btnBoPhong.Text = "<<";
            this.btnBoPhong.UseVisualStyleBackColor = true;
            this.btnBoPhong.Click += new System.EventHandler(this.btnBoPhong_Click);
            // 
            // dgvChon
            // 
            this.dgvChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChon.Location = new System.Drawing.Point(550, 120);
            this.dgvChon.Name = "dgvChon";
            this.dgvChon.RowHeadersWidth = 51;
            this.dgvChon.Size = new System.Drawing.Size(400, 320);
            this.dgvChon.TabIndex = 12;
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Location = new System.Drawing.Point(410, 465);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(180, 45);
            this.btnLapPhieu.TabIndex = 13;
            this.btnLapPhieu.Text = "Lập phiếu đặt phòng";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // lblSoP
            // 
            this.lblSoP.AutoSize = true;
            this.lblSoP.Location = new System.Drawing.Point(20, 23);
            this.lblSoP.Name = "lblSoP";
            this.lblSoP.Size = new System.Drawing.Size(63, 16);
            this.lblSoP.TabIndex = 14;
            this.lblSoP.Text = "Số phiếu:";
            // 
            // lblKhach
            // 
            this.lblKhach.AutoSize = true;
            this.lblKhach.Location = new System.Drawing.Point(230, 23);
            this.lblKhach.Name = "lblKhach";
            this.lblKhach.Size = new System.Drawing.Size(43, 16);
            this.lblKhach.TabIndex = 15;
            this.lblKhach.Text = "Khách:";
            // 
            // lblNVL
            // 
            this.lblNVL.AutoSize = true;
            this.lblNVL.Location = new System.Drawing.Point(480, 23);
            this.lblNVL.Name = "lblNVL";
            this.lblNVL.Size = new System.Drawing.Size(47, 16);
            this.lblNVL.TabIndex = 16;
            this.lblNVL.Text = "Lễ tân:";
            // 
            // lblKenh
            // 
            this.lblKenh.AutoSize = true;
            this.lblKenh.Location = new System.Drawing.Point(720, 23);
            this.lblKenh.Name = "lblKenh";
            this.lblKenh.Size = new System.Drawing.Size(41, 16);
            this.lblKenh.TabIndex = 17;
            this.lblKenh.Text = "Kênh:";
            // 
            // lblNgayL
            // 
            this.lblNgayL.AutoSize = true;
            this.lblNgayL.Location = new System.Drawing.Point(20, 73);
            this.lblNgayL.Name = "lblNgayL";
            this.lblNgayL.Size = new System.Drawing.Size(65, 16);
            this.lblNgayL.TabIndex = 18;
            this.lblNgayL.Text = "Ngày lập:";
            // 
            // lblNgayN
            // 
            this.lblNgayN.AutoSize = true;
            this.lblNgayN.Location = new System.Drawing.Point(220, 73);
            this.lblNgayN.Name = "lblNgayN";
            this.lblNgayN.Size = new System.Drawing.Size(76, 16);
            this.lblNgayN.TabIndex = 19;
            this.lblNgayN.Text = "Ngày nhận:";
            // 
            // lblNgayT
            // 
            this.lblNgayT.AutoSize = true;
            this.lblNgayT.Location = new System.Drawing.Point(480, 73);
            this.lblNgayT.Name = "lblNgayT";
            this.lblNgayT.Size = new System.Drawing.Size(61, 16);
            this.lblNgayT.TabIndex = 20;
            this.lblNgayT.Text = "Ngày trả:";
            // 
            // lblCoc
            // 
            this.lblCoc.AutoSize = true;
            this.lblCoc.Location = new System.Drawing.Point(720, 73);
            this.lblCoc.Name = "lblCoc";
            this.lblCoc.Size = new System.Drawing.Size(62, 16);
            this.lblCoc.TabIndex = 21;
            this.lblCoc.Text = "Tiền cọc:";
            // 
            // tabNP
            // 
            this.tabNP.Controls.Add(this.btnNoShow);
            this.tabNP.Controls.Add(this.btnNhanPhong);
            this.tabNP.Controls.Add(this.btnThemNguoi);
            this.tabNP.Controls.Add(this.txtNguoiQT);
            this.tabNP.Controls.Add(this.txtNguoiCMND);
            this.tabNP.Controls.Add(this.txtNguoiTen);
            this.tabNP.Controls.Add(this.txtNguoiPhong);
            this.tabNP.Controls.Add(this.dgvNguoi);
            this.tabNP.Controls.Add(this.dgvCT);
            this.tabNP.Controls.Add(this.txtPhieuChon);
            this.tabNP.Controls.Add(this.dgvPhieu);
            this.tabNP.Location = new System.Drawing.Point(4, 25);
            this.tabNP.Name = "tabNP";
            this.tabNP.Size = new System.Drawing.Size(972, 531);
            this.tabNP.TabIndex = 2;
            this.tabNP.Text = "Nhận phòng";
            this.tabNP.UseVisualStyleBackColor = true;
            // 
            // dgvPhieu
            // 
            this.dgvPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPhieu.Location = new System.Drawing.Point(0, 0);
            this.dgvPhieu.Name = "dgvPhieu";
            this.dgvPhieu.RowHeadersWidth = 51;
            this.dgvPhieu.Size = new System.Drawing.Size(972, 220);
            this.dgvPhieu.TabIndex = 0;
            this.dgvPhieu.SelectionChanged += new System.EventHandler(this.dgvPhieu_SelectionChanged);
            // 
            // txtPhieuChon
            // 
            this.txtPhieuChon.Location = new System.Drawing.Point(20, 235);
            this.txtPhieuChon.Name = "txtPhieuChon";
            this.txtPhieuChon.ReadOnly = true;
            this.txtPhieuChon.Size = new System.Drawing.Size(120, 22);
            this.txtPhieuChon.TabIndex = 1;
            // 
            // dgvCT
            // 
            this.dgvCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT.Location = new System.Drawing.Point(20, 270);
            this.dgvCT.Name = "dgvCT";
            this.dgvCT.RowHeadersWidth = 51;
            this.dgvCT.Size = new System.Drawing.Size(360, 230);
            this.dgvCT.TabIndex = 2;
            // 
            // dgvNguoi
            // 
            this.dgvNguoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoi.Location = new System.Drawing.Point(400, 270);
            this.dgvNguoi.Name = "dgvNguoi";
            this.dgvNguoi.RowHeadersWidth = 51;
            this.dgvNguoi.Size = new System.Drawing.Size(550, 160);
            this.dgvNguoi.TabIndex = 3;
            // 
            // txtNguoiPhong
            // 
            this.txtNguoiPhong.Location = new System.Drawing.Point(400, 445);
            this.txtNguoiPhong.Name = "txtNguoiPhong";
            this.txtNguoiPhong.Size = new System.Drawing.Size(80, 22);
            this.txtNguoiPhong.TabIndex = 4;
            // 
            // txtNguoiTen
            // 
            this.txtNguoiTen.Location = new System.Drawing.Point(490, 445);
            this.txtNguoiTen.Name = "txtNguoiTen";
            this.txtNguoiTen.Size = new System.Drawing.Size(150, 22);
            this.txtNguoiTen.TabIndex = 5;
            // 
            // txtNguoiCMND
            // 
            this.txtNguoiCMND.Location = new System.Drawing.Point(650, 445);
            this.txtNguoiCMND.Name = "txtNguoiCMND";
            this.txtNguoiCMND.Size = new System.Drawing.Size(120, 22);
            this.txtNguoiCMND.TabIndex = 6;
            // 
            // txtNguoiQT
            // 
            this.txtNguoiQT.Location = new System.Drawing.Point(780, 445);
            this.txtNguoiQT.Name = "txtNguoiQT";
            this.txtNguoiQT.Size = new System.Drawing.Size(90, 22);
            this.txtNguoiQT.TabIndex = 7;
            // 
            // btnThemNguoi
            // 
            this.btnThemNguoi.Location = new System.Drawing.Point(880, 440);
            this.btnThemNguoi.Name = "btnThemNguoi";
            this.btnThemNguoi.Size = new System.Drawing.Size(70, 32);
            this.btnThemNguoi.TabIndex = 8;
            this.btnThemNguoi.Text = "Thêm";
            this.btnThemNguoi.UseVisualStyleBackColor = true;
            this.btnThemNguoi.Click += new System.EventHandler(this.btnThemNguoi_Click);
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.Location = new System.Drawing.Point(520, 485);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(140, 35);
            this.btnNhanPhong.TabIndex = 9;
            this.btnNhanPhong.Text = "Nhận phòng";
            this.btnNhanPhong.UseVisualStyleBackColor = true;
            this.btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click);
            // 
            // btnNoShow
            // 
            this.btnNoShow.Location = new System.Drawing.Point(690, 485);
            this.btnNoShow.Name = "btnNoShow";
            this.btnNoShow.Size = new System.Drawing.Size(140, 35);
            this.btnNoShow.TabIndex = 10;
            this.btnNoShow.Text = "Đánh dấu No-show";
            this.btnNoShow.UseVisualStyleBackColor = true;
            this.btnNoShow.Click += new System.EventHandler(this.btnNoShow_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(850, 570);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 35);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 615);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt và Nhận phòng";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabKH.ResumeLayout(false);
            this.tabKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            this.tabDP.ResumeLayout(false);
            this.tabDP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).EndInit();
            this.tabNP.ResumeLayout(false);
            this.tabNP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoi)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabKH;
        private System.Windows.Forms.TabPage tabDP;
        private System.Windows.Forms.TabPage tabNP;

        private System.Windows.Forms.DataGridView dgvKhach;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtQT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnThemKhach;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblQT;
        private System.Windows.Forms.Label lblSDT;

        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.ComboBox cboKhach;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.ComboBox cboKenh;
        private System.Windows.Forms.DateTimePicker dtLap;
        private System.Windows.Forms.DateTimePicker dtNhan;
        private System.Windows.Forms.DateTimePicker dtTra;
        private System.Windows.Forms.NumericUpDown numCoc;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.NumericUpDown numSoNguoi;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Button btnBoPhong;
        private System.Windows.Forms.DataGridView dgvChon;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.Label lblSoP;
        private System.Windows.Forms.Label lblKhach;
        private System.Windows.Forms.Label lblNVL;
        private System.Windows.Forms.Label lblKenh;
        private System.Windows.Forms.Label lblNgayL;
        private System.Windows.Forms.Label lblNgayN;
        private System.Windows.Forms.Label lblNgayT;
        private System.Windows.Forms.Label lblCoc;

        private System.Windows.Forms.DataGridView dgvPhieu;
        private System.Windows.Forms.TextBox txtPhieuChon;
        private System.Windows.Forms.DataGridView dgvCT;
        private System.Windows.Forms.DataGridView dgvNguoi;
        private System.Windows.Forms.TextBox txtNguoiPhong;
        private System.Windows.Forms.TextBox txtNguoiTen;
        private System.Windows.Forms.TextBox txtNguoiCMND;
        private System.Windows.Forms.TextBox txtNguoiQT;
        private System.Windows.Forms.Button btnThemNguoi;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.Button btnNoShow;

        private System.Windows.Forms.Button btnDong;
    }
}
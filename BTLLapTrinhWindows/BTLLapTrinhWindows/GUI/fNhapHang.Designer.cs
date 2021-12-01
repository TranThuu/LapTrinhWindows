
namespace BTLLapTrinhWindows.GUI
{
    partial class fNhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDanhSachSanPham = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvDSSanPham = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTenNCC = new System.Windows.Forms.Label();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaHDNhap = new System.Windows.Forms.TextBox();
            this.cbbTenNV = new System.Windows.Forms.ComboBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.gpNCC = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPDF = new FontAwesome.Sharp.IconButton();
            this.btnReload = new FontAwesome.Sharp.IconButton();
            this.btnCreate = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoLuongCon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbSanPham = new System.Windows.Forms.ComboBox();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.cbbDanhMucSP = new System.Windows.Forms.ComboBox();
            this.lblDMSP = new System.Windows.Forms.Label();
            this.ptbAnhSP = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSanPham)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpNCC.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhSP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDanhSachSanPham
            // 
            this.lblDanhSachSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDanhSachSanPham.AutoSize = true;
            this.lblDanhSachSanPham.Location = new System.Drawing.Point(17, 268);
            this.lblDanhSachSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanhSachSanPham.Name = "lblDanhSachSanPham";
            this.lblDanhSachSanPham.Size = new System.Drawing.Size(146, 17);
            this.lblDanhSachSanPham.TabIndex = 5;
            this.lblDanhSachSanPham.Text = "Danh sách sản phẩm:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(124, 146);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(223, 23);
            this.txtSDT.TabIndex = 6;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTenNCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTenNCC.Location = new System.Drawing.Point(124, 97);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(223, 23);
            this.txtTenNCC.TabIndex = 5;
            this.txtTenNCC.TextChanged += new System.EventHandler(this.txtTenNCC_TextChanged);
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Enabled = false;
            this.txtMaNCC.Location = new System.Drawing.Point(124, 46);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(132, 23);
            this.txtMaNCC.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvDSSanPham);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 307);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(745, 207);
            this.panel4.TabIndex = 7;
            // 
            // dgvDSSanPham
            // 
            this.dgvDSSanPham.AllowUserToAddRows = false;
            this.dgvDSSanPham.AllowUserToDeleteRows = false;
            this.dgvDSSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.dongia,
            this.soluong,
            this.thanhtien});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSSanPham.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSSanPham.Location = new System.Drawing.Point(0, 0);
            this.dgvDSSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSSanPham.Name = "dgvDSSanPham";
            this.dgvDSSanPham.ReadOnly = true;
            this.dgvDSSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSanPham.Size = new System.Drawing.Size(745, 207);
            this.dgvDSSanPham.TabIndex = 0;
            this.dgvDSSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSanPham_CellClick);
            // 
            // masp
            // 
            this.masp.HeaderText = "Mã sản phẩm";
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            // 
            // tensp
            // 
            this.tensp.HeaderText = "Tên sản phẩm";
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.HeaderText = "Đơn giá nhập";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng nhập";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(15, 148);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(95, 17);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Location = new System.Drawing.Point(13, 98);
            this.lblTenNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(69, 17);
            this.lblTenNCC.TabIndex = 0;
            this.lblTenNCC.Text = "Tên NCC:";
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Location = new System.Drawing.Point(15, 47);
            this.lblMaNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(63, 17);
            this.lblMaNCC.TabIndex = 0;
            this.lblMaNCC.Text = "Mã NCC:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTongTien);
            this.panel3.Controls.Add(this.lblTongTien);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 514);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(745, 91);
            this.panel3.TabIndex = 0;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(458, 24);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(276, 22);
            this.txtTongTien.TabIndex = 0;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(328, 23);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(95, 24);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNgayNhap.CustomFormat = "dd/MM/yyyy ";
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(117, 92);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(180, 23);
            this.dtpNgayNhap.TabIndex = 2;
            this.dtpNgayNhap.Value = new System.DateTime(2021, 9, 5, 0, 0, 0, 0);
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(11, 92);
            this.lblNgayNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(81, 17);
            this.lblNgayNhap.TabIndex = 0;
            this.lblNgayNhap.Text = "Ngày nhập:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.lblDanhSachSanPham);
            this.panel2.Controls.Add(this.gpNCC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 307);
            this.panel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtMaHDNhap);
            this.groupBox1.Controls.Add(this.cbbTenNV);
            this.groupBox1.Controls.Add(this.lblMaNV);
            this.groupBox1.Controls.Add(this.lblMaHD);
            this.groupBox1.Controls.Add(this.dtpNgayNhap);
            this.groupBox1.Controls.Add(this.lblNgayNhap);
            this.groupBox1.Location = new System.Drawing.Point(20, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 214);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn nhập";
            // 
            // txtMaHDNhap
            // 
            this.txtMaHDNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaHDNhap.BackColor = System.Drawing.Color.White;
            this.txtMaHDNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaHDNhap.Location = new System.Drawing.Point(112, 37);
            this.txtMaHDNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHDNhap.Name = "txtMaHDNhap";
            this.txtMaHDNhap.ReadOnly = true;
            this.txtMaHDNhap.Size = new System.Drawing.Size(234, 16);
            this.txtMaHDNhap.TabIndex = 1;
            // 
            // cbbTenNV
            // 
            this.cbbTenNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbTenNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenNV.FormattingEnabled = true;
            this.cbbTenNV.Location = new System.Drawing.Point(117, 144);
            this.cbbTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTenNV.Name = "cbbTenNV";
            this.cbbTenNV.Size = new System.Drawing.Size(228, 25);
            this.cbbTenNV.TabIndex = 3;
            // 
            // lblMaNV
            // 
            this.lblMaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(7, 147);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(103, 17);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Tên nhân viên:";
            // 
            // lblMaHD
            // 
            this.lblMaHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(6, 37);
            this.lblMaHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(87, 17);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã hóa đơn:";
            // 
            // gpNCC
            // 
            this.gpNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpNCC.Controls.Add(this.txtDiaChi);
            this.gpNCC.Controls.Add(this.lblDiaChi);
            this.gpNCC.Controls.Add(this.txtSDT);
            this.gpNCC.Controls.Add(this.txtTenNCC);
            this.gpNCC.Controls.Add(this.txtMaNCC);
            this.gpNCC.Controls.Add(this.lblSDT);
            this.gpNCC.Controls.Add(this.lblTenNCC);
            this.gpNCC.Controls.Add(this.lblMaNCC);
            this.gpNCC.Location = new System.Drawing.Point(379, 16);
            this.gpNCC.Margin = new System.Windows.Forms.Padding(4);
            this.gpNCC.Name = "gpNCC";
            this.gpNCC.Padding = new System.Windows.Forms.Padding(4);
            this.gpNCC.Size = new System.Drawing.Size(355, 242);
            this.gpNCC.TabIndex = 0;
            this.gpNCC.TabStop = false;
            this.gpNCC.Text = "Nhà cung cấp";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(124, 194);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(223, 20);
            this.txtDiaChi.TabIndex = 7;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(15, 195);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(55, 17);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGiaNhap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPDF);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtSoLuongCon);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtSoLuongNhap);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbbSanPham);
            this.panel1.Controls.Add(this.lblSanPham);
            this.panel1.Controls.Add(this.cbbDanhMucSP);
            this.panel1.Controls.Add(this.lblDMSP);
            this.panel1.Controls.Add(this.ptbAnhSP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(745, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 605);
            this.panel1.TabIndex = 4;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGiaNhap.Location = new System.Drawing.Point(27, 349);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(148, 23);
            this.txtGiaNhap.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 323);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Giá nhập";
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.Black;
            this.btnPDF.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.btnPDF.IconColor = System.Drawing.Color.Black;
            this.btnPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPDF.IconSize = 40;
            this.btnPDF.Location = new System.Drawing.Point(29, 551);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(4);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(270, 50);
            this.btnPDF.TabIndex = 17;
            this.btnPDF.Text = "   Export PDF";
            this.btnPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReload.BackColor = System.Drawing.Color.Orange;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.Black;
            this.btnReload.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnReload.IconColor = System.Drawing.Color.Black;
            this.btnReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReload.IconSize = 40;
            this.btnReload.Location = new System.Drawing.Point(28, 493);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(270, 54);
            this.btnReload.TabIndex = 16;
            this.btnReload.Text = "     ReLoad";
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnCreate.IconColor = System.Drawing.Color.Black;
            this.btnCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreate.IconSize = 40;
            this.btnCreate.Location = new System.Drawing.Point(28, 439);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(270, 51);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "       Create";
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.BackColor = System.Drawing.Color.PeachPuff;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(220, 388);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 33);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(129, 388);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 33);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.BackColor = System.Drawing.Color.PeachPuff;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(28, 388);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 33);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoLuongCon
            // 
            this.txtSoLuongCon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoLuongCon.Enabled = false;
            this.txtSoLuongCon.Location = new System.Drawing.Point(154, 294);
            this.txtSoLuongCon.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongCon.Name = "txtSoLuongCon";
            this.txtSoLuongCon.Size = new System.Drawing.Size(105, 23);
            this.txtSoLuongCon.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(155, 268);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số lượng còn:";
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoLuongNhap.Location = new System.Drawing.Point(25, 294);
            this.txtSoLuongNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(99, 23);
            this.txtSoLuongNhap.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 268);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số lượng nhập";
            // 
            // cbbSanPham
            // 
            this.cbbSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSanPham.FormattingEnabled = true;
            this.cbbSanPham.Location = new System.Drawing.Point(21, 233);
            this.cbbSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.cbbSanPham.Name = "cbbSanPham";
            this.cbbSanPham.Size = new System.Drawing.Size(258, 25);
            this.cbbSanPham.TabIndex = 9;
            this.cbbSanPham.SelectedIndexChanged += new System.EventHandler(this.cbbSanPham_SelectedIndexChanged);
            // 
            // lblSanPham
            // 
            this.lblSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.Location = new System.Drawing.Point(19, 212);
            this.lblSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(76, 17);
            this.lblSanPham.TabIndex = 0;
            this.lblSanPham.Text = "Sản phẩm:";
            // 
            // cbbDanhMucSP
            // 
            this.cbbDanhMucSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbDanhMucSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDanhMucSP.FormattingEnabled = true;
            this.cbbDanhMucSP.Location = new System.Drawing.Point(22, 173);
            this.cbbDanhMucSP.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDanhMucSP.Name = "cbbDanhMucSP";
            this.cbbDanhMucSP.Size = new System.Drawing.Size(258, 25);
            this.cbbDanhMucSP.TabIndex = 8;
            this.cbbDanhMucSP.SelectedIndexChanged += new System.EventHandler(this.cbbDanhMucSP_SelectedIndexChanged);
            // 
            // lblDMSP
            // 
            this.lblDMSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDMSP.AutoSize = true;
            this.lblDMSP.Location = new System.Drawing.Point(20, 147);
            this.lblDMSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDMSP.Name = "lblDMSP";
            this.lblDMSP.Size = new System.Drawing.Size(142, 17);
            this.lblDMSP.TabIndex = 0;
            this.lblDMSP.Text = "Danh mục sản phẩm:";
            // 
            // ptbAnhSP
            // 
            this.ptbAnhSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbAnhSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbAnhSP.Location = new System.Drawing.Point(23, 8);
            this.ptbAnhSP.Margin = new System.Windows.Forms.Padding(4);
            this.ptbAnhSP.Name = "ptbAnhSP";
            this.ptbAnhSP.Size = new System.Drawing.Size(256, 135);
            this.ptbAnhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAnhSP.TabIndex = 0;
            this.ptbAnhSP.TabStop = false;
            // 
            // fNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1053, 605);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fNhapHang";
            this.Text = "Nhập hàng";
            this.Load += new System.EventHandler(this.fNhapHang_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSanPham)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpNCC.ResumeLayout(false);
            this.gpNCC.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDanhSachSanPham;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvDSSanPham;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTenNCC;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbTenNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaHDNhap;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.GroupBox gpNCC;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnPDF;
        private FontAwesome.Sharp.IconButton btnReload;
        private FontAwesome.Sharp.IconButton btnCreate;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSoLuongCon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbSanPham;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.ComboBox cbbDanhMucSP;
        private System.Windows.Forms.Label lblDMSP;
        private System.Windows.Forms.PictureBox ptbAnhSP;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
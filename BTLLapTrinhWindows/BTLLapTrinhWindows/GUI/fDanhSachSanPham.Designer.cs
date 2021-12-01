
namespace BTLLapTrinhWindows.GUI
{
    partial class fDanhSachSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkDSSPNgungBan = new System.Windows.Forms.LinkLabel();
            this.txtSoTrang = new System.Windows.Forms.TextBox();
            this.icNext = new FontAwesome.Sharp.IconButton();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.anhSP = new System.Windows.Forms.DataGridViewImageColumn();
            this.maSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvtinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icPrevious = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.icb_them = new FontAwesome.Sharp.IconButton();
            this.icb_sua = new FontAwesome.Sharp.IconButton();
            this.icbLoc = new FontAwesome.Sharp.IconButton();
            this.cbbKieuTK = new System.Windows.Forms.ComboBox();
            this.icb_reload = new FontAwesome.Sharp.IconButton();
            this.icb_pdf = new FontAwesome.Sharp.IconButton();
            this.ibtnSearch = new FontAwesome.Sharp.IconButton();
            this.icb_excel = new FontAwesome.Sharp.IconButton();
            this.cbbDanhMuc = new System.Windows.Forms.ComboBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.txtTuKhoaTK = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkDSSPNgungBan);
            this.panel1.Controls.Add(this.txtSoTrang);
            this.panel1.Controls.Add(this.icNext);
            this.panel1.Controls.Add(this.dgvSanPham);
            this.panel1.Controls.Add(this.icPrevious);
            this.panel1.Location = new System.Drawing.Point(3, 141);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 465);
            this.panel1.TabIndex = 0;
            // 
            // linkDSSPNgungBan
            // 
            this.linkDSSPNgungBan.AutoSize = true;
            this.linkDSSPNgungBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDSSPNgungBan.LinkColor = System.Drawing.Color.Black;
            this.linkDSSPNgungBan.Location = new System.Drawing.Point(835, 426);
            this.linkDSSPNgungBan.Name = "linkDSSPNgungBan";
            this.linkDSSPNgungBan.Size = new System.Drawing.Size(203, 16);
            this.linkDSSPNgungBan.TabIndex = 36;
            this.linkDSSPNgungBan.TabStop = true;
            this.linkDSSPNgungBan.Text = "Danh sách sản phẩm ngừng bán ";
            this.linkDSSPNgungBan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDSSPNgungBan_LinkClicked);
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTrang.Location = new System.Drawing.Point(64, 422);
            this.txtSoTrang.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.ReadOnly = true;
            this.txtSoTrang.Size = new System.Drawing.Size(69, 22);
            this.txtSoTrang.TabIndex = 35;
            this.txtSoTrang.Text = "1";
            this.txtSoTrang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSoTrang.TextChanged += new System.EventHandler(this.txtSoTrang_TextChanged);
            this.txtSoTrang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTrang_KeyPress);
            // 
            // icNext
            // 
            this.icNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icNext.BackColor = System.Drawing.Color.YellowGreen;
            this.icNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icNext.ForeColor = System.Drawing.Color.White;
            this.icNext.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.icNext.IconColor = System.Drawing.Color.White;
            this.icNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icNext.IconSize = 20;
            this.icNext.Location = new System.Drawing.Point(137, 422);
            this.icNext.Margin = new System.Windows.Forms.Padding(0);
            this.icNext.Name = "icNext";
            this.icNext.Size = new System.Drawing.Size(28, 22);
            this.icNext.TabIndex = 23;
            this.icNext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.icNext.UseVisualStyleBackColor = false;
            this.icNext.Click += new System.EventHandler(this.icNext_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSanPham.ColumnHeadersHeight = 31;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anhSP,
            this.maSP,
            this.tenSP,
            this.nhaSX,
            this.moTa,
            this.dvtinh,
            this.gia,
            this.maDM});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.YellowGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSanPham.Location = new System.Drawing.Point(25, 17);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(124)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowTemplate.Height = 50;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(1013, 386);
            this.dgvSanPham.TabIndex = 21;
            this.dgvSanPham.SelectionChanged += new System.EventHandler(this.dgvSanPham_SelectionChanged);
            // 
            // anhSP
            // 
            this.anhSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.anhSP.DataPropertyName = "AnhSP";
            this.anhSP.FillWeight = 80F;
            this.anhSP.HeaderText = "Ảnh";
            this.anhSP.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.anhSP.Name = "anhSP";
            this.anhSP.ReadOnly = true;
            this.anhSP.Width = 80;
            // 
            // maSP
            // 
            this.maSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.maSP.DataPropertyName = "MaSanPham";
            this.maSP.HeaderText = "Mã";
            this.maSP.Name = "maSP";
            this.maSP.ReadOnly = true;
            // 
            // tenSP
            // 
            this.tenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tenSP.DataPropertyName = "TenSP";
            this.tenSP.FillWeight = 240F;
            this.tenSP.HeaderText = "Tên";
            this.tenSP.Name = "tenSP";
            this.tenSP.ReadOnly = true;
            this.tenSP.Width = 240;
            // 
            // nhaSX
            // 
            this.nhaSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nhaSX.DataPropertyName = "NhaSX";
            this.nhaSX.HeaderText = "Nhà SX";
            this.nhaSX.Name = "nhaSX";
            this.nhaSX.ReadOnly = true;
            // 
            // moTa
            // 
            this.moTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.moTa.DataPropertyName = "MoTa";
            this.moTa.HeaderText = "Mô tả";
            this.moTa.Name = "moTa";
            this.moTa.ReadOnly = true;
            // 
            // dvtinh
            // 
            this.dvtinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvtinh.DataPropertyName = "DonViTinh";
            this.dvtinh.FillWeight = 120F;
            this.dvtinh.HeaderText = "Đơn vị";
            this.dvtinh.Name = "dvtinh";
            this.dvtinh.ReadOnly = true;
            this.dvtinh.Width = 120;
            // 
            // gia
            // 
            this.gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gia.DataPropertyName = "GiaBan";
            this.gia.FillWeight = 120F;
            this.gia.HeaderText = "Giá";
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            this.gia.Width = 120;
            // 
            // maDM
            // 
            this.maDM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.maDM.DataPropertyName = "MaDM";
            this.maDM.HeaderText = "Mã DM";
            this.maDM.Name = "maDM";
            this.maDM.ReadOnly = true;
            // 
            // icPrevious
            // 
            this.icPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icPrevious.BackColor = System.Drawing.Color.YellowGreen;
            this.icPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icPrevious.ForeColor = System.Drawing.Color.White;
            this.icPrevious.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.icPrevious.IconColor = System.Drawing.Color.White;
            this.icPrevious.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icPrevious.IconSize = 20;
            this.icPrevious.Location = new System.Drawing.Point(32, 422);
            this.icPrevious.Margin = new System.Windows.Forms.Padding(0);
            this.icPrevious.Name = "icPrevious";
            this.icPrevious.Size = new System.Drawing.Size(28, 22);
            this.icPrevious.TabIndex = 22;
            this.icPrevious.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.icPrevious.UseVisualStyleBackColor = false;
            this.icPrevious.Click += new System.EventHandler(this.icPrevious_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.icb_them);
            this.panel2.Controls.Add(this.icb_sua);
            this.panel2.Controls.Add(this.icbLoc);
            this.panel2.Controls.Add(this.cbbKieuTK);
            this.panel2.Controls.Add(this.icb_reload);
            this.panel2.Controls.Add(this.icb_pdf);
            this.panel2.Controls.Add(this.ibtnSearch);
            this.panel2.Controls.Add(this.icb_excel);
            this.panel2.Controls.Add(this.cbbDanhMuc);
            this.panel2.Controls.Add(this.lblDanhMuc);
            this.panel2.Controls.Add(this.txtTuKhoaTK);
            this.panel2.Location = new System.Drawing.Point(3, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 135);
            this.panel2.TabIndex = 1;
            // 
            // icb_them
            // 
            this.icb_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icb_them.BackColor = System.Drawing.Color.YellowGreen;
            this.icb_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icb_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icb_them.ForeColor = System.Drawing.Color.White;
            this.icb_them.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.icb_them.IconColor = System.Drawing.Color.White;
            this.icb_them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icb_them.IconSize = 40;
            this.icb_them.Location = new System.Drawing.Point(25, 67);
            this.icb_them.Name = "icb_them";
            this.icb_them.Size = new System.Drawing.Size(124, 53);
            this.icb_them.TabIndex = 38;
            this.icb_them.Text = "Thêm";
            this.icb_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icb_them.UseVisualStyleBackColor = false;
            this.icb_them.Click += new System.EventHandler(this.icb_them_Click);
            // 
            // icb_sua
            // 
            this.icb_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icb_sua.BackColor = System.Drawing.Color.YellowGreen;
            this.icb_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icb_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icb_sua.ForeColor = System.Drawing.Color.White;
            this.icb_sua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.icb_sua.IconColor = System.Drawing.Color.White;
            this.icb_sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icb_sua.IconSize = 40;
            this.icb_sua.Location = new System.Drawing.Point(599, 67);
            this.icb_sua.Name = "icb_sua";
            this.icb_sua.Size = new System.Drawing.Size(111, 53);
            this.icb_sua.TabIndex = 38;
            this.icb_sua.Text = "Sửa";
            this.icb_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icb_sua.UseVisualStyleBackColor = false;
            this.icb_sua.Click += new System.EventHandler(this.icb_sua_Click);
            // 
            // icbLoc
            // 
            this.icbLoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icbLoc.BackColor = System.Drawing.Color.YellowGreen;
            this.icbLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbLoc.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.icbLoc.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.icbLoc.IconColor = System.Drawing.Color.White;
            this.icbLoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbLoc.IconSize = 20;
            this.icbLoc.Location = new System.Drawing.Point(332, 22);
            this.icbLoc.Margin = new System.Windows.Forms.Padding(4);
            this.icbLoc.Name = "icbLoc";
            this.icbLoc.Size = new System.Drawing.Size(31, 28);
            this.icbLoc.TabIndex = 42;
            this.icbLoc.UseVisualStyleBackColor = false;
            this.icbLoc.Click += new System.EventHandler(this.icbLoc_Click_1);
            // 
            // cbbKieuTK
            // 
            this.cbbKieuTK.AllowDrop = true;
            this.cbbKieuTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbKieuTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKieuTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKieuTK.FormattingEnabled = true;
            this.cbbKieuTK.Location = new System.Drawing.Point(519, 21);
            this.cbbKieuTK.Margin = new System.Windows.Forms.Padding(4);
            this.cbbKieuTK.Name = "cbbKieuTK";
            this.cbbKieuTK.Size = new System.Drawing.Size(237, 28);
            this.cbbKieuTK.TabIndex = 40;
            this.cbbKieuTK.SelectedIndexChanged += new System.EventHandler(this.cbbKieuTK_SelectedIndexChanged);
            // 
            // icb_reload
            // 
            this.icb_reload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icb_reload.BackColor = System.Drawing.Color.YellowGreen;
            this.icb_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icb_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icb_reload.ForeColor = System.Drawing.Color.White;
            this.icb_reload.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.icb_reload.IconColor = System.Drawing.Color.White;
            this.icb_reload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icb_reload.IconSize = 40;
            this.icb_reload.Location = new System.Drawing.Point(155, 67);
            this.icb_reload.Name = "icb_reload";
            this.icb_reload.Size = new System.Drawing.Size(124, 53);
            this.icb_reload.TabIndex = 38;
            this.icb_reload.Text = "Reload";
            this.icb_reload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icb_reload.UseVisualStyleBackColor = false;
            this.icb_reload.Click += new System.EventHandler(this.icb_reload_Click);
            // 
            // icb_pdf
            // 
            this.icb_pdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icb_pdf.BackColor = System.Drawing.Color.YellowGreen;
            this.icb_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icb_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icb_pdf.ForeColor = System.Drawing.Color.White;
            this.icb_pdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.icb_pdf.IconColor = System.Drawing.Color.White;
            this.icb_pdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icb_pdf.IconSize = 40;
            this.icb_pdf.Location = new System.Drawing.Point(880, 67);
            this.icb_pdf.Name = "icb_pdf";
            this.icb_pdf.Size = new System.Drawing.Size(158, 53);
            this.icb_pdf.TabIndex = 37;
            this.icb_pdf.Text = "Export PDF";
            this.icb_pdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icb_pdf.UseVisualStyleBackColor = false;
            this.icb_pdf.Click += new System.EventHandler(this.icb_pdf_Click);
            // 
            // ibtnSearch
            // 
            this.ibtnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnSearch.BackColor = System.Drawing.Color.YellowGreen;
            this.ibtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSearch.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ibtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnSearch.IconColor = System.Drawing.Color.White;
            this.ibtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSearch.IconSize = 17;
            this.ibtnSearch.Location = new System.Drawing.Point(1003, 22);
            this.ibtnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ibtnSearch.Name = "ibtnSearch";
            this.ibtnSearch.Size = new System.Drawing.Size(35, 26);
            this.ibtnSearch.TabIndex = 38;
            this.ibtnSearch.UseVisualStyleBackColor = false;
            this.ibtnSearch.Click += new System.EventHandler(this.ibtnSearch_Click_1);
            // 
            // icb_excel
            // 
            this.icb_excel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icb_excel.BackColor = System.Drawing.Color.YellowGreen;
            this.icb_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icb_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icb_excel.ForeColor = System.Drawing.Color.White;
            this.icb_excel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.icb_excel.IconColor = System.Drawing.Color.White;
            this.icb_excel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icb_excel.IconSize = 40;
            this.icb_excel.Location = new System.Drawing.Point(716, 67);
            this.icb_excel.Name = "icb_excel";
            this.icb_excel.Size = new System.Drawing.Size(158, 53);
            this.icb_excel.TabIndex = 37;
            this.icb_excel.Text = "Export Excel";
            this.icb_excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icb_excel.UseVisualStyleBackColor = false;
            this.icb_excel.Click += new System.EventHandler(this.icb_excel_Click);
            // 
            // cbbDanhMuc
            // 
            this.cbbDanhMuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDanhMuc.FormattingEnabled = true;
            this.cbbDanhMuc.Location = new System.Drawing.Point(111, 22);
            this.cbbDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDanhMuc.Name = "cbbDanhMuc";
            this.cbbDanhMuc.Size = new System.Drawing.Size(223, 28);
            this.cbbDanhMuc.TabIndex = 37;
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDanhMuc.Location = new System.Drawing.Point(26, 26);
            this.lblDanhMuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(86, 20);
            this.lblDanhMuc.TabIndex = 36;
            this.lblDanhMuc.Text = "Danh mục:";
            // 
            // txtTuKhoaTK
            // 
            this.txtTuKhoaTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTuKhoaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuKhoaTK.Location = new System.Drawing.Point(767, 22);
            this.txtTuKhoaTK.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuKhoaTK.Name = "txtTuKhoaTK";
            this.txtTuKhoaTK.Size = new System.Drawing.Size(237, 26);
            this.txtTuKhoaTK.TabIndex = 34;
            this.txtTuKhoaTK.Text = "Tìm kiếm ...";
            this.txtTuKhoaTK.Click += new System.EventHandler(this.txtTuKhoaTK_Click);
            this.txtTuKhoaTK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTuKhoaTK_KeyDown);
            // 
            // fDanhSachSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1053, 605);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fDanhSachSanPham";
            this.Text = "Danh sách sản phẩm";
            this.Load += new System.EventHandler(this.fDanhSachSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton icNext;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private FontAwesome.Sharp.IconButton icPrevious;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton icbLoc;
        private System.Windows.Forms.ComboBox cbbKieuTK;
        private FontAwesome.Sharp.IconButton ibtnSearch;
        private System.Windows.Forms.ComboBox cbbDanhMuc;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.TextBox txtTuKhoaTK;
        private System.Windows.Forms.TextBox txtSoTrang;
        private System.Windows.Forms.DataGridViewImageColumn anhSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvtinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDM;
        private System.Windows.Forms.LinkLabel linkDSSPNgungBan;
        private FontAwesome.Sharp.IconButton icb_excel;
        private FontAwesome.Sharp.IconButton icb_pdf;
        private FontAwesome.Sharp.IconButton icb_sua;
        private FontAwesome.Sharp.IconButton icb_them;
        private FontAwesome.Sharp.IconButton icb_reload;
    }
}
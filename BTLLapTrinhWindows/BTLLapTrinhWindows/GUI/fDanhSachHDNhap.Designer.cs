
namespace BTLLapTrinhWindows.GUI
{
    partial class fDanhSachHDNhap
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
            this.cbbKey = new System.Windows.Forms.ComboBox();
            this.txtMaHDNhap = new System.Windows.Forms.TextBox();
            this.lblMaHDNhap = new System.Windows.Forms.Label();
            this.gpHDNhap = new System.Windows.Forms.GroupBox();
            this.txtSLHDNhap = new System.Windows.Forms.TextBox();
            this.lblSLHDNhap = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.cbbTKTheo = new System.Windows.Forms.ComboBox();
            this.dgvHDNhap = new System.Windows.Forms.DataGridView();
            this.mahdb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReload = new FontAwesome.Sharp.IconButton();
            this.btnXemHDNhap = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.btnPdf = new FontAwesome.Sharp.IconButton();
            this.lblTongHDN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTongHoaDonNhap = new System.Windows.Forms.TextBox();
            this.gpHDNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbKey
            // 
            this.cbbKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKey.FormattingEnabled = true;
            this.cbbKey.Location = new System.Drawing.Point(214, 83);
            this.cbbKey.Margin = new System.Windows.Forms.Padding(4);
            this.cbbKey.Name = "cbbKey";
            this.cbbKey.Size = new System.Drawing.Size(430, 24);
            this.cbbKey.TabIndex = 18;
            // 
            // txtMaHDNhap
            // 
            this.txtMaHDNhap.Location = new System.Drawing.Point(27, 65);
            this.txtMaHDNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHDNhap.Name = "txtMaHDNhap";
            this.txtMaHDNhap.ReadOnly = true;
            this.txtMaHDNhap.Size = new System.Drawing.Size(257, 22);
            this.txtMaHDNhap.TabIndex = 1;
            // 
            // lblMaHDNhap
            // 
            this.lblMaHDNhap.AutoSize = true;
            this.lblMaHDNhap.Location = new System.Drawing.Point(23, 34);
            this.lblMaHDNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHDNhap.Name = "lblMaHDNhap";
            this.lblMaHDNhap.Size = new System.Drawing.Size(82, 16);
            this.lblMaHDNhap.TabIndex = 0;
            this.lblMaHDNhap.Text = "Mã hóa đơn:";
            // 
            // gpHDNhap
            // 
            this.gpHDNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpHDNhap.Controls.Add(this.txtMaHDNhap);
            this.gpHDNhap.Controls.Add(this.lblMaHDNhap);
            this.gpHDNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpHDNhap.Location = new System.Drawing.Point(694, 37);
            this.gpHDNhap.Margin = new System.Windows.Forms.Padding(4);
            this.gpHDNhap.Name = "gpHDNhap";
            this.gpHDNhap.Padding = new System.Windows.Forms.Padding(4);
            this.gpHDNhap.Size = new System.Drawing.Size(335, 123);
            this.gpHDNhap.TabIndex = 24;
            this.gpHDNhap.TabStop = false;
            this.gpHDNhap.Text = "Hóa đơn ";
            // 
            // txtSLHDNhap
            // 
            this.txtSLHDNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSLHDNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSLHDNhap.Enabled = false;
            this.txtSLHDNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLHDNhap.Location = new System.Drawing.Point(177, 642);
            this.txtSLHDNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtSLHDNhap.Name = "txtSLHDNhap";
            this.txtSLHDNhap.Size = new System.Drawing.Size(133, 15);
            this.txtSLHDNhap.TabIndex = 22;
            // 
            // lblSLHDNhap
            // 
            this.lblSLHDNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSLHDNhap.AutoSize = true;
            this.lblSLHDNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLHDNhap.Location = new System.Drawing.Point(-40, 642);
            this.lblSLHDNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSLHDNhap.Name = "lblSLHDNhap";
            this.lblSLHDNhap.Size = new System.Drawing.Size(157, 16);
            this.lblSLHDNhap.TabIndex = 21;
            this.lblSLHDNhap.Text = "Số lượng hóa đơn đã tạo:";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(214, 127);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(430, 22);
            this.dtpNgayNhap.TabIndex = 20;
            this.dtpNgayNhap.Value = new System.DateTime(2021, 8, 24, 0, 0, 0, 0);
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhap.Location = new System.Drawing.Point(41, 134);
            this.lblNgayNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(77, 16);
            this.lblNgayNhap.TabIndex = 19;
            this.lblNgayNhap.Text = "Ngày nhập:";
            // 
            // lblKey
            // 
            this.lblKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.Location = new System.Drawing.Point(41, 83);
            this.lblKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(45, 16);
            this.lblKey.TabIndex = 17;
            this.lblKey.Text = "label2";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(41, 43);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(95, 16);
            this.lblTimKiem.TabIndex = 13;
            this.lblTimKiem.Text = "Tìm kiếm theo:";
            // 
            // cbbTKTheo
            // 
            this.cbbTKTheo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbTKTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTKTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTKTheo.FormattingEnabled = true;
            this.cbbTKTheo.Location = new System.Drawing.Point(214, 39);
            this.cbbTKTheo.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTKTheo.Name = "cbbTKTheo";
            this.cbbTKTheo.Size = new System.Drawing.Size(430, 24);
            this.cbbTKTheo.TabIndex = 15;
            this.cbbTKTheo.SelectedIndexChanged += new System.EventHandler(this.cbbTKTheo_SelectedIndexChanged);
            // 
            // dgvHDNhap
            // 
            this.dgvHDNhap.AllowUserToAddRows = false;
            this.dgvHDNhap.AllowUserToDeleteRows = false;
            this.dgvHDNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvHDNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvHDNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahdb,
            this.ngaylap,
            this.tongtien,
            this.manv,
            this.maKhach});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(176)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHDNhap.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHDNhap.Location = new System.Drawing.Point(45, 260);
            this.dgvHDNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHDNhap.Name = "dgvHDNhap";
            this.dgvHDNhap.ReadOnly = true;
            this.dgvHDNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHDNhap.Size = new System.Drawing.Size(984, 278);
            this.dgvHDNhap.TabIndex = 14;
            this.dgvHDNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDNhap_CellClick);
            // 
            // mahdb
            // 
            this.mahdb.DataPropertyName = "MaHDN";
            this.mahdb.HeaderText = "Mã hóa đơn nhập";
            this.mahdb.Name = "mahdb";
            this.mahdb.ReadOnly = true;
            // 
            // ngaylap
            // 
            this.ngaylap.DataPropertyName = "NgayNhap";
            this.ngaylap.HeaderText = "Ngày nhập";
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.ReadOnly = true;
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "TongTien";
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "MaNV";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            // 
            // maKhach
            // 
            this.maKhach.DataPropertyName = "MaNhaCC";
            this.maKhach.HeaderText = "Mã nhà cung cấp";
            this.maKhach.Name = "maKhach";
            this.maKhach.ReadOnly = true;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(176)))), ((int)(((byte)(123)))));
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btnReload.IconColor = System.Drawing.Color.White;
            this.btnReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReload.IconSize = 40;
            this.btnReload.Location = new System.Drawing.Point(214, 188);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(122, 47);
            this.btnReload.TabIndex = 25;
            this.btnReload.Text = "ReLoad";
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnXemHDNhap
            // 
            this.btnXemHDNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXemHDNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(176)))), ((int)(((byte)(123)))));
            this.btnXemHDNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemHDNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemHDNhap.ForeColor = System.Drawing.Color.White;
            this.btnXemHDNhap.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXemHDNhap.IconColor = System.Drawing.Color.Black;
            this.btnXemHDNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXemHDNhap.Location = new System.Drawing.Point(863, 188);
            this.btnXemHDNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemHDNhap.Name = "btnXemHDNhap";
            this.btnXemHDNhap.Size = new System.Drawing.Size(166, 47);
            this.btnXemHDNhap.TabIndex = 23;
            this.btnXemHDNhap.Text = "Xem chi tiết hóa đơn";
            this.btnXemHDNhap.UseVisualStyleBackColor = false;
            this.btnXemHDNhap.Click += new System.EventHandler(this.btnXemHDNhap_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(176)))), ((int)(((byte)(123)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.White;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 40;
            this.btnTimKiem.Location = new System.Drawing.Point(45, 188);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(127, 47);
            this.btnTimKiem.TabIndex = 16;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(128)))), ((int)(((byte)(144)))));
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPdf.IconColor = System.Drawing.Color.Black;
            this.btnPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPdf.Location = new System.Drawing.Point(977, 625);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(4);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(151, 55);
            this.btnPdf.TabIndex = 26;
            this.btnPdf.Text = "Export PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // lblTongHDN
            // 
            this.lblTongHDN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTongHDN.AutoSize = true;
            this.lblTongHDN.Location = new System.Drawing.Point(41, 565);
            this.lblTongHDN.Name = "lblTongHDN";
            this.lblTongHDN.Size = new System.Drawing.Size(164, 17);
            this.lblTongHDN.TabIndex = 27;
            this.lblTongHDN.Text = "Số lượng hóa đơn nhập: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 564);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 28;
            // 
            // txtTongHoaDonNhap
            // 
            this.txtTongHoaDonNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTongHoaDonNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongHoaDonNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongHoaDonNhap.Location = new System.Drawing.Point(211, 565);
            this.txtTongHoaDonNhap.Name = "txtTongHoaDonNhap";
            this.txtTongHoaDonNhap.Size = new System.Drawing.Size(100, 17);
            this.txtTongHoaDonNhap.TabIndex = 29;
            // 
            // fDanhSachHDNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1053, 605);
            this.Controls.Add(this.txtTongHoaDonNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTongHDN);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.cbbKey);
            this.Controls.Add(this.gpHDNhap);
            this.Controls.Add(this.btnXemHDNhap);
            this.Controls.Add(this.txtSLHDNhap);
            this.Controls.Add(this.lblSLHDNhap);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.lblNgayNhap);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.cbbTKTheo);
            this.Controls.Add(this.dgvHDNhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fDanhSachHDNhap";
            this.Text = "Danh sách hóa đơn nhập";
            this.Load += new System.EventHandler(this.fDanhSachHDNhap_Load);
            this.gpHDNhap.ResumeLayout(false);
            this.gpHDNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnReload;
        private System.Windows.Forms.ComboBox cbbKey;
        private System.Windows.Forms.TextBox txtMaHDNhap;
        private System.Windows.Forms.Label lblMaHDNhap;
        private System.Windows.Forms.GroupBox gpHDNhap;
        private FontAwesome.Sharp.IconButton btnXemHDNhap;
        private System.Windows.Forms.TextBox txtSLHDNhap;
        private System.Windows.Forms.Label lblSLHDNhap;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblKey;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.ComboBox cbbTKTheo;
        private System.Windows.Forms.DataGridView dgvHDNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahdb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhach;
        private FontAwesome.Sharp.IconButton btnPdf;
        private System.Windows.Forms.Label lblTongHDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTongHoaDonNhap;
    }
}
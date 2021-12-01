
namespace BTLLapTrinhWindows.GUI
{
    partial class fDanhSachDonHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_hdb = new System.Windows.Forms.DataGridView();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_timkiemtheo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_bang = new System.Windows.Forms.ComboBox();
            this.lb_tungay = new System.Windows.Forms.Label();
            this.dtp_tungay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_soHDB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_mahdb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.butReload = new FontAwesome.Sharp.IconButton();
            this.butXemHDB = new FontAwesome.Sharp.IconButton();
            this.butTimKiem = new FontAwesome.Sharp.IconButton();
            this.lb_denngay = new System.Windows.Forms.Label();
            this.dtp_denngay = new System.Windows.Forms.DateTimePicker();
            this.but_ExportExcel = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hdb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_hdb
            // 
            this.dgv_hdb.AllowUserToAddRows = false;
            this.dgv_hdb.AllowUserToDeleteRows = false;
            this.dgv_hdb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_hdb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hdb.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(120)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hdb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_hdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hdb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.tenkhachhang,
            this.sodienthoai,
            this.manhanvien,
            this.tennhanvien,
            this.ngayban,
            this.thanhtien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(113)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_hdb.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_hdb.Location = new System.Drawing.Point(88, 249);
            this.dgv_hdb.MultiSelect = false;
            this.dgv_hdb.Name = "dgv_hdb";
            this.dgv_hdb.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(120)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hdb.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_hdb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hdb.Size = new System.Drawing.Size(875, 256);
            this.dgv_hdb.TabIndex = 1;
            this.dgv_hdb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hdb_CellContentClick);
            // 
            // mahd
            // 
            this.mahd.DataPropertyName = "MaHDB";
            this.mahd.HeaderText = "Mã hóa đơn ";
            this.mahd.Name = "mahd";
            this.mahd.ReadOnly = true;
            // 
            // tenkhachhang
            // 
            this.tenkhachhang.DataPropertyName = "TenKH";
            this.tenkhachhang.HeaderText = "Tên khách hàng";
            this.tenkhachhang.Name = "tenkhachhang";
            this.tenkhachhang.ReadOnly = true;
            // 
            // sodienthoai
            // 
            this.sodienthoai.DataPropertyName = "SDT";
            this.sodienthoai.HeaderText = "Số điện thoại";
            this.sodienthoai.Name = "sodienthoai";
            this.sodienthoai.ReadOnly = true;
            // 
            // manhanvien
            // 
            this.manhanvien.DataPropertyName = "MaNV";
            this.manhanvien.HeaderText = "Mã nhân viên";
            this.manhanvien.Name = "manhanvien";
            this.manhanvien.ReadOnly = true;
            // 
            // tennhanvien
            // 
            this.tennhanvien.DataPropertyName = "TenNV";
            this.tennhanvien.HeaderText = "Tên nhân viên";
            this.tennhanvien.Name = "tennhanvien";
            this.tennhanvien.ReadOnly = true;
            // 
            // ngayban
            // 
            this.ngayban.DataPropertyName = "NgayBan";
            this.ngayban.HeaderText = "Ngày lập";
            this.ngayban.Name = "ngayban";
            this.ngayban.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "TongTien";
            this.thanhtien.HeaderText = "Tổng tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm theo:";
            // 
            // cbb_timkiemtheo
            // 
            this.cbb_timkiemtheo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_timkiemtheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_timkiemtheo.FormattingEnabled = true;
            this.cbb_timkiemtheo.Items.AddRange(new object[] {
            "Nhân viên",
            "Khách hàng",
            "Ngày "});
            this.cbb_timkiemtheo.Location = new System.Drawing.Point(215, 42);
            this.cbb_timkiemtheo.Name = "cbb_timkiemtheo";
            this.cbb_timkiemtheo.Size = new System.Drawing.Size(374, 25);
            this.cbb_timkiemtheo.TabIndex = 2;
            this.cbb_timkiemtheo.SelectedIndexChanged += new System.EventHandler(this.cbb_timkiemtheo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // cbb_bang
            // 
            this.cbb_bang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_bang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_bang.FormattingEnabled = true;
            this.cbb_bang.Location = new System.Drawing.Point(215, 88);
            this.cbb_bang.Name = "cbb_bang";
            this.cbb_bang.Size = new System.Drawing.Size(374, 25);
            this.cbb_bang.TabIndex = 5;
            // 
            // lb_tungay
            // 
            this.lb_tungay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_tungay.AutoSize = true;
            this.lb_tungay.Location = new System.Drawing.Point(85, 140);
            this.lb_tungay.Name = "lb_tungay";
            this.lb_tungay.Size = new System.Drawing.Size(64, 17);
            this.lb_tungay.TabIndex = 6;
            this.lb_tungay.Text = "Từ ngày:";
            // 
            // dtp_tungay
            // 
            this.dtp_tungay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_tungay.CustomFormat = "dd/MM/yyyy";
            this.dtp_tungay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_tungay.Location = new System.Drawing.Point(164, 137);
            this.dtp_tungay.Name = "dtp_tungay";
            this.dtp_tungay.Size = new System.Drawing.Size(110, 23);
            this.dtp_tungay.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 535);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số lượng hóa đơn đã tạo:";
            // 
            // txt_soHDB
            // 
            this.txt_soHDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_soHDB.BackColor = System.Drawing.Color.White;
            this.txt_soHDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_soHDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soHDB.Location = new System.Drawing.Point(257, 536);
            this.txt_soHDB.Name = "txt_soHDB";
            this.txt_soHDB.ReadOnly = true;
            this.txt_soHDB.Size = new System.Drawing.Size(100, 19);
            this.txt_soHDB.TabIndex = 9;
            this.txt_soHDB.Text = "17";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txt_mahdb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(712, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 115);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn ";
            // 
            // txt_mahdb
            // 
            this.txt_mahdb.Location = new System.Drawing.Point(20, 59);
            this.txt_mahdb.Name = "txt_mahdb";
            this.txt_mahdb.ReadOnly = true;
            this.txt_mahdb.Size = new System.Drawing.Size(194, 23);
            this.txt_mahdb.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã hóa đơn:";
            // 
            // butReload
            // 
            this.butReload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(113)))), ((int)(((byte)(132)))));
            this.butReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butReload.ForeColor = System.Drawing.Color.White;
            this.butReload.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.butReload.IconColor = System.Drawing.Color.White;
            this.butReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butReload.IconSize = 40;
            this.butReload.Location = new System.Drawing.Point(221, 181);
            this.butReload.Name = "butReload";
            this.butReload.Size = new System.Drawing.Size(113, 49);
            this.butReload.TabIndex = 12;
            this.butReload.Text = "ReLoad";
            this.butReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butReload.UseVisualStyleBackColor = false;
            this.butReload.Click += new System.EventHandler(this.butReload_Click);
            // 
            // butXemHDB
            // 
            this.butXemHDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butXemHDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(113)))), ((int)(((byte)(132)))));
            this.butXemHDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butXemHDB.ForeColor = System.Drawing.Color.White;
            this.butXemHDB.IconChar = FontAwesome.Sharp.IconChar.None;
            this.butXemHDB.IconColor = System.Drawing.Color.White;
            this.butXemHDB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butXemHDB.Location = new System.Drawing.Point(802, 181);
            this.butXemHDB.Name = "butXemHDB";
            this.butXemHDB.Size = new System.Drawing.Size(161, 49);
            this.butXemHDB.TabIndex = 10;
            this.butXemHDB.Text = "Xem chi tiết hóa đơn";
            this.butXemHDB.UseVisualStyleBackColor = false;
            this.butXemHDB.Click += new System.EventHandler(this.butXemHDB_Click);
            // 
            // butTimKiem
            // 
            this.butTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(113)))), ((int)(((byte)(132)))));
            this.butTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butTimKiem.ForeColor = System.Drawing.Color.White;
            this.butTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.butTimKiem.IconColor = System.Drawing.Color.White;
            this.butTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butTimKiem.IconSize = 40;
            this.butTimKiem.Location = new System.Drawing.Point(88, 181);
            this.butTimKiem.Name = "butTimKiem";
            this.butTimKiem.Size = new System.Drawing.Size(127, 49);
            this.butTimKiem.TabIndex = 3;
            this.butTimKiem.Text = "Tìm kiếm";
            this.butTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butTimKiem.UseVisualStyleBackColor = false;
            this.butTimKiem.Click += new System.EventHandler(this.butTimKiem_Click);
            // 
            // lb_denngay
            // 
            this.lb_denngay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_denngay.AutoSize = true;
            this.lb_denngay.Location = new System.Drawing.Point(353, 143);
            this.lb_denngay.Name = "lb_denngay";
            this.lb_denngay.Size = new System.Drawing.Size(73, 17);
            this.lb_denngay.TabIndex = 6;
            this.lb_denngay.Text = "Đến ngày:";
            // 
            // dtp_denngay
            // 
            this.dtp_denngay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_denngay.CustomFormat = "dd/MM/yyyy";
            this.dtp_denngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_denngay.Location = new System.Drawing.Point(432, 140);
            this.dtp_denngay.Name = "dtp_denngay";
            this.dtp_denngay.Size = new System.Drawing.Size(110, 23);
            this.dtp_denngay.TabIndex = 7;
            // 
            // but_ExportExcel
            // 
            this.but_ExportExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but_ExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(113)))), ((int)(((byte)(132)))));
            this.but_ExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_ExportExcel.ForeColor = System.Drawing.Color.White;
            this.but_ExportExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.but_ExportExcel.IconColor = System.Drawing.Color.White;
            this.but_ExportExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.but_ExportExcel.IconSize = 40;
            this.but_ExportExcel.Location = new System.Drawing.Point(340, 181);
            this.but_ExportExcel.Name = "but_ExportExcel";
            this.but_ExportExcel.Size = new System.Drawing.Size(137, 49);
            this.but_ExportExcel.TabIndex = 13;
            this.but_ExportExcel.Text = "Export Excel";
            this.but_ExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_ExportExcel.UseVisualStyleBackColor = false;
            this.but_ExportExcel.Click += new System.EventHandler(this.but_ExportExcel_Click);
            // 
            // fDanhSachDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1053, 605);
            this.Controls.Add(this.but_ExportExcel);
            this.Controls.Add(this.butReload);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butXemHDB);
            this.Controls.Add(this.txt_soHDB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_denngay);
            this.Controls.Add(this.lb_denngay);
            this.Controls.Add(this.dtp_tungay);
            this.Controls.Add(this.lb_tungay);
            this.Controls.Add(this.cbb_bang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butTimKiem);
            this.Controls.Add(this.cbb_timkiemtheo);
            this.Controls.Add(this.dgv_hdb);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fDanhSachDonHang";
            this.Text = "Danh sách đơn hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hdb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_hdb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_timkiemtheo;
        private FontAwesome.Sharp.IconButton butTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_bang;
        private System.Windows.Forms.Label lb_tungay;
        private System.Windows.Forms.DateTimePicker dtp_tungay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_soHDB;
        private FontAwesome.Sharp.IconButton butXemHDB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_mahdb;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton butReload;
        private System.Windows.Forms.Label lb_denngay;
        private System.Windows.Forms.DateTimePicker dtp_denngay;
        private FontAwesome.Sharp.IconButton but_ExportExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayban;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
    }
}
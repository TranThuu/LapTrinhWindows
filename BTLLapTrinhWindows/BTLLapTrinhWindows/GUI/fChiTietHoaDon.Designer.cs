
namespace BTLLapTrinhWindows.GUI
{
    partial class fChiTietHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChiTietHoaDon));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.icb_thoat = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_sanpham = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butExport = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_mahdb = new System.Windows.Forms.Label();
            this.lb_nv = new System.Windows.Forms.Label();
            this.lb_kh = new System.Windows.Forms.Label();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.dtp_ngay = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_dtkh = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(128)))), ((int)(((byte)(144)))));
            this.panel_Top.Controls.Add(this.icb_thoat);
            this.panel_Top.Controls.Add(this.label7);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1067, 61);
            this.panel_Top.TabIndex = 0;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // icb_thoat
            // 
            this.icb_thoat.FlatAppearance.BorderSize = 0;
            this.icb_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icb_thoat.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.icb_thoat.IconColor = System.Drawing.Color.Black;
            this.icb_thoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icb_thoat.IconSize = 40;
            this.icb_thoat.Location = new System.Drawing.Point(989, 16);
            this.icb_thoat.Name = "icb_thoat";
            this.icb_thoat.Size = new System.Drawing.Size(56, 30);
            this.icb_thoat.TabIndex = 1;
            this.icb_thoat.UseVisualStyleBackColor = true;
            this.icb_thoat.Click += new System.EventHandler(this.icb_thoat_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(439, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chi tiết hóa đơn bán";
            // 
            // dgv_sanpham
            // 
            this.dgv_sanpham.AllowUserToAddRows = false;
            this.dgv_sanpham.AllowUserToDeleteRows = false;
            this.dgv_sanpham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_sanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sanpham.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(128)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sanpham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.tensp,
            this.dongia,
            this.soluong,
            this.thanhtien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(128)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_sanpham.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_sanpham.Location = new System.Drawing.Point(106, 251);
            this.dgv_sanpham.Name = "dgv_sanpham";
            this.dgv_sanpham.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(120)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sanpham.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_sanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sanpham.Size = new System.Drawing.Size(844, 244);
            this.dgv_sanpham.TabIndex = 1;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // tensp
            // 
            this.tensp.HeaderText = "Tên sản phẩm";
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày lập:";
            // 
            // butExport
            // 
            this.butExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(128)))), ((int)(((byte)(144)))));
            this.butExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butExport.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.butExport.IconColor = System.Drawing.Color.Black;
            this.butExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butExport.IconSize = 40;
            this.butExport.Location = new System.Drawing.Point(812, 510);
            this.butExport.Name = "butExport";
            this.butExport.Size = new System.Drawing.Size(138, 46);
            this.butExport.TabIndex = 6;
            this.butExport.Text = "Export PDF";
            this.butExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butExport.UseVisualStyleBackColor = false;
            this.butExport.Click += new System.EventHandler(this.butExport_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng tiền:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nhân viên:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(569, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Khách hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Danh sách sản phẩm:";
            // 
            // lb_mahdb
            // 
            this.lb_mahdb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_mahdb.AutoSize = true;
            this.lb_mahdb.Location = new System.Drawing.Point(231, 87);
            this.lb_mahdb.Name = "lb_mahdb";
            this.lb_mahdb.Size = new System.Drawing.Size(46, 17);
            this.lb_mahdb.TabIndex = 14;
            this.lb_mahdb.Text = "label8";
            // 
            // lb_nv
            // 
            this.lb_nv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_nv.AutoSize = true;
            this.lb_nv.Location = new System.Drawing.Point(223, 177);
            this.lb_nv.Name = "lb_nv";
            this.lb_nv.Size = new System.Drawing.Size(46, 17);
            this.lb_nv.TabIndex = 15;
            this.lb_nv.Text = "label9";
            // 
            // lb_kh
            // 
            this.lb_kh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_kh.AutoSize = true;
            this.lb_kh.Location = new System.Drawing.Point(682, 87);
            this.lb_kh.Name = "lb_kh";
            this.lb_kh.Size = new System.Drawing.Size(54, 17);
            this.lb_kh.TabIndex = 16;
            this.lb_kh.Text = "label10";
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.Location = new System.Drawing.Point(223, 510);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(54, 17);
            this.lb_tongtien.TabIndex = 18;
            this.lb_tongtien.Text = "label12";
            // 
            // dtp_ngay
            // 
            this.dtp_ngay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_ngay.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngay.Enabled = false;
            this.dtp_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngay.Location = new System.Drawing.Point(234, 134);
            this.dtp_ngay.Name = "dtp_ngay";
            this.dtp_ngay.Size = new System.Drawing.Size(200, 23);
            this.dtp_ngay.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(572, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Số điện thoại:";
            // 
            // lb_dtkh
            // 
            this.lb_dtkh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_dtkh.AutoSize = true;
            this.lb_dtkh.Location = new System.Drawing.Point(685, 120);
            this.lb_dtkh.Name = "lb_dtkh";
            this.lb_dtkh.Size = new System.Drawing.Size(46, 17);
            this.lb_dtkh.TabIndex = 21;
            this.lb_dtkh.Text = "label9";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(128)))), ((int)(((byte)(144)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 527);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(128)))), ((int)(((byte)(144)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1065, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 527);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(128)))), ((int)(((byte)(144)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(2, 586);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1063, 2);
            this.panel3.TabIndex = 23;
            // 
            // fChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_dtkh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_ngay);
            this.Controls.Add(this.lb_tongtien);
            this.Controls.Add(this.lb_kh);
            this.Controls.Add(this.lb_nv);
            this.Controls.Add(this.lb_mahdb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_sanpham);
            this.Controls.Add(this.panel_Top);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fChiTietHoaDon";
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.DataGridView dgv_sanpham;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton butExport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.Label lb_mahdb;
        private System.Windows.Forms.Label lb_nv;
        private System.Windows.Forms.Label lb_kh;
        private System.Windows.Forms.Label lb_tongtien;
        private System.Windows.Forms.DateTimePicker dtp_ngay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_dtkh;
        private FontAwesome.Sharp.IconButton icb_thoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
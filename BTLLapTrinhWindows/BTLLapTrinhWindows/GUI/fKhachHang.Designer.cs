
namespace BTLLapTrinhWindows.GUI
{
    partial class FKhachHang
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
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.icb_loc_sdt = new FontAwesome.Sharp.IconButton();
            this.icb_loc_tenkh = new FontAwesome.Sharp.IconButton();
            this.icbtn_sua = new FontAwesome.Sharp.IconButton();
            this.icbtn_xoa = new FontAwesome.Sharp.IconButton();
            this.icbtn_them = new FontAwesome.Sharp.IconButton();
            this.icbtn_export = new FontAwesome.Sharp.IconButton();
            this.icbtn_reload = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDT.Location = new System.Drawing.Point(270, 123);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(346, 26);
            this.txtSDT.TabIndex = 17;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenKhach.Location = new System.Drawing.Point(270, 81);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(346, 26);
            this.txtTenKhach.TabIndex = 18;
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaKhach.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaKhach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKhach.ForeColor = System.Drawing.Color.Black;
            this.txtMaKhach.Location = new System.Drawing.Point(270, 32);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.ReadOnly = true;
            this.txtMaKhach.Size = new System.Drawing.Size(231, 26);
            this.txtMaKhach.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số điện thoại:";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SDT";
            this.Column3.HeaderText = "Số Điện Thoại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKH";
            this.Column2.HeaderText = "Tên Khách Hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã khách hàng:";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKhach";
            this.Column1.HeaderText = "Mã Khách Hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(142)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachHang.Location = new System.Drawing.Point(39, 229);
            this.dgvKhachHang.MultiSelect = false;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(990, 291);
            this.dgvKhachHang.TabIndex = 6;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(200)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.icb_loc_sdt);
            this.groupBox1.Controls.Add(this.icb_loc_tenkh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenKhach);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaKhach);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(3)))), ((int)(((byte)(37)))));
            this.groupBox1.Location = new System.Drawing.Point(39, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 172);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            // 
            // icb_loc_sdt
            // 
            this.icb_loc_sdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icb_loc_sdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(142)))), ((int)(((byte)(191)))));
            this.icb_loc_sdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icb_loc_sdt.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.icb_loc_sdt.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.icb_loc_sdt.IconColor = System.Drawing.Color.White;
            this.icb_loc_sdt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icb_loc_sdt.IconSize = 18;
            this.icb_loc_sdt.Location = new System.Drawing.Point(575, 123);
            this.icb_loc_sdt.Name = "icb_loc_sdt";
            this.icb_loc_sdt.Size = new System.Drawing.Size(41, 25);
            this.icb_loc_sdt.TabIndex = 20;
            this.icb_loc_sdt.UseVisualStyleBackColor = false;
            this.icb_loc_sdt.Click += new System.EventHandler(this.icb_loc_sdt_Click);
            // 
            // icb_loc_tenkh
            // 
            this.icb_loc_tenkh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icb_loc_tenkh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(142)))), ((int)(((byte)(191)))));
            this.icb_loc_tenkh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icb_loc_tenkh.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.icb_loc_tenkh.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.icb_loc_tenkh.IconColor = System.Drawing.Color.White;
            this.icb_loc_tenkh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icb_loc_tenkh.IconSize = 18;
            this.icb_loc_tenkh.Location = new System.Drawing.Point(575, 81);
            this.icb_loc_tenkh.Name = "icb_loc_tenkh";
            this.icb_loc_tenkh.Size = new System.Drawing.Size(41, 25);
            this.icb_loc_tenkh.TabIndex = 20;
            this.icb_loc_tenkh.UseVisualStyleBackColor = false;
            this.icb_loc_tenkh.Click += new System.EventHandler(this.icb_loc_tenkh_Click);
            // 
            // icbtn_sua
            // 
            this.icbtn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(142)))), ((int)(((byte)(191)))));
            this.icbtn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_sua.ForeColor = System.Drawing.Color.White;
            this.icbtn_sua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.icbtn_sua.IconColor = System.Drawing.Color.White;
            this.icbtn_sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_sua.IconSize = 40;
            this.icbtn_sua.Location = new System.Drawing.Point(879, 82);
            this.icbtn_sua.Name = "icbtn_sua";
            this.icbtn_sua.Size = new System.Drawing.Size(150, 46);
            this.icbtn_sua.TabIndex = 22;
            this.icbtn_sua.Text = "Sửa";
            this.icbtn_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_sua.UseVisualStyleBackColor = false;
            this.icbtn_sua.Click += new System.EventHandler(this.icbtn_sua_Click);
            // 
            // icbtn_xoa
            // 
            this.icbtn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(142)))), ((int)(((byte)(191)))));
            this.icbtn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_xoa.ForeColor = System.Drawing.Color.White;
            this.icbtn_xoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.icbtn_xoa.IconColor = System.Drawing.Color.White;
            this.icbtn_xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_xoa.IconSize = 40;
            this.icbtn_xoa.Location = new System.Drawing.Point(879, 143);
            this.icbtn_xoa.Name = "icbtn_xoa";
            this.icbtn_xoa.Size = new System.Drawing.Size(150, 46);
            this.icbtn_xoa.TabIndex = 22;
            this.icbtn_xoa.Text = "Xóa";
            this.icbtn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_xoa.UseVisualStyleBackColor = false;
            this.icbtn_xoa.Click += new System.EventHandler(this.icbtn_xoa_Click);
            // 
            // icbtn_them
            // 
            this.icbtn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(142)))), ((int)(((byte)(191)))));
            this.icbtn_them.FlatAppearance.BorderSize = 0;
            this.icbtn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_them.ForeColor = System.Drawing.Color.White;
            this.icbtn_them.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.icbtn_them.IconColor = System.Drawing.Color.White;
            this.icbtn_them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_them.IconSize = 40;
            this.icbtn_them.Location = new System.Drawing.Point(879, 20);
            this.icbtn_them.Name = "icbtn_them";
            this.icbtn_them.Size = new System.Drawing.Size(150, 46);
            this.icbtn_them.TabIndex = 24;
            this.icbtn_them.Text = "Thêm";
            this.icbtn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_them.UseVisualStyleBackColor = false;
            this.icbtn_them.Click += new System.EventHandler(this.icbtn_them_Click);
            // 
            // icbtn_export
            // 
            this.icbtn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(142)))), ((int)(((byte)(191)))));
            this.icbtn_export.FlatAppearance.BorderSize = 0;
            this.icbtn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_export.ForeColor = System.Drawing.Color.White;
            this.icbtn_export.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.icbtn_export.IconColor = System.Drawing.Color.White;
            this.icbtn_export.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_export.IconSize = 40;
            this.icbtn_export.Location = new System.Drawing.Point(409, 535);
            this.icbtn_export.Name = "icbtn_export";
            this.icbtn_export.Size = new System.Drawing.Size(157, 49);
            this.icbtn_export.TabIndex = 24;
            this.icbtn_export.Text = "Export Excel";
            this.icbtn_export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_export.UseVisualStyleBackColor = false;
            this.icbtn_export.Click += new System.EventHandler(this.icbtn_export_Click);
            // 
            // icbtn_reload
            // 
            this.icbtn_reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(142)))), ((int)(((byte)(191)))));
            this.icbtn_reload.FlatAppearance.BorderSize = 0;
            this.icbtn_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_reload.ForeColor = System.Drawing.Color.White;
            this.icbtn_reload.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.icbtn_reload.IconColor = System.Drawing.Color.White;
            this.icbtn_reload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_reload.IconSize = 40;
            this.icbtn_reload.Location = new System.Drawing.Point(585, 534);
            this.icbtn_reload.Name = "icbtn_reload";
            this.icbtn_reload.Size = new System.Drawing.Size(157, 49);
            this.icbtn_reload.TabIndex = 24;
            this.icbtn_reload.Text = "Reload";
            this.icbtn_reload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_reload.UseVisualStyleBackColor = false;
            this.icbtn_reload.Click += new System.EventHandler(this.icbtn_reload_Click);
            // 
            // FKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1053, 605);
            this.Controls.Add(this.icbtn_reload);
            this.Controls.Add(this.icbtn_export);
            this.Controls.Add(this.icbtn_them);
            this.Controls.Add(this.icbtn_xoa);
            this.Controls.Add(this.icbtn_sua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvKhachHang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FKhachHang";
            this.Text = "KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.fKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton icbtn_sua;
        private FontAwesome.Sharp.IconButton icbtn_xoa;
        private FontAwesome.Sharp.IconButton icbtn_them;
        private FontAwesome.Sharp.IconButton icbtn_export;
        private FontAwesome.Sharp.IconButton icbtn_reload;
        private FontAwesome.Sharp.IconButton icb_loc_tenkh;
        private FontAwesome.Sharp.IconButton icb_loc_sdt;
    }
}
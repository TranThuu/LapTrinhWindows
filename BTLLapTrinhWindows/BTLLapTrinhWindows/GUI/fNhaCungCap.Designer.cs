
namespace BTLLapTrinhWindows.GUI
{
    partial class fNhaCungCap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.icbtn_xoa = new FontAwesome.Sharp.IconButton();
            this.icbtn_sua = new FontAwesome.Sharp.IconButton();
            this.icbtn_them = new FontAwesome.Sharp.IconButton();
            this.icbtn_export = new FontAwesome.Sharp.IconButton();
            this.icbtn_reload = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNCC
            // 
            this.dgvNCC.AllowUserToAddRows = false;
            this.dgvNCC.AllowUserToDeleteRows = false;
            this.dgvNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNCC.BackgroundColor = System.Drawing.Color.White;
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNCC.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNCC.Location = new System.Drawing.Point(40, 305);
            this.dgvNCC.MultiSelect = false;
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.ReadOnly = true;
            this.dgvNCC.RowHeadersWidth = 51;
            this.dgvNCC.RowTemplate.Height = 24;
            this.dgvNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNCC.Size = new System.Drawing.Size(973, 254);
            this.dgvNCC.TabIndex = 14;
            this.dgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNhaCC";
            this.Column1.HeaderText = "Mã NCC";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNCC";
            this.Column2.HeaderText = "Tên NCC";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SDT";
            this.Column3.HeaderText = "Số điện thoại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DiaChi";
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDT.Location = new System.Drawing.Point(176, 132);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(253, 23);
            this.txtSDT.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiaChi.Location = new System.Drawing.Point(176, 187);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(557, 55);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNCC.Location = new System.Drawing.Point(176, 81);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(557, 23);
            this.txtTenNCC.TabIndex = 12;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaNCC.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNCC.ForeColor = System.Drawing.Color.Black;
            this.txtMaNCC.Location = new System.Drawing.Point(177, 36);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.ReadOnly = true;
            this.txtMaNCC.Size = new System.Drawing.Size(169, 23);
            this.txtMaNCC.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Điện Thoại:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa Chỉ:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên Nhà Cung Cấp:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã Nhà Cung Cấp:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaNCC);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenNCC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(40, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 267);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // icbtn_xoa
            // 
            this.icbtn_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icbtn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.icbtn_xoa.FlatAppearance.BorderSize = 0;
            this.icbtn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_xoa.ForeColor = System.Drawing.Color.White;
            this.icbtn_xoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.icbtn_xoa.IconColor = System.Drawing.Color.White;
            this.icbtn_xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_xoa.IconSize = 40;
            this.icbtn_xoa.Location = new System.Drawing.Point(862, 118);
            this.icbtn_xoa.Name = "icbtn_xoa";
            this.icbtn_xoa.Size = new System.Drawing.Size(151, 46);
            this.icbtn_xoa.TabIndex = 20;
            this.icbtn_xoa.Text = "Xóa";
            this.icbtn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_xoa.UseVisualStyleBackColor = false;
            this.icbtn_xoa.Click += new System.EventHandler(this.icbtn_xoa_Click);
            // 
            // icbtn_sua
            // 
            this.icbtn_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icbtn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.icbtn_sua.FlatAppearance.BorderSize = 0;
            this.icbtn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_sua.ForeColor = System.Drawing.Color.White;
            this.icbtn_sua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.icbtn_sua.IconColor = System.Drawing.Color.White;
            this.icbtn_sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_sua.IconSize = 40;
            this.icbtn_sua.Location = new System.Drawing.Point(862, 64);
            this.icbtn_sua.Name = "icbtn_sua";
            this.icbtn_sua.Size = new System.Drawing.Size(151, 46);
            this.icbtn_sua.TabIndex = 20;
            this.icbtn_sua.Text = "Sửa";
            this.icbtn_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_sua.UseVisualStyleBackColor = false;
            this.icbtn_sua.Click += new System.EventHandler(this.icbtn_sua_Click);
            // 
            // icbtn_them
            // 
            this.icbtn_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icbtn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.icbtn_them.FlatAppearance.BorderSize = 0;
            this.icbtn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_them.ForeColor = System.Drawing.Color.White;
            this.icbtn_them.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.icbtn_them.IconColor = System.Drawing.Color.White;
            this.icbtn_them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_them.IconSize = 40;
            this.icbtn_them.Location = new System.Drawing.Point(862, 12);
            this.icbtn_them.Name = "icbtn_them";
            this.icbtn_them.Size = new System.Drawing.Size(151, 46);
            this.icbtn_them.TabIndex = 20;
            this.icbtn_them.Text = "Thêm";
            this.icbtn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_them.UseVisualStyleBackColor = false;
            this.icbtn_them.Click += new System.EventHandler(this.icbtn_them_Click);
            // 
            // icbtn_export
            // 
            this.icbtn_export.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icbtn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.icbtn_export.FlatAppearance.BorderSize = 0;
            this.icbtn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_export.ForeColor = System.Drawing.Color.White;
            this.icbtn_export.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.icbtn_export.IconColor = System.Drawing.Color.White;
            this.icbtn_export.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_export.IconSize = 40;
            this.icbtn_export.Location = new System.Drawing.Point(862, 231);
            this.icbtn_export.Name = "icbtn_export";
            this.icbtn_export.Size = new System.Drawing.Size(151, 46);
            this.icbtn_export.TabIndex = 20;
            this.icbtn_export.Text = "Export Excel";
            this.icbtn_export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_export.UseVisualStyleBackColor = false;
            this.icbtn_export.Click += new System.EventHandler(this.icbtn_export_Click);
            // 
            // icbtn_reload
            // 
            this.icbtn_reload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icbtn_reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.icbtn_reload.FlatAppearance.BorderSize = 0;
            this.icbtn_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icbtn_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icbtn_reload.ForeColor = System.Drawing.Color.White;
            this.icbtn_reload.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.icbtn_reload.IconColor = System.Drawing.Color.White;
            this.icbtn_reload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icbtn_reload.IconSize = 40;
            this.icbtn_reload.Location = new System.Drawing.Point(862, 179);
            this.icbtn_reload.Name = "icbtn_reload";
            this.icbtn_reload.Size = new System.Drawing.Size(151, 46);
            this.icbtn_reload.TabIndex = 20;
            this.icbtn_reload.Text = "Reload";
            this.icbtn_reload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icbtn_reload.UseVisualStyleBackColor = false;
            this.icbtn_reload.Click += new System.EventHandler(this.icbtn_reload_Click);
            // 
            // fNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1053, 605);
            this.Controls.Add(this.icbtn_sua);
            this.Controls.Add(this.icbtn_xoa);
            this.Controls.Add(this.icbtn_reload);
            this.Controls.Add(this.icbtn_export);
            this.Controls.Add(this.icbtn_them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvNCC);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fNhaCungCap";
            this.Text = "Nhà cung cấp";
            this.Load += new System.EventHandler(this.fNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private FontAwesome.Sharp.IconButton icbtn_them;
        private FontAwesome.Sharp.IconButton icbtn_export;
        private FontAwesome.Sharp.IconButton icbtn_reload;
        private FontAwesome.Sharp.IconButton icbtn_xoa;
        private FontAwesome.Sharp.IconButton icbtn_sua;
    }
}
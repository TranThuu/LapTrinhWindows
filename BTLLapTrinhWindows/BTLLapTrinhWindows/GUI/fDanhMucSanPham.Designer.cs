
namespace BTLLapTrinhWindows.GUI
{
    partial class fDanhMucSanPham
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.icb_sua = new FontAwesome.Sharp.IconButton();
            this.icb_reload = new FontAwesome.Sharp.IconButton();
            this.icb_them = new FontAwesome.Sharp.IconButton();
            this.grpDanhMuc = new System.Windows.Forms.GroupBox();
            this.pl_ttrang = new System.Windows.Forms.Panel();
            this.icb_loc = new FontAwesome.Sharp.IconButton();
            this.ckb_tinhtrang = new System.Windows.Forms.CheckBox();
            this.lb_tinhtrang = new System.Windows.Forms.Label();
            this.lblTenDMError = new System.Windows.Forms.Label();
            this.lblMaDMError = new System.Windows.Forms.Label();
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.lblTenDM = new System.Windows.Forms.Label();
            this.txtMaDM = new System.Windows.Forms.TextBox();
            this.lblMaDM = new System.Windows.Forms.Label();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpDanhMuc.SuspendLayout();
            this.pl_ttrang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1053, 605);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.icb_sua);
            this.panel2.Controls.Add(this.icb_reload);
            this.panel2.Controls.Add(this.icb_them);
            this.panel2.Controls.Add(this.grpDanhMuc);
            this.panel2.Controls.Add(this.dgvDanhMuc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1045, 595);
            this.panel2.TabIndex = 1;
            // 
            // icb_sua
            // 
            this.icb_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icb_sua.BackColor = System.Drawing.Color.LightSeaGreen;
            this.icb_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icb_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icb_sua.ForeColor = System.Drawing.Color.White;
            this.icb_sua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.icb_sua.IconColor = System.Drawing.Color.White;
            this.icb_sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icb_sua.IconSize = 40;
            this.icb_sua.Location = new System.Drawing.Point(791, 172);
            this.icb_sua.Name = "icb_sua";
            this.icb_sua.Size = new System.Drawing.Size(171, 44);
            this.icb_sua.TabIndex = 7;
            this.icb_sua.Text = "Sửa";
            this.icb_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icb_sua.UseVisualStyleBackColor = false;
            this.icb_sua.Click += new System.EventHandler(this.icb_sua_Click);
            // 
            // icb_reload
            // 
            this.icb_reload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icb_reload.BackColor = System.Drawing.Color.LightSeaGreen;
            this.icb_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icb_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icb_reload.ForeColor = System.Drawing.Color.White;
            this.icb_reload.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.icb_reload.IconColor = System.Drawing.Color.White;
            this.icb_reload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icb_reload.IconSize = 40;
            this.icb_reload.Location = new System.Drawing.Point(791, 68);
            this.icb_reload.Name = "icb_reload";
            this.icb_reload.Size = new System.Drawing.Size(171, 44);
            this.icb_reload.TabIndex = 7;
            this.icb_reload.Text = "Reload";
            this.icb_reload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icb_reload.UseVisualStyleBackColor = false;
            this.icb_reload.Click += new System.EventHandler(this.icb_reload_Click);
            // 
            // icb_them
            // 
            this.icb_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icb_them.BackColor = System.Drawing.Color.LightSeaGreen;
            this.icb_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icb_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icb_them.ForeColor = System.Drawing.Color.White;
            this.icb_them.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.icb_them.IconColor = System.Drawing.Color.White;
            this.icb_them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icb_them.IconSize = 40;
            this.icb_them.Location = new System.Drawing.Point(791, 18);
            this.icb_them.Name = "icb_them";
            this.icb_them.Size = new System.Drawing.Size(171, 44);
            this.icb_them.TabIndex = 7;
            this.icb_them.Text = "Thêm";
            this.icb_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icb_them.UseVisualStyleBackColor = false;
            this.icb_them.Click += new System.EventHandler(this.icb_them_Click);
            // 
            // grpDanhMuc
            // 
            this.grpDanhMuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpDanhMuc.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grpDanhMuc.Controls.Add(this.pl_ttrang);
            this.grpDanhMuc.Controls.Add(this.lb_tinhtrang);
            this.grpDanhMuc.Controls.Add(this.lblTenDMError);
            this.grpDanhMuc.Controls.Add(this.lblMaDMError);
            this.grpDanhMuc.Controls.Add(this.txtTenDM);
            this.grpDanhMuc.Controls.Add(this.lblTenDM);
            this.grpDanhMuc.Controls.Add(this.txtMaDM);
            this.grpDanhMuc.Controls.Add(this.lblMaDM);
            this.grpDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhMuc.ForeColor = System.Drawing.Color.Black;
            this.grpDanhMuc.Location = new System.Drawing.Point(66, 18);
            this.grpDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.grpDanhMuc.Name = "grpDanhMuc";
            this.grpDanhMuc.Padding = new System.Windows.Forms.Padding(4);
            this.grpDanhMuc.Size = new System.Drawing.Size(683, 198);
            this.grpDanhMuc.TabIndex = 2;
            this.grpDanhMuc.TabStop = false;
            this.grpDanhMuc.Text = "Danh mục";
            // 
            // pl_ttrang
            // 
            this.pl_ttrang.BackColor = System.Drawing.Color.White;
            this.pl_ttrang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_ttrang.Controls.Add(this.icb_loc);
            this.pl_ttrang.Controls.Add(this.ckb_tinhtrang);
            this.pl_ttrang.Location = new System.Drawing.Point(255, 141);
            this.pl_ttrang.Name = "pl_ttrang";
            this.pl_ttrang.Size = new System.Drawing.Size(341, 29);
            this.pl_ttrang.TabIndex = 10;
            // 
            // icb_loc
            // 
            this.icb_loc.BackColor = System.Drawing.Color.LightSeaGreen;
            this.icb_loc.Dock = System.Windows.Forms.DockStyle.Right;
            this.icb_loc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icb_loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icb_loc.ForeColor = System.Drawing.Color.White;
            this.icb_loc.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.icb_loc.IconColor = System.Drawing.Color.White;
            this.icb_loc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icb_loc.IconSize = 20;
            this.icb_loc.Location = new System.Drawing.Point(307, 0);
            this.icb_loc.Name = "icb_loc";
            this.icb_loc.Size = new System.Drawing.Size(32, 27);
            this.icb_loc.TabIndex = 7;
            this.icb_loc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icb_loc.UseVisualStyleBackColor = false;
            this.icb_loc.Click += new System.EventHandler(this.icb_loc_Click);
            // 
            // ckb_tinhtrang
            // 
            this.ckb_tinhtrang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckb_tinhtrang.AutoSize = true;
            this.ckb_tinhtrang.Checked = true;
            this.ckb_tinhtrang.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_tinhtrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_tinhtrang.Location = new System.Drawing.Point(10, 4);
            this.ckb_tinhtrang.Name = "ckb_tinhtrang";
            this.ckb_tinhtrang.Size = new System.Drawing.Size(80, 21);
            this.ckb_tinhtrang.TabIndex = 9;
            this.ckb_tinhtrang.Text = "Còn bán";
            this.ckb_tinhtrang.UseVisualStyleBackColor = true;
            // 
            // lb_tinhtrang
            // 
            this.lb_tinhtrang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_tinhtrang.AutoSize = true;
            this.lb_tinhtrang.Location = new System.Drawing.Point(131, 139);
            this.lb_tinhtrang.Name = "lb_tinhtrang";
            this.lb_tinhtrang.Size = new System.Drawing.Size(84, 20);
            this.lb_tinhtrang.TabIndex = 8;
            this.lb_tinhtrang.Text = "Tình trạng:";
            // 
            // lblTenDMError
            // 
            this.lblTenDMError.AutoSize = true;
            this.lblTenDMError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDMError.Location = new System.Drawing.Point(211, 113);
            this.lblTenDMError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenDMError.Name = "lblTenDMError";
            this.lblTenDMError.Size = new System.Drawing.Size(0, 16);
            this.lblTenDMError.TabIndex = 7;
            // 
            // lblMaDMError
            // 
            this.lblMaDMError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaDMError.AutoSize = true;
            this.lblMaDMError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDMError.Location = new System.Drawing.Point(251, 70);
            this.lblMaDMError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaDMError.Name = "lblMaDMError";
            this.lblMaDMError.Size = new System.Drawing.Size(0, 16);
            this.lblMaDMError.TabIndex = 6;
            // 
            // txtTenDM
            // 
            this.txtTenDM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDM.Location = new System.Drawing.Point(255, 88);
            this.txtTenDM.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(341, 23);
            this.txtTenDM.TabIndex = 3;
            // 
            // lblTenDM
            // 
            this.lblTenDM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenDM.AutoSize = true;
            this.lblTenDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDM.Location = new System.Drawing.Point(131, 93);
            this.lblTenDM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenDM.Name = "lblTenDM";
            this.lblTenDM.Size = new System.Drawing.Size(114, 20);
            this.lblTenDM.TabIndex = 2;
            this.lblTenDM.Text = "Tên danh mục:";
            // 
            // txtMaDM
            // 
            this.txtMaDM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaDM.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaDM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDM.Location = new System.Drawing.Point(255, 43);
            this.txtMaDM.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.ReadOnly = true;
            this.txtMaDM.Size = new System.Drawing.Size(197, 23);
            this.txtMaDM.TabIndex = 1;
            // 
            // lblMaDM
            // 
            this.lblMaDM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaDM.AutoSize = true;
            this.lblMaDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDM.Location = new System.Drawing.Point(131, 44);
            this.lblMaDM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaDM.Name = "lblMaDM";
            this.lblMaDM.Size = new System.Drawing.Size(109, 20);
            this.lblMaDM.TabIndex = 0;
            this.lblMaDM.Text = "Mã danh mục:";
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AllowUserToAddRows = false;
            this.dgvDanhMuc.AllowUserToDeleteRows = false;
            this.dgvDanhMuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhMuc.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhMuc.Location = new System.Drawing.Point(66, 270);
            this.dgvDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhMuc.MultiSelect = false;
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMuc.Size = new System.Drawing.Size(896, 237);
            this.dgvDanhMuc.TabIndex = 1;
            this.dgvDanhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMuc_CellClick);
            // 
            // fDanhMucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1053, 605);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fDanhMucSanPham";
            this.Text = "Danh mục sản phẩm";
            this.Load += new System.EventHandler(this.fDanhMucSanPham_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.grpDanhMuc.ResumeLayout(false);
            this.grpDanhMuc.PerformLayout();
            this.pl_ttrang.ResumeLayout(false);
            this.pl_ttrang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grpDanhMuc;
        private System.Windows.Forms.Label lblTenDMError;
        private System.Windows.Forms.Label lblMaDMError;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.Label lblTenDM;
        private System.Windows.Forms.TextBox txtMaDM;
        private System.Windows.Forms.Label lblMaDM;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.CheckBox ckb_tinhtrang;
        private System.Windows.Forms.Label lb_tinhtrang;
        private FontAwesome.Sharp.IconButton icb_sua;
        private FontAwesome.Sharp.IconButton icb_reload;
        private FontAwesome.Sharp.IconButton icb_loc;
        private FontAwesome.Sharp.IconButton icb_them;
        private System.Windows.Forms.Panel pl_ttrang;
    }
}
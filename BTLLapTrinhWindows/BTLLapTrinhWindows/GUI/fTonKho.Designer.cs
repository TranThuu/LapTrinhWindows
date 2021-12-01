
namespace BTLLapTrinhWindows.GUI
{
    partial class fTonKho
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPDF = new FontAwesome.Sharp.IconButton();
            this.btnExcel = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTongTonKho = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.txtSanPham = new System.Windows.Forms.TextBox();
            this.cmbDanhMuc = new System.Windows.Forms.ComboBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTonKho = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnPDF);
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnXemBaoCao);
            this.panel1.Controls.Add(this.txtSanPham);
            this.panel1.Controls.Add(this.cmbDanhMuc);
            this.panel1.Controls.Add(this.lbTen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 169);
            this.panel1.TabIndex = 0;
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnPDF.IconColor = System.Drawing.Color.White;
            this.btnPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPDF.IconSize = 40;
            this.btnPDF.Location = new System.Drawing.Point(821, 114);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(177, 50);
            this.btnPDF.TabIndex = 9;
            this.btnPDF.Text = "   Export PDF";
            this.btnPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnbtnPDF_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExcel.IconColor = System.Drawing.Color.White;
            this.btnExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExcel.IconSize = 40;
            this.btnExcel.Location = new System.Drawing.Point(821, 61);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(177, 50);
            this.btnExcel.TabIndex = 9;
            this.btnExcel.Text = "   Export Excel";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(308, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(328, 90);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lbTongTonKho);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 77);
            this.panel3.TabIndex = 4;
            // 
            // lbTongTonKho
            // 
            this.lbTongTonKho.AutoSize = true;
            this.lbTongTonKho.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbTongTonKho.Location = new System.Drawing.Point(15, 37);
            this.lbTongTonKho.Name = "lbTongTonKho";
            this.lbTongTonKho.Size = new System.Drawing.Size(126, 19);
            this.lbTongTonKho.TabIndex = 0;
            this.lbTongTonKho.Text = "1000000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá trị tồn kho của chi nhánh";
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXemBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btnXemBaoCao.FlatAppearance.BorderSize = 0;
            this.btnXemBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemBaoCao.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnXemBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnXemBaoCao.Location = new System.Drawing.Point(821, 5);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(177, 50);
            this.btnXemBaoCao.TabIndex = 3;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = false;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // txtSanPham
            // 
            this.txtSanPham.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSanPham.Location = new System.Drawing.Point(577, 27);
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.Size = new System.Drawing.Size(162, 24);
            this.txtSanPham.TabIndex = 2;
            // 
            // cmbDanhMuc
            // 
            this.cmbDanhMuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbDanhMuc.BackColor = System.Drawing.Color.White;
            this.cmbDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDanhMuc.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDanhMuc.FormattingEnabled = true;
            this.cmbDanhMuc.Location = new System.Drawing.Point(213, 27);
            this.cmbDanhMuc.Name = "cmbDanhMuc";
            this.cmbDanhMuc.Size = new System.Drawing.Size(180, 24);
            this.cmbDanhMuc.TabIndex = 1;
            // 
            // lbTen
            // 
            this.lbTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(485, 27);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(77, 19);
            this.lbTen.TabIndex = 0;
            this.lbTen.Text = "Sản phẩm";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvTonKho);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1053, 436);
            this.panel2.TabIndex = 1;
            // 
            // dgvTonKho
            // 
            this.dgvTonKho.AllowUserToAddRows = false;
            this.dgvTonKho.AllowUserToDeleteRows = false;
            this.dgvTonKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTonKho.BackgroundColor = System.Drawing.Color.White;
            this.dgvTonKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTonKho.ColumnHeadersHeight = 45;
            this.dgvTonKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.sp,
            this.dvt,
            this.dm,
            this.Tk,
            this.gtt});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTonKho.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTonKho.Location = new System.Drawing.Point(12, 6);
            this.dgvTonKho.MultiSelect = false;
            this.dgvTonKho.Name = "dgvTonKho";
            this.dgvTonKho.ReadOnly = true;
            this.dgvTonKho.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTonKho.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTonKho.RowHeadersVisible = false;
            this.dgvTonKho.RowHeadersWidth = 51;
            this.dgvTonKho.RowTemplate.Height = 35;
            this.dgvTonKho.RowTemplate.ReadOnly = true;
            this.dgvTonKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTonKho.Size = new System.Drawing.Size(1029, 393);
            this.dgvTonKho.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "MaSanPham";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 120;
            // 
            // sp
            // 
            this.sp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sp.DataPropertyName = "TenSP";
            this.sp.FillWeight = 30.92783F;
            this.sp.HeaderText = "Sản phẩm";
            this.sp.MinimumWidth = 6;
            this.sp.Name = "sp";
            this.sp.ReadOnly = true;
            // 
            // dvt
            // 
            this.dvt.DataPropertyName = "DonViTinh";
            this.dvt.FillWeight = 376.2887F;
            this.dvt.HeaderText = "DVT";
            this.dvt.MinimumWidth = 6;
            this.dvt.Name = "dvt";
            this.dvt.ReadOnly = true;
            this.dvt.Width = 73;
            // 
            // dm
            // 
            this.dm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dm.DataPropertyName = "TenDM";
            this.dm.FillWeight = 30.92783F;
            this.dm.HeaderText = "Danh mục";
            this.dm.MinimumWidth = 6;
            this.dm.Name = "dm";
            this.dm.ReadOnly = true;
            this.dm.Width = 220;
            // 
            // Tk
            // 
            this.Tk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Tk.DataPropertyName = "TonKho";
            this.Tk.FillWeight = 30.92783F;
            this.Tk.HeaderText = "Tồn kho";
            this.Tk.MinimumWidth = 6;
            this.Tk.Name = "Tk";
            this.Tk.ReadOnly = true;
            this.Tk.Width = 120;
            // 
            // gtt
            // 
            this.gtt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.gtt.DataPropertyName = "GiaTriTon";
            this.gtt.FillWeight = 30.92783F;
            this.gtt.HeaderText = "Giá trị tồn";
            this.gtt.MinimumWidth = 6;
            this.gtt.Name = "gtt";
            this.gtt.ReadOnly = true;
            this.gtt.Width = 180;
            // 
            // fTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 605);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTonKho";
            this.Text = "TỒN KHO";
            this.Load += new System.EventHandler(this.fTonKho_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTonKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTonKho;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.TextBox txtSanPham;
        private System.Windows.Forms.ComboBox cmbDanhMuc;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTongTonKho;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnExcel;
        private FontAwesome.Sharp.IconButton btnPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tk;
        private System.Windows.Forms.DataGridViewTextBoxColumn gtt;
    }
}
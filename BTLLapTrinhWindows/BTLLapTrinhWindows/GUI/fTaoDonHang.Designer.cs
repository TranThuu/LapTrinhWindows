
namespace BTLLapTrinhWindows.GUI
{
    partial class fTaoDonHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.butPDF = new FontAwesome.Sharp.IconButton();
            this.butNew = new FontAwesome.Sharp.IconButton();
            this.butSave = new FontAwesome.Sharp.IconButton();
            this.butXoa = new System.Windows.Forms.Button();
            this.butSua = new System.Windows.Forms.Button();
            this.butThem = new System.Windows.Forms.Button();
            this.txt_soluongcon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_soluongmua = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbb_sanpham = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_dmsp = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ptb_anhsp = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_mahdb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_ngaylap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckb_KH = new System.Windows.Forms.CheckBox();
            this.cbb_KH = new System.Windows.Forms.ComboBox();
            this.txt_sdtkh = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_sanpham = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anhsp)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butPDF);
            this.panel1.Controls.Add(this.butNew);
            this.panel1.Controls.Add(this.butSave);
            this.panel1.Controls.Add(this.butXoa);
            this.panel1.Controls.Add(this.butSua);
            this.panel1.Controls.Add(this.butThem);
            this.panel1.Controls.Add(this.txt_soluongcon);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_soluongmua);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbb_sanpham);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbb_dmsp);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ptb_anhsp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(775, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 605);
            this.panel1.TabIndex = 0;
            // 
            // butPDF
            // 
            this.butPDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(104)))), ((int)(((byte)(107)))));
            this.butPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPDF.ForeColor = System.Drawing.Color.White;
            this.butPDF.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.butPDF.IconColor = System.Drawing.Color.White;
            this.butPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butPDF.IconSize = 40;
            this.butPDF.Location = new System.Drawing.Point(25, 552);
            this.butPDF.Name = "butPDF";
            this.butPDF.Size = new System.Drawing.Size(231, 50);
            this.butPDF.TabIndex = 8;
            this.butPDF.Text = "   Export PDF";
            this.butPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butPDF.UseVisualStyleBackColor = false;
            this.butPDF.Click += new System.EventHandler(this.butPDF_Click);
            // 
            // butNew
            // 
            this.butNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(131)))), ((int)(((byte)(135)))));
            this.butNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNew.ForeColor = System.Drawing.Color.White;
            this.butNew.IconChar = FontAwesome.Sharp.IconChar.File;
            this.butNew.IconColor = System.Drawing.Color.White;
            this.butNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butNew.IconSize = 40;
            this.butNew.Location = new System.Drawing.Point(25, 501);
            this.butNew.Name = "butNew";
            this.butNew.Size = new System.Drawing.Size(231, 50);
            this.butNew.TabIndex = 8;
            this.butNew.Text = "       New";
            this.butNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butNew.UseVisualStyleBackColor = false;
            this.butNew.Click += new System.EventHandler(this.butNew_Click);
            // 
            // butSave
            // 
            this.butSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(174)))), ((int)(((byte)(179)))));
            this.butSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSave.ForeColor = System.Drawing.Color.White;
            this.butSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.butSave.IconColor = System.Drawing.Color.White;
            this.butSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butSave.IconSize = 40;
            this.butSave.Location = new System.Drawing.Point(25, 452);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(231, 47);
            this.butSave.TabIndex = 8;
            this.butSave.Text = "        Save";
            this.butSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butSave.UseVisualStyleBackColor = false;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butXoa
            // 
            this.butXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.butXoa.FlatAppearance.BorderSize = 0;
            this.butXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butXoa.Location = new System.Drawing.Point(181, 398);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(75, 32);
            this.butXoa.TabIndex = 7;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = false;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butSua
            // 
            this.butSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.butSua.FlatAppearance.BorderSize = 0;
            this.butSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSua.Location = new System.Drawing.Point(103, 398);
            this.butSua.Name = "butSua";
            this.butSua.Size = new System.Drawing.Size(75, 32);
            this.butSua.TabIndex = 7;
            this.butSua.Text = "Sửa";
            this.butSua.UseVisualStyleBackColor = false;
            this.butSua.Click += new System.EventHandler(this.butSua_Click);
            // 
            // butThem
            // 
            this.butThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(182)))), ((int)(((byte)(186)))));
            this.butThem.FlatAppearance.BorderSize = 0;
            this.butThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butThem.Location = new System.Drawing.Point(25, 398);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(75, 32);
            this.butThem.TabIndex = 7;
            this.butThem.Text = "Thêm";
            this.butThem.UseVisualStyleBackColor = false;
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // txt_soluongcon
            // 
            this.txt_soluongcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_soluongcon.Enabled = false;
            this.txt_soluongcon.Location = new System.Drawing.Point(151, 362);
            this.txt_soluongcon.Name = "txt_soluongcon";
            this.txt_soluongcon.Size = new System.Drawing.Size(100, 23);
            this.txt_soluongcon.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(152, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Số lượng còn:";
            // 
            // txt_soluongmua
            // 
            this.txt_soluongmua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_soluongmua.Location = new System.Drawing.Point(25, 362);
            this.txt_soluongmua.Name = "txt_soluongmua";
            this.txt_soluongmua.Size = new System.Drawing.Size(100, 23);
            this.txt_soluongmua.TabIndex = 6;
            this.txt_soluongmua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soluongmua_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Số lượng mua:";
            // 
            // cbb_sanpham
            // 
            this.cbb_sanpham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_sanpham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_sanpham.FormattingEnabled = true;
            this.cbb_sanpham.Location = new System.Drawing.Point(25, 302);
            this.cbb_sanpham.Name = "cbb_sanpham";
            this.cbb_sanpham.Size = new System.Drawing.Size(226, 25);
            this.cbb_sanpham.TabIndex = 4;
            this.cbb_sanpham.SelectedIndexChanged += new System.EventHandler(this.cbb_sanpham_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Sản phẩm:";
            // 
            // cbb_dmsp
            // 
            this.cbb_dmsp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_dmsp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_dmsp.FormattingEnabled = true;
            this.cbb_dmsp.Location = new System.Drawing.Point(25, 238);
            this.cbb_dmsp.Name = "cbb_dmsp";
            this.cbb_dmsp.Size = new System.Drawing.Size(226, 25);
            this.cbb_dmsp.TabIndex = 2;
            this.cbb_dmsp.SelectedIndexChanged += new System.EventHandler(this.cbb_dmsp_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Danh mục sản phẩm:";
            // 
            // ptb_anhsp
            // 
            this.ptb_anhsp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptb_anhsp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_anhsp.Location = new System.Drawing.Point(18, 12);
            this.ptb_anhsp.Name = "ptb_anhsp";
            this.ptb_anhsp.Size = new System.Drawing.Size(244, 185);
            this.ptb_anhsp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_anhsp.TabIndex = 0;
            this.ptb_anhsp.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 235);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txt_mahdb);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtp_ngaylap);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(32, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 154);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa đơn";
            // 
            // txt_mahdb
            // 
            this.txt_mahdb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_mahdb.BackColor = System.Drawing.Color.White;
            this.txt_mahdb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mahdb.Location = new System.Drawing.Point(135, 40);
            this.txt_mahdb.Name = "txt_mahdb";
            this.txt_mahdb.ReadOnly = true;
            this.txt_mahdb.Size = new System.Drawing.Size(200, 16);
            this.txt_mahdb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // dtp_ngaylap
            // 
            this.dtp_ngaylap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_ngaylap.CustomFormat = "dd/MM/yyyy ";
            this.dtp_ngaylap.Enabled = false;
            this.dtp_ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaylap.Location = new System.Drawing.Point(111, 86);
            this.dtp_ngaylap.Name = "dtp_ngaylap";
            this.dtp_ngaylap.Size = new System.Drawing.Size(200, 23);
            this.dtp_ngaylap.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày lập:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Danh sách sản phẩm:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.ckb_KH);
            this.groupBox1.Controls.Add(this.cbb_KH);
            this.groupBox1.Controls.Add(this.txt_sdtkh);
            this.groupBox1.Controls.Add(this.txt_tenkh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(395, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng";
            // 
            // ckb_KH
            // 
            this.ckb_KH.AutoSize = true;
            this.ckb_KH.Location = new System.Drawing.Point(14, 23);
            this.ckb_KH.Name = "ckb_KH";
            this.ckb_KH.Size = new System.Drawing.Size(138, 21);
            this.ckb_KH.TabIndex = 8;
            this.ckb_KH.Text = "Chọn khách hàng";
            this.ckb_KH.UseVisualStyleBackColor = true;
            this.ckb_KH.CheckedChanged += new System.EventHandler(this.ckb_KH_CheckedChanged);
            // 
            // cbb_KH
            // 
            this.cbb_KH.BackColor = System.Drawing.Color.White;
            this.cbb_KH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_KH.Enabled = false;
            this.cbb_KH.FormattingEnabled = true;
            this.cbb_KH.Location = new System.Drawing.Point(14, 55);
            this.cbb_KH.Name = "cbb_KH";
            this.cbb_KH.Size = new System.Drawing.Size(337, 25);
            this.cbb_KH.TabIndex = 7;
            this.cbb_KH.SelectedIndexChanged += new System.EventHandler(this.cbb_KH_SelectedIndexChanged);
            // 
            // txt_sdtkh
            // 
            this.txt_sdtkh.Location = new System.Drawing.Point(114, 137);
            this.txt_sdtkh.Name = "txt_sdtkh";
            this.txt_sdtkh.Size = new System.Drawing.Size(185, 23);
            this.txt_sdtkh.TabIndex = 5;
            this.txt_sdtkh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdtkh_KeyPress);
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(112, 99);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(239, 23);
            this.txt_tenkh.TabIndex = 4;
            this.txt_tenkh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tenkh_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Họ tên:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_tongtien);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 506);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 99);
            this.panel3.TabIndex = 2;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tongtien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtien.Location = new System.Drawing.Point(587, 13);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(188, 22);
            this.txt_tongtien.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(467, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tổng tiền:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_sanpham);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 235);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(775, 271);
            this.panel4.TabIndex = 3;
            // 
            // dgv_sanpham
            // 
            this.dgv_sanpham.AllowUserToAddRows = false;
            this.dgv_sanpham.AllowUserToDeleteRows = false;
            this.dgv_sanpham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_sanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sanpham.BackgroundColor = System.Drawing.Color.White;
            this.dgv_sanpham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(104)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sanpham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.dongia,
            this.soluong,
            this.thanhtien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(104)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_sanpham.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_sanpham.Location = new System.Drawing.Point(0, 0);
            this.dgv_sanpham.MultiSelect = false;
            this.dgv_sanpham.Name = "dgv_sanpham";
            this.dgv_sanpham.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(174)))), ((int)(((byte)(179)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sanpham.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_sanpham.RowHeadersWidth = 51;
            this.dgv_sanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sanpham.Size = new System.Drawing.Size(775, 271);
            this.dgv_sanpham.TabIndex = 0;
            this.dgv_sanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sanpham_CellContentClick);
            // 
            // masp
            // 
            this.masp.HeaderText = "Mã sản phẩm";
            this.masp.MinimumWidth = 6;
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            // 
            // tensp
            // 
            this.tensp.HeaderText = "Tên sản phẩm";
            this.tensp.MinimumWidth = 6;
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.MinimumWidth = 6;
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.MinimumWidth = 6;
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // fTaoDonHang
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
            this.Name = "fTaoDonHang";
            this.Text = "Tạo đơn hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anhsp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.Button butSua;
        private System.Windows.Forms.Button butThem;
        private System.Windows.Forms.TextBox txt_soluongmua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbb_sanpham;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb_dmsp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox ptb_anhsp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_ngaylap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mahdb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_sdtkh;
        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_sanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.TextBox txt_soluongcon;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton butPDF;
        private FontAwesome.Sharp.IconButton butNew;
        private FontAwesome.Sharp.IconButton butSave;
        private System.Windows.Forms.ComboBox cbb_KH;
        private System.Windows.Forms.CheckBox ckb_KH;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

namespace BTLLapTrinhWindows.GUI
{
    partial class fDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLoginMain = new System.Windows.Forms.Panel();
            this.butForgetPW = new System.Windows.Forms.Button();
            this.butLogin = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.butPass = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.butUser = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLoginMain.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 440);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(86, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Team 7 CNTT4_K13";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::BTLLapTrinhWindows.Properties.Resources.logoCuaHang2;
            this.pictureBox1.Location = new System.Drawing.Point(59, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(100, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Developed by";
            // 
            // panelLoginMain
            // 
            this.panelLoginMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
            this.panelLoginMain.Controls.Add(this.butForgetPW);
            this.panelLoginMain.Controls.Add(this.butLogin);
            this.panelLoginMain.Controls.Add(this.panel4);
            this.panelLoginMain.Controls.Add(this.panel3);
            this.panelLoginMain.Controls.Add(this.label3);
            this.panelLoginMain.Controls.Add(this.iconButton1);
            this.panelLoginMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoginMain.Location = new System.Drawing.Point(315, 0);
            this.panelLoginMain.Name = "panelLoginMain";
            this.panelLoginMain.Size = new System.Drawing.Size(490, 440);
            this.panelLoginMain.TabIndex = 6;
            this.panelLoginMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLoginMain_MouseDown);
            // 
            // butForgetPW
            // 
            this.butForgetPW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butForgetPW.FlatAppearance.BorderSize = 0;
            this.butForgetPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butForgetPW.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butForgetPW.ForeColor = System.Drawing.Color.White;
            this.butForgetPW.Location = new System.Drawing.Point(236, 339);
            this.butForgetPW.Name = "butForgetPW";
            this.butForgetPW.Size = new System.Drawing.Size(181, 43);
            this.butForgetPW.TabIndex = 5;
            this.butForgetPW.Text = "Forget password";
            this.butForgetPW.UseVisualStyleBackColor = true;
            this.butForgetPW.Click += new System.EventHandler(this.butForgetPW_Click);
            // 
            // butLogin
            // 
            this.butLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.butLogin.BackColor = System.Drawing.Color.White;
            this.butLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogin.Location = new System.Drawing.Point(84, 332);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(126, 43);
            this.butLogin.TabIndex = 4;
            this.butLogin.Text = "Login";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txt_pass);
            this.panel4.Controls.Add(this.butPass);
            this.panel4.Location = new System.Drawing.Point(83, 202);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(311, 43);
            this.panel4.TabIndex = 3;
            // 
            // txt_pass
            // 
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Location = new System.Drawing.Point(60, 10);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(209, 16);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // butPass
            // 
            this.butPass.Dock = System.Windows.Forms.DockStyle.Left;
            this.butPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
            this.butPass.FlatAppearance.BorderSize = 0;
            this.butPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPass.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.butPass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
            this.butPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butPass.IconSize = 40;
            this.butPass.Location = new System.Drawing.Point(0, 0);
            this.butPass.Name = "butPass";
            this.butPass.Size = new System.Drawing.Size(54, 41);
            this.butPass.TabIndex = 6;
            this.butPass.UseVisualStyleBackColor = true;
            this.butPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.butPass_MouseDown);
            this.butPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.butPass_MouseUp);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_user);
            this.panel3.Controls.Add(this.butUser);
            this.panel3.Location = new System.Drawing.Point(83, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 43);
            this.panel3.TabIndex = 2;
            // 
            // txt_user
            // 
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(60, 13);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(250, 16);
            this.txt_user.TabIndex = 0;
            // 
            // butUser
            // 
            this.butUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.butUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
            this.butUser.FlatAppearance.BorderSize = 0;
            this.butUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.butUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
            this.butUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butUser.IconSize = 40;
            this.butUser.Location = new System.Drawing.Point(0, 0);
            this.butUser.Name = "butUser";
            this.butUser.Size = new System.Drawing.Size(54, 41);
            this.butUser.TabIndex = 6;
            this.butUser.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Login with your account:";
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(444, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(43, 39);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // fDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 440);
            this.ControlBox = false;
            this.Controls.Add(this.panelLoginMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDangNhap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLoginMain.ResumeLayout(false);
            this.panelLoginMain.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLoginMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_pass;
        private FontAwesome.Sharp.IconButton butPass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_user;
        private FontAwesome.Sharp.IconButton butUser;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Button butForgetPW;
    }
}
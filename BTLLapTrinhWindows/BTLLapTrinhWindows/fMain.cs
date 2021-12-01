using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTLLapTrinhWindows.GUI;
using System.Runtime.InteropServices;
using BTLLapTrinhWindows.Proccessing;

namespace BTLLapTrinhWindows
{
    
    public partial class fMain : Form
    {
        public static Form fM;
        public static PictureBox ptbAnh;
        public static Label lbTenNV;
        public static Label lbMaNV;
        public static Label lbHello;
        public static IconButton btnnv;

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        public static Form currentChildForm;
        public static Panel panelDesktop;

        DBProccessing_TaiKhoan dataTK = new DBProccessing_TaiKhoan();
        DBProccessing_DangNhap dataDN = new DBProccessing_DangNhap();
        DBProccessing_Main dataMain = new DBProccessing_Main();
        public fMain()
        {
            fM = this;
            InitializeComponent();
            ptbAnh = ptb_anhNV;
            lbMaNV = lb_maNV;
            lbTenNV = lb_tenNV;
            lbHello = lbTitleChildForm;
            btnnv = btnNhanVien;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 59);
            pnlMenu.Controls.Add(leftBorderBtn);
            customizeDesign();

            panelDesktop = pnlDesktop;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(71, 188, 133);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(0, 166, 198);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(218, 164, 32);
            public static Color color8 = Color.FromArgb(244, 128, 114);
            public static Color color9 = Color.FromArgb(133, 182, 186);
            public static Color color10 = Color.FromArgb(26, 189, 157);
            public static Color color11 = Color.FromArgb(165, 180, 68);
            public static Color color12 = Color.FromArgb(234, 112, 98);
        }

        private void ActivateButton(object senderBtn, Color color, int y)
        {
            if(senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(46, 64, 87);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                lbTitleChildForm.ForeColor = color;
                lbText.ForeColor = color;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y + y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(38, 58, 83);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        //submenu
        private void customizeDesign()
        {
            pnlKHDT.Visible = false;
            pnlDonHang.Visible = false;
            pnlSanPham.Visible = false;
            pnlBaoCao.Visible = false;
        }

        private void hideSubmenu()
        {
            if (pnlSanPham.Visible == true)
                pnlSanPham.Visible = false;
            if (pnlDonHang.Visible == true)
                pnlDonHang.Visible = false;
            if (pnlKHDT.Visible == true)
                pnlKHDT.Visible = false;
            if (pnlBaoCao.Visible == true)
                pnlBaoCao.Visible = false;
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        //end submenu

        //open child Form
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitleChildForm.Text = childForm.Text;
            lbText.Visible = false;
        }
        //end open child form
        //reset
        private void Reset()
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            lbTitleChildForm.Text = "Xin Chào " + lbTenNV.Text;
            lbText.Visible = true;
        }
        private void fMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            Reset();
            showSubmenu(pnlDonHang);
            ActivateButton(sender, RGBColors.color1, 0);
            dataDN.GetNhanVien(lbMaNV.Text);
            
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            Reset();
            showSubmenu(pnlSanPham);
            ActivateButton(sender, RGBColors.color2, 0);
        }

        private void btnKHDT_Click(object sender, EventArgs e)
        {
            Reset();
            showSubmenu(pnlKHDT);
            ActivateButton(sender, RGBColors.color3, 0);

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            Reset();
            showSubmenu(pnlBaoCao);
            ActivateButton(sender, RGBColors.color1, 0);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            ActivateButton(sender, RGBColors.color5, 0);
            OpenChildForm(new fTaiKhoan());
            dataTK.GetNhanVien(lbMaNV.Text);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            ActivateButton(sender, RGBColors.color6, 0);
            OpenChildForm(new fNhanVien());
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            ActivateButton(sender, RGBColors.color7, 0);
            OpenChildForm(new fTroGiup());
        }

        private void btnDSDonHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8, 144 + 59);
            OpenChildForm(new fDanhSachDonHang());
        }

        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color9, 144 + 59);
            OpenChildForm(new fTaoDonHang());
        }

        private void btnDMSanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color10,144 + 59 + 59);
            OpenChildForm(new fDanhMucSanPham());
            if (dataMain.Check_ChucVu(lbMaNV.Text))
            {
                dataMain.Visible_DanhMucSanPham_NV();
            }
        }

        private void btnDSSanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color11, 144 + 59 + 59);
            OpenChildForm(new fDanhSachSanPham());
            if (dataMain.Check_ChucVu(lbMaNV.Text))
            {
                dataMain.Visible_DanhSachSanPham_NV();
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color12,144 + 59 + 59);
            OpenChildForm(new fNhapHang());
        }
        private void btnDSNhapHang_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1, 144 + 59 + 59);
            OpenChildForm(new fDanhSachHDNhap());
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2, 144 + 59 + 59 + 59);
            OpenChildForm(new FKhachHang());
            if (dataMain.Check_ChucVu(lbMaNV.Text))
            {
                dataMain.Visible_KhachHang_NV();
            }
        }

        private void btnNhacc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3,144 + 59 + 59 + 59);
            OpenChildForm(new fNhaCungCap());
            if (dataMain.Check_ChucVu(lbMaNV.Text))
            {
                dataMain.Visible_NhaCungCap_NV();
            }
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            fDangNhap.tt_ma.Clear();
            fDangNhap.tt_pass.Clear();
            fDangNhap.fDN.Show();
            fMain.fM.Hide();
        }
        //drag from
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4, 144 + 59 + 59 + 59+59);
            OpenChildForm(new fBaoCaoBanHang());
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5, 144+59+59+59+59);
            OpenChildForm(new fTonKho());
        }

    }
} 

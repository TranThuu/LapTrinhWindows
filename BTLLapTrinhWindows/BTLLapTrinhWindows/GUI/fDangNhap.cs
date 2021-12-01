using BTLLapTrinhWindows.Proccessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLLapTrinhWindows.GUI
{
    public partial class fDangNhap : Form
    {
        public static Form fDN;
        public static TextBox tt_ma;
        public static TextBox tt_pass;
        DBProccessing_DangNhap datapro = new DBProccessing_DangNhap();
        public fDangNhap()
        {
            InitializeComponent();
            fDN = this;
            tt_ma = txt_user;
            tt_pass = txt_pass;
            txt_user.Focus();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //drag from
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelLoginMain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_user.Text) || string.IsNullOrWhiteSpace(txt_pass.Text))
            {
                MessageBox.Show("Không được để trống", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(datapro.GetTinhTrangNV(txt_user.Text).Rows.Count == 0)
            {
                MessageBox.Show("Tài khoản đã bị khóa!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_user.Clear();
                txt_pass.Clear();
                return;                
            }
            if (datapro.IsCheckAccount(txt_user.Text, txt_pass.Text))
            {
                fMain f = new fMain();
                datapro.GetNhanVien(txt_user.Text);
                f.Show();
                fDangNhap.fDN.Hide();
            }
            else MessageBox.Show("Mã nhân viên hoặc mật khẩu sai!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void butPass_MouseDown(object sender, MouseEventArgs e)
        {
            txt_pass.UseSystemPasswordChar = false;
        }

        private void butPass_MouseUp(object sender, MouseEventArgs e)
        {
            txt_pass.UseSystemPasswordChar = true;
        }

        private void butForgetPW_Click(object sender, EventArgs e)
        {
            fDangNhap.fDN.Hide();
            fForgetPassWord f = new fForgetPassWord();
            f.Show();
        }
    }
}

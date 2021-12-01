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
    public partial class fResetPassWord : Form
    {
        public static Form fRSP;
        DBProccessing_ResetPassword datapro = new DBProccessing_ResetPassword();
        public fResetPassWord()
        {
            InitializeComponent();
            fRSP = this;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void iconButton1_Click(object sender, EventArgs e)
        {
            fResetPassWord.fRSP.Close();
            fMain.fM.Show();
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        void ClearText()
        {
            txt_oldpass.Clear();
            txt_newpass.Clear();
            txt_confirmpass.Clear();
        }
        private void butSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_oldpass.Text)|| string.IsNullOrWhiteSpace(txt_newpass.Text)
                || string.IsNullOrWhiteSpace(txt_confirmpass.Text))
            {
                MessageBox.Show("Cannot be left blank!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!datapro.CheckOldPass(fMain.lbMaNV.Text, txt_oldpass.Text))
            {
                MessageBox.Show("Old password is false!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!datapro.CheckNewPass(txt_newpass.Text, txt_confirmpass.Text))
            {
                MessageBox.Show("New password and Confirm password are not the same.!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            datapro.SavePass(fMain.lbMaNV.Text, txt_newpass.Text);
            ClearText();
            iconButton1_Click(sender, e);
        }
    }
}

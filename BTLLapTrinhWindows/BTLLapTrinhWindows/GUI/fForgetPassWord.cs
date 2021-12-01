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
    public partial class fForgetPassWord : Form
    {
        DBProccessing_ForgetPassword datapro = new DBProccessing_ForgetPassword();
        public fForgetPassWord()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            fDangNhap.fDN.Show();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void butConfirm_Click(object sender, EventArgs e)
        {
            if (datapro.CheckTaiKhoan(txt_manv.Text, txt_tennv.Text, txt_sdt.Text, dtp_ngaysinh.Value))
            {
                if (!datapro.checkTinhTrang(txt_manv.Text))
                {
                    MessageBox.Show("Tài khoản đã bị khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_manv.Clear();
                    txt_sdt.Clear();
                    txt_tennv.Clear();
                    dtp_ngaysinh.Value = DateTime.Today.Date;
                    return;
                }
                Random r = new Random();
                int mk = r.Next(100000, 999999);
                datapro.UpdateNhanVien(txt_manv.Text, mk.ToString());
                string s = "Mật khẩu mới của bạn là " + mk.ToString();
                MessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_manv.Clear();
                txt_sdt.Clear();
                txt_tennv.Clear();
                dtp_ngaysinh.Value = DateTime.Today.Date;
            }
            else
            {
                MessageBox.Show("Thông tin không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_tennv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}

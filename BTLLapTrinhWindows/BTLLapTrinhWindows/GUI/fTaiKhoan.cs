using BTLLapTrinhWindows.Proccessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLLapTrinhWindows.GUI
{
    public partial class fTaiKhoan : Form
    {
        public static TextBox tt_ma;
        public static TextBox tt_ten;
        public static TextBox tt_chucvu;
        public static TextBox tt_sdt;
        public static CheckBox cb_gioiT;
        public static DateTimePicker dp_ngayS;
        public static PictureBox pb_anh;

        DBProccessing_TaiKhoan dataTK = new DBProccessing_TaiKhoan();

        public fTaiKhoan()
        {
            InitializeComponent();
            tt_ma = txt_ma;
            tt_ten = txt_hoten;
            tt_chucvu = txt_chucvu;
            tt_sdt = txt_sdt;
            cb_gioiT = ckb_nu;
            dp_ngayS = dtp_ngaysinh;
            pb_anh = ptb_anh;
        }
        string fileName = "";
        private void butChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image file(*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // display image to picturebox
                    ptb_anh.Image = Image.FromFile(ofd.FileName);
                    fileName = ofd.FileName;
                }
            }
        }

        private void butLuu_Click(object sender, EventArgs e)
        {
            bool gt = false;
            if (ckb_nu.Checked)
                gt = true;
            if(string.IsNullOrWhiteSpace(txt_hoten.Text)|| string.IsNullOrWhiteSpace(txt_sdt.Text))
            {
                MessageBox.Show("Không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dataTK.CheckTaiKhoan(txt_ma.Text,txt_sdt.Text))
            {
                MessageBox.Show("Số điện thoại này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sdt.Focus();
                return;                
            }
            dataTK.LuuThayDoi(txt_ma.Text, txt_hoten.Text, txt_sdt.Text,gt, dtp_ngaysinh.Value, ptb_anh.Image,fileName);
            MessageBox.Show("Đã lưu những thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            fMain.ptbAnh.Image = ptb_anh.Image;
            fMain.lbTenNV.Text = txt_hoten.Text;
        }

        private void fTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void butDoiMatKhau_Click(object sender, EventArgs e)
        {
            fResetPassWord f = new fResetPassWord();
            f.Show();
            fMain.fM.Hide();
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_hoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

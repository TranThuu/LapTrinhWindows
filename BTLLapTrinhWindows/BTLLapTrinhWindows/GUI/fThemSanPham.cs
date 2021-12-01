using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BTLLapTrinhWindows.Proccessing;
using System.Runtime.InteropServices;

namespace BTLLapTrinhWindows.GUI
{
    public partial class fThemSanPham : Form
    {
        DBProccessing_DanhSachSanPham dt= new DBProccessing_DanhSachSanPham();
        string fileName = "";
        string maSP;
        public fThemSanPham()
        {
            InitializeComponent();
        }

        private void fThemSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                TaoMaSP();
                cbbDanhMuc.DataSource = dt.showDanhMuc();
                cbbDanhMuc.DisplayMember = "TenDM";
                cbbDanhMuc.ValueMember = "MaDM";
                ptbAnhSP.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void TaoMaSP()
        {
            maSP = dt.MaCuoiBang("SanPham");
            int so = int.Parse(maSP.Substring(2)) + 1;
            if (so < 10)
                maSP = "SP0000000" + so;
            else if (so >= 10 && so < 100)
                maSP = "SP000000" + so;
            else if (so >= 100 && so < 1000)
                maSP = "SP00000" + so;
            else if (so >= 1000 && so < 10000)
                maSP = "SP0000" + so;
            else if (so >= 10000 && so < 100000)
                maSP = "SP000" + so;
            else if (so >= 100000 && so < 1000000)
                maSP = "SP00" + so;
            else if (so>= 10000000)
                maSP = "SP0" + so;
            else
                maSP = "SP" + so;
            txtMaSP.Text = maSP;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ValiData())
            {
                try
                {
                    bool tontai = dt.kiemTraTonTai(txtTenSP.Text,txtNhaSX.Text,int.Parse(txtGiaBan.Text), cbbDanhMuc.SelectedValue.ToString());
                    if (tontai == true)
                    {
                        MessageBox.Show("Sản phẩm này đã tồn tại. Không thể thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        dt.themSP(txtMaSP.Text, txtTenSP.Text, true, txtNhaSX.Text, txtMoTa.Text, txtDonVi.Text, ptbAnhSP.Image, cbbDanhMuc.SelectedValue.ToString(), int.Parse(txtGiaBan.Text));
                        DialogResult kq = MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (kq == DialogResult.OK)
                        {
                            Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("duplicate key"))
                    {
                        MessageBox.Show("Trùng mã sản phẩm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image file(*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // hiển thị ảnh lên picturebox
                    ptbAnhSP.Image = Image.FromFile(ofd.FileName);
                    fileName = ofd.FileName;
                }
            }
        }
        private bool ValiData()
        {
            if(txtMaSP.Text == "")
            {
                MessageBox.Show("Mã sản phẩm không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSP.Focus();
                return false;
            }
            if (txtTenSP.Text == "")
            {
                MessageBox.Show("Tên sản phẩm không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSP.Focus();
                return false;
            }
            if (txtNhaSX.Text == "")
            {
                MessageBox.Show("Nhà sản xuất không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhaSX.Focus();
                return false;
            }
            if (txtDonVi.Text == "")
            {
                MessageBox.Show("Đơn vị tính không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonVi.Focus();
                return false;
            }
            if (txtGiaBan.Text == "")
            {
                MessageBox.Show("Giá bán không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiaBan.Focus();
                return false;
            }
            else
            {
                try
                {
                    int.Parse(txtGiaBan.Text);
                    if (int.Parse(txtGiaBan.Text) <= 0)
                    {
                        MessageBox.Show("Giá phải lớn hơn 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtGiaBan.Focus();
                        return false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Bạn phải nhập vào một số nguyên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGiaBan.Focus();
                    return false;
                }
            }
            return true;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

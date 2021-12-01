using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTLLapTrinhWindows.Proccessing;
using System.IO;
using System.Runtime.InteropServices;
namespace BTLLapTrinhWindows.GUI
{
    public partial class fSuaSanPham : Form
    {
        DBProccessing_DanhSachSanPham data = new DBProccessing_DanhSachSanPham();
        //khai báo delegate
        public delegate void SendData(string maSP);
        public SendData Sender;
        string fileName = "";
        string danhMuc;
        fDanhSachSanPham frmDSSP = (fDanhSachSanPham)Application.OpenForms["fDanhSachSanPham"];
        public fSuaSanPham()
        {
            InitializeComponent();
            //tạo con trỏ tới hàm getData
            Sender = new SendData(GetData);
        }
        //lấy dl từ fDanhSachSanPham
        private void GetData(string maSP)
        {
            try
            {
                DataTable dt = data.getSPDMById(maSP);
                //MessageBox.Show(ma);
                ptbAnhSP.SizeMode = PictureBoxSizeMode.StretchImage;
                if (dt.Rows.Count>=0)
                {
                    txtMaSP.Enabled = false;
                    txtMaSP.Text = dt.Rows[0]["MaSanPham"].ToString();
                    txtTenSP.Text = dt.Rows[0]["TenSP"].ToString();
                    txtNhaSX.Text = dt.Rows[0]["NhaSX"].ToString();
                    txtMoTa.Text = dt.Rows[0]["MoTa"].ToString();
                    txtDonVi.Text = dt.Rows[0]["DonViTinh"].ToString();
                    txtGiaBan.Text = dt.Rows[0]["GiaBan"].ToString();
                    ptbAnhSP.Image = ConvertByArrayToImage((byte[])dt.Rows[0]["AnhSP"]);
                    lblDMCu.Text = dt.Rows[0]["TenDM"].ToString();
                    danhMuc = dt.Rows[0]["MaDM"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }
        public Image ConvertByArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void fSuaSanPham_Load(object sender, EventArgs e)
        {
            cbbDanhMuc.DataSource = data.showDanhMuc();
            cbbDanhMuc.DisplayMember = "TenDM";
            cbbDanhMuc.ValueMember = "MaDM";
            cbbDanhMuc.SelectedValue = danhMuc;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValiData())
            {
                try
                {
                    bool tinhTrang;
                    if(rdoConBan.Checked)
                    {
                        tinhTrang = true;
                    }
                    else
                    {
                        tinhTrang = false;
                    }
                    //String ma, String tenSP, String nsx, String mt, String dvt, int gia, String maDM , Image anhSP
                    DialogResult confirm = MessageBox.Show("Bạn có chắc chắn sửa thông tin sản phẩm", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        data.suaSanPham(txtMaSP.Text, txtTenSP.Text, txtNhaSX.Text, txtMoTa.Text, txtDonVi.Text, ptbAnhSP.Image, cbbDanhMuc.SelectedValue.ToString(), int.Parse(txtGiaBan.Text), tinhTrang);
                        DialogResult kq = MessageBox.Show("Sửa thông tin sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (kq == DialogResult.OK)
                        {
                            Close();
                            frmDSSP.refreshData();
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
                    // display image to picturebox
                    ptbAnhSP.Image = Image.FromFile(ofd.FileName);
                    fileName = ofd.FileName;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool ValiData()
        {
            if (txtMaSP.Text == "")
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
            if (ptbAnhSP.Image == null)
            {
                MessageBox.Show("Bạn hãy chọn ảnh sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

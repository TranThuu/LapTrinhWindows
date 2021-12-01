using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTLLapTrinhWindows.Proccessing;
namespace BTLLapTrinhWindows.GUI
{
    public partial class fNhanVien : Form
    {
        DBProccessing_NhanVien dbnv = new DBProccessing_NhanVien();
        string fileName = "";
        public fNhanVien()
        {
            InitializeComponent();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaNV.Focus();
            txtMaNV.Enabled = false;
            cbb_chucvu.SelectedItem = cbb_chucvu.Items[1];
        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                pbAnh.SizeMode = PictureBoxSizeMode.StretchImage;
                string nl = Environment.NewLine;
                DataTable dt = dbnv.showNhanVien();
                txtMaNV.Text = manv(dbnv.showall().Rows.Count);
                foreach (DataRow row in dt.Rows)
                {
                    this.dgvNhanVien.Rows.Add(row["AnhNV"], row["TenNV"].ToString() + nl + "Chức vụ: " + row["ChucVu"].ToString());
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        String manv(int count)
        {
            if ((count+1) < 10) return "NV00" + (count+1);
            else if ((count+1) < 100) return "NV0" + (count+1);
            else return "Nv" + (count+1);
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCheckMK.Visible = false; txtMK.Visible = false; txtSDT.Enabled = false;txtMaNV.Enabled = false; txtTen.Enabled = false;dtpNgaySinh.Enabled = false;rdNu.Enabled = false; rdNam.Enabled = false;
                lbMK.Visible = false;lbReMK.Visible = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true; btnXoa.Enabled = true;
                btnTaiLen.Visible = false;
                string nl = Environment.NewLine;
                DataTable dt = dbnv.showNhanVien();
                int index = e.RowIndex;
                
                txtMaNV.Text = dt.Rows[index]["MaNV"].ToString();
                if (dt.Rows[index]["ChucVu"].ToString() == "Admin")
                    cbb_chucvu.SelectedItem = cbb_chucvu.Items[0];
                else cbb_chucvu.SelectedItem = cbb_chucvu.Items[1];
                txtTen.Text = dt.Rows[index]["TenNV"].ToString();
                txtSDT.Text = dt.Rows[index]["SDT"].ToString();
                DateTime ngaySinh = (DateTime)dt.Rows[index]["NgaySinh"];
                dtpNgaySinh.Value = ngaySinh;
                if (dt.Rows[index]["GioiTinh"].ToString() == "True")
                    rdNu.Checked = true;

                pbAnh.Image = ConvertByArrayToImage((byte[])dt.Rows[index]["AnhNV"]);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public Image ConvertByArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaNV.Focus();
            txtCheckMK.Clear(); txtCheckMK.Visible = true;
            cbb_chucvu.SelectedItem = cbb_chucvu.Items[1];
            txtMK.Clear(); txtMK.Visible = true;
            txtSDT.Clear(); txtSDT.Enabled = true;           
            txtTen.Clear(); txtTen.Enabled = true; 
            rdNam.Checked = true; rdNam.Enabled = true;
            rdNu.Enabled = true;
            pbAnh.Image = pbAnh.BackgroundImage;
            error1.Visible = false; error2.Visible = false;
            btnSua.Enabled = false; btnXoa.Enabled = false;
            lbMK.Visible = true;
            lbReMK.Visible = true;
            btnThem.Enabled = true;
            btnTaiLen.Visible = true;
            dtpNgaySinh.Enabled = true;
            dgvNhanVien.Rows.Clear();
            fNhanVien_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                error1.Visible = false;
                error2.Visible = false;
                int gt = 0;
                if (rdNu.Checked) gt = 1;
                if (txtCheckMK.Text == "" || cbb_chucvu.Text == "" || txtMaNV.Text == "" || txtMK.Text == "" || txtSDT.Text == "" || txtTen.Text == "")
                    throw new Exception("Bạn phải nhập đủ các trường!");
                if (pbAnh.Image == null)
                    throw new Exception("Hãy nhập ảnh");
                if (txtSDT.Text.Length != 10)
                    throw new Exception("Số điện thoại phải đủ 10 số !");
                if(txtMK.Text != txtCheckMK.Text)
                {
                    error1.Visible = true;
                    error2.Visible = true;
                    error1.Text = "Mật khẩu không trùng khớp!";
                    error2.Text = error1.Text;
                    throw new Exception("Mật khẩu không trùng khớp!");
                }
                dbnv.themNV(txtMaNV.Text, txtTen.Text, txtSDT.Text, cbb_chucvu.Text, txtMK.Text,gt,dtpNgaySinh.Value, pbAnh.Image);
                dgvNhanVien.Rows.Clear();
                btnClear_Click(sender, e);
                MessageBox.Show("Thêm thành công nhân viên mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnTaiLen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image file(*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // display image to picturebox
                    pbAnh.Image = Image.FromFile(ofd.FileName);
                    fileName = ofd.FileName;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                error1.Visible = false;error2.Visible = false;
                int gt = 0;
                if (rdNu.Checked) gt = 1;
                if (cbb_chucvu.Text == "")
                    throw new Exception("Bạn phải chọn \"Chức vụ\"!");
                    
                dbnv.suaNV(txtMaNV.Text,cbb_chucvu.Text);
                btnClear_Click(sender, e);
                MessageBox.Show("Sửa thành công nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaNV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtTen.Focus();
        }

        private void txtTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtSDT.Focus();
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cbb_chucvu.Focus();
        }

        private void txtMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCheckMK.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr= MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên " + txtTen.Text + " không??", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(dr == DialogResult.OK)
                {
                    dbnv.XoaNV(txtMaNV.Text);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear_Click(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

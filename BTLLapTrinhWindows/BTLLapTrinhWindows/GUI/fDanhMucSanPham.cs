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
using FontAwesome.Sharp;

namespace BTLLapTrinhWindows.GUI
{
    public partial class fDanhMucSanPham : Form
    {
        DBProccessing_DanhMucSanPham data = new DBProccessing_DanhMucSanPham();
        public static IconButton button_sua;
        public static IconButton button_xoa;
        int soMaDMCuoi;
        bool LaNV;
        public fDanhMucSanPham()
        {
            InitializeComponent();
            LaNV = data.IsNhanVien(fMain.lbMaNV.Text);
            DataTable t = data.showAllDanhMuc();
            string macuoi = t.Rows[t.Rows.Count - 1][0].ToString();
            soMaDMCuoi = int.Parse(macuoi.Substring(2));
            button_sua = icb_sua;
            button_xoa = icb_loc;
            if (LaNV)
                HeaderNhanVien();
            else HeaderAdmin();
        }
        void HeaderNhanVien()
        {
            dgvDanhMuc.ColumnCount = 2;
            dgvDanhMuc.Columns[0].HeaderText = "Mã danh mục";
            dgvDanhMuc.Columns[0].DataPropertyName = "MaDM";
            dgvDanhMuc.Columns[1].HeaderText = "Tên danh mục";
            dgvDanhMuc.Columns[1].DataPropertyName = "TenDM";
            lb_tinhtrang.Visible = false;
            ckb_tinhtrang.Visible = false;
            pl_ttrang.Visible = false;
            
        }
        void HeaderAdmin()
        {
            dgvDanhMuc.ColumnCount = 2;
            dgvDanhMuc.Columns[0].HeaderText = "Mã danh mục";
            dgvDanhMuc.Columns[0].DataPropertyName = "MaDM";
            dgvDanhMuc.Columns[1].HeaderText = "Tên danh mục";
            dgvDanhMuc.Columns[1].DataPropertyName = "TenDM";
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();            
            dgvDanhMuc.Columns.Add(checkColumn);
            dgvDanhMuc.Columns[2].HeaderText = "Tình trạng";
            dgvDanhMuc.Columns[2].DataPropertyName = "TinhTrang";
            lb_tinhtrang.Visible = true;
            ckb_tinhtrang.Visible = true;
            pl_ttrang.Visible = true;
        }
        private void dgvStyle()
        {
            dgvDanhMuc.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(80, 124, 209);
            dgvDanhMuc.RowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
            dgvDanhMuc.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void fDanhMucSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable tblDM = new DataTable();
                if (LaNV)
                {
                    tblDM = data.showDanhMuc_NV();
                }
                else
                {
                    tblDM = data.showDanhMuc_Admin();
                }                    
                dgvDanhMuc.DataSource = tblDM;
                dgvStyle();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            if(d>=0)
            {
                txtMaDM.Text = dgvDanhMuc.Rows[d].Cells[0].Value.ToString();
                txtTenDM.Text = dgvDanhMuc.Rows[d].Cells[1].Value.ToString();
                if (!LaNV)
                {
                    if (dgvDanhMuc.Rows[d].Cells[2].Value.Equals(true))
                        ckb_tinhtrang.Checked = true;
                    else ckb_tinhtrang.Checked = false;
                }
            }    
        }
        string SetMaDM(int soMaDM)
        {
            string ma = "";
            if (soMaDM > 0 && soMaDM < 10) ma = "DM00" + (soMaDM).ToString();
            else if (soMaDM >= 10 && soMaDM < 100) ma = "DM0" + (soMaDM).ToString();
            else ma = "DM" + (soMaDM + 1).ToString();
            return ma;
        }
        private void ClearData()
        {
            txtMaDM.Text = "";
            txtTenDM.Text = "";
            lblMaDMError.Text = "";
        } 
        private void icb_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (data.CheckTenDM_Them(txtTenDM.Text))
                    throw new Exception("Tên danh mục này đã tồn tại !");
                soMaDMCuoi++;
                if (LaNV)
                    data.InsertDM_NV(SetMaDM(soMaDMCuoi), txtTenDM.Text);
                else data.InsertDM_Admin(SetMaDM(soMaDMCuoi), txtTenDM.Text, ckb_tinhtrang.Checked == true ? true : false);
                fDanhMucSanPham_Load(sender, e);
                ClearData();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("duplicate key"))
                {
                    MessageBox.Show("Kiểm tra trùng mã danh mục", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void icb_reload_Click(object sender, EventArgs e)
        {
            txtMaDM.Text = "";
            txtTenDM.Text = "";
            if (!LaNV)
            {
                ckb_tinhtrang.Checked = true;
            }
            fDanhMucSanPham_Load(sender, e);
        }

        private void icb_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (data.CheckTenDM_Sua(txtMaDM.Text,txtTenDM.Text))
                    throw new Exception("Tên danh mục này đã tồn tại !");
                DialogResult kq = MessageBox.Show("Bạn có chắc chắn sửa thông tin danh mục", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (kq == DialogResult.Yes)
                {
                    if (LaNV)
                        data.UpdateDM_NV(txtMaDM.Text, txtTenDM.Text);
                    else data.UpdateDM_Admin(txtMaDM.Text, txtTenDM.Text, ckb_tinhtrang.Checked == true ? true : false);
                    MessageBox.Show("Sửa danh mục thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fDanhMucSanPham_Load(sender, e);
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void icb_loc_Click(object sender, EventArgs e)
        {
            DataTable t = data.Loc_TinhTrang(ckb_tinhtrang.Checked == true ? true : false);
            dgvDanhMuc.DataSource = t;
        }
    }
}

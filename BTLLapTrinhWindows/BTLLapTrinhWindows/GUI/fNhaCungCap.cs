using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BTLLapTrinhWindows.Proccessing;
using ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat;
using FontAwesome.Sharp;

namespace BTLLapTrinhWindows.GUI
{
    public partial class fNhaCungCap : Form
    {
        public static IconButton button_sua;
        public static IconButton button_xoa;
        string maNCC;
        public fNhaCungCap()
        {
            InitializeComponent();
            button_sua = icbtn_sua;
            button_xoa = icbtn_xoa;
            DataTable t = data.GetAllNCC_1();
            if (t.Rows.Count == 0)
                maNCC = "NCC00";
            else
                maNCC = t.Rows[t.Rows.Count - 1][0].ToString();
        }
        DBProccessing_NhaCungCap data = new DBProccessing_NhaCungCap();
        private void fNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNCC.DataSource = data.GetAllNCC();
        }
        void MaTuTang()
        {
            int so = int.Parse(maNCC.Substring(3));
            if (so > 0 && so < 10)
                maNCC = "NCC0" + (so + 1).ToString();
            else maNCC = "NCC" + (so + 1).ToString();
        }
        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaNCC.Enabled = false;
                txtMaNCC.Text = dgvNCC.Rows[row].Cells[0].Value.ToString();
                txtTenNCC.Text = dgvNCC.Rows[row].Cells[1].Value.ToString();
                txtSDT.Text = dgvNCC.Rows[row].Cells[2].Value.ToString();
                txtDiaChi.Text = dgvNCC.Rows[row].Cells[3].Value.ToString();
            }
        }

        private void icbtn_them_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                if (txtSDT.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại có 10 số!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSDT.Clear();
                    txtSDT.Focus();
                    return;
                }
            }
            try
            {
                
                string tenNCC = txtTenNCC.Text;
                string sdt = txtSDT.Text;
                string diaChi = txtDiaChi.Text;
                if (String.IsNullOrWhiteSpace(tenNCC)) throw new Exception("Bạn chưa nhập tên NCC");
                if (String.IsNullOrWhiteSpace(sdt)) throw new Exception("Bạn chưa nhập SĐT");
                if (String.IsNullOrWhiteSpace(diaChi)) throw new Exception("Bạn chưa nhập địa chỉ");
                foreach (char c in sdt)
                {
                    if (char.IsLetter(c)) throw new Exception("Số điện thoại sai cú pháp");
                }
                if (data.CheckRowThem(txtTenNCC.Text, txtSDT.Text))
                    throw new Exception("Nhà cung cấp này đã tồn tại!");
                MaTuTang();
                data.InsertNewNCC(maNCC, tenNCC, sdt, diaChi);
                fNhaCungCap_Load(sender, e);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("duplicate key"))
                {
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void icbtn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtMaNCC.Text;
                string tenNCC = txtTenNCC.Text;
                string sdt = txtSDT.Text;
                string diaChi = txtDiaChi.Text;
                if (String.IsNullOrWhiteSpace(id)) throw new Exception("Bạn chưa nhập mã NCC");
                if (String.IsNullOrWhiteSpace(tenNCC)) throw new Exception("Bạn chưa nhập tên NCC");
                if (String.IsNullOrWhiteSpace(sdt)) throw new Exception("Bạn chưa nhập SĐT");
                foreach (char c in sdt)
                {
                    if (char.IsLetter(c)) throw new Exception("Số điện thoại sai cú pháp");
                }
                if (data.CheckRowSua(txtMaNCC.Text, txtTenNCC.Text, txtSDT.Text,txtDiaChi.Text))
                {
                    throw new Exception("Thông tin nhà cung cấp bị trùng !");
                }
                data.EditNCCById(id, tenNCC, sdt, diaChi);

                fNhaCungCap_Load(sender, e);
                icbtn_reload_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void icbtn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtMaNCC.Text;
                if(MessageBox.Show("Bạn chắc chắn xóa ?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    data.DeleteNCCByID(id);
                    fNhaCungCap_Load(sender, e);
                    icbtn_reload_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void icbtn_export_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application xlAppToUpload = new Microsoft.Office.Interop.Excel.Application();
                xlAppToUpload.Workbooks.Add();

                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheetToUpload = default(Microsoft.Office.Interop.Excel.Worksheet);
                xlWorkSheetToUpload = xlAppToUpload.Sheets["Sheet1"];
                int iRowCnt = 0;
                DataTable dt = (DataTable)(dgvNCC.DataSource);
                //setting
                xlAppToUpload.Visible = true;

                if (dt.Rows.Count > 0)
                {
                    iRowCnt = 7;

                    // style header
                    xlWorkSheetToUpload.Cells[2, 4].value = "THÔNG TIN NHÀ CUNG CẤP";
                    xlWorkSheetToUpload.Cells[2, 4].FONT.NAME = "Calibri";
                    xlWorkSheetToUpload.Cells[2, 4].Font.Bold = true;
                    xlWorkSheetToUpload.Cells[2, 4].Font.Size = 20;
                    xlWorkSheetToUpload.get_Range("D2", "H2").Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    xlWorkSheetToUpload.Cells[3, 5].value = "Ngày: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");

                    // merge header
                    xlWorkSheetToUpload.Range["D2:H2"].MergeCells = true;
                    xlWorkSheetToUpload.Range["D3:H3"].MergeCells = true;

                    // show collum tittle
                    xlWorkSheetToUpload.Cells[iRowCnt - 1, 4].value = "Mã NCC";
                    xlWorkSheetToUpload.Cells[iRowCnt - 1, 5].value = "Tên NCC";
                    xlWorkSheetToUpload.Cells[iRowCnt - 1, 6].value = "Số Điện Thoại";
                    xlWorkSheetToUpload.Cells[iRowCnt - 1, 7].value = "Địa Chỉ";

                    // import data
                    for (var i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        xlWorkSheetToUpload.Cells[iRowCnt, 4].value = dt.Rows[i]["MaNhaCC"];
                        xlWorkSheetToUpload.Cells[iRowCnt, 5].value = dt.Rows[i]["TenNCC"];
                        xlWorkSheetToUpload.Cells[iRowCnt, 6].value = dt.Rows[i]["SDT"];
                        xlWorkSheetToUpload.Cells[iRowCnt, 7].value = dt.Rows[i]["DiaChi"];

                        iRowCnt = iRowCnt + 1;
                    }
                    // format excel
                    xlAppToUpload.ActiveCell.Worksheet.Cells[7, 4].AutoFormat(ExcelAutoFormat.xlRangeAutoFormatList2);
                    xlAppToUpload = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void icbtn_reload_Click(object sender, EventArgs e)
        {
            txtDiaChi.Clear();
            txtMaNCC.Clear();
            txtSDT.Clear();
            txtTenNCC.Clear();
        }
    }
}

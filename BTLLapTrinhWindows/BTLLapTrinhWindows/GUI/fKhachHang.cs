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
    public partial class FKhachHang : Form
    {
        public static IconButton button_sua;
        public static IconButton button_xoa;
        string makh;
        public FKhachHang()
        {
            InitializeComponent();
            button_sua = icbtn_sua;
            button_xoa = icbtn_xoa;
            DataTable t = khachHang.GetAllKhachHang();
            makh = t.Rows[t.Rows.Count - 1][0].ToString();
        }

        DBProccessing_KhachHang khachHang = new DBProccessing_KhachHang();

        private void IdIncrease()
        {
            int so = int.Parse(makh.Substring(2));
            if (so > 0 && so < 10)
                makh = "KH00" + (so + 1).ToString();
            else if (so >= 10 && so < 100)
                makh = "KH0" + (so + 1).ToString();
            else if (so >= 100)
                makh = "KH" + (so + 1).ToString();
        }

        private void fKhachHang_Load(object sender, EventArgs e)
        {
            DataTable table = khachHang.GetAllKhachHang1();
            dgvKhachHang.DataSource = table;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaKhach.Enabled = false;
                txtMaKhach.Text = dgvKhachHang.Rows[row].Cells[0].Value.ToString();
                txtTenKhach.Text = dgvKhachHang.Rows[row].Cells[1].Value.ToString();
                txtSDT.Text = dgvKhachHang.Rows[row].Cells[2].Value.ToString();
            }
        }

        private void icbtn_sua_Click(object sender, EventArgs e)
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
                string tenKhach = txtTenKhach.Text;
                string sdt = txtSDT.Text;
                if (String.IsNullOrWhiteSpace(tenKhach)) throw new Exception("Bạn chưa nhập tên khách");
                if (String.IsNullOrWhiteSpace(sdt)) throw new Exception("Bạn chưa nhập số điện thoại khách hàng");
                foreach (char c in tenKhach)
                {
                    if (Char.IsDigit(c)) throw new Exception("Tên khách hàng không đúng định dạng!");
                }
                foreach (char c in sdt)
                {
                    if (Char.IsLetter(c)) throw new Exception("Số điện thoại không đúng định dạng!");
                }

                khachHang.EditKhachHangById(txtMaKhach.Text, tenKhach, sdt);
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
                string id = txtMaKhach.Text;
                if (String.IsNullOrWhiteSpace(id)) throw new Exception("Bạn chưa chọn khách hàng cần xóa");
                DialogResult res = MessageBox.Show("Bạn chắc chắn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    khachHang.DeleteKhachHangByID(id);
                    fKhachHang_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void icbtn_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtTenKhach.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                DataTable table = khachHang.GetKhachHangByNameOrSDT(name.Trim(), sdt);
                dgvKhachHang.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void icbtn_them_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                if(txtSDT.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại có 10 số!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSDT.Clear();
                    txtSDT.Focus();
                    return;
                }
            }
            try
            {
                IdIncrease();
                string tenKhach = txtTenKhach.Text;
                string sdt = txtSDT.Text;
                if (String.IsNullOrWhiteSpace(tenKhach)) throw new Exception("Bạn chưa nhập tên khách hàng!");
                if (String.IsNullOrWhiteSpace(sdt)) throw new Exception("Bạn chưa nhập số điện thoại khách hàng!");
                if (khachHang.CheckSDT_them(sdt)) throw new Exception("Khách hàng này đã tồn tại!");
                foreach (char c in tenKhach)
                {
                    if (Char.IsDigit(c)) throw new Exception("Tên khách hàng không đúng định dạng!");
                }
                foreach (char c in sdt)
                {
                    if (Char.IsLetter(c)) throw new Exception("Số điện thoại không đúng định dạng!");
                }

                khachHang.InsertNewKhachHang(makh, tenKhach, sdt);

                icbtn_reload_Click(sender, e);
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
                if (dgvKhachHang.Rows.Count == 0) throw new Exception("Không tồn tại khách hàng nào!");
                Microsoft.Office.Interop.Excel.Application xlAppToUpload = new Microsoft.Office.Interop.Excel.Application();
                xlAppToUpload.Workbooks.Add();

                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheetToUpload = default(Microsoft.Office.Interop.Excel.Worksheet);
                xlWorkSheetToUpload = xlAppToUpload.Sheets["Sheet1"];
                int iRowCnt = 0;
                DataTable dt = (DataTable)(dgvKhachHang.DataSource); //lấy dữ liệu trong dgv
                //setting
                xlAppToUpload.Visible = true;

                if (dt.Rows.Count > 0)
                {
                    iRowCnt = 7;

                    // style header
                    xlWorkSheetToUpload.Cells[2, 4].value = "THÔNG TIN KHÁCH HÀNG";
                    xlWorkSheetToUpload.Cells[2, 4].FONT.NAME = "Calibri";
                    xlWorkSheetToUpload.Cells[2, 4].Font.Bold = true;
                    xlWorkSheetToUpload.Cells[2, 4].Font.Size = 20;
                    xlWorkSheetToUpload.get_Range("D2", "I2").Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    xlWorkSheetToUpload.Cells[3, 5].value = "Ngày: " + DateTime.Now;

                    // merge header
                    xlWorkSheetToUpload.Range["D2:I2"].MergeCells = true;
                    xlWorkSheetToUpload.Range["D3:I3"].MergeCells = true;

                    // show collum tittle
                    xlWorkSheetToUpload.Cells[iRowCnt - 1, 4].value = "Mã Khách";
                    xlWorkSheetToUpload.Cells[iRowCnt - 1, 5].value = "Tên Khách";
                    xlWorkSheetToUpload.Cells[iRowCnt - 1, 6].value = "Số Điện Thoại";

                    // import data
                    for (var i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        xlWorkSheetToUpload.Cells[iRowCnt, 4].value = dt.Rows[i]["MaKhach"];
                        xlWorkSheetToUpload.Cells[iRowCnt, 5].value = dt.Rows[i]["TenKH"];
                        xlWorkSheetToUpload.Cells[iRowCnt, 6].value = dt.Rows[i]["SDT"];

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
            txtMaKhach.Clear();
            txtSDT.Clear();
            txtTenKhach.Clear();
            fKhachHang_Load(sender, e);
        }

        private void icb_loc_tenkh_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtTenKhach.Text.Trim();
                DataTable table = khachHang.GetKhachHangByName(name.Trim());
                dgvKhachHang.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void icb_loc_sdt_Click(object sender, EventArgs e)
        {
            try
            {
                string sdt = txtSDT.Text.Trim();
                DataTable table = khachHang.GetKhachHangBySDT(sdt);
                dgvKhachHang.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

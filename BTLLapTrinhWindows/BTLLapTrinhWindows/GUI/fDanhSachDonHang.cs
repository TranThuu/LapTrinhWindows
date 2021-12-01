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
using System.Globalization;
using System.IO;
using ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat;

namespace BTLLapTrinhWindows.GUI
{
    public partial class fDanhSachDonHang : Form
    {
        DBProccessing_DanhSachDonHang datapro = new DBProccessing_DanhSachDonHang();
        //string tenBang = "";
        public static string maHDB;
        public static Form fDSDH;
        public fDanhSachDonHang()
        {
            InitializeComponent();
            HienThiCBB_Bang();
            cbb_timkiemtheo.SelectedItem = cbb_timkiemtheo.Items[0];
            dgv_hdb.DataSource = datapro.GetTable_Excel();
            cbb_timkiemtheo.SelectedItem = cbb_timkiemtheo.Items[0];
            
            txt_soHDB.Text = (dgv_hdb.Rows.Count).ToString();
            maHDB = txt_mahdb.Text;

            fDSDH = this;
        }
        void HienThiCBB_Bang()
        {
            label2.Visible = true;
            if (cbb_timkiemtheo.SelectedItem == cbb_timkiemtheo.Items[0])
            {
                cbb_bang.Text = "";
                cbb_bang.Items.Clear();
                cbb_bang.Items.AddRange(datapro.LayTenNV().ToArray());
                cbb_bang.Enabled = true;
                label2.Text = "Tên nhân viên:";
                cbb_bang.SelectedItem = cbb_bang.Items[0];
                dtp_tungay.Visible = false;
                dtp_denngay.Visible = false;
                lb_tungay.Visible = false;
                lb_denngay.Visible = false;
            }
            else if (cbb_timkiemtheo.SelectedItem == cbb_timkiemtheo.Items[1])
            {
                cbb_bang.Text = "";
                cbb_bang.Items.Clear();
                cbb_bang.Enabled = true;
                label2.Text = "Tên khách hàng:";
                cbb_bang.Items.AddRange(datapro.LayTenKH().ToArray());
                cbb_bang.SelectedItem = cbb_bang.Items[0];
                dtp_tungay.Visible = false;
                dtp_denngay.Visible = false;
                lb_tungay.Visible = false;
                lb_denngay.Visible = false;
            }
            else
            {
                cbb_bang.Enabled = false;
                dtp_tungay.Visible = true;
                dtp_denngay.Visible = true;
                lb_tungay.Visible = true;
                lb_denngay.Visible = true;
            }
        }
        private void cbb_timkiemtheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiCBB_Bang();
        }

        private void dgv_hdb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                txt_mahdb.Text = dgv_hdb.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void butTimKiem_Click(object sender, EventArgs e)
        {
            if(cbb_timkiemtheo.SelectedItem == cbb_timkiemtheo.Items[0])
            {
                
                DataTable t = datapro.GetNhanVien_DieuKien(cbb_bang.Text);
                if(t.Rows.Count == 0)
                {
                    MessageBox.Show("Không có hóa đơn nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dgv_hdb.DataSource = t;
            }
            else if (cbb_timkiemtheo.SelectedItem == cbb_timkiemtheo.Items[1])
            {
                
                DataTable t = datapro.GetKhachHang_DieuKien(cbb_bang.Text);
                if (t.Rows.Count == 0)
                {
                    MessageBox.Show("Không có hóa đơn nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dgv_hdb.DataSource = t;
            }
            else
            {
                
                if(DateTime.Compare(dtp_denngay.Value.Date, dtp_tungay.Value.Date) == -1)
                {
                    MessageBox.Show("'Đến ngày' phải lớn hơn hoặc bằng 'Từ ngày'!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string tungay = dtp_tungay.Value.ToString("yyyy-MM-dd");
                string denngay = dtp_denngay.Value.ToString("yyyy-MM-dd");
                DataTable t = datapro.GetTable_Ngay(DateTime.ParseExact(tungay,"yyyy-MM-dd",CultureInfo.InvariantCulture), DateTime.ParseExact(denngay, "yyyy-MM-dd", CultureInfo.InvariantCulture));
                if (t.Rows.Count == 0)
                {
                    MessageBox.Show("Không có hóa đơn nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dgv_hdb.DataSource = t;
                
            }
                
        }

        private void butReload_Click(object sender, EventArgs e)
        {
            dgv_hdb.DataSource = datapro.GetTable_Excel();
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (fMain.currentChildForm != null)
            {
                fMain.currentChildForm.Close();
            }
            fMain.currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            fMain.panelDesktop.Controls.Add(childForm);
            childForm.Show();
        }
        private void butXemHDB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_mahdb.Text))
            {
                MessageBox.Show("Không có hóa đơn bán nào được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            maHDB = txt_mahdb.Text;
            fChiTietHoaDon f = new fChiTietHoaDon();
            f.ShowDialog();
            //OpenChildForm(new fChiTietHoaDon());
        }

        private void but_ExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable t = (DataTable)dgv_hdb.DataSource;
                if(dgv_hdb.Rows.Count == 0)
                {
                    throw new Exception("Không có bản ghi nào!");
                }
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                app.Workbooks.Add();
                Microsoft.Office.Interop.Excel.Worksheet wsheet = default(Microsoft.Office.Interop.Excel.Worksheet);
                wsheet = app.Worksheets["Sheet1"];
                app.Visible = true;
                
                if (t.Rows.Count > 0)
                {
                    //tiêu đề
                    wsheet.Cells[2, 2].value = "Danh sách hóa đơn bán hàng";
                    wsheet.Cells[2, 2].FONT.NAME = "Calibri";
                    wsheet.Cells[2, 2].FONT.Bold = true;
                    wsheet.Cells[2, 2].FONT.Size = 20;
                    wsheet.get_Range("B2", "H2").Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    //gộp hai dòng
                    wsheet.Range["B2:H2"].MergeCells = true;
                    wsheet.Range["B3:H3"].MergeCells = true;

                    wsheet.Cells[3, 2].value = "Ngày: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
                    // bắt đầu từ dòng thứ 6
                    int r = 6;
                    //đặt tên cho cho tiêu đề của bảng
                    wsheet.Cells[r, 2].value = "Mã hóa đơn";
                    wsheet.Cells[r, 3].value = "Tên khách hàng";
                    wsheet.Cells[r, 4].value = "Số điện thoại";
                    wsheet.Cells[r, 5].value = "Mã nhân viên";
                    wsheet.Cells[r, 6].value = "Tên nhân viên";
                    wsheet.Cells[r, 7].value = "Ngày lập";
                    wsheet.Cells[r, 8].value = "Tổng tiền";
                    r++;
                    // hiển thị lên bảng
                    for (int i = 0; i < t.Rows.Count; i++, r++)
                    {
                        wsheet.Cells[r, 2].value = t.Rows[i]["MaHDB"];
                        wsheet.Cells[r, 3].value = t.Rows[i]["TenKH"];
                        wsheet.Cells[r, 4].NumberFormat = "@";
                        wsheet.Cells[r, 4].value = t.Rows[i]["SDT"];
                        wsheet.Cells[r, 5].value = t.Rows[i]["MaNV"];
                        wsheet.Cells[r, 6].value = t.Rows[i]["TenNV"];
                        wsheet.Cells[r, 7].value = t.Rows[i]["NgayBan"];
                        wsheet.Cells[r, 8].value = t.Rows[i]["TongTien"];
                    }
                    app.ActiveCell.Worksheet.Cells[6, 2].AutoFormat(ExcelAutoFormat.xlRangeAutoFormatList2);
                    app = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

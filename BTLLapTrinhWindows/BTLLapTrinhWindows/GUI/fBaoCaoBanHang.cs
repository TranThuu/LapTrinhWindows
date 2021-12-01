using BTLLapTrinhWindows.Connection;
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
using System.Windows.Forms.DataVisualization.Charting;
using ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat;
namespace BTLLapTrinhWindows.GUI
{
    
    public partial class fBaoCaoBanHang : Form
    {
        DBProcessing_BaoCaoBanHang dpBaoCao = new DBProcessing_BaoCaoBanHang();
        public fBaoCaoBanHang()
        {
            InitializeComponent();
            cmbNam.Items.Add("2017");
            cmbNam.Items.Add("2018");
            cmbNam.Items.Add("2019");
            cmbNam.Items.Add("2020");
            cmbNam.Items.Add("2021");
            cmbNam.SelectedItem = "2021";
            dtpbd.Value = new DateTime(2021, 01, 01);
            dtpkt.Value = DateTime.Now;
        }

        private void dgvStyle()
        {
            dgvBaoCao.BorderStyle = BorderStyle.None;
            dgvBaoCao.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(217, 247, 252);
            dgvBaoCao.ForeColor = Color.Black;
        }

        private void fBanHang_Load(object sender, EventArgs e)
        {
            try
            {
                dgvBaoCao.DataSource = dpBaoCao.showBaoCaoThang(cmbNam.Text);

                DataTable dt = dpBaoCao.showBaoCaoThang(cmbNam.Text);
                chartBaoCao.DataSource = dt;
                chartBaoCao.Series["Doanh Thu"].XValueMember = "Thang";
                chartBaoCao.Series["Doanh Thu"].YValueMembers = "SumOfPayment";
                chartBaoCao.Titles.Add("Biểu đồ Báo Cáo Doanh Thu năm "+cmbNam.Text);
                //Thống kê theo ngày
                showThongKeNgay();
                dgvStyle();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        void showThongKeNgay()
        {
            DataTable dt = dpBaoCao.thongKeHangBan(dtpbd.Value,dtpkt.Value);
            dgvBan.DataSource = dt;
            Int32 TongGT = 0;
            foreach(DataRow row in dt.Rows)
                TongGT += Convert.ToInt32(row["TongTien"]);
            lbGiaTriBan.Text = TongGT.ToString("###\\.###\\.##0");
            lbSLBan.Text =  dt.Rows.Count.ToString();

            //Nhập
            dt = dpBaoCao.thongKeHangNhap(dtpbd.Value, dtpkt.Value);
            dgvNhap.DataSource = dt;
            TongGT = 0;
            foreach (DataRow row in dt.Rows)
                TongGT += Convert.ToInt32(row["TongTien"]);
            lbGiaTriNhap.Text = TongGT.ToString("###\\.###\\.##0");
            lbSLNhap.Text = dt.Rows.Count.ToString();
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (dgvBaoCao.SelectedRows.Count > 0)
            {
                dgvBaoCao.Rows.RemoveAt(this.dgvBaoCao.SelectedRows[0].Index);
            }
            chartBaoCao.Titles.RemoveAt(0);
            fBanHang_Load(sender, e);
        }

        private void btnLocDL_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpbd.Value > dtpkt.Value)
                    throw new Exception("Thời gian bắt đầu phải nhỏ hơn thời gian kết thúc!");
                showThongKeNgay();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBan.Rows.Count == 0 && dgvNhap.Rows.Count == 0)
                    throw new Exception("Không tồn tại dữ liệu để xuất!");
                Microsoft.Office.Interop.Excel.Application xlAppToUpload = new Microsoft.Office.Interop.Excel.Application();
                xlAppToUpload.Workbooks.Add();

                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheetToUpload = default(Microsoft.Office.Interop.Excel.Worksheet);
                xlWorkSheetToUpload = xlAppToUpload.Sheets["Sheet1"];
                int iRowCnt = 0;
                int iRowCnt2 = 0;
                DataTable dt = (DataTable)(dgvBan.DataSource);
                DataTable dt2 = (DataTable)(dgvNhap.DataSource);
                //setting
                xlAppToUpload.Visible = true;

                if (dt.Rows.Count > 0)
                {
                    iRowCnt2 = iRowCnt = 7;  // dòng bắt đầu in
                    var range = xlWorkSheetToUpload.get_Range(string.Format("{0}:{0}", 1, Type.Missing));
                    range = range.EntireRow;
                    range.Style.Font.Name = "Cambria";
                    range.Style.Font.Bold = false;
                    range.Style.Font.Size = 12;
                    // style header
                    xlWorkSheetToUpload.Cells[2, 4].value = "TỔNG HỢP BÁN HÀNG THEO NGÀY";
                    xlWorkSheetToUpload.Cells[2, 4].FONT.NAME = "Cambria";
                    xlWorkSheetToUpload.Cells[2, 4].Font.Bold = true;
                    xlWorkSheetToUpload.Cells[2, 4].Font.Size = 20;
                    xlWorkSheetToUpload.get_Range("D2", "I2").Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    xlWorkSheetToUpload.Cells[3, 5].value = "Từ ngày: " + dtpbd.Value.ToString("dd/MM/yyyy") + "\t Đến ngày: " + dtpkt.Value.ToString("dd/MM/yyyy");

                    // merge header
                    xlWorkSheetToUpload.Range["D2:L2"].MergeCells = true;
                    xlWorkSheetToUpload.Range["D3:L3"].MergeCells = true;

                    // show collum tittle
                    xlWorkSheetToUpload.Cells[iRowCnt - 1, 4].value = "Ngày bán";
                    xlWorkSheetToUpload.Cells[iRowCnt - 1, 5].value = "Mã HDB";
                    xlWorkSheetToUpload.Cells[iRowCnt - 1, 6].value = "Số Lượng SP";
                    xlWorkSheetToUpload.Cells[iRowCnt - 1, 7].value = "Tổng tiền";

                    xlWorkSheetToUpload.Cells[iRowCnt - 1, 9].value = "Ngày nhập";
                    xlWorkSheetToUpload.Cells[iRowCnt - 1, 10].value = "Mã HDN";
                    xlWorkSheetToUpload.Cells[iRowCnt - 1, 11].value = "Số Lượng SP";
                    xlWorkSheetToUpload.Cells[iRowCnt - 1, 12].value = "Tổng tiền";

                    // import data
                    for (var i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        xlWorkSheetToUpload.Cells[iRowCnt, 4].value = dt.Rows[i]["NgayBan"];
                        xlWorkSheetToUpload.Cells[iRowCnt, 5].value = dt.Rows[i]["MaHDB"];
                        xlWorkSheetToUpload.Cells[iRowCnt, 6].value = dt.Rows[i]["SLSP"];
                        xlWorkSheetToUpload.Cells[iRowCnt, 7].value = dt.Rows[i]["TongTien"];
                        iRowCnt = iRowCnt + 1;
                    }
                    for (var i = 0; i <= dt2.Rows.Count - 1; i++)
                    {
                        xlWorkSheetToUpload.Cells[iRowCnt2, 9].value = dt2.Rows[i]["NgayNhap"];
                        xlWorkSheetToUpload.Cells[iRowCnt2, 10].value = dt2.Rows[i]["MaHDN"];
                        xlWorkSheetToUpload.Cells[iRowCnt2, 11].value = dt2.Rows[i]["SLSP"];
                        xlWorkSheetToUpload.Cells[iRowCnt2, 12].value = dt2.Rows[i]["TongTien"];
                        iRowCnt2 = iRowCnt2 + 1;
                    }
                    int ttrow = (iRowCnt > iRowCnt2) ? iRowCnt : iRowCnt2;
                    xlWorkSheetToUpload.Cells[ttrow+1, 9].value = "TỔNG TIỀN";
                    xlWorkSheetToUpload.Cells[ttrow + 1, 12].value = lbGiaTriNhap.Text;
                    xlWorkSheetToUpload.Cells[ttrow + 1, 4].value = "TỔNG TIỀN";
                    xlWorkSheetToUpload.Cells[ttrow + 1, 7].value = lbGiaTriBan.Text;
                    // format excel
                    xlAppToUpload.ActiveCell.Worksheet.Cells[7, 8].AutoFormat(ExcelAutoFormat.xlRangeAutoFormatList3);
                    xlAppToUpload = null;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                dtpbd.Value = new DateTime(2021, 01, 01);
                dtpkt.Value = DateTime.Now;
                showThongKeNgay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

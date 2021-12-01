using BTLLapTrinhWindows.Proccessing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat;

namespace BTLLapTrinhWindows.GUI
{
    public partial class fTonKho : Form
    {
        DBProcessing_TonKho dBTonKHo = new DBProcessing_TonKho();

        public fTonKho()
        {
            InitializeComponent();
        }
        private void dgvStyle()
        {
            dgvTonKho.BorderStyle = BorderStyle.None;
            dgvTonKho.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 245, 249);
            dgvTonKho.ForeColor = Color.Black;
        }
        private void fTonKho_Load(object sender, EventArgs e)
        {
            try
            {
                dgvTonKho.DataSource = dBTonKHo.showTonKho();
                DataTable dt = new DataTable();
                dt = dBTonKHo.showDM();
                cmbDanhMuc.Items.Add ("");
                List<string> lst = new List<string>(dt.Rows.Count);
                foreach (DataRow row in dt.Rows)
                    lst.Add(row["TenDM"].ToString());

                cmbDanhMuc.Items.AddRange(lst.ToArray());

                lbTongTonKho.Text = dBTonKHo.TongTonKho().ToString("###\\.###\\.##0");
                dgvStyle();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if(cmbDanhMuc.Text==""&& txtSanPham.Text != "")
            {
                dt = dBTonKHo.searchTenSanPham(txtSanPham.Text);
                dgvTonKho.DataSource = dt;
            }else
            if(cmbDanhMuc.Text!=""&& txtSanPham.Text == "")
            {
                dt = dBTonKHo.searchTenDanhMuc(cmbDanhMuc.Text);
                dgvTonKho.DataSource = dt;
            }else
            if (cmbDanhMuc.Text != "" && txtSanPham.Text != "")
            {
                dt = dBTonKHo.searchTenDMTenSP(cmbDanhMuc.Text, txtSanPham.Text);
                dgvTonKho.DataSource = dt;
            }
            else
                dgvTonKho.DataSource = dBTonKHo.showTonKho();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTonKho.Rows.Count == 0)
                    throw new Exception("Không tồn tại dữ liệu để xuất!");
                Microsoft.Office.Interop.Excel.Application xlAppToUpload = new Microsoft.Office.Interop.Excel.Application();
                xlAppToUpload.Workbooks.Add();

                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheetToUpload = default(Microsoft.Office.Interop.Excel.Worksheet);
                xlWorkSheetToUpload = xlAppToUpload.Sheets["Sheet1"];
                int iRowCnt = 0;
                DataTable dt = (DataTable)(dgvTonKho.DataSource);
                //setting
                xlAppToUpload.Visible = true;

                if (dt.Rows.Count > 0)
                {
                    iRowCnt = 7;                      // dòng bắt đầu in

                    // style header
                    xlWorkSheetToUpload.Cells[2, 4].value = "BÁO CÁO TỒN KHO";
                    xlWorkSheetToUpload.Cells[2, 4].FONT.NAME = "Calibri";
                    xlWorkSheetToUpload.Cells[2, 4].Font.Bold = true;
                    xlWorkSheetToUpload.Cells[2, 4].Font.Size = 20;
                    xlWorkSheetToUpload.get_Range("D2", "I2").Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    xlWorkSheetToUpload.Cells[3, 5].value = "Ngày báo cáo: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");

                    // merge header
                    xlWorkSheetToUpload.Range["D2:I2"].MergeCells = true;
                    xlWorkSheetToUpload.Range["D3:I3"].MergeCells = true;

                    // show collum tittle
                    xlWorkSheetToUpload.Cells[iRowCnt - 1, 4].value = "Mã SP";
                    xlWorkSheetToUpload.Cells[iRowCnt - 1, 5].value = "Tên sản phẩm";
                    xlWorkSheetToUpload.Cells[iRowCnt - 1, 6].value = "ĐVT";
                    xlWorkSheetToUpload.Cells[iRowCnt - 1, 7].value = "TenDM";
                    xlWorkSheetToUpload.Cells[iRowCnt - 1, 8].value = "SL tồn";
                    xlWorkSheetToUpload.Cells[iRowCnt - 1, 9].value = "Giá trị tồn";

                    // import data
                    for (var i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        xlWorkSheetToUpload.Cells[iRowCnt, 4].value = dt.Rows[i]["MaSanPham"];
                        xlWorkSheetToUpload.Cells[iRowCnt, 5].value = dt.Rows[i]["TenSP"];
                        xlWorkSheetToUpload.Cells[iRowCnt, 6].value = dt.Rows[i]["DonViTinh"];
                        xlWorkSheetToUpload.Cells[iRowCnt, 7].value = dt.Rows[i]["TenDM"];
                        xlWorkSheetToUpload.Cells[iRowCnt, 8].value = dt.Rows[i]["TonKho"];
                        xlWorkSheetToUpload.Cells[iRowCnt, 9].value = dt.Rows[i]["GiaTriTon"];

                        iRowCnt = iRowCnt + 1;
                    }
                    xlWorkSheetToUpload.Range["D"+(iRowCnt+1)+":I"+ (iRowCnt + 1)].Font.Bold = true;
                    xlWorkSheetToUpload.Cells[iRowCnt + 1, 4].value = "TỔNG GT TỒN KHO: ";
                    xlWorkSheetToUpload.Cells[iRowCnt + 1, 9].value = lbTongTonKho.Text;
                    // format excel
                    xlAppToUpload.ActiveCell.Worksheet.Cells[7, 4].AutoFormat(ExcelAutoFormat.xlRangeAutoFormatList3);
                    xlAppToUpload = null;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbtnPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTonKho.Rows.Count == 0)
                    throw new Exception("Không tồn tại dữ liệu để xuất!");
                SaveFileDialog s = new SaveFileDialog();
                s.FileName = "File name";
                s.DefaultExt = ".pdf";
                s.Filter = "PDF (*.pdf)|*.pdf";
                if (s.ShowDialog() == DialogResult.OK)
                {
                    // Setup để thêm dữ liệu
                    Document document = new Document(PageSize.A4, 10f, 20f, 20f, 20f);
                    FileStream fileStream = new FileStream(s.FileName, FileMode.Create);
                    PdfWriter.GetInstance(document, fileStream);
                    //Phần trên hóa đơn
                    PdfPTable ptable = new PdfPTable(2);
                    ptable.DefaultCell.Padding = 5;
                    ptable.WidthPercentage = 95;
                    ptable.HorizontalAlignment = Element.ALIGN_CENTER;
                    ptable.DefaultCell.BorderWidth = 1;
                    document.Open();
                    // font chữ
                    string path = Path.Combine(Path.GetFullPath(@"..\..\"), "Resources") + @"\CALIBRI.TTF";
                    BaseFont bf = BaseFont.CreateFont(path, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 13, iTextSharp.text.Font.NORMAL);
                    iTextSharp.text.Font fontHearder = new iTextSharp.text.Font(bf, 15, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font fontBold = new iTextSharp.text.Font(bf, 13, iTextSharp.text.Font.BOLD);
                    //Tên cửa hàng
                    Phrase phrase2 = new Phrase("Văn phòng phẩm Bookish Freaks", fontBold);
                    PdfPCell pcell2 = new PdfPCell(phrase2);
                    pcell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell2.Colspan = 2;
                    pcell2.HorizontalAlignment = Element.ALIGN_LEFT;
                    ptable.AddCell(pcell2);
                    // Địa chỉ cửa hàng
                    Phrase phrase3 = new Phrase("\nĐịa chỉ: Đại học Công nghiệp Hà Nội - Cơ sở 1", fontBold);
                    PdfPCell pcell3 = new PdfPCell(phrase3);
                    pcell3.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell3.Colspan = 2;
                    pcell3.HorizontalAlignment = Element.ALIGN_LEFT;
                    ptable.AddCell(pcell3);
                    //Điện thoại cửa hàng
                    Phrase phrase4 = new Phrase("\nĐiện thoại: 1900 1900.", fontBold);
                    PdfPCell pcell4 = new PdfPCell(phrase4);
                    pcell4.Colspan = 2;
                    pcell4.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell4.HorizontalAlignment = Element.ALIGN_LEFT;
                    ptable.AddCell(pcell4);
                    // Báo cáo tồn kho
                    Phrase phrase5 = new Phrase("\nBÁO CÁO TỒN KHO", fontHearder);
                    PdfPCell pcell5 = new PdfPCell(phrase5);
                    pcell5.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell5.Colspan = 2;
                    pcell5.HorizontalAlignment = Element.ALIGN_CENTER;
                    pcell5.PaddingTop = 10;
                    pcell5.PaddingBottom = 0;
                    ptable.AddCell(pcell5);

                    Phrase phrase6= new Phrase("\nNgày thống kê: "+ DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), text);
                    PdfPCell pcell6 = new PdfPCell(phrase6);
                    pcell6.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell6.Colspan = 2;
                    pcell6.HorizontalAlignment = Element.ALIGN_CENTER;
                    pcell6.PaddingTop = 0;
                    pcell6.PaddingBottom = 10;
                    ptable.AddCell(pcell6);

                    PdfPTable ptable1 = new PdfPTable(dgvTonKho.Columns.Count);
                    ptable1.DefaultCell.Padding = 10;
                    ptable1.WidthPercentage = 100;
                    ptable1.HorizontalAlignment = Element.ALIGN_CENTER;
                    ptable1.DefaultCell.BorderWidth = 1;
                    float[] columnsWidth = { 1, 1.6f, 0.5f, 1f, 0.7f,0.9f };
                    ptable1.SetWidths(columnsWidth);
                    //Header bảng tồn kho
                    foreach (DataGridViewColumn col in dgvTonKho.Columns)
                    {
                        PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText, fontBold));
                        pCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pCell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                        ptable1.AddCell(pCell);
                    }
                    //Thêm các data cho bảng
                    for (int i = 0; i < dgvTonKho.Rows.Count - 1; i++)
                    {
                        DataGridViewRow viewRow = dgvTonKho.Rows[i];
                        foreach (DataGridViewCell dcell in viewRow.Cells)
                        {
                            PdfPCell pCell = new PdfPCell(new Phrase(dcell.Value.ToString(), text));
                            pCell.HorizontalAlignment = Element.ALIGN_CENTER;
                            ptable1.AddCell(pCell);
                        }
                    }
                    PdfPCell pCell1 = new PdfPCell(new Phrase("TỔNG", text));
                    pCell1.HorizontalAlignment = Element.ALIGN_CENTER;
                    pCell1.Colspan = 5;
                    ptable1.AddCell(pCell1);

                    PdfPCell pCell12 = new PdfPCell(new Phrase(lbTongTonKho.Text));
                    pCell1.HorizontalAlignment = Element.ALIGN_CENTER;
                    pCell1.Colspan = 1;
                    ptable1.AddCell(pCell12);

                    PdfPTable ptable2 = new PdfPTable(2);
                    ptable2.DefaultCell.Padding = 5;
                    ptable2.WidthPercentage = 95;
                    ptable2.HorizontalAlignment = Element.ALIGN_CENTER;
                    ptable2.DefaultCell.BorderWidth = 1;

                    Phrase phrase7 = new Phrase("\nNgày...., tháng....., Năm 20...", text);
                    PdfPCell pcell7 = new PdfPCell(phrase7);
                    pcell7.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell7.Colspan = 2;
                    pcell7.HorizontalAlignment = Element.ALIGN_RIGHT;
                    pcell7.PaddingTop = 0;
                    pcell7.PaddingBottom = 0;
                    ptable2.AddCell(pcell7);

                    Phrase phrase8 = new Phrase("\nNgười lập biểu", text);
                    PdfPCell pcell8 = new PdfPCell(phrase8);
                    pcell8.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell8.Colspan = 2;
                    pcell8.HorizontalAlignment = Element.ALIGN_RIGHT;
                    pcell8.PaddingTop = 0;
                    pcell8.PaddingBottom = 0;
                    ptable2.AddCell(pcell8);

                    Paragraph parablank = new Paragraph(" ", text);

                    document.Add(ptable);
                    document.Add(parablank);
                    document.Add(ptable1);
                    document.Add(ptable2);
                    document.Close();
                    fileStream.Close();
                    MessageBox.Show("Xuất file thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Runtime.InteropServices;

namespace BTLLapTrinhWindows.GUI
{
    public partial class fChiTietHoaDonNhap : Form
    {
        DBProccessing_DSNhapHang dt = new DBProccessing_DSNhapHang();
        //khai báo delegate
        public delegate void SendData(string maHDN);
        public SendData Sender;
        public fChiTietHoaDonNhap()
        {
            InitializeComponent();
            Sender = new SendData(GetData);
        }
        private void GetData(string maHDN)
        {
            try
            {
                DataTable tbl = dt.getInforHDN(maHDN);
                //MessageBox.Show(ma);
                if (tbl.Rows.Count >= 0)
                {
                    lblMaHDNhap.Text = maHDN;
                    dtpNgayNhap.Text = tbl.Rows[0]["NgayNhap"].ToString();
                    lblNhanVien.Text = tbl.Rows[0]["TenNV"].ToString();
                    lblNhaCC.Text = tbl.Rows[0]["TenNCC"].ToString();
                    lblSDT.Text = tbl.Rows[0]["SDT"].ToString();
                    lblDiaChi.Text = tbl.Rows[0]["DiaChi"].ToString();
                    DataTable chiTietHDN = new DataTable();
                    chiTietHDN = dt.getCTHDByMa(maHDN);
                    dgvSanPham.DataSource = chiTietHDN;
                    int tongTien = 0;
                    for(int i=0;i<dgvSanPham.Rows.Count;i++)
                    {
                        tongTien += int.Parse(dgvSanPham.Rows[i].Cells[4].Value.ToString());
                    }
                    lblTongTien.Text = string.Format("{0:0,0}", tongTien) + " VNĐ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnExportPDF_Click_1(object sender, EventArgs e)
        {
            try
            {
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
                    // Hóa đơn bán
                    Phrase phrase5 = new Phrase("\nHÓA ĐƠN NHẬP", fontHearder);
                    PdfPCell pcell5 = new PdfPCell(phrase5);
                    pcell5.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell5.Colspan = 2;
                    pcell5.HorizontalAlignment = Element.ALIGN_CENTER;
                    pcell5.PaddingTop = 10;
                    pcell5.PaddingBottom = 10;
                    ptable.AddCell(pcell5);
                    //Ngày nhập hóa đơn
                    Phrase phrase10 = new Phrase("\nNgày nhập: " + dtpNgayNhap.Text, fontBold);
                    PdfPCell pcell10 = new PdfPCell(phrase10);
                    pcell10.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell10.HorizontalAlignment = Element.ALIGN_RIGHT;
                    pcell10.Colspan = 2;
                    ptable.AddCell(pcell10);
                    //Mã hóa đơn
                    Phrase phrase6 = new Phrase("\nMã hóa đơn:  " + lblMaHDNhap.Text, text);
                    PdfPCell pcell6 = new PdfPCell(phrase6);
                    pcell6.Colspan = 2;
                    pcell6.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell6.HorizontalAlignment = Element.ALIGN_LEFT;
                    pcell6.PaddingBottom = 5;
                    ptable.AddCell(pcell6);
                    //Nhân viên
                    Phrase phrase7 = new Phrase("\nNhân viên:   " + lblNhanVien.Text, text);
                    PdfPCell pcell7 = new PdfPCell(phrase7);
                    pcell7.Colspan = 2;
                    pcell7.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell7.HorizontalAlignment = Element.ALIGN_LEFT;
                    ptable.AddCell(pcell7);
                    //Nhà cung cấp
                    Phrase phNCC = new Phrase("\nNhà cung cấp:  " + lblNhaCC.Text, text);
                    PdfPCell pcell8 = new PdfPCell(phNCC);
                    pcell8.Colspan = 1;
                    pcell8.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell8.HorizontalAlignment = Element.ALIGN_LEFT;
                    ptable.AddCell(pcell8);
                    //Điện thoại NCC
                    Phrase phrase81 = new Phrase("\nĐiện thoại:  " + lblSDT.Text, text);
                    PdfPCell pcell81 = new PdfPCell(phrase81);
                    pcell81.Colspan = 1;
                    pcell81.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell81.HorizontalAlignment = Element.ALIGN_LEFT;
                    ptable.AddCell(pcell81);
                    //Địa chỉ NCC
                    Phrase phrase9 = new Phrase("\nĐịa chỉ:   " + lblDiaChi.Text, text);
                    PdfPCell pcell9 = new PdfPCell(phrase9);
                    pcell9.Colspan = 2;
                    pcell9.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell9.HorizontalAlignment = Element.ALIGN_LEFT;
                    pcell9.PaddingBottom = 10;
                    ptable.AddCell(pcell9);
                    //Bảng sản phẩm
                    PdfPTable ptable1 = new PdfPTable(dgvSanPham.Columns.Count);
                    ptable1.DefaultCell.Padding = 10;
                    ptable1.WidthPercentage = 100;
                    ptable1.HorizontalAlignment = Element.ALIGN_CENTER;
                    ptable1.DefaultCell.BorderWidth = 1;
                    float[] columnsWidth = { 1f, 1.7f, 1, 0.8f, 1 };
                    ptable1.SetWidths(columnsWidth);
                    //Header bảng sản phẩm
                    foreach (DataGridViewColumn col in dgvSanPham.Columns)
                    {
                        PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText, fontBold));
                        pCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pCell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                        ptable1.AddCell(pCell);
                    }
                    //Thêm các hàng cho bảng
                    foreach (DataGridViewRow viewRow in dgvSanPham.Rows)
                    {
                        foreach (DataGridViewCell dcell in viewRow.Cells)
                        {
                            PdfPCell pCell = new PdfPCell(new Phrase(dcell.Value.ToString(), text));
                            pCell.HorizontalAlignment = Element.ALIGN_CENTER;
                            ptable1.AddCell(pCell);
                        }
                    }
                    //Phần dưới hóa đơn
                    PdfPTable ptable2 = new PdfPTable(1);
                    ptable2.DefaultCell.Padding = 10;
                    ptable2.WidthPercentage = 95;
                    ptable2.HorizontalAlignment = Element.ALIGN_LEFT;
                    ptable2.DefaultCell.BorderWidth = 1;
                    //Thêm tổng tiền
                    Phrase phTongTien = new Phrase("\nTổng tiền: " + lblTongTien.Text, fontBold);
                    PdfPCell pcellTongTien = new PdfPCell(phTongTien);
                    pcellTongTien.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcellTongTien.HorizontalAlignment = Element.ALIGN_RIGHT;
                    pcellTongTien.PaddingTop = 5;
                    pcellTongTien.PaddingBottom = 10;
                    pcellTongTien.Colspan = 1;
                    ptable2.AddCell(pcellTongTien);

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

﻿using BTLLapTrinhWindows.Proccessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace BTLLapTrinhWindows.GUI
{
    public partial class fChiTietHoaDon : Form
    {
        string ma;
        DBProccessing_ChTietHoaDon datapro = new DBProccessing_ChTietHoaDon();
        public fChiTietHoaDon()
        {
            //this.StartPosition = fDanhSachDonHang.fDSDH.StartPosition;
            InitializeComponent();
            ma = fDanhSachDonHang.maHDB;
            lb_mahdb.Text = ma;
            DataTable t = datapro.LayHoaDonBan(ma);
            DataRow r = t.Rows[0];
            dtp_ngay.Text = r[1].ToString();
            lb_kh.Text = r[4].ToString();
            lb_nv.Text = r[3].ToString();
            lb_tongtien.Text = string.Format("{0:0,0}", float.Parse(r[2].ToString())) + " VNĐ" ;
            lb_dtkh.Text = r[5].ToString();

            DataTable t2 = datapro.LayBangCTHDB(ma);
            int i = 1;
            foreach(DataRow r2 in t2.Rows)
            {
                dgv_sanpham.Rows.Add(i, r2[0].ToString(), r2[1].ToString(), r2[2].ToString(), string.Format("{0:0,0}",float.Parse(r2[3].ToString())));
                i++;
            }
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
        private void butExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog s = new SaveFileDialog();
                s.FileName = "File name";
                s.DefaultExt = ".pdf";
                s.Filter = "PDF (*.pdf)|*.pdf";
                if(s.ShowDialog() == DialogResult.OK)
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
                    Phrase phrase5 = new Phrase("\nHÓA ĐƠN BÁN", fontHearder);
                    PdfPCell pcell5 = new PdfPCell(phrase5);
                    pcell5.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell5.Colspan = 2;
                    pcell5.HorizontalAlignment = Element.ALIGN_CENTER;
                    pcell5.PaddingTop = 10;
                    pcell5.PaddingBottom = 10;
                    ptable.AddCell(pcell5);
                    //Ngày lập hóa đơn
                    Phrase phrase10 = new Phrase("\nNgày lập: " + dtp_ngay.Text, fontBold);
                    PdfPCell pcell10 = new PdfPCell(phrase10);
                    pcell10.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell10.HorizontalAlignment = Element.ALIGN_RIGHT;
                    pcell10.Colspan = 2;
                    ptable.AddCell(pcell10);
                    //Mã hóa đơn
                    Phrase phrase6 = new Phrase("\nMã hóa đơn:  " + lb_mahdb.Text, text);
                    PdfPCell pcell6 = new PdfPCell(phrase6);
                    pcell6.Colspan = 2;
                    pcell6.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell6.HorizontalAlignment = Element.ALIGN_LEFT;
                    pcell6.PaddingBottom = 5;
                    ptable.AddCell(pcell6);
                    //Nhân viên
                    Phrase phrase7 = new Phrase("\nNhân viên:   " + lb_nv.Text, text);
                    PdfPCell pcell7 = new PdfPCell(phrase7);
                    pcell7.Colspan = 2;
                    pcell7.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell7.HorizontalAlignment = Element.ALIGN_LEFT;
                    ptable.AddCell(pcell7);
                    //Khách hàng
                    Phrase phrase8 = new Phrase("\nKhách hàng:  " + lb_kh.Text, text);
                    PdfPCell pcell8 = new PdfPCell(phrase8);
                    pcell8.Colspan = 1;
                    pcell8.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell8.HorizontalAlignment = Element.ALIGN_LEFT;
                    pcell8.PaddingBottom = 10;
                    ptable.AddCell(pcell8);
                    //Điện thoại khách hàng
                    Phrase phrase81 = new Phrase("\nĐiện thoại:  " + lb_dtkh.Text, text);
                    PdfPCell pcell81 = new PdfPCell(phrase81);
                    pcell81.Colspan = 1;
                    pcell81.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell81.HorizontalAlignment = Element.ALIGN_LEFT;
                    pcell81.PaddingBottom = 10;
                    ptable.AddCell(pcell81);
                    //Bảng sản phẩm
                    PdfPTable ptable1 = new PdfPTable(dgv_sanpham.Columns.Count);
                    ptable1.DefaultCell.Padding = 10;
                    ptable1.WidthPercentage = 100;
                    ptable1.HorizontalAlignment = Element.ALIGN_CENTER;
                    ptable1.DefaultCell.BorderWidth = 1;
                    float[] columnsWidth = { 0.5f, 1.7f, 1, 0.8f, 1 };
                    ptable1.SetWidths(columnsWidth);
                    //Header bảng sản phẩm
                    foreach (DataGridViewColumn col in dgv_sanpham.Columns)
                    {
                        PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText, fontBold));
                        pCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pCell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                        ptable1.AddCell(pCell);
                    }
                    //Thêm các hàng cho bảng
                    foreach(DataGridViewRow viewRow in dgv_sanpham.Rows)
                    {
                        foreach(DataGridViewCell dcell in viewRow.Cells)
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
                    Phrase phrase9 = new Phrase("\nTổng tiền: " +  lb_tongtien.Text, fontBold);
                    PdfPCell pcell9 = new PdfPCell(phrase9);
                    pcell9.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell9.HorizontalAlignment = Element.ALIGN_RIGHT;
                    pcell9.PaddingTop = 5;
                    pcell9.PaddingBottom = 10;
                    pcell9.Colspan = 1;
                    ptable2.AddCell(pcell9);

                    Paragraph parablank = new Paragraph(" ", text);

                    document.Add(ptable);
                    document.Add(parablank);
                    document.Add(ptable1);
                    document.Add(ptable2);
                    document.Close();
                    fileStream.Close();
                    MessageBox.Show("Xuất file thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        System.Diagnostics.Process.Start("explorer.exe", s.FileName); // XML NHẬP
                    }
                    catch (Exception)
                    {
                        System.Diagnostics.Process.Start("msedge.exe", s.FileName);

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void icb_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

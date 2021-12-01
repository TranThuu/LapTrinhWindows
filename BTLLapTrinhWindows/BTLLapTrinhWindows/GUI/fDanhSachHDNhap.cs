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
using System.Globalization;

namespace BTLLapTrinhWindows.GUI
{
    public partial class fDanhSachHDNhap : Form
    {
        DBProccessing_DSNhapHang dt = new DBProccessing_DSNhapHang();
        public static string maHDNhap;
        string maHDSender;
        public fDanhSachHDNhap()
        {
            InitializeComponent();
        }
        private void fDanhSachHDNhap_Load(object sender, EventArgs e)
        {
            cbbTKTheo.Items.Add("Nhân viên");
            cbbTKTheo.Items.Add("Nhà cung cấp");
            cbbTKTheo.Items.Add("Ngày nhập");
            cbbTKTheo.SelectedItem = cbbTKTheo.Items[0];
            dgvHienThi();
            dgvHDNhap.DataSource = dt.GetTable_HDN();
            cbbTKTheo.SelectedItem = cbbTKTheo.Items[0];
            txtTongHoaDonNhap.Text = (dgvHDNhap.Rows.Count).ToString();
            maHDNhap = txtMaHDNhap.Text;
        }
        void dgvHienThi()
        {
            if (cbbTKTheo.SelectedItem.ToString().Equals("Nhân viên"))
            {
                cbbKey.DataSource = dt.GetTable("NhanVien");
                cbbKey.DisplayMember = "TenNV";
                cbbKey.ValueMember = "MaNV";
                lblKey.Visible = true;
                lblKey.Text = "Tên nhân viên:";
                cbbKey.Visible = true;
            }
            else if (cbbTKTheo.SelectedItem.ToString().Equals("Nhà cung cấp"))
            {
                cbbKey.DataSource = dt.GetTable("NhaCungCap");
                cbbKey.DisplayMember = "TenNCC";
                cbbKey.ValueMember = "MaNhaCC";
                lblKey.Visible = true;
                lblKey.Text = "Tên nhà cung cấp: ";
                cbbKey.Visible = true;
            }
            else
            {
                lblKey.Visible = false;
                cbbKey.Visible = false;
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cbbTKTheo.SelectedItem.ToString().Equals("Nhân viên"))
            {
                DataTable t = dt.GetTable_DieuKien("MaNV", cbbKey.SelectedValue.ToString());
                if(t.Rows.Count ==0)
                {
                    MessageBox.Show("Không có hóa đơn nào được nhập bởi nhân viên '" + cbbKey.Text + "'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvHDNhap.DataSource = t;
            }
            else if (cbbTKTheo.SelectedItem.ToString().Equals("Nhà cung cấp"))
            {
                DataTable t = dt.GetTable_DieuKien("MaNhaCC", cbbKey.SelectedValue.ToString());
                if (t.Rows.Count == 0)
                {
                    MessageBox.Show("Không có hóa đơn nào được nhập từ nhà cung cấp '" + cbbKey.Text + "'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvHDNhap.DataSource = t;
            }
            else
            {
                string ngayNhap = dtpNgayNhap.Value.ToString("yyyy-MM-dd");
                DataTable t = dt.GetTable_Ngay("NgayNhap", ngayNhap);
                if (t.Rows.Count == 0)
                {
                    MessageBox.Show("Không có hóa đơn nào được nhập vào ngày '"+ngayNhap+"'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvHDNhap.DataSource = t;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvHDNhap.DataSource= dt.GetTable("HoaDonNhap");
            txtMaHDNhap.Text = "";
        }

        private void btnXemHDNhap_Click(object sender, EventArgs e)
        {
            if(txtMaHDNhap.Text=="")
            {
                MessageBox.Show("Không hóa đơn nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fChiTietHoaDonNhap frm = new fChiTietHoaDonNhap();
                frm.Sender(maHDSender);
                frm.Show();
            } 
        }

        private void cbbTKTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvHienThi();
        }

        private void dgvHDNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            if(d >= 0)
            {
                txtMaHDNhap.Text = dgvHDNhap.Rows[d].Cells[0].Value.ToString();
                maHDSender = txtMaHDNhap.Text;
            }    
        }

        private void btnPdf_Click(object sender, EventArgs e)
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
                    // DS HD nhập
                    Phrase phrase5 = new Phrase("\nDANH SÁCH HÓA ĐƠN NHẬP", fontHearder);
                    PdfPCell pcell5 = new PdfPCell(phrase5);
                    pcell5.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell5.Colspan = 2;
                    pcell5.HorizontalAlignment = Element.ALIGN_CENTER;
                    pcell5.PaddingTop = 10;
                    pcell5.PaddingBottom = 10;

                    //Bảng Hóa Đơn Nhập
                    PdfPTable ptable1 = new PdfPTable(dgvHDNhap.Columns.Count);
                    ptable1.DefaultCell.Padding = 10;
                    ptable1.WidthPercentage = 100;
                    ptable1.HorizontalAlignment = Element.ALIGN_CENTER;
                    ptable1.DefaultCell.BorderWidth = 1;
                    float[] columnsWidth = { 1f, 1.7f, 1, 0.8f, 1 };
                    ptable1.SetWidths(columnsWidth);
                    //Header bảng sản phẩm
                    foreach (DataGridViewColumn col in dgvHDNhap.Columns)
                    {
                        PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText, fontBold));
                        pCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pCell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                        ptable1.AddCell(pCell);
                    }
                    //Thêm các hàng cho bảng
                    foreach (DataGridViewRow viewRow in dgvHDNhap.Rows)
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
                    //Thêm tổng hóa đơn
                    Phrase phTongTien = new Phrase("\nTổng số lượng hóa đơn: " + txtSLHDNhap.Text, fontBold);
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
    }
}

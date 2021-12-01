using System;
using System.Collections.Generic;
using System.ComponentModel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTLLapTrinhWindows.Proccessing;
using System.IO;
using ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat;
using FontAwesome.Sharp;

namespace BTLLapTrinhWindows.GUI
{
    public partial class fDanhSachSanPham : Form
    {
        DBProccessing_DanhSachSanPham data = new DBProccessing_DanhSachSanPham();
        public string maSanPham;
        public static IconButton button_sua;
        public static LinkLabel dsDPNgungBan;
        public fDanhSachSanPham()
        {
            InitializeComponent();
            button_sua = icb_sua;
            dsDPNgungBan = linkDSSPNgungBan;
        }
        private void dgvStyle()
        {
            dgvSanPham.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(80, 124, 209);
            dgvSanPham.RowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
            dgvSanPham.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);  
        }
        private void addLoaiTK()
        {
            cbbKieuTK.Items.Add("Mã sản phẩm");
            cbbKieuTK.Items.Add("Tên sản phẩm");
            cbbKieuTK.SelectedItem = cbbKieuTK.Items[0];
        }
        private void fDanhSachSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable tblSanPham = new DataTable();
                tblSanPham = data.showSPPanging(1);
                dgvSanPham.DataSource = tblSanPham;
                DataTable tblDMSanPham = new DataTable();
                tblDMSanPham = data.showDanhMuc();
                cbbDanhMuc.DataSource = tblDMSanPham;
                cbbDanhMuc.DisplayMember = "TenDM";
                cbbDanhMuc.ValueMember = "MaDM";
                addLoaiTK();
                dgvStyle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void icPrevious_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtSoTrang.Text);

            if (page > 1)
                page--;

            txtSoTrang.Text = page.ToString();
        }

        private void icNext_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtSoTrang.Text);
            int sumRecord = data.TongSP();
            int lastPage = sumRecord / 7;

            if (sumRecord % 7 != 0)
                lastPage++;

            if (page < lastPage)
                page++;
            txtSoTrang.Text = page.ToString();
        }

        private void txtSoTrang_TextChanged(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = data.showSPPanging(int.Parse(txtSoTrang.Text));
        }
        //lấy giá trị mã sản phẩm
        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSanPham.SelectedRows)
            {
                maSanPham = row.Cells[0].Value.ToString();
            }
        }

        private void ibtnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cbbKieuTK.SelectedItem.ToString().Equals("Mã sản phẩm") || cbbKieuTK.SelectedItem.ToString().Equals("Tên sản phẩm"))
                {
                    if (string.IsNullOrWhiteSpace(txtTuKhoaTK.Text))
                    {
                        MessageBox.Show("Từ khóa tìm kiếm không được để trắng !!!");
                    }
                    else
                    {
                        if (cbbKieuTK.SelectedItem.ToString().Equals("Mã sản phẩm"))
                        {
                            dgvSanPham.DataSource = data.TimSanPham("MaSanPham", txtTuKhoaTK.Text);
                            if (dgvSanPham.Rows.Count==0)
                            {
                                MessageBox.Show("Không tìm thấy sản phẩm nào có mã là '"+txtTuKhoaTK.Text+"'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (cbbKieuTK.SelectedItem.ToString().Equals("Tên sản phẩm"))
                        {
                            dgvSanPham.DataSource = data.TimSanPham("TenSP", txtTuKhoaTK.Text);
                            if (dgvSanPham.Rows.Count == 0)
                            {
                                MessageBox.Show("Không tìm thấy sản phẩm nào có tên là '" + txtTuKhoaTK.Text + "'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void icb_them_Click(object sender, EventArgs e)
        {
            fThemSanPham frmThem = new fThemSanPham();
            if (Application.OpenForms["fSuaSanPham"] == null)
            {
                frmThem.Show();
            }
        }

        private void icb_sua_Click(object sender, EventArgs e)
        {
            fSuaSanPham frmSua = new fSuaSanPham();
            frmSua.Sender(maSanPham);
            if (Application.OpenForms["fSuaSanPham"] == null)
            {
                frmSua.Show();
            }
        }

        private void icb_reload_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = data.showSPPanging(1);
            txtTuKhoaTK.Clear();
            txtSoTrang.Text = "1";
            icb_sua.Visible = true;
            icb_them.Visible = true;
            icb_pdf.Visible = true;
            icb_excel.Visible = true;
            ibtnSearch.Enabled = true;
            icbLoc.Enabled = true;
        }
        private void icbLoc_Click_1(object sender, EventArgs e)
        {
            lblDanhMuc.Text = cbbDanhMuc.SelectedValue.ToString();
            try
            {
                DataTable tblSP = new DataTable();
                tblSP = data.showSPInDM(cbbDanhMuc.SelectedValue.ToString());
                dgvSanPham.DataSource = tblSP;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtTuKhoaTK_Click(object sender, EventArgs e)
        {
            txtTuKhoaTK.Text = "";
        }

        private void cbbKieuTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTuKhoaTK.Text = "";
        }

        private void txtTuKhoaTK_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ibtnSearch_Click_1(sender, e);
            }    
        }
        public void refreshData()
        {
            dgvSanPham.DataSource = data.showSPPanging(int.Parse(txtSoTrang.Text));
        }

        private void txtSoTrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ktra chỉ cho phép người dùng nhập vào số và các kí tự điều khiển để xóa khi nhập sai
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void linkDSSPNgungBan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dgvSanPham.DataSource = data.getSPNgungBan();
            icb_sua.Visible = false;
            icb_them.Visible = false;
            icb_pdf.Visible = false;
            icb_excel.Visible = false;
            ibtnSearch.Enabled = false;
            icbLoc.Enabled = false;
        }

        private void icb_excel_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                app.Workbooks.Add();
                Microsoft.Office.Interop.Excel.Worksheet worksheet = default(Microsoft.Office.Interop.Excel.Worksheet);
                worksheet = app.Sheets["Sheet1"];
                app.Visible = true;

                DataTable dt = data.showSanPham();
                if (dt.Rows.Count > 0)
                {
                    // style header
                    worksheet.Cells[2, 4].value = "DANH SÁCH SẢN PHẨM";
                    worksheet.Cells[2, 4].FONT.NAME = "Calibri";
                    worksheet.Cells[2, 4].Font.Bold = true;
                    worksheet.Cells[2, 4].Font.Size = 20;
                    worksheet.get_Range("D2", "J2").Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    // merge header
                    worksheet.Range["D2:J2"].MergeCells = true;
                    worksheet.Range["D3:J3"].MergeCells = true;
                    int row = 7;
                    // show collum tittle
                    worksheet.Cells[row - 1, 4].value = "Mã sản phẩm";
                    worksheet.Cells[row - 1, 5].value = "Tên";
                    worksheet.Cells[row - 1, 6].value = "Nhà sản xuất";
                    worksheet.Cells[row - 1, 7].value = "Mô tả";
                    worksheet.Cells[row - 1, 8].value = "Đơn vị";
                    worksheet.Cells[row - 1, 9].value = "Giá";
                    worksheet.Cells[row - 1, 10].value = "Mã danh mục";
                    // import data
                    for (var i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        worksheet.Cells[row, 4].value = dt.Rows[i]["MaSanPham"];
                        worksheet.Cells[row, 5].value = dt.Rows[i]["TenSP"];
                        worksheet.Cells[row, 6].value = dt.Rows[i]["NhaSX"];
                        worksheet.Cells[row, 7].value = dt.Rows[i]["MoTa"];
                        worksheet.Cells[row, 8].value = dt.Rows[i]["DonViTinh"];
                        worksheet.Cells[row, 9].value = dt.Rows[i]["GiaBan"];
                        worksheet.Cells[row, 10].value = dt.Rows[i]["MaDM"];
                        row = row + 1;
                    }
                    app.ActiveCell.Worksheet.Cells[7, 4].AutoFormat(ExcelAutoFormat.xlRangeAutoFormatList2);
                    app = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void icb_pdf_Click(object sender, EventArgs e)
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
                    // danh sách sản phẩm
                    Phrase phrase5 = new Phrase("\nDANH SÁCH SẢN PHẨM", fontHearder);
                    PdfPCell pcell5 = new PdfPCell(phrase5);
                    pcell5.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell5.Colspan = 2;
                    pcell5.HorizontalAlignment = Element.ALIGN_CENTER;
                    pcell5.PaddingTop = 10;
                    pcell5.PaddingBottom = 10;
                    ptable.AddCell(pcell5);
                    dgvSanPham.DataSource = data.showSanPham_TenDM();
                    PdfPTable ptable1 = new PdfPTable(dgvSanPham.Columns.Count - 1);

                    ptable1.DefaultCell.Padding = 10;
                    ptable1.WidthPercentage = 100;
                    ptable1.HorizontalAlignment = Element.ALIGN_CENTER;
                    ptable1.DefaultCell.BorderWidth = 1;
                    float[] columnsWidth = { 1, 1.6f, 1f, 0.7f, 0.8f, 1, 1 };
                    ptable1.SetWidths(columnsWidth);
                    //Header bảng sản phẩm
                    foreach (DataGridViewColumn col in dgvSanPham.Columns)
                    {
                        bool validCol;
                        if (col is DataGridViewCheckBoxColumn || col is DataGridViewImageColumn)
                        {
                            validCol = false;
                        }
                        else
                        {
                            validCol = true;
                        }

                        if (validCol)
                        {
                            PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText, fontBold));
                            pCell.HorizontalAlignment = Element.ALIGN_CENTER;
                            pCell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                            ptable1.AddCell(pCell);
                        }
                    }
                    //Thêm các data cho bảng
                    for (int i = 0; i < dgvSanPham.Rows.Count; i++)
                    {
                        bool f;
                        DataGridViewRow viewRow = dgvSanPham.Rows[i];
                        foreach (DataGridViewCell dcell in viewRow.Cells)
                        {
                            if (dcell.GetType() == typeof(DataGridViewCheckBoxCell) || dcell.GetType() == typeof(DataGridViewImageCell))
                            {
                                f = false;
                            }
                            else
                            {
                                f = true;
                            }

                            if (f == true)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(dcell.Value.ToString(), text));
                                pCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                ptable1.AddCell(pCell);
                            }
                        }
                    }

                    Paragraph parablank = new Paragraph(" ", text);

                    document.Add(ptable);
                    document.Add(parablank);
                    document.Add(ptable1);
                    document.Close();
                    fileStream.Close();
                    MessageBox.Show("Xuất file thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    icb_reload_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

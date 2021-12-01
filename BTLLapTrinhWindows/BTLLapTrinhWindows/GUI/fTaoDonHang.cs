using BTLLapTrinhWindows.Classes;
using BTLLapTrinhWindows.Proccessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace BTLLapTrinhWindows.GUI
{
    public partial class fTaoDonHang : Form
    {
        DBProccessing_TaoDonHang datapro = new DBProccessing_TaoDonHang();
        List<ChiTietHoaDonBan> ListHDB = new List<ChiTietHoaDonBan>();
        List<KhachHang> ListKH = new List<KhachHang>(); // Thêm
        string maHDB;
        string maKH;
        public fTaoDonHang()
        {
            InitializeComponent();
            cbb_dmsp.DataSource = datapro.GetTable_TinhTrang_1("DanhMucSanPham");
            cbb_dmsp.DisplayMember = "TenDM";
            cbb_dmsp.ValueMember = "MaDM";
            cbb_dmsp.SelectedItem = cbb_dmsp.Items[0];
            LaySanPham(cbb_dmsp.SelectedValue.ToString());

            TaoMaHDB();
            //TaoMaKhachHang();
            LaySoLuongConTheoMaSP(cbb_sanpham.SelectedValue.ToString());
            //Thêm
            DataTable t = datapro.GetTable_TinhTrang_1("KhachHang");
            foreach(DataRow r in t.Rows)
            {
                ListKH.Add(new KhachHang(r[0].ToString(), r[1].ToString(), r[2].ToString()));                
            }
            ListKH.RemoveAt(0);
        }
        void LaySanPham(string maDM)
        {
            cbb_sanpham.DataSource = datapro.GetSP_maDM(maDM);
            cbb_sanpham.DisplayMember = "TenSP";
            cbb_sanpham.ValueMember = "MaSanPham";
        }
        //Thêm
        void ThongTinKH()
        {
            if (ckb_KH.Checked)
            {
                cbb_KH.Enabled = true;
                cbb_KH.Items.Clear();
                foreach(KhachHang k in ListKH)
                {
                    cbb_KH.Items.Add(k.maKH + " - " + k.tenKH + " - " + k.sdt);
                }
                txt_tenkh.Enabled = false;
                txt_sdtkh.Enabled = false;
            }
            else
            {
                cbb_KH.Enabled = false;
                txt_tenkh.Clear();
                txt_sdtkh.Clear();
                txt_tenkh.Enabled = true;
                txt_sdtkh.Enabled = true;
            }
        }
        private void cbb_dmsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            LaySanPham(cbb_dmsp.SelectedValue.ToString());
        }
        public System.Drawing.Image ConvertByArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }

        private void cbb_sanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable t = datapro.GetSP_Ma(cbb_sanpham.SelectedValue.ToString());
            DataRow r = t.Rows[0];
            ptb_anhsp.Image = ConvertByArrayToImage((byte[])r["AnhSP"]);
            LaySoLuongConTheoMaSP(cbb_sanpham.SelectedValue.ToString());
            
        }
        void TaoMaHDB()
        {
            maHDB = datapro.MaCuoiBang("HoaDonBan","HDB0000000");
            int so = int.Parse(maHDB.Substring(3)) + 1;
            if (so < 10)
                maHDB = "HDB000000" + so;
            else if (so >= 10 && so < 100)
                maHDB = "HDB00000" + so;
            else if (so >= 100 && so < 1000)
                maHDB = "HDB0000" + so;
            else if (so >= 1000 && so < 10000)
                maHDB = "HDB000" + so;
            else if (so >= 10000 && so < 100000)
                maHDB = "HDB00" + so;
            else if (so >= 100000 && so < 1000000)
                maHDB = "HDB0" + so;
            else maHDB = "HDB" + so;
            txt_mahdb.Text = maHDB;
        }
        void TaoMaKhachHang()
        {
            maKH = datapro.MaCuoiBang("KhachHang","KH000");
            int so = int.Parse(maKH.Substring(2)) + 1;
            if (so < 10)
                maKH = "KH00" + so;
            else if (so >= 10 && so < 100)
                maKH = "KH0" + so;
            else maKH = "KH" + so;
            //txt_makh.Text = maKH;
        }
        void LaySoLuongConTheoMaSP(string ma)
        {
            DataTable t = datapro.LayBangSanPhamCon(ma);
            DataRow r = t.Rows[0];
            txt_soluongcon.Text = r[1].ToString();
        }
        private void butThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_soluongmua.Text))
                    throw new Exception("Không được để trống số lượng mua!");
                if (int.Parse(txt_soluongmua.Text) <= 0)
                    throw new Exception("Số lượng mua phải > 0!");
                if (int.Parse(txt_soluongmua.Text) > int.Parse(txt_soluongcon.Text))
                    throw new Exception("Số lượng mua phải <= số lượng còn!");
                if (ListHDB.Find(x => x.maSanPham == cbb_sanpham.SelectedValue.ToString()) != null)
                    throw new Exception("Mã sản phẩm này đã tồn tại!");
                ChiTietHoaDonBan c = new ChiTietHoaDonBan();
                c.maHoaDonBan = txt_mahdb.Text;
                c.maSanPham = cbb_sanpham.SelectedValue.ToString();
                c.tenSanPham = cbb_sanpham.Text;
                c.gia = datapro.LayGiaSanPham(cbb_sanpham.SelectedValue.ToString());
                c.soLuongBan = int.Parse(txt_soluongmua.Text);
                txt_soluongcon.Text = (int.Parse(txt_soluongcon.Text) - c.soLuongBan).ToString();
                c.soLuongCon = int.Parse(txt_soluongcon.Text);
                ListHDB.Add(c);
                HienThi();
                txt_soluongmua.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void HienThi()
        {
            dgv_sanpham.Rows.Clear();
            float gia = 0;
            foreach(ChiTietHoaDonBan c in ListHDB)
            {
                dgv_sanpham.Rows.Add(c.maSanPham, c.tenSanPham, c.gia, c.soLuongBan, string.Format("{0:0,0}", c.ThanhTien()));
                gia += c.ThanhTien();
            }
            if(ListHDB.Count > 0)
            {

                txt_tongtien.Text = string.Format("{0:0,0}", gia);
                txt_soluongcon.Text = ListHDB.Find(x => x.maSanPham == cbb_sanpham.SelectedValue.ToString()).soLuongCon.ToString();
            }
            else
            {
                txt_tongtien.Clear();
                txt_soluongcon.Clear();
                txt_soluongmua.Clear();
            }
        }

        private void dgv_sanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txt_soluongmua.Text = dgv_sanpham.Rows[i].Cells[3].Value.ToString();
                DataTable t = datapro.GetSP_Ma(dgv_sanpham.Rows[i].Cells[0].Value.ToString());
                DataRow r = t.Rows[0];
                cbb_dmsp.SelectedValue = r["MaDM"];
                cbb_sanpham.SelectedValue = r["MaSanPham"];
                txt_soluongcon.Text = ListHDB.Find(x => x.maSanPham == dgv_sanpham.Rows[i].Cells[0].Value.ToString()).soLuongCon.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietHoaDonBan c = ListHDB.Find(x => x.maSanPham == cbb_sanpham.SelectedValue.ToString());
                int i = ListHDB.FindIndex(x => x.maSanPham == cbb_sanpham.SelectedValue.ToString());
                int slMuaCu = c.soLuongBan;
                int slMuaMoi = int.Parse(txt_soluongmua.Text);
                if (slMuaMoi <= 0)
                    throw new Exception("Số lượng mua phải> 0!");
                int slCon = c.soLuongCon+ slMuaCu - slMuaMoi;
                if (slCon < 0)
                    throw new Exception("Không đủ số lượng sản phẩm này!");
                ListHDB[i].soLuongBan = slMuaMoi;
                ListHDB[i].soLuongCon = slCon;
                HienThi();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Bạn chắc chắn xóa?","Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ChiTietHoaDonBan cthdb = ListHDB.Find(x => x.maSanPham == cbb_sanpham.SelectedValue.ToString());
                    txt_soluongcon.Text = (cthdb.soLuongCon + cthdb.soLuongBan).ToString();
                    ListHDB.Remove(ListHDB.Find(x => x.maSanPham == cbb_sanpham.SelectedValue.ToString()));
                    
                    dgv_sanpham.Rows.Clear();
                    float gia = 0;
                    foreach (ChiTietHoaDonBan c in ListHDB)
                    {
                        dgv_sanpham.Rows.Add(c.maSanPham, c.tenSanPham, c.gia, c.soLuongBan, string.Format("{0:0,0}", c.ThanhTien()));
                        gia += c.ThanhTien();
                    }
                    txt_tongtien.Text = string.Format("{0:0,0}", gia);
                    txt_soluongmua.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Thêm sửa
        private void butSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_sdtkh.Text))
            {
                if(txt_sdtkh.Text.Length < 10 || txt_sdtkh.Text.Length > 10)
                {
                    MessageBox.Show("Số điện thoại phải có đủ 10 số!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_sdtkh.Clear();
                    txt_sdtkh.Focus();
                    return;
                }
            }
            try
            {
                if (string.IsNullOrWhiteSpace(txt_tenkh.Text) || string.IsNullOrWhiteSpace(txt_sdtkh.Text))
                    maKH = "KH000";
                else maKH = datapro.LayMaKH(txt_tenkh.Text, txt_sdtkh.Text);
                if (dgv_sanpham.Rows.Count == 0)
                    throw new Exception("Cần thêm sản phẩm cho hóa đơn !");                
                if (maKH == "")
                {
                    TaoMaKhachHang();
                    datapro.Insert_KhachHang(maKH, txt_tenkh.Text, txt_sdtkh.Text);
                }                
                datapro.Insert_HoaDonBan(txt_mahdb.Text, maKH, fDangNhap.tt_ma.Text, dtp_ngaylap.Value, float.Parse(txt_tongtien.Text));
                foreach(ChiTietHoaDonBan c in ListHDB)
                {
                    datapro.Insert_ChiTietHoaDonBan(c.maHoaDonBan,c.maSanPham,c.soLuongBan);
                }
                LamMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void LamMoi()
        {
            ListHDB.Clear();
            txt_tongtien.Clear();
            txt_tenkh.Clear();
            txt_sdtkh.Clear();
            TaoMaHDB();
            dgv_sanpham.Rows.Clear();
            txt_soluongmua.Clear();
            LaySoLuongConTheoMaSP(cbb_sanpham.SelectedValue.ToString());
        }
        private void butNew_Click(object sender, EventArgs e)
        {
            if(dgv_sanpham.Rows.Count > 0)
            {
                if(MessageBox.Show("Bạn có muốn lưu hóa đơn này?","Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    butSave_Click(sender, e);
                }
            }
            LamMoi();
        }

        private void txt_sdtkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void butPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_sanpham.Rows.Count == 0)
                    throw new Exception("Hóa đơn cần có ít nhất 1 sản phẩm!");
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
                    Phrase phrase5 = new Phrase("\nHÓA ĐƠN BÁN", fontHearder);
                    PdfPCell pcell5 = new PdfPCell(phrase5);
                    pcell5.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell5.Colspan = 2;
                    pcell5.HorizontalAlignment = Element.ALIGN_CENTER;
                    pcell5.PaddingTop = 10;
                    pcell5.PaddingBottom = 10;
                    ptable.AddCell(pcell5);
                    //Ngày lập hóa đơn
                    Phrase phrase10 = new Phrase("\nNgày lập: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), fontBold);
                    PdfPCell pcell10 = new PdfPCell(phrase10);
                    pcell10.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell10.HorizontalAlignment = Element.ALIGN_RIGHT;
                    pcell10.Colspan = 2;
                    ptable.AddCell(pcell10);
                    //Mã hóa đơn
                    Phrase phrase6 = new Phrase("\nMã hóa đơn:  " + txt_mahdb.Text, text);
                    PdfPCell pcell6 = new PdfPCell(phrase6);
                    pcell6.Colspan = 2;
                    pcell6.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell6.HorizontalAlignment = Element.ALIGN_LEFT;
                    pcell6.PaddingBottom = 5;
                    ptable.AddCell(pcell6);
                    //Nhân viên
                    Phrase phrase7 = new Phrase("\nNhân viên:   " + fMain.lbTenNV.Text, text);
                    PdfPCell pcell7 = new PdfPCell(phrase7);
                    pcell7.Colspan = 2;
                    pcell7.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell7.HorizontalAlignment = Element.ALIGN_LEFT;
                    ptable.AddCell(pcell7);
                    //Khách hàng
                    if (string.IsNullOrWhiteSpace(txt_tenkh.Text))
                        txt_tenkh.Text = "Khách lẻ";
                    Phrase phrase8 = new Phrase("\nKhách hàng:  " + txt_tenkh.Text, text);
                    PdfPCell pcell8 = new PdfPCell(phrase8);
                    pcell8.Colspan = 1;
                    pcell8.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    pcell8.HorizontalAlignment = Element.ALIGN_LEFT;
                    pcell8.PaddingBottom = 10;
                    ptable.AddCell(pcell8);
                    //Điện thoại khách hàng
                    Phrase phrase81 = new Phrase("\nĐiện thoại:  " + txt_sdtkh.Text, text);
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
                    float[] columnsWidth = { 1, 1.6f, 0.8f, 0.8f, 0.8f };
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
                    for(int i = 0; i< dgv_sanpham.Rows.Count;i++)
                    {
                        DataGridViewRow viewRow = dgv_sanpham.Rows[i];
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
                    Phrase phrase9 = new Phrase("\nTổng tiền: " + txt_tongtien.Text + " VNĐ", fontBold);
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
                    //butNew_Click(sender, e);
                    try
                    {
                        System.Diagnostics.Process.Start("explorer.exe", s.FileName); // XML NHẬP
                    }
                    catch (Exception)
                    {
                        System.Diagnostics.Process.Start("msedge.exe", s.FileName);

                    }
                    butSave_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Thêm
        private void cbb_KH_SelectedIndexChanged(object sender, EventArgs e)
        {
            int d = cbb_KH.SelectedIndex;
            txt_tenkh.Text = ListKH[d].tenKH;
            txt_sdtkh.Text = ListKH[d].sdt;
        }
        //Thêm
        private void ckb_KH_CheckedChanged(object sender, EventArgs e)
        {
            ThongTinKH();
        }

        private void txt_tenkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_soluongmua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}

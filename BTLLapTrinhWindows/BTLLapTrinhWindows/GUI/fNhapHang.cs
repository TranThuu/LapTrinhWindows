using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTLLapTrinhWindows.Classes;
using BTLLapTrinhWindows.Proccessing;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace BTLLapTrinhWindows.GUI
{
    public partial class fNhapHang : Form
    {
        string maHDN;
        string maNCC;
        bool themNCC = false;
        bool isCreated = false;
        DBProccessing_NhapHang dt = new DBProccessing_NhapHang();
        List<ChiTietHoaDonNhap> lstHoaDonNhap = new List<ChiTietHoaDonNhap>();
        public fNhapHang()
        {
            InitializeComponent();
        }

        private void fNhapHang_Load(object sender, EventArgs e)
        {
            ptbAnhSP.SizeMode = PictureBoxSizeMode.StretchImage;
            cbbDanhMucSP.DataSource = dt.GetTableDK("DanhMucSanPham");
            cbbDanhMucSP.DisplayMember = "TenDM";
            cbbDanhMucSP.ValueMember = "MaDM";
            cbbDanhMucSP.SelectedItem = cbbDanhMucSP.Items[0];
            //lấy sp theo DM
            getSPByDM(cbbDanhMucSP.SelectedValue.ToString());
            //lấy SL có của SP
            getSLCoOfSP(cbbSanPham.SelectedValue.ToString());
            //lấy mã nhân viên
            cbbTenNV.DataSource = dt.GetTableDK("NhanVien");
            cbbTenNV.DisplayMember = "TenNV";
            cbbTenNV.ValueMember = "MaNV";
            cbbTenNV.Text = fMain.lbTenNV.Text;
            //Tạo mã hóa đơn nhập
            TaoMaHDNhap();
            //
            autoCompleteTenNCC();
        }
        void getSPByDM(string maDM)
        {
            cbbSanPham.DataSource = dt.GetSPBy_MaDM(maDM);
            cbbSanPham.DisplayMember = "TenSP";
            cbbSanPham.ValueMember = "MaSanPham";
        }
        void getSLCoOfSP(string maSP)
        {
            DataTable tbl = dt.GetSLCoBySP(maSP);
            DataRow r = tbl.Rows[0];
            txtSoLuongCon.Text = r[1].ToString();
        }    
        private void cbbDanhMucSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            getSPByDM(cbbDanhMucSP.SelectedValue.ToString());
        }

        private void cbbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable t = dt.GetSPByID(cbbSanPham.SelectedValue.ToString());
            DataRow r = t.Rows[0];
            ptbAnhSP.Image = ConvertByArrayToImage((byte[])r["AnhSP"]);
            getSLCoOfSP(cbbSanPham.SelectedValue.ToString());
        }

        void TaoMaHDNhap()
        {
            maHDN = dt.MaCuoiBang("HoaDonNhap");
            int so = int.Parse(maHDN.Substring(3)) + 1;
            if (so < 10)
                maHDN = "HDN000000" + so;
            else if (so >= 10 && so < 100)
                maHDN = "HDN00000" + so;
            else if (so >= 100 && so < 1000)
                maHDN = "HDN0000" + so;
            else if (so >= 1000 && so < 10000)
                maHDN = "HDN000" + so;
            else if (so >= 10000 && so < 100000)
                maHDN = "HDN00" + so;
            else if (so >= 100000 && so < 1000000)
                maHDN = "HDN0" + so;
            else maHDN = "HDN" + so;
            txtMaHDNhap.Text = maHDN;
        }
        void TaoMaNCC()
        {
            maNCC = dt.MaCuoiBang("NhaCungCap");
            int so = int.Parse(maNCC.Substring(3)) + 1;
            if (so < 10)
                maNCC = "NCC0" + so;
            else if (so >= 10 && so < 100)
                maNCC = "NCC" + so;
            txtMaNCC.Text = maNCC;
        }
        public System.Drawing.Image ConvertByArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }

        void autoCompleteTenNCC()
        {
            AutoCompleteStringCollection tenNCC = new AutoCompleteStringCollection();
            DataTable nhaCC = dt.GetTableDK("NhaCungCap");
            foreach (DataRow row in nhaCC.Rows)
            {
                tenNCC.Add(row["TenNCC"].ToString());
            }
            txtTenNCC.AutoCompleteCustomSource = tenNCC;
        }

        private void txtTenNCC_TextChanged(object sender, EventArgs e)
        {
            DataTable tblnhaCC = dt.GetNCCByName(txtTenNCC.Text);
            if(tblnhaCC.Rows.Count==0)
            {
                themNCC = true;
                TaoMaNCC();
                txtSDT.Clear();
                txtDiaChi.Clear();
            }
            else
            {
                themNCC = false;
                DataRow r = tblnhaCC.Rows[0];
                txtMaNCC.Text = r["MaNhaCC"].ToString();
                txtSDT.Text = r["SDT"].ToString();
                txtDiaChi.Text = r["DiaChi"].ToString();
            }
        }
       
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValiDataNCC())
                {
                    if (dgvDSSanPham.Rows.Count <= 0)
                    {
                        throw new Exception("Cần thêm sản phẩm cho hóa đơn !");
                    }
                    if(themNCC==true)
                    {
                        dt.themNCC(txtMaNCC.Text, txtTenNCC.Text, txtSDT.Text, txtDiaChi.Text);
                    }    
                    dt.themHDNhap(txtMaHDNhap.Text, dtpNgayNhap.Value.ToString("yyyy-MM-dd"), float.Parse(txtTongTien.Text), cbbTenNV.SelectedValue.ToString(), txtMaNCC.Text);
                    foreach (ChiTietHoaDonNhap nhap in lstHoaDonNhap)
                    {
                        dt.themChiTietHDNhap(nhap.maHDNhap, nhap.maSP, nhap.soLuongNhap, nhap.giaNhap);
                    }
                    DialogResult kq=MessageBox.Show("Tạo hóa đơn nhập thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isCreated = true;  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValiDataSlNhap())
                {
                    if (lstHoaDonNhap.Find(x => x.maSP == cbbSanPham.SelectedValue.ToString()) != null)
                        throw new Exception("Mã sản phẩm này đã tồn tại!");
                    ChiTietHoaDonNhap hdNhap = new ChiTietHoaDonNhap();
                    hdNhap.maHDNhap = txtMaHDNhap.Text;
                    hdNhap.maSP = cbbSanPham.SelectedValue.ToString();
                    hdNhap.tenSP = cbbSanPham.Text;
                    hdNhap.giaNhap = int.Parse(txtGiaNhap.Text);
                    hdNhap.soLuongNhap = int.Parse(txtSoLuongNhap.Text);
                    txtSoLuongCon.Text = (int.Parse(txtSoLuongCon.Text) + hdNhap.soLuongNhap).ToString();
                    hdNhap.soLuongCon = int.Parse(txtSoLuongCon.Text);
                    lstHoaDonNhap.Add(hdNhap);
                    dgvHienThi();
                    txtSoLuongNhap.Text = "";
                    txtGiaNhap.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvHienThi()
        {
            dgvDSSanPham.Rows.Clear();
            float tongTien = 0;
            foreach (ChiTietHoaDonNhap nhap in lstHoaDonNhap)
            {
                dgvDSSanPham.Rows.Add(nhap.maSP, nhap.tenSP, nhap.giaNhap, nhap.soLuongNhap, string.Format("{0:0,0}", nhap.ThanhTien()));
                tongTien += nhap.ThanhTien();
            }
            if (lstHoaDonNhap.Count > 0)
            {

                txtTongTien.Text = string.Format("{0:0,0}", tongTien);
                //txtSoLuongCon.Text = lstHoaDonNhap.Find(x => x.maSP == cbbSanPham.SelectedValue.ToString()).soLuongCon.ToString();
            }
            else
            {
                txtTongTien.Clear();
                txtSoLuongCon.Clear();
                txtSoLuongNhap.Clear();
                txtGiaNhap.Clear();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietHoaDonNhap nhap = lstHoaDonNhap.Find(x => x.maSP == cbbSanPham.SelectedValue.ToString());
                int i = lstHoaDonNhap.FindIndex(x => x.maSP == cbbSanPham.SelectedValue.ToString());
                int slNhapCu = nhap.soLuongNhap;
                int slNhapMoi = int.Parse(txtSoLuongNhap.Text);
                if (ValiDataSlNhap())
                {
                    int slCon = nhap.soLuongCon + slNhapMoi - slNhapCu;
                    lstHoaDonNhap[i].soLuongNhap = slNhapMoi;
                    lstHoaDonNhap[i].soLuongCon = slCon;
                    lstHoaDonNhap[i].giaNhap = int.Parse(txtGiaNhap.Text);
                    txtSoLuongCon.Text = lstHoaDonNhap.Find(x => x.maSP == cbbSanPham.SelectedValue.ToString()).soLuongCon.ToString();
                    dgvHienThi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa sản phẩm '"+cbbSanPham.Text+"'?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ChiTietHoaDonNhap cthdn = lstHoaDonNhap.Find(x => x.maSP == cbbSanPham.SelectedValue.ToString());
                    txtSoLuongCon.Text = (cthdn.soLuongCon - cthdn.soLuongNhap).ToString();
                    lstHoaDonNhap.Remove(lstHoaDonNhap.Find(x => x.maSP == cbbSanPham.SelectedValue.ToString()));
                    //dgvHienThi();
                    dgvDSSanPham.Rows.Clear();
                    float tongTien = 0;
                    foreach (ChiTietHoaDonNhap nhap in lstHoaDonNhap)
                    {
                        dgvDSSanPham.Rows.Add(nhap.maSP, nhap.tenSP, nhap.giaNhap, nhap.soLuongNhap, string.Format("{0:0,0}", nhap.ThanhTien()));
                        tongTien += nhap.ThanhTien();
                    }
                    txtTongTien.Text = string.Format("{0:0,0}", tongTien);
                    txtSoLuongNhap.Clear();
                    txtGiaNhap.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValiDataNCC()
        {
            if (txtTenNCC.Text == "")
            {
                MessageBox.Show("Tên nhà cung cấp không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNCC.Focus();
                return false;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Số điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return false;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ nhà cung cấp không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return false;
            }
            return true;
        }
        private bool ValiDataSlNhap()
        {
            if (txtSoLuongNhap.Text == "")
            {
                MessageBox.Show("Số lượng nhập không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuongNhap.Focus();
                return false;
            }
            else
            {
                try
                {
                    int.Parse(txtSoLuongNhap.Text);
                    if (int.Parse(txtSoLuongNhap.Text) <= 0)
                    {
                        MessageBox.Show("Số lượng nhập lớn hơn 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSoLuongNhap.Focus();
                        return false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Bạn phải nhập vào một số nguyên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoLuongNhap.Focus();
                    return false;
                }
            }
            //giá nhập
            if (txtGiaNhap.Text == "")
            {
                MessageBox.Show("Giá nhập không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiaNhap.Focus();
                return false;
            }
            else
            {
                try
                {
                    int.Parse(txtGiaNhap.Text);
                    if (int.Parse(txtGiaNhap.Text) <= 0)
                    {
                        MessageBox.Show("Giá phải lớn hơn 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtGiaNhap.Focus();
                        return false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Bạn phải nhập vào một số nguyên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGiaNhap.Focus();
                    return false;
                }
            }
            return true;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            lstHoaDonNhap.Clear();
            dgvDSSanPham.Rows.Clear();
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtSoLuongNhap.Text = "";
            txtGiaNhap.Text = "";
            TaoMaHDNhap();
        }

        private void dgvDSSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtSoLuongNhap.Text = dgvDSSanPham.Rows[i].Cells[3].Value.ToString();
                DataTable tbl = dt.GetSPByID(dgvDSSanPham.Rows[i].Cells[0].Value.ToString());
                DataRow row = tbl.Rows[0];
                cbbDanhMucSP.SelectedValue = row["MaDM"];
                cbbSanPham.SelectedValue = row["MaSanPham"];
                txtSoLuongCon.Text = lstHoaDonNhap.Find(x => x.maSP == dgvDSSanPham.Rows[i].Cells[0].Value.ToString()).soLuongCon.ToString();
                txtGiaNhap.Text= dgvDSSanPham.Rows[i].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnPDF_Click(object sender, EventArgs e)
        {
            try
            {
                bool hasError = false;
                if(ValiDataNCC()==false)
                {
                    hasError = true;
                    return;
                }
                if(dgvDSSanPham.Rows.Count <= 0)
                {
                    throw new Exception("Hóa đơn phải có ít nhất một sản phẩm");
                }    
                if(isCreated == false)
                {
                    btnCreate_Click(sender, e);
                }    
                if(hasError==false)
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
                        //Phần title hóa đơn nhập
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
                        // Hóa đơn nhập
                        Phrase phrase5 = new Phrase("\nHÓA ĐƠN NHẬP", fontHearder);
                        PdfPCell pcell5 = new PdfPCell(phrase5);
                        pcell5.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pcell5.Colspan = 2;
                        pcell5.HorizontalAlignment = Element.ALIGN_CENTER;
                        pcell5.PaddingTop = 10;
                        pcell5.PaddingBottom = 10;
                        ptable.AddCell(pcell5);
                        //Ngày lập hóa đơn
                        Phrase phrase10 = new Phrase("\nNgày nhập: " + dtpNgayNhap.Text, fontBold);
                        PdfPCell pcell10 = new PdfPCell(phrase10);
                        pcell10.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pcell10.HorizontalAlignment = Element.ALIGN_RIGHT;
                        pcell10.Colspan = 2;
                        ptable.AddCell(pcell10);
                        //Mã hóa đơn
                        Phrase phrase6 = new Phrase("\nMã hóa đơn:  " + txtMaHDNhap.Text, text);
                        PdfPCell pcell6 = new PdfPCell(phrase6);
                        pcell6.Colspan = 2;
                        pcell6.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pcell6.HorizontalAlignment = Element.ALIGN_LEFT;
                        pcell6.PaddingBottom = 5;
                        ptable.AddCell(pcell6);
                        //Nhân viên
                        Phrase phrase7 = new Phrase("\nNhân viên:   " + cbbTenNV.Text, text);
                        PdfPCell pcell7 = new PdfPCell(phrase7);
                        pcell7.Colspan = 2;
                        pcell7.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pcell7.HorizontalAlignment = Element.ALIGN_LEFT;
                        ptable.AddCell(pcell7);
                        //Nhà cung cấp
                        Phrase phrase8 = new Phrase("\nNhà cung cấp:  " + txtTenNCC.Text, text);
                        PdfPCell pcell8 = new PdfPCell(phrase8);
                        pcell8.Colspan = 1;
                        pcell8.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pcell8.HorizontalAlignment = Element.ALIGN_LEFT;
                        pcell8.PaddingBottom = 10;
                        ptable.AddCell(pcell8);
                        //Điện thoại ncc
                        Phrase phrase81 = new Phrase("\nĐiện thoại:  " + txtSDT.Text, text);
                        PdfPCell pcell81 = new PdfPCell(phrase81);
                        pcell81.Colspan = 1;
                        pcell81.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        pcell81.HorizontalAlignment = Element.ALIGN_LEFT;
                        pcell81.PaddingBottom = 10;
                        ptable.AddCell(pcell81);
                        //Bảng sản phẩm
                        PdfPTable ptable1 = new PdfPTable(dgvDSSanPham.Columns.Count);
                        ptable1.DefaultCell.Padding = 10;
                        ptable1.WidthPercentage = 100;
                        ptable1.HorizontalAlignment = Element.ALIGN_CENTER;
                        ptable1.DefaultCell.BorderWidth = 1;
                        float[] columnsWidth = { 1, 1.6f, 0.8f, 0.8f, 0.8f };
                        ptable1.SetWidths(columnsWidth);
                        //Header bảng sản phẩm
                        foreach (DataGridViewColumn col in dgvDSSanPham.Columns)
                        {
                            PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText, fontBold));
                            pCell.HorizontalAlignment = Element.ALIGN_CENTER;
                            pCell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                            ptable1.AddCell(pCell);
                        }
                        //Thêm các hàng cho bảng
                        for (int i = 0; i < dgvDSSanPham.Rows.Count; i++)
                        {
                            DataGridViewRow viewRow = dgvDSSanPham.Rows[i];
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
                        Phrase phrase9 = new Phrase("\nTổng tiền: " + txtTongTien.Text + "VNĐ", fontBold);
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
                    }
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ktra chỉ cho phép người dùng nhập vào số và các kí tự điều khiển để xóa khi nhập sai
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

using BTLLapTrinhWindows.Connection;
using BTLLapTrinhWindows.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;
namespace BTLLapTrinhWindows.Proccessing
{
    class DBProccessing_DanhSachSanPham
    {
        DBConnection dbConn = new DBConnection();
        public DataTable showSanPham()
        {
            string sql = "SELECT MaSanPham,TenSP,NhaSX,MoTa,DonViTinh,AnhSP,SanPham.MaDM,GiaBan FROM SanPham INNER JOIN DanhMucSanPham ON SanPham.MaDM=DanhMucSanPham.MaDM WHERE SanPham.TinhTrang=1";
            DataTable tblSanPham = new DataTable();
            tblSanPham = dbConn.GetTable(sql);
            return tblSanPham;
        }
        public DataTable showSanPham_TenDM()
        {
            string sql = "SELECT MaSanPham,TenSP,NhaSX,MoTa,DonViTinh,AnhSP,TenDM,GiaBan FROM SanPham INNER JOIN DanhMucSanPham ON SanPham.MaDM=DanhMucSanPham.MaDM WHERE SanPham.TinhTrang=1";
            DataTable tblSanPham = new DataTable();
            tblSanPham = dbConn.GetTable(sql);
            return tblSanPham;
        }
        public DataTable getSPDMById(string ma)
        {
            string sql = "SELECT * FROM SanPham INNER JOIN DanhMucSanPham ON SanPham.MaDM=DanhMucSanPham.MaDM WHERE MaSanPham ='" + ma + "' AND SanPham.TinhTrang=1";
            DataTable tblSanPham = new DataTable();
            tblSanPham = dbConn.GetTable(sql);
            return tblSanPham;
        }
        public DataTable showDanhMuc()
        {
            string sql = "SELECT * FROM DanhMucSanPham WHERE TinhTrang=1";
            DataTable tblDMSanPham = new DataTable();
            tblDMSanPham = dbConn.GetTable(sql);
            return tblDMSanPham;
        }
        public DataTable showSPInDM(string maDM)
        {
            string sql = "SELECT MaSanPham,TenSP,NhaSX,MoTa,DonViTinh,AnhSP,MaDM,GiaBan FROM SanPham WHERE MaDM LIKE '" + maDM + "' AND TinhTrang=1";
            DataTable tbl = new DataTable();
            tbl = dbConn.GetTable(sql);
            return tbl;
        }
        public DataTable TimSanPham(string kieuTK, string tuKhoa)
        {
            string sql = "SELECT MaSanPham,TenSP,NhaSX,MoTa,DonViTinh,AnhSP,MaDM,GiaBan FROM SanPham WHERE " + kieuTK + " LIKE N'%" + tuKhoa + "%' AND TinhTrang=1";
            DataTable tbl = new DataTable();
            tbl = dbConn.GetTable(sql);
            return tbl;
        }
        public DataTable showSPPanging(int page)
        {
            string sql = "EXEC SanPhamPanging '" + page + "'";
            DataTable tbl = new DataTable();
            tbl = dbConn.GetTable(sql);
            return tbl;
        }
        public int TongSP()
        {
            int tong = 0;
            string sql = "SELECT COUNT (*) FROM SanPham WHERE TinhTrang=1";
            tong = dbConn.ExecuteNonQueryNumber(sql);
            return tong;
        }
        //them,sua,xoa
        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        byte[] ConvertImageToByteArray(Image imageToConvert)
        {
            using (var ms = new MemoryStream())
            {
                Bitmap bmp = new Bitmap(imageToConvert);
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public void themSP(String ma, String tenSP, bool tt, String nsx, String mt, String dvt, Image anhSP, String maDM, int gia)
        {
            SqlConnection conn = dbConn.getConnection();
            conn.Open();
            String sql = " INSERT INTO SanPham  VALUES(N'" + ma + "',N'" + tenSP + "','" + tt + "',N'" + nsx + "',N'" + mt + "',N'" + dvt + "', @Anh,'" + maDM + "','" + gia + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Anh", ConvertImageToBytes(anhSP));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void suaSanPham(String ma, String tenSP, String nsx, String mt, String dvt, Image anhSP, String maDM, int gia, bool tt)
        {
            SqlConnection conn = dbConn.getConnection();
            conn.Open();
            string sql = "UPDATE SanPham  SET TenSP=N'" + tenSP + "',NhaSX=N'" + nsx + "',MoTa=N'" + mt + "',DonViTinh=N'" + dvt + "', AnhSP=@Anh,MaDM='" + maDM + "',GiaBan='" + gia + "', TinhTrang='"+tt+"' WHERE MaSanPham='"+ma+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Anh", ConvertImageToByteArray(anhSP));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void xoaSanPham(String ma)
        {
            SqlConnection conn = dbConn.getConnection();
            conn.Open();
            string sql = "UPDATE SanPham  SET TinhTrang=0 WHERE MaSanPham='" + ma + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataTable getAllSP()
        {
            string sql = "SELECT * FROM SanPham";
            DataTable tbl = dbConn.GetTable(sql);
            return tbl;
        }
        public string MaCuoiBang(string tenBang)
        {
            string maSP = "";
            DataTable t = getAllSP();
            if (t.Rows.Count == 0)
            {
                maSP = "SP00000000";
            }
            else
            {
                DataRow r = t.Rows[t.Rows.Count - 1];
                maSP = r[0].ToString();
            }
            return maSP;
        }
        public bool kiemTraTonTai(string ten, string nhasx, int gia,string maDM)
        {
            string sql = "SELECT * FROM SANPHAM WHERE TenSP=N'" + ten + "' AND NhaSX=N'" + nhasx + "' AND GiaBan='" + gia + "' AND MaDM='"+maDM+"' AND TinhTrang=1";
            DataTable tbl = dbConn.GetTable(sql);
            if(tbl.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public DataTable getSPNgungBan()
        {
            string sql = "SELECT MaSanPham,TenSP,NhaSX,MoTa,DonViTinh,AnhSP,SanPham.MaDM,GiaBan FROM SanPham INNER JOIN DanhMucSanPham ON SanPham.MaDM=DanhMucSanPham.MaDM WHERE SanPham.TinhTrang=0";
            DataTable tbl = new DataTable();
            tbl = dbConn.GetTable(sql);
            return tbl;
        }
    }
}

using BTLLapTrinhWindows.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLLapTrinhWindows.Proccessing
{

    class DBProccessing_NhapHang
    {
        DBConnection dbConn = new DBConnection();
        public DataTable GetTable(string tenBang)
        {
            string sql = "SELECT * FROM " + tenBang;
            DataTable tbl = new DataTable();
            tbl = dbConn.GetTable(sql);
            return tbl;
        }
        public DataTable GetTableDK(string tenBang)
        {
            string sql = "SELECT * FROM " + tenBang + " WHERE TinhTrang=1";
            DataTable tbl = new DataTable();
            tbl = dbConn.GetTable(sql);
            return tbl;
        }
        public DataTable GetSPBy_MaDM(string ma)
        {
            string sql = "SELECT * FROM SanPham WHERE MaDM = '" + ma + "' AND TinhTrang=1";
            DataTable tbl = new DataTable();
            tbl = dbConn.GetTable(sql);
            return tbl;
        }
        public DataTable GetSPByID(string maSP)
        {
            string sql = "SELECT * FROM SanPham WHERE MaSanPham='" + maSP + "' ";
            DataTable tbl = new DataTable();
            tbl = dbConn.GetTable(sql);
            return tbl;
        }
        public DataTable GetSLCoBySP(string maSP)
        {
            string sql = "SELECT a.MaSanPham, SoLuongTon = a.SoLuongNhap - b.SoLuongBan FROM(SELECT SanPham.MaSanPham, SoLuongNhap = (Case  when SoLuongNhap is NULL then 0 else SoLuongNhap end ) from(select MaSanPham, SoLuongNhap = SUM(SoLuongNhap) from HoaDonNhap " +
                "inner join ChiTietHoaDonNhap on HoaDonNhap.MaHDN = ChiTietHoaDonNhap.MaHDN group by MaSanPham) a right join SanPham on a.MaSanPham = SanPham.MaSanPham) a INNER JOIN(SELECT SanPham.MaSanPham, SoLuongBan = (Case  when SoLuongBan is NULL then 0 else SoLuongBan end ) from(select MaSanPham, SoLuongBan = SUM(SoLuongBan) from HoaDonBan " +
                "inner join ChiTietHoaDonBan on HoaDonBan.MaHDB = ChiTietHoaDonBan.MaHDB group by MaSanPham) a right join SanPham on a.MaSanPham = SanPham.MaSanPham) b " +
                "on a.MaSanPham = b.MaSanPham where a.MaSanPham = '"+maSP+"'";
            DataTable tbl = new DataTable();
            tbl = dbConn.GetTable(sql);
            return tbl;
        }
        public DataTable GetNCCByName(string tenNCC)
        {
            string sql = "SELECT * FROM NhaCungCap WHERE TenNCC=N'" + tenNCC + "'";
            DataTable tbl = new DataTable();
            tbl = dbConn.GetTable(sql);
            return tbl;
        }
        //thêm NCC vào bảng NhaCungCap
        public void themNCC(string maNCC,string tenNCC,string sdt, string dc)
        {
            string sql = "INSERT INTO NhaCungCap VALUES('" + maNCC + "',N'" + tenNCC + "','" + sdt + "',N'" + dc + "','"+true+"')";
            dbConn.ExecuteNonQuery(sql);
        }
        public void themChiTietHDNhap(string maHDN, string maSP, int slNhap, int giaNhap)
        {
            string sql = "INSERT INTO ChiTietHoaDonNhap VALUES('" + maHDN + "','" + maSP + "','" + slNhap + "','" + giaNhap + "')";
            dbConn.ExecuteNonQuery(sql);
        }
        public void themHDNhap(string maHDN, string ngayNhap, float tongTien, string maNV, string maNCC)
        {
            string sql = "INSERT INTO HoaDonNhap VALUES('" +maHDN+ "','" + ngayNhap + "','" + tongTien + "','" + maNV + "','" + maNCC + "')";
            dbConn.ExecuteNonQuery(sql);
        }
        public string MaCuoiBang(string tenBang)
        {
            string maHDN = "";
            DataTable tbl = GetTable(tenBang);
            if (tbl.Rows.Count == 0)
            {
                maHDN = "HDN0000000";
            }
            else
            {
                DataRow r = tbl.Rows[tbl.Rows.Count - 1];
                maHDN = r[0].ToString();
            }
            return maHDN;
        }
    }
}

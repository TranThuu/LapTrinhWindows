using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BTLLapTrinhWindows.Connection;

namespace BTLLapTrinhWindows.Proccessing
{
    class DBProccessing_DSNhapHang
    {
        DBConnection dbConn = new DBConnection();
        public DataTable GetTable(string tenBang)
        {
            string sql = "SELECT * FROM " + tenBang;
            DataTable t = dbConn.GetTable(sql);
            return t;
        }
        public DataTable GetTable_HDN()
        {
            string sql = "SELECT MaHDN, NgayNhap= CONVERT(varchar,NgayNhap,103),TongTien,MaNV,MaNhaCC FROM HoaDonNhap";
            DataTable t = dbConn.GetTable(sql);
            return t;
        }
        public DataTable GetTable_DieuKien(string cot, string ma)
        {
            string sql = "SELECT MaHDN, NgayNhap= CONVERT(varchar,NgayNhap,103),TongTien,MaNV,MaNhaCC FROM HoaDonNhap where " + cot + " = N'" + ma + "'";
            DataTable tbl = dbConn.GetTable(sql);
            return tbl;
        }
        public DataTable GetTable_Ngay(string cot, string ngayNhap)
        {
            string sql = "SELECT MaHDN, NgayNhap= CONVERT(varchar,NgayNhap,103),TongTien,MaNV,MaNhaCC FROM HoaDonNhap where " + cot + " = '" + ngayNhap + "'";
            DataTable tbl = dbConn.GetTable(sql);
            return tbl;
        }
        public DataTable getInforHDN(string maHDN)
        {
            string sql = "SELECT MaHDN,NgayNhap,TongTien,TenNV,TenNCC,NhaCungCap.SDT,DiaChi  FROM HoaDonNhap INNER JOIN NhanVien ON HoaDonNhap.MaNV=NhanVien.MaNV INNER JOIN NhaCungCap ON HoaDonNhap.MaNhaCC=NhaCungCap.MaNhaCC WHERE MaHDN='"+maHDN+"'";
            DataTable tbl = dbConn.GetTable(sql);
            return tbl;
        }
        public DataTable getCTHDByMa(string maHDN)
        {
            string sql = "SELECT ChiTietHoaDonNhap.MaSanPham,TenSP,SoLuongNhap,GiaNhap, (SoLuongNhap * GiaNhap) AS ThanhTien " +
                "FROM ChiTietHoaDonNhap INNER JOIN SanPham ON ChiTietHoaDonNhap.MaSanPham = SanPham.MaSanPham " +
                "WHERE MaHDN = '" + maHDN + "'";
            DataTable tbl = dbConn.GetTable(sql);
            return tbl;
        }
    }
}

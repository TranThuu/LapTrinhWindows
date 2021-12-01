using BTLLapTrinhWindows.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLLapTrinhWindows.Proccessing
{
    class DBProccessing_ChTietHoaDon
    {
        DBConnection dataconn = new DBConnection();
        public DataTable LayHoaDonBan(string maHDB)
        {
            string sql = "select MaHDB,NgayBan,TongTien,TenNV,TenKH, KhachHang.SDT from HoaDonBan inner join NhanVien on HoaDonBan.MaNV = NhanVien.MaNV inner join KhachHang on HoaDonBan.MaKhach = KhachHang.MaKhach where MaHDB = '"+maHDB+"'";
            DataTable t = dataconn.GetTable(sql);
            return t;
        }
        public DataTable LayBangCTHDB(string maHDB)
        {
            string sql = "select TenSP, GiaBan, SoLuongBan, ThanhTien = GiaBan * SoLuongBan from ChiTietHoaDonBan inner join SanPham on ChiTietHoaDonBan.MaSanPham = SanPham.MaSanPham where MaHDB = '"+maHDB+"'";
            DataTable t = dataconn.GetTable(sql);
            return t;
        }
    }
}

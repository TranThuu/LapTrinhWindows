using BTLLapTrinhWindows.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLLapTrinhWindows.Proccessing
{
    class DBProcessing_BaoCaoBanHang
    {
        DBConnection conn = new DBConnection();

        public DataTable showBaoCaoThang(String nam)
        {
            DataTable dt = new DataTable();
            dt = conn.GetTable("EXEC BaoCaoTheoThang '"+nam+"'");
            return dt;
        }
        public DataTable thongKeHangBan(DateTime bd, DateTime kt){
            DataTable dt = new DataTable();
            String sql = "SELECT  Convert(varchar,NgayBan,103) AS NgayBan,c.MaHDB, SUM(SoLuongBan) AS SLSP, TongTien FROM ChiTietHoaDonBan c INNER JOIN HoaDonBan h ON c.MaHDB = h.MaHDB WHERE NgayBan >= '"+bd+"' AND NgayBan <='"+kt+"' GROUP BY NgayBan, c.MaHDB, TongTien";
            dt = conn.GetTable(sql);
            return dt;
        }
        public DataTable thongKeHangNhap(DateTime bd, DateTime kt)
        {
            DataTable dt = new DataTable();
            String sql = "SELECT  Convert(varchar,NgayNhap,103) AS NgayNhap,c.MaHDN, SUM(SoLuongNhap) AS SLSP, TongTien FROM ChiTietHoaDonNhap c INNER JOIN HoaDonNhap h ON c.MaHDN = h.MaHDN WHERE NgayNhap >= '" + bd + "' AND NgayNhap <='" + kt + "'  GROUP BY NgayNhap, c.MaHDN, TongTien";
            dt = conn.GetTable(sql);
            return dt;
        }
    }
}

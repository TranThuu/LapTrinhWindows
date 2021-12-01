using BTLLapTrinhWindows.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLLapTrinhWindows.Proccessing
{
    class DBProccessing_TaoDonHang
    {
        DBConnection dataconn = new DBConnection();
        public DataTable GetTable( string tenBang)
        {
            string sql = "select * from " + tenBang;
            DataTable tb = new DataTable();
            tb = dataconn.GetTable(sql);
            return tb;
        }
        public DataTable GetTable_TinhTrang_1(string tenBang)
        {
            string sql = "select * from " + tenBang + " where TinhTrang = 1";
            DataTable tb = new DataTable();
            tb = dataconn.GetTable(sql);
            return tb;
        }
        public DataTable GetSP_maDM(string dmsp)
        {
            string sql = "select * from SanPham where MaDM = '" + dmsp + "' and TinhTrang = 1";
            DataTable tb = new DataTable();
            tb = dataconn.GetTable(sql);
            return tb;
        }
        public DataTable GetSP_Ma(string masp)
        {
            string sql = "select * from SanPham where MaSanPham = '" + masp + "'";
            DataTable tb = new DataTable();
            tb = dataconn.GetTable(sql);
            return tb;
        }
        public string MaCuoiBang(string tenBang, string ma)
        {
            string maHDB = "";
            DataTable t = GetTable(tenBang);
            if (t.Rows.Count == 0)
                maHDB = ma;
            else
            {
                DataRow r = t.Rows[t.Rows.Count - 1];
                maHDB = r[0].ToString();
            }            
            return maHDB;
        }
        public DataTable LayBangSanPhamCon(string maSP)
        {
            DataTable t = new DataTable();
            string sql = "select a.MaSanPham, SoLuongTon = a.SoLuongNhap - b.SoLuongBan " +
                "from (select SanPham.MaSanPham, SoLuongNhap = ( Case  when SoLuongNhap is NULL then 0 else SoLuongNhap end ) from (select MaSanPham, SoLuongNhap = SUM(SoLuongNhap) from HoaDonNhap inner join ChiTietHoaDonNhap on HoaDonNhap.MaHDN = ChiTietHoaDonNhap.MaHDN group by MaSanPham) a right join SanPham on a.MaSanPham = SanPham.MaSanPham) a " +
                "inner join (select SanPham.MaSanPham, SoLuongBan  = ( Case  when SoLuongBan is NULL then 0 else SoLuongBan end ) from (select MaSanPham, SoLuongBan = SUM(SoLuongBan) from HoaDonBan inner join ChiTietHoaDonBan on HoaDonBan.MaHDB = ChiTietHoaDonBan.MaHDB group by MaSanPham) a right join SanPham on a.MaSanPham = SanPham.MaSanPham) b " +
                "on a.MaSanPham = b.MaSanPham where a.MaSanPham = '"+maSP+"'";
            t = dataconn.GetTable(sql);
            return t;
        }
        public int LayGiaSanPham(string maSP)
        {
            int gia = 0;
            string sql = "select GiaBan from SanPham where MaSanPham = '" + maSP + "'";
            DataRow r = dataconn.GetTable(sql).Rows[0];
            gia = int.Parse(r[0].ToString());
            return gia;
        }
        public string LayMaKH(string ten, string sdt)
        {
            string ma = "";
            string sql = "select MaKhach from KhachHang where TenKH = N'" + ten + "' and SDT = N'" + sdt + "'";
            if(dataconn.GetTable(sql).Rows.Count > 0)
            {
                DataRow r = dataconn.GetTable(sql).Rows[0];
                ma = r[0].ToString();
            }
            return ma;
        }
        public void Insert_KhachHang(string ma,string ten,string sdt)
        {
            string sql = "insert into KhachHang values ('"+ma+"',N'"+ten+"','"+sdt+"', 1)";
            dataconn.ExecuteNonQuery(sql);
        }
        public void Insert_HoaDonBan(string mahdb,string maKhach,string maNV,DateTime ngayLap,float tongtien)
        {
            string sql = "insert into HoaDonBan values ('" + mahdb + "','" + maKhach + "','" + maNV + "','" + ngayLap + "','" + tongtien + "')";
            dataconn.ExecuteNonQuery(sql);
        }
        public void Insert_ChiTietHoaDonBan(string mahd,string masp,int soluong)
        {
            string sql = "insert into ChiTietHoaDonBan values ('"+mahd+"','"+masp+"','"+soluong+"')";
            dataconn.ExecuteNonQuery(sql);
        }
    }
}

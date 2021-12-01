using BTLLapTrinhWindows.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLLapTrinhWindows.Proccessing
{
    class DBProccessing_DanhSachDonHang
    {
        DBConnection dataconn = new DBConnection();
        public List<string> LayMaBang(string tenBang)
        {
            List<string> l = new List<string>();
            string sql = "select * from " + tenBang;
            DataTable t = dataconn.GetTable(sql);
            foreach(DataRow r in t.Rows)
            {
                l.Add(r[0].ToString());
            }
            return l;
        }
        public List<string> LayTenNV()
        {
            List<string> l = new List<string>();
            string sql = "select distinct TenNV from NhanVien";
            DataTable t = dataconn.GetTable(sql);
            foreach (DataRow r in t.Rows)
            {
                l.Add(r[0].ToString());
            }
            return l;
        }
        public List<string> LayTenKH()
        {
            List<string> l = new List<string>();
            string sql = "select distinct * from KhachHang";
            DataTable t = dataconn.GetTable(sql);
            foreach (DataRow r in t.Rows)
            {
                l.Add(r[1].ToString());
            }
            return l;
        }
        public DataTable GetTable(string tenBang)
        {
            string sql = "select * from " + tenBang;
            DataTable t = dataconn.GetTable(sql);
            return t;
        }
        public DataTable GetTable_HDB()
        {
            string sql = "select MaHDB, MaKhach, MaNV, NgayBan = CONVERT(varchar,NgayBan,103), TongTien from HoaDonBan";
            DataTable t = dataconn.GetTable(sql);
            return t;
        }

        public DataTable GetNhanVien_DieuKien(string tenNV)
        {
            string sql = "select MaHDB, TenKH, SDT = KhachHang.SDT,NhanVien.MaNV, TenNV, NgayBan = CONVERT(varchar,NgayBan,103), TongTien from HoaDonBan " +
                "inner join NhanVien on HoaDonBan.MaNV = NhanVien.MaNV inner join KhachHang on HoaDonBan.MaKhach = KhachHang.MaKhach where TenNV = N'" + tenNV +"'";
            DataTable t = dataconn.GetTable(sql);
            return t;
        }
        public DataTable GetKhachHang_DieuKien(string tenKH)
        {
            string sql = "select MaHDB, TenKH, SDT = KhachHang.SDT,NhanVien.MaNV, TenNV, NgayBan = CONVERT(varchar,NgayBan,103), TongTien from HoaDonBan " +
                "inner join NhanVien on HoaDonBan.MaNV = NhanVien.MaNV inner join KhachHang on HoaDonBan.MaKhach = KhachHang.MaKhach where TenKH = N'" + tenKH + "'";
            DataTable t = dataconn.GetTable(sql);
            return t;
        }
        public DataTable GetTable_Ngay(DateTime tungay,DateTime denngay)
        {
            string sql = "select MaHDB, TenKH, SDT = KhachHang.SDT,NhanVien.MaNV, TenNV, NgayBan = CONVERT(varchar,NgayBan,103), TongTien from HoaDonBan " +
                "inner join NhanVien on HoaDonBan.MaNV = NhanVien.MaNV inner join KhachHang on HoaDonBan.MaKhach = KhachHang.MaKhach where NgayBan >= '" + tungay+"' and NgayBan <= '"+denngay+"'";
            DataTable t = dataconn.GetTable(sql);
            return t;
        }
        public DataTable GetTable_Excel()
        {
            DataTable t = new DataTable();
            string sql = "select MaHDB, TenKH, SDT = KhachHang.SDT,NhanVien.MaNV, TenNV, NgayBan = CONVERT(varchar,NgayBan,103), TongTien from HoaDonBan " +
                "inner join NhanVien on HoaDonBan.MaNV = NhanVien.MaNV inner join KhachHang on HoaDonBan.MaKhach = KhachHang.MaKhach";
            t = dataconn.GetTable(sql);
            return t;
        }

    }
}

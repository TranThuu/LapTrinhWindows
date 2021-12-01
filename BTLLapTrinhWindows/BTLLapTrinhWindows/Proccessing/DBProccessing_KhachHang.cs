using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTLLapTrinhWindows.Connection;
using System.Data;
using System.Data.SqlClient;

namespace BTLLapTrinhWindows.Proccessing
{
    class DBProccessing_KhachHang
    {
        DBConnection dbConnection = new DBConnection();

        public DataTable GetAllKhachHang()
        {
            string sql = "select MaKhach, TenKH, SDT from KhachHang";
            return dbConnection.GetTable(sql);
        }
        public DataTable GetAllKhachHang1()
        {
            string sql = "select MaKhach, TenKH, SDT from KhachHang where MaKhach <> 'KH000' and TinhTrang = 1";
            return dbConnection.GetTable(sql);
        }

        public DataTable GetKhachHangByNameOrSDT(string name, string sdt)
        {
            string sql = "";
            if (String.IsNullOrWhiteSpace(name))
            {
                sql = "select * from KhachHang where SDT like '%" + sdt + "%' and TinhTrang = 1";
            }
            else if (String.IsNullOrWhiteSpace(sdt))
            {
                sql = "select * from KhachHang where TenKH like N'%" + name + "%' and TinhTrang = 1";
            }
            else
            {
                sql = "select MaKhach, TenKH from KhachHang where TenKH Like '%" + name + "%' or SDT like '%" + sdt + "%' and TinhTrang = 1";
            }
            return dbConnection.GetTable(sql);
        }
        public DataTable GetKhachHangByName(string name)
        {
            string sql = "";
            sql = "select MaKhach, TenKH, SDT from KhachHang where TenKH like N'%" + name + "%' and TinhTrang = 1 and MaKhach <> 'KH000'";
            return dbConnection.GetTable(sql);
        }
        public DataTable GetKhachHangBySDT(string sdt)
        {
            string sql = "";
            sql = "select MaKhach, TenKH, SDT from KhachHang where SDT like '%" + sdt + "%' and TinhTrang = 1 and MaKhach <> 'KH000'";
            return dbConnection.GetTable(sql);
        }

        public void DeleteKhachHangByID(string id)
        {
            string sql = "Update KhachHang set TinhTrang = 0 where MaKhach = '" + id + "'";
            dbConnection.ExecuteNonQuery(sql);
        }

        public void InsertNewKhachHang(string maKhach, string tenKH, string sdt)
        {
            string sql = "insert into KhachHang values('" + maKhach + "',N'" + tenKH + "','" + sdt + "', 1)";
            dbConnection.ExecuteNonQuery(sql);
        }
        public void EditKhachHangById(string maKhach, string tenKH, string sdt)
        {
            string sql = "update KhachHang set TenKH = N'" + tenKH + "', SDT = '" + sdt + "' where MaKhach = '" + maKhach + "'";
            dbConnection.ExecuteNonQuery(sql);
        }
        public bool CheckSDT_them(string sdt)
        {
            string sql = "select * from KhachHang where SDT = '" + sdt + "'";
            if (dbConnection.GetTable(sql).Rows.Count > 0)
                return true;
            return false;                  
        }
        public bool CheckSDT_sua(string makh, string sdt)
        {
            bool co = false;
            string sql = "select * from KhachHang where MaKhach <> '"+makh+"' and SDT = '" + sdt + "'";
            if (dbConnection.GetTable(sql).Rows.Count > 0)
                co = true;
            return co;
        }
    }
}

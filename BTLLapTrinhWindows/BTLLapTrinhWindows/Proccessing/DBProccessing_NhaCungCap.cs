using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BTLLapTrinhWindows.Connection;

namespace BTLLapTrinhWindows.Proccessing
{
    class DBProccessing_NhaCungCap
    {
        private DBConnection dbConnection = new DBConnection();
        public DataTable GetAllNCC()
        {
            string sql = "select MaNhaCC, TenNCC, SDT, DiaChi from NhaCungCap where TinhTrang = 1";
            return dbConnection.GetTable(sql);
        }
        public DataTable GetAllNCC_1()
        {
            string sql = "select MaNhaCC, TenNCC, SDT, DiaChi from NhaCungCap";
            return dbConnection.GetTable(sql);
        }

        public DataTable GetNCCByName(string name)
        {
            string sql = "select * from KhachHang where TenNCC = N'" + name + "' and TinhTrang = 1";
            return dbConnection.GetTable(sql);
        }

        public void DeleteNCCByID(string id)
        {
            string sql = "Update NhaCungCap set TinhTrang = '"+0+"' where MaNhaCC = '" + id + "'";
            dbConnection.ExecuteNonQuery(sql);
        }

        public void InsertNewNCC(string maNCC, string tenNCC, string sdt, string diaChi)
        {
            string sql = "insert into NhaCungCap values('" + maNCC + "',N'" + tenNCC + "','" + sdt + "',N'" + diaChi + "', 1)";
            dbConnection.ExecuteNonQuery(sql);
        }
        public void EditNCCById(string maNCC, string tenNCC, string sdt, string diaChi)
        {
            string sql = "update NhaCungCap set TenNCC = N'" + tenNCC + "', SDT = '" + sdt + "', DiaChi = N'" + diaChi + "' where MaNhaCC = '" + maNCC + "'";
            dbConnection.ExecuteNonQuery(sql);
        }
        public bool CheckRowThem(string ten,string sdt)
        {
            bool co = false;
            string sql = "select * from NhaCungCap where TenNCC = N'" + ten + "' or SDT = '" + sdt + "'";
            if (dbConnection.GetTable(sql).Rows.Count > 0)
                co = true;
            return co;
        }
        public bool CheckRowSua(string mancc,string ten, string sdt, string diachi)
        {
            bool co = false;
            string sql = "select * from NhaCungCap where MaNhacc <> '"+mancc+"' and (TenNCC = N'" + ten + "' or SDT = '" + sdt + "' or DiaChi = N'" + diachi + "')";
            if (dbConnection.GetTable(sql).Rows.Count > 0)
                co = true;
            return co;
        }

    }
}

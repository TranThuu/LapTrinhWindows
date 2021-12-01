using BTLLapTrinhWindows.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLLapTrinhWindows.Proccessing
{
    class DBProccessing_ForgetPassword
    {
        DBConnection dataconn = new DBConnection();
        public bool checkTinhTrang(string ma)
        {
            bool checkTK = false;
            string sql = "select * from NhanVien where MaNV = '" + ma + "' and TinhTrang = 1";
            if (dataconn.GetTable(sql).Rows.Count > 0)
                checkTK = true;
            return checkTK;
        }
        public bool CheckTaiKhoan(string ma,string ten,string sdt,DateTime ngay)
        {
            bool checkTK = false;
            string sql = "select * from NhanVien where MaNV = '" + ma + "' and TenNV = N'" + ten + "' and " +
                "SDT = '" + sdt + "' and NgaySinh = '" + ngay + "'";
            DataTable t = dataconn.GetTable(sql);
            if (t.Rows.Count > 0)
                checkTK = true;
            return checkTK;
        }
        public void UpdateNhanVien(string manv,string mk)
        {
            string sql = "Update NhanVien set MatKhau = '" + mk + "' where MaNV = '" + manv + "'";
            dataconn.ExecuteNonQuery(sql);
        }
    }
}

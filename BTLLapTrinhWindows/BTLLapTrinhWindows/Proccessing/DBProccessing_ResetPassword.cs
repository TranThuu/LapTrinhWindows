using BTLLapTrinhWindows.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLLapTrinhWindows.Proccessing
{
    class DBProccessing_ResetPassword
    {
        DBConnection dataconn = new DBConnection();
        public bool CheckOldPass(string maNV,string oldpass)
        {
            bool tonTai = false;
            string sql = "select * from NhanVien where MaNV = '" + maNV + "' and MatKhau = '" + oldpass + "'";
            if (dataconn.GetTable(sql).Rows.Count > 0)
                tonTai = true;
            return tonTai;
        }
        public bool CheckNewPass(string newpass,string confirmpass)
        {
            bool trung = false;
            if (newpass == confirmpass)
                return true;
            return trung;
        }
        public void SavePass(string manv,string newpass)
        {
            string sql = "Update NhanVien Set MatKhau = '" + newpass + "' Where MaNV = '" + manv + "'";
            dataconn.ExecuteNonQuery(sql);
        }
    }
}

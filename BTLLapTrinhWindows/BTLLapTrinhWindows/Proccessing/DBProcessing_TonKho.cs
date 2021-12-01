using BTLLapTrinhWindows.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLLapTrinhWindows.Proccessing
{
    class DBProcessing_TonKho
    {
        DBConnection conn = new DBConnection();

         public DataTable showTonKho()
        {
            DataTable dt = new DataTable();
            dt = conn.GetTable("EXEC TonKho ");
            return dt;
        }
        public DataTable showDM()
        {
            DataTable dt = new DataTable();
            dt = conn.GetTable("SELECT * FROM DanhMucSanPham");
            return dt;
        }
        public int TongTonKho()
        {
            int tongTon = 0;
            DataTable dt = new DataTable();
            tongTon = conn.ExecuteNonQueryNumber("SELECT dbo.TongTonKho()");
            return tongTon;

        }

        public DataTable searchTenDanhMuc(String tenDM)
        {
            DataTable dt = new DataTable();
            dt = conn.GetTable("EXEC SearchTonKho N'"+tenDM+"', ''");
            return dt;
        }
        public DataTable searchTenSanPham(String tenSP)
        {
            DataTable dt = new DataTable();
            dt = conn.GetTable("EXEC SearchTonKho '' , N'" + tenSP + "'");
            return dt;
        }
        public DataTable searchTenDMTenSP(String tenDM, String tenSP)
        {
            DataTable dt = new DataTable();
            dt = conn.GetTable("EXEC SearchTonKho N'" + tenDM + "', N'"+tenSP+"'");
            return dt;
        }

    }
}

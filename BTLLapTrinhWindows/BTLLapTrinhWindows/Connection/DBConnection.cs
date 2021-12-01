using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace BTLLapTrinhWindows.Connection
{
    class DBConnection
    {
        public SqlConnection getConnection()
        {
            string conn = @"Data Source=DESKTOP-QMHOU0D;Initial Catalog=NHOM7_QLCH_Ban_VPP;Integrated Security=True";//Trang
            //string conn = @"Data Source=DESKTOP-TR8ANRT\SQLEXPRESS;Initial Catalog=NHOM7_QLCH_Ban_VPP;Integrated Security=True";//Thu
            //string conn = @"Data Source=MCCOMPUTER;Initial Catalog=NHOM7_QLCH_Ban_VPP;Integrated Security=True";//Ánh
            //string conn = @"Data Source=DESKTOP-MB2VKHQ;Initial Catalog=NHOM7_QLCH_Ban_VPP;Integrated Security=True";//Phuong
            return new SqlConnection(conn);
        }
        public DataTable GetTable(string sql)
        {
            DataTable table = new DataTable();
            SqlConnection conn = getConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(table);
            return table;
        }
        public void ExecuteNonQuery(string sql)
        {
                SqlConnection conn = getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
        }

        public int ExecuteNonQueryNumber(string sql)
        {
            int giaTri = 0;
            SqlConnection conn = getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            giaTri = (int)cmd.ExecuteScalar();
            conn.Close();
            return giaTri;
        }
    }
}

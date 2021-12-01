using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTLLapTrinhWindows.Connection;
using System.Data;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;

namespace BTLLapTrinhWindows.Proccessing
{
    class DBProccessing_NhanVien
    {
        DBConnection dbConn = new DBConnection();

        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public DataTable showNhanVien()
        {
            DataTable dt = new DataTable();
            dt = dbConn.GetTable("SELECT * FROM NhanVien where TinhTrang = 1");
            return dt;
        }
        public DataTable showall()
        {
            DataTable dt = new DataTable();
            dt = dbConn.GetTable("SELECT * FROM NhanVien");
            return dt;
        }

        public DataTable showNhanVienMa(String ma)
        {
            DataTable dt = new DataTable();
            dt = dbConn.GetTable("SELECT * FROM NhanVien WHERE MaNV = '"+ma+"'");
            return dt;
        }

        public void themNV(String ma, String tenNV, String sdt, String chucVu, String mk, int gt, DateTime ngaySinh, Image anhNV)
        {
            SqlConnection conn = dbConn.getConnection();
            conn.Open();
            String sql = " INSERT INTO NhanVien  VALUES(N'"+ma+"',N'" + tenNV + "','" + sdt + "',N'" + chucVu + "','" + mk + "',"+gt+",'"+ngaySinh+"', @Anh,1)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Anh", ConvertImageToBytes(anhNV));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void suaNV(String ma, String chucVu)
        {
            string sql = "update NhanVien set ChucVu = N'"+chucVu+"' where MaNV = '" + ma + "'";
            dbConn.ExecuteNonQuery(sql);
        }

        public void XoaNV(String ma)
        {
            String sql = "update NhanVien set TinhTrang = 0 where MaNV = '" + ma + "'";
            dbConn.ExecuteNonQuery(sql);
        }
    }
}

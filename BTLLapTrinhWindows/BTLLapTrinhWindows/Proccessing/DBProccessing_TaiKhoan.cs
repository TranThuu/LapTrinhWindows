using BTLLapTrinhWindows.Connection;
using BTLLapTrinhWindows.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BTLLapTrinhWindows.Proccessing
{
    class DBProccessing_TaiKhoan
    {
        DBConnection dataconn = new DBConnection();
        byte[] ConvertImageToBytes(Image img)
        {
            using (var ms = new MemoryStream())
            {
                Bitmap bmp = new Bitmap(img);
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image ConvertByArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        public void GetNhanVien(string manv)
        {
            DataTable table = new DataTable();
            string sql = "select * from NhanVien Where MaNV = '" + manv + "'";
            table = dataconn.GetTable(sql);
            DataRow row = table.Rows[0];

            fTaiKhoan.tt_ma.Text = row["MaNV"].ToString(); ;
            fTaiKhoan.tt_ten.Text = row["TenNV"].ToString();
            fTaiKhoan.tt_chucvu.Text = row["ChucVu"].ToString();
            fTaiKhoan.tt_sdt.Text = row["SDT"].ToString();
            if (row["GioiTinh"].ToString() == "True")
                fTaiKhoan.cb_gioiT.Checked = true;
            fTaiKhoan.dp_ngayS.Text = row["NgaySinh"].ToString();
            fTaiKhoan.pb_anh.Image = ConvertByArrayToImage((byte[])row["AnhNV"]);
        }
        public void LuuThayDoi(string ma,string ten,string sdt,bool gt,DateTime ngay,Image image,string fileName)
        {
            SqlConnection conn = dataconn.getConnection();
            string sql = "update NhanVien set TenNV = N'" + ten + "', SDT = '" + sdt + "', GioiTinh = '" + gt + "'," +
                " NgaySinh = '" + ngay + "', AnhNV = @Anh where MaNV = '" + ma +"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            if(image != null)
                cmd.Parameters.AddWithValue("@Anh", ConvertImageToBytes(image));
            else cmd.Parameters.AddWithValue("@Anh", "NULL");
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public bool CheckTaiKhoan(string manv,string sdt)
        {
            bool co = false;
            string sql = "select * from NhanVien where SDT = '" + sdt + "' and MaNV <> '" + manv + "' and TinhTrang = 1";
            if (dataconn.GetTable(sql).Rows.Count > 0)
                co = true;
            return co;
        }
    }
}

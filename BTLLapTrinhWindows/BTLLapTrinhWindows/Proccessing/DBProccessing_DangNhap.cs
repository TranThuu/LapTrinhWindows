using BTLLapTrinhWindows.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Drawing;
using BTLLapTrinhWindows.GUI;

namespace BTLLapTrinhWindows.Proccessing
{
    class DBProccessing_DangNhap
    {
        DBConnection dataconn = new DBConnection();
        public bool IsCheckAccount(string maNV, string pass)
        {
            bool account = false;
            string sql = "select * from NhanVien where MaNV = '"+ maNV +"' and MatKhau = '"+ pass +"' and TinhTrang = 1";
            DataTable table = new DataTable();
            table = dataconn.GetTable(sql);
            if (table.Rows.Count > 0)
                account = true;
            return account;
        }
        public DataTable GetTinhTrangNV(string ma)
        {
            DataTable t = new DataTable();
            string sql = "select * from NhanVien where MaNV = '" + ma + "' and TinhTrang = 1";
            t = dataconn.GetTable(sql);
            return t;
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
            fMain.ptbAnh.Image = ConvertByArrayToImage((byte[])row["AnhNV"]);
            fMain.lbMaNV.Text = row["MaNV"].ToString();
            fMain.lbTenNV.Text = row["TenNV"].ToString();
            fMain.lbHello.Text = "Xin Chào: " + row["TenNV"].ToString();
            if (row["ChucVu"].ToString() == "NhanVien")
            {
                fMain.btnnv.Visible = false;
            }
        }
    }
}

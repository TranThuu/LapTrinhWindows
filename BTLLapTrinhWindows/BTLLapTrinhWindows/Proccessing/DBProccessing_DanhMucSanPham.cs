using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTLLapTrinhWindows.Connection;
using System.Data;
namespace BTLLapTrinhWindows.Proccessing
{
    class DBProccessing_DanhMucSanPham
    {
        DBConnection dbConn = new DBConnection();
        public DataTable showAllDanhMuc()
        {
            string sql = "SELECT MaDM,TenDM FROM DanhMucSanPham";
            DataTable tblDMSanPham = new DataTable();
            tblDMSanPham = dbConn.GetTable(sql);
            return tblDMSanPham;
        }
        public DataTable showDanhMuc_NV()
        {
            string sql = "SELECT MaDM,TenDM FROM DanhMucSanPham WHERE TinhTrang=1";
            DataTable tblDMSanPham = new DataTable();
            tblDMSanPham = dbConn.GetTable(sql);
            return tblDMSanPham;
        }
        public DataTable showDanhMuc_Admin()
        {
            string sql = "SELECT MaDM,TenDM, TinhTrang FROM DanhMucSanPham";
            DataTable tblDMSanPham = new DataTable();
            tblDMSanPham = dbConn.GetTable(sql);
            return tblDMSanPham;
        }
        public bool CheckTenDM_Sua(string maDM,string tenDM)
        {
            bool co = false;
            string sql = "select * from DanhMucSanPham where MaDM <> '"+maDM+"' and TenDM = N'" + tenDM + "'";
            if (dbConn.GetTable(sql).Rows.Count > 0)
                co = true;
            return co;
        }
        public bool CheckTenDM_Them(string tenDM)
        {
            bool co = false;
            string sql = "select * from DanhMucSanPham where TenDM = N'" + tenDM + "'";
            if (dbConn.GetTable(sql).Rows.Count > 0)
                co = true;
            return co;
        }
        public bool CheckMaDM(string maDM)
        {
            bool co = false;
            string sql = "select * from DanhMucSanPham where MaDM = '" + maDM + "'";
            if (dbConn.GetTable(sql).Rows.Count > 0)
                co = true;
            return co;
        }
        public void InsertDM_NV(string maDM, string tenDM)
        {
            string sql = "INSERT INTO DanhMucSanPham VALUES('" + maDM + "',N'" + tenDM + "','"+true+"')";
            dbConn.ExecuteNonQuery(sql);
        }
        public void InsertDM_Admin(string maDM, string tenDM, bool tinhtrang)
        {
            string sql = "INSERT INTO DanhMucSanPham VALUES('" + maDM + "',N'" + tenDM + "','" + tinhtrang + "')";
            dbConn.ExecuteNonQuery(sql);
        }
        public void UpdateDM_NV(string maDM, string tenDM)
        {
            string sql = "UPDATE DanhMucSanPham SET TenDM=N'" + tenDM + "' WHERE MaDM ='"+maDM+"'";
            dbConn.ExecuteNonQuery(sql);
        }
        public void UpdateDM_Admin(string maDM, string tenDM, bool tinhtrang)
        {
            string sql = "UPDATE DanhMucSanPham SET TenDM=N'" + tenDM + "', TinhTrang = N'" + tinhtrang + "' WHERE MaDM ='" + maDM + "'";
            dbConn.ExecuteNonQuery(sql);
        }
        public bool IsNhanVien(string manv)
        {
            bool co = false;
            string sql = "select * from NhanVien where MaNV = '" + manv + "' and ChucVu = N'NhanVien'";
            if (dbConn.GetTable(sql).Rows.Count > 0)
                co = true;
            return co;
        }
        public DataTable Loc_TinhTrang(bool tinhtrang)
        {
            string sql = "select * from DanhMucSanPham where TinhTrang = N'" + tinhtrang + "'";
            return dbConn.GetTable(sql);
        }
    }
}

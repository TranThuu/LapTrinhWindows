using BTLLapTrinhWindows.Connection;
using BTLLapTrinhWindows.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLLapTrinhWindows.Proccessing
{
    class DBProccessing_Main
    {
        DBConnection datacon = new DBConnection();
        public bool Check_ChucVu(string manv)
        {
            bool isNV = true;
            string sql = "select * from NhanVien where MaNV = '" + manv + "' and ChucVu = N'Admin'";
            if (datacon.GetTable(sql).Rows.Count > 0)
                isNV = false;
            return isNV;
        }
        public void Visible_DanhMucSanPham_NV()
        {
            fDanhMucSanPham.button_sua.Visible = false;
            fDanhMucSanPham.button_xoa.Visible = false;
        }
        public void Visible_DanhSachSanPham_NV()
        {
            fDanhSachSanPham.button_sua.Visible = false;
            fDanhSachSanPham.dsDPNgungBan.Visible = false;
        }
        public void Visible_KhachHang_NV()
        {
            FKhachHang.button_sua.Visible = false;
            FKhachHang.button_xoa.Visible = false;
        }
        public void Visible_NhaCungCap_NV()
        {
            fNhaCungCap.button_sua.Visible = false;
            fNhaCungCap.button_xoa.Visible = false;
        }
    }
}

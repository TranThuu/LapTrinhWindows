using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLLapTrinhWindows.Classes
{
    class ChiTietHoaDonBan
    {
        public string maHoaDonBan { get; set; }
        public string maSanPham { get; set; }
        public int soLuongBan { get; set; }
        public string tenSanPham { get; set; }
        public float gia { get; set; }
        public int soLuongCon { get; set; }
        public ChiTietHoaDonBan() { }
        public ChiTietHoaDonBan(string ma, string maSP, int soLuong, string ten, float gia,int soluongcon)
        {
            this.maHoaDonBan = ma;
            this.maSanPham = maSP;
            this.soLuongBan = soLuong;
            this.tenSanPham = ten;
            this.gia = gia;
            this.soLuongCon = soluongcon;
        }
        public float ThanhTien()
        {
            return soLuongBan * gia;
        }
    }
}

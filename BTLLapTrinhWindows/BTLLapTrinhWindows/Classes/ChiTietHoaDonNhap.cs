using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLLapTrinhWindows.Classes
{
    class ChiTietHoaDonNhap
    {
        public string maHDNhap { get; set; }
        public string maSP { get; set; }
        public string tenSP { get; set; }
        public int giaNhap { get; set; }
        public int soLuongNhap { get; set; }
        public int soLuongCon { get; set; }
        public ChiTietHoaDonNhap()
        {

        }
        public ChiTietHoaDonNhap(string ma, string maSP, string tenSP, int giaNhap, int slNhap, int slCon)
        {
            this.maHDNhap = ma;
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.giaNhap = giaNhap;
            this.soLuongNhap = slNhap;
            this.soLuongCon = slCon;
        }
        public float ThanhTien()
        {
            return soLuongNhap * giaNhap;
        }
        public float updateSLCon()
        {
            return soLuongCon += soLuongNhap;
        }
    }
}

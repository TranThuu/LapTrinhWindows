using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLLapTrinhWindows.Classes
{
    class KhachHang
    {
        public string maKH;
        public string tenKH;
        public string sdt;
        public KhachHang() { }
        public KhachHang(string ma,string ten,string dt)
        {
            this.maKH = ma;
            this.tenKH = ten;
            this.sdt = dt;
        }
    }
}

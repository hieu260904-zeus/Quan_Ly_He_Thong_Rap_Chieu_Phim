using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_He_Thong_Rap_Chieu_Phim
{
    public class Phim
    {
        public string maphim { get; set; }
        public string tenphim { get; set; }
        public string theloai { get; set; }
        public string tendaodien { get; set; }
        public string tendienvien { get; set; }
        public double thoiluongphim { get; set; }
        public Phim(string maphim, string tenphim, string theloai, string tendaodien, string tendienvien, double thoiluongphim)
        {
            this.maphim=maphim;
            this.tenphim=tenphim;
            this.theloai=theloai;
            this.tendaodien=tendaodien;
            this.tendienvien=tendienvien;
            this.thoiluongphim=thoiluongphim;
        }
    }
}

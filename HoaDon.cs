using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_He_Thong_Rap_Chieu_Phim
{
    public class HoaDon
    {
        public string mahoadon { get; set; }
        public DateTime? ngayHD { get; set; }
        public double sotientra { get; set; }
        public string tenphim { get; set; }
        public double giochieu { get; set; }
        public string vitrighe { get; set; }
        public KhanGia khangia_mua { get; set; }
        public HoaDon(string mahoadon, DateTime? ngayHD, double sotientra, string tenphim, double giochieu, string vitrighe, KhanGia khangia_mua)
        {
            this.mahoadon=mahoadon;
            this.ngayHD=ngayHD;
            this.sotientra=sotientra;
            this.tenphim=tenphim;
            this.giochieu=giochieu;
            this.vitrighe=vitrighe;
            this.khangia_mua=khangia_mua;
        }
    }
}

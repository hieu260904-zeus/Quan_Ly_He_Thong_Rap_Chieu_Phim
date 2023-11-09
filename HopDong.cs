using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_He_Thong_Rap_Chieu_Phim
{
    public class HopDong
    {
        public string maHD { get; set; }
        public string tenHD { get; set; }
        public DateTime? ngayHD { get; set; }
        public double trigiaHD { get; set; }
        public HopDong(string maHD, string tenHD, DateTime? ngayHD, double trigiaHD)
        {
            this.maHD=maHD;
            this.tenHD=tenHD;
            this.ngayHD=ngayHD;
            this.trigiaHD=trigiaHD;
        }

    }
}

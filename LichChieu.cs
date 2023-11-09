using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_He_Thong_Rap_Chieu_Phim
{
    public class LichChieu
    {
        public Phim bophim { get; set; }
        public Phong phong { get; set; }
        public DateTime thoigianchieu { get; set; }
        public LichChieu(Phim bophim, Phong phong, DateTime thoigianchieu)
        {
            this.bophim=bophim;
            this.phong=phong;
            this.thoigianchieu=thoigianchieu;
        }
    }
}

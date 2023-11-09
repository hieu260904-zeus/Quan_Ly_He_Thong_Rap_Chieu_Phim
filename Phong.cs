using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_He_Thong_Rap_Chieu_Phim
{
    public class Phong
    {
        public string maphong { get; set; }
        public string khuvuc { get; set; }
        public int soluongghe { get; set; }
        public bool? loaiphong { get; set; }
        public Phong(string maphong, string khuvuc, int soluongghe, bool? loaiphong)
        {
            this.maphong=maphong;
            this.khuvuc=khuvuc;
            this.soluongghe=soluongghe;
            this.loaiphong=loaiphong;
        }
    }
}

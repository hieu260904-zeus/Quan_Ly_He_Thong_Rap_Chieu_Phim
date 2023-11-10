using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_He_Thong_Rap_Chieu_Phim
{
    public class TepKH
    {
        public string matepKH { get; set; }
        public string dotuoi { get; set; }
        public string sothich { get; set; }
        public int soluong { get; set; }

        public TepKH(string matepKH, string dotuoi, string sothich, int soluong)
        {
            this.matepKH = matepKH;
            this.dotuoi = dotuoi;
            this.sothich = sothich;
            this.soluong = soluong;
        }
    }
}

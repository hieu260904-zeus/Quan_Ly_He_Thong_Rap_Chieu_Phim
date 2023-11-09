using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_He_Thong_Rap_Chieu_Phim
{
    public class ViTriCV
    {
        public string maCV { get; set; }
        public string tenCV { get; set; }
        public string motaCV { get; set; }
        public ViTriCV(string maCV, string tenCV, string motaCV)
        {
            this.maCV=maCV;
            this.tenCV=tenCV;
            this.motaCV=motaCV;
        }
    }
}

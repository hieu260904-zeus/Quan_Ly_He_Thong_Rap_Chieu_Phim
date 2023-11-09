using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_He_Thong_Rap_Chieu_Phim
{
    public class DoiTac
    {
        public string maDT { get; set; }
        public string hoten { get; set; }
        public DateTime? ngaysinh { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }
        public DoiTac(string maDT, string hoten, DateTime? ngaysinh, string diachi, string sdt)
        {
            this.maDT=maDT;
            this.hoten=hoten;
            this.ngaysinh=ngaysinh;
            this.diachi=diachi;
            this.sdt=sdt;
        }
    }
}

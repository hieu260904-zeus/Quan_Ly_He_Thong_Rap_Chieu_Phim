using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_He_Thong_Rap_Chieu_Phim
{
    public class DoiTac : ConNguoi
    {
        public string maDT { get; set; }
        public DoiTac(string maDT, string hoten, DateTime? ngaysinh, string diachi, string sdt):base(hoten, ngaysinh, diachi, sdt)
        {
            this.maDT=maDT;
        }
    }
}

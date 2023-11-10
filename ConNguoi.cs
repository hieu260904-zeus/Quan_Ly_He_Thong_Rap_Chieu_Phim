using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_He_Thong_Rap_Chieu_Phim
{
    public class ConNguoi
    {
        public string hoten { get; set; }
        public DateTime? ngaysinh { get; set; }
        public string diachi { get; set; }
        public string sdt { get; set; }
        public ConNguoi(string hoten, DateTime? ngaysinh, string diachi, string sdt)
        {
            this.hoten=hoten;
            this.ngaysinh=ngaysinh;
            this.diachi=diachi;
            this.sdt=sdt;
        }
    }
}

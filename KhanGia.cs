using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_He_Thong_Rap_Chieu_Phim
{
    public class KhanGia
    {
        public string makhangia { get; set; }
        public string hoten { get; set; }
        public DateTime? ngaysinh;
        public string diachi { get; set; }
        public string sdt { get; set; }
        public TepKH tepkhachhang { get; set; }
        public KhanGia(string khangia, string hoten, DateTime? ngaysinh, string diachi, string sdt, TepKH tepkhachhang)
        {
            this.makhangia=khangia;
            this.hoten=hoten;
            this.ngaysinh=ngaysinh;
            this.diachi=diachi;
            this.sdt=sdt;
            this.tepkhachhang=tepkhachhang;
        }
    }
}

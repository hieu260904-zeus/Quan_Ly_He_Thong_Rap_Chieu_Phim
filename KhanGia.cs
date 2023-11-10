using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_He_Thong_Rap_Chieu_Phim
{
    public class KhanGia : ConNguoi
    {
        public string makhangia { get; set; }
        public TepKH tepkhachhang { get; set; }
        public KhanGia(string khangia, string hoten, DateTime? ngaysinh, string diachi, string sdt, TepKH tepkhachhang):base(hoten, ngaysinh, diachi, sdt)
        {
            this.makhangia=khangia;
            this.tepkhachhang=tepkhachhang;
        }
    }
}

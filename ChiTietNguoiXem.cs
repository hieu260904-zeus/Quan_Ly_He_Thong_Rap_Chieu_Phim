using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_He_Thong_Rap_Chieu_Phim
{
    public class ChiTietNguoiXem
    {
        public Phim phim_duocxem { get; set; }
        public KhanGia khangia_xemphim { get; set; }
        public bool? trangthai { get; set; }
        public ChiTietNguoiXem(Phim phim_duocxem, KhanGia khangia_xemphim, bool? trangthai)
        {
            this.phim_duocxem=phim_duocxem;
            this.khangia_xemphim=khangia_xemphim;
            this.trangthai=trangthai;
        }
    }
}

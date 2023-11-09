using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_He_Thong_Rap_Chieu_Phim
{
    public class KhaNang
    {
        public NhanVien nhanvien_kn { get; set; }
        public List<ViTriCV> congviec_kn { get; set; }
        public int capdo { get; set; }
        public KhaNang(NhanVien nhanvien_kn, List<ViTriCV> congviec_kn, int capdo)
        {
            this.nhanvien_kn=nhanvien_kn;
            this.congviec_kn=congviec_kn;
            this.capdo=capdo;
        }
    }
}

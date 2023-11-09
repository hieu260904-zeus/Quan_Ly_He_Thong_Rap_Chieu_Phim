using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_He_Thong_Rap_Chieu_Phim
{
    public class Rap
    {
        public string marap { get; set; }
        public string tenrap { get; set; }
        public string diachi { get; set; }
        public int sophong { get; set; }
        public int succhua { get; set; }
        public NhanVien QuanLy { get; set; }
        public Rap(string marap, string tenrap, string diachi, int sophong, int succhua, NhanVien quanLy)
        {
            this.marap=marap;
            this.tenrap=tenrap;
            this.diachi=diachi;
            this.sophong=sophong;
            this.succhua=succhua;
            QuanLy=quanLy;
        }
    }
}

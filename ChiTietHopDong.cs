using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_He_Thong_Rap_Chieu_Phim
{
    public class ChiTietHopDong
    {
        public HopDong hopdong_chitiet { get; set; }
        public DoiTac doitac_chitiet { get; set; }
        public Rap rap_chitiet { get; set; }
        public double sotiendong { get; set; }
        public DateTime? ngaydong { get; set; }
        public ChiTietHopDong(HopDong hopdong_chitiet, DoiTac doitac_chitiet, Rap rap_chitiet, double sotiendong, DateTime? ngaydong)
        {
            this.hopdong_chitiet=hopdong_chitiet;
            this.doitac_chitiet=doitac_chitiet;
            this.sotiendong=sotiendong;
            this.ngaydong=ngaydong;
            this.rap_chitiet=rap_chitiet;
        }
    }
}

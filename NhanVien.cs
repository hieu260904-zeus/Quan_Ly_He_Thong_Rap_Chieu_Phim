using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_He_Thong_Rap_Chieu_Phim
{
    public class NhanVien : ConNguoi
    {
        public string manhanvien { get; set; }
        public double luong { get; set; }
        public NhanVien(string manhanvien, string hoten, DateTime? ngaysinh, string diachi, string sdt, double luong) : base(hoten, ngaysinh, diachi, sdt)
        {
            this.manhanvien = manhanvien;
            this.luong=luong;
            
        }
    }
}

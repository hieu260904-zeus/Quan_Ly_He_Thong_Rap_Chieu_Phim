using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_He_Thong_Rap_Chieu_Phim
{
    public class QLHeThongRapChieuPhim
    {
        // Tao cac tap thuc the
        static List<Phim> dsPhim = new List<Phim>();
        static List<Phong> dsPhong = new List<Phong>();
        static List<TepKH> dsTepKhachHang = new List<TepKH>();
        static List<KhanGia> dsKhanGia = new List<KhanGia>();
        static List<HoaDon> dsHoaDon = new List<HoaDon>();
        static List<Rap> dsRap = new List<Rap>();
        static List<NhanVien> dsNhanVien = new List<NhanVien>();
        static List<ViTriCV> dsViTriCongViec = new List<ViTriCV>();
        static List<DoiTac> dsDoiTac = new List<DoiTac>();
        static List<HopDong> dsHopDong = new List<HopDong>();

        static List<LichChieu> dsLichChieu = new List<LichChieu>();
        static List<KhaNang> dsKhaNang = new List<KhaNang>();
        static List<ChiTietHopDong> dsChiTietHopDong = new List<ChiTietHopDong>();
        static List<ChiTietNguoiXem> dsChiTietNguoiXem = new List<ChiTietNguoiXem>();

        public static void taoDanhSachBoPhim()
        {
            dsPhim.Add(new Phim("BoPhim001", "Dat rung phuong Nam", "Phieu lieu", "Nguyen Quan Dung", "Tran Thanh", 1.30));
            dsPhim.Add(new Phim("BoPhim002", "Nguoi tinh", "Tinh cam", "Le Anh Dung", "Kang Tae Oh", 1.45));
            dsPhim.Add(new Phim("BoPhim003", "Chiec la cuoi cung", "Hinh su", "Vu Ngoc Dang", "Ngo Thanh Van", 1.50));
            dsPhim.Add(new Phim("BoPhim004", "Mat biec", "Lang mang", "Do Duc Thinh", "Tran Nu Yen Khe", 2.00));
            dsPhim.Add(new Phim("BoPhim005", "Co be ban diem", "Hai huoc", "Dinh Tuan Vu", "Sam", 1.35));
            dsPhim.Add(new Phim("BoPhim006", "Gac ma", "Kinh di", "Derek Nguyen", "Ngo Thanh Van", 1.40));
            dsPhim.Add(new Phim("BoPhim007", "Dinh thu Oan khuat", "Gia dinh", "Phan Gia Nhat Linh", "Ngoc Lan", 1.55));
            dsPhim.Add(new Phim("BoPhim008", "Thang tien hon nhan", "Tinh cam", "Ngo Quang Hai", "Quynh Nga", 1.25));
            dsPhim.Add(new Phim("BoPhim009", "Chay an", "Hanh dong", "Le Hoang", "Thai Hoa", 1.48));
            dsPhim.Add(new Phim("BoPhim010", "Conan - Chiec tau sat mau den", "Phieu Lieu - Hinh su", "Kodama Kenji", "Conan", 2.32));
            dsPhim.Add(new Phim("BoPhim011", "One Piece", "Phieu Lieu - Hinh su - Lang man", "Erochi Oda", "Luffy", 5.45));
            dsPhim.Add(new Phim("BoPhim012", "Bo Gia", "Gia Dinh", "Tran Thanh", "Tran Thanh", 2.30));
            dsPhim.Add(new Phim("BoPhim013", "Cua lai vo bau", "Tinh Cam", "Tran Thanh", "Tran Thanh", 2.30));
        }
        public static void taoDanhSachPhong()
        {
            dsPhong.Add(new Phong("Phong001", "A301", 90, true, dsRap[0]));
            dsPhong.Add(new Phong("Phong002", "B102", 80, true, dsRap[2]));
            dsPhong.Add(new Phong("Phong003", "C205", 100, false, dsRap[3]));
            dsPhong.Add(new Phong("Phong004", "D401", 120, false, dsRap[0]));
            dsPhong.Add(new Phong("Phong005", "E301", 95, true, dsRap[1]));
            dsPhong.Add(new Phong("Phong006", "F202", 110, false, dsRap[2]));
            dsPhong.Add(new Phong("Phong007", "G103", 75, true, dsRap[3]));
            dsPhong.Add(new Phong("Phong008", "H304", 85, true, dsRap[0]));
            dsPhong.Add(new Phong("Phong009", "I205", 105, false, dsRap[1]));
            dsPhong.Add(new Phong("Phong010", "J401", 130, false, dsRap[2]));
            dsPhong.Add(new Phong("Phong011", "K301", 100, true, dsRap[2]));
            dsPhong.Add(new Phong("Phong012", "L202", 115, false, dsRap[3]));
            dsPhong.Add(new Phong("Phong013", "M103", 80, true, dsRap[0]));
            dsPhong.Add(new Phong("Phong014", "N304", 90, true, dsRap[1]));
            dsPhong.Add(new Phong("Phong015", "O205", 110, false, dsRap[2]));
            dsPhong.Add(new Phong("Phong016", "A301", 90, true, dsRap[1]));
        }
        public static void taoDanhSachTepKH()
        {
            dsTepKhachHang.Add(new TepKH("TepKH001", "16 - 35", "Lang man", 40));
            dsTepKhachHang.Add(new TepKH("TepKH002", "10 - 60", "Hai huoc", 35));
            dsTepKhachHang.Add(new TepKH("TepKH003", "18 - 45", "Hanh dong", 30));
        }
        public static void taoDanhSachKG()
        {
            dsKhanGia.Add(new KhanGia("KG001", "Tran Minh Triet", new DateTime(2004, 04, 25), "TPHCM", "0877362452", dsTepKhachHang[0]));
            dsKhanGia.Add(new KhanGia("KG002", "Nguyen Thi Mai", new DateTime(1995, 08, 15), "Ha Noi", "0987654321", dsTepKhachHang[1]));
            dsKhanGia.Add(new KhanGia("KG003", "Le Van Hieu", new DateTime(1980, 03, 10), "Da Nang", "0909123456", dsTepKhachHang[2]));
            dsKhanGia.Add(new KhanGia("KG004", "Tran Thi Anh", new DateTime(1999, 06, 20), "Can Tho", "0369875412", dsTepKhachHang[0]));
            dsKhanGia.Add(new KhanGia("KG005", "Ho Van Hung", new DateTime(1988, 09, 30), "TP.HCM", "0789456123", dsTepKhachHang[0]));
            dsKhanGia.Add(new KhanGia("KG006", "Truong Van Khoi", new DateTime(2002, 05, 18), "Dak Lak", "0978563412", dsTepKhachHang[1]));
            dsKhanGia.Add(new KhanGia("KG007", "Phan Thi Thao", new DateTime(1998, 08, 14), "Long An", "0123456789", dsTepKhachHang[0]));
            dsKhanGia.Add(new KhanGia("KG008", "Nguyen Van Hoang", new DateTime(1983, 06, 15), "Quang Tri", "0932109876", dsTepKhachHang[2]));
            dsKhanGia.Add(new KhanGia("KG009", "Tran Thi Thuy", new DateTime(1996, 09, 10), "Binh Dinh", "0654789321", dsTepKhachHang[1]));
            dsKhanGia.Add(new KhanGia("KG010", "Tran Van Tuan", new DateTime(2010, 05, 30), "Ha Noi", "0932108765", dsTepKhachHang[1]));
        }
        public static void taoDanhSachHoaDon()
        {
            dsHoaDon.Add(new HoaDon("HD001", new DateTime(2023, 06, 25), 180, "Dat rung phuong Nam", 1.45, "G4", dsKhanGia[0]));
            dsHoaDon.Add(new HoaDon("HD002", new DateTime(2023, 06, 26), 150, "Chiec la cuoi cung", 1.3, "A2", dsKhanGia[1]));
            dsHoaDon.Add(new HoaDon("HD003", new DateTime(2023, 06, 27), 200, "Conan - Chiec tau sat mau den", 1.8, "B3", dsKhanGia[2]));
            dsHoaDon.Add(new HoaDon("HD004", new DateTime(2023, 06, 28), 120, "Chiec la cuoi cung", 1.2, "C1", dsKhanGia[3]));
            dsHoaDon.Add(new HoaDon("HD005", new DateTime(2023, 06, 29), 250, "Conan - Chiec tau sat mau den", 2.0, "D5", dsKhanGia[4]));
            dsHoaDon.Add(new HoaDon("HD006", new DateTime(2023, 06, 30), 190, "Mat biec", 1.6, "E2", dsKhanGia[2]));
            dsHoaDon.Add(new HoaDon("HD007", new DateTime(2023, 07, 01), 170, "Mat biec", 1.7, "F3", dsKhanGia[6]));
            dsHoaDon.Add(new HoaDon("HD008", new DateTime(2023, 07, 02), 210, "Mat biec", 1.9, "G4", dsKhanGia[3]));
            dsHoaDon.Add(new HoaDon("HD009", new DateTime(2023, 07, 03), 160, "Co be ban diem", 1.4, "A2", dsKhanGia[8]));
            dsHoaDon.Add(new HoaDon("HD010", new DateTime(2023, 07, 04), 180, "Thang tien hon nhan", 1.5, "B3", dsKhanGia[9]));
        }
        public static void taoDanhSachRap()
        {
            
            dsRap.Add(new Rap("Rap001", "Rap CGV Quan 9", "Quan 9 - TP.HCM", 4, 500, dsNhanVien[0]));
            dsRap.Add(new Rap("Rap002", "Rap Galaxy Tan Binh", "Tan Binh - TP.HCM", 5, 600, dsNhanVien[1]));
            dsRap.Add(new Rap("Rap003", "Rap Lotte Mart Go Vap", "Go Vap - TP.HCM", 3, 450, dsNhanVien[2]));
            dsRap.Add(new Rap("Rap004", "Rap BHD Vincom Thu Duc", "Thu Duc - TP.HCM", 6, 700, dsNhanVien[7]));
        }
        public static void taoDSNhanVien()
        {
            dsNhanVien.Add(new NhanVien("NV001", "Le Binh Tan", new DateTime(2000, 01, 20), "TP.HCM", "0878884223", 2000));
            dsNhanVien.Add(new NhanVien("NV002", "Nguyen Thi Hoa", new DateTime(1995, 05, 15), "Ha Noi", "0901234567", 1900));
            dsNhanVien.Add(new NhanVien("NV003", "Tran Van Quyen", new DateTime(1988, 10, 08), "TP.HCM", "0987654321", 5000));
            dsNhanVien.Add(new NhanVien("NV004", "Pham Thu Ha", new DateTime(1992, 03, 25), "Binh Dinh", "0912345678", 500));
            dsNhanVien.Add(new NhanVien("NV005", "Vo Ngoc Lan", new DateTime(1997, 08, 12), "Hue", "0888777666",600));
            dsNhanVien.Add(new NhanVien("NV006", "Truong Minh Duc", new DateTime(1990, 11, 30), "TP.HCM", "0909876543", 500));
            dsNhanVien.Add(new NhanVien("NV007", "Le Thi Anh Thu", new DateTime(1993, 04, 18), "Tien Giang", "0932109876", 700));
            dsNhanVien.Add(new NhanVien("NV008", "Hoang Van Hiep", new DateTime(1985, 07, 22), "Binh Ding", "0976543210",1000));
            dsNhanVien.Add(new NhanVien("NV009", "Nguyen Van Quang", new DateTime(1987, 12, 03), "Vung Tau", "0945678901", 800));
            dsNhanVien.Add(new NhanVien("NV010", "Tran Thi My Linh", new DateTime(1994, 06, 05), "Ha Noi", "0898765432", 600));
            dsNhanVien.Add(new NhanVien("NV011", "Tran Van An", new DateTime(1996, 09, 08), "TP.HCM", "0918765432", 700));
            dsNhanVien.Add(new NhanVien("NV012", "Nguyen Thi Mai", new DateTime(1991, 02, 14), "Da Nang", "0965432109", 650));
        }
        public static void taoDSViTriCV()
        {
            dsViTriCongViec.Add(new ViTriCV("CV001", "Ban ve", "Dung ban ve va ban nuoc"));
            dsViTriCongViec.Add(new ViTriCV("CV002", "Ky hop dong", "Gap go doi tac de ky hop dong"));
            dsViTriCongViec.Add(new ViTriCV("CV003", "Le tan", "Don tiep va huong dan khach hang"));
            dsViTriCongViec.Add(new ViTriCV("CV004", "Ke toan", "Quan ly cac giao dich tai chinh"));
            dsViTriCongViec.Add(new ViTriCV("CV005", "Nhan vien ve sinh", "Dua don sach se va bao tri khu vuc"));
            dsViTriCongViec.Add(new ViTriCV("CV006", "Thu quy", "Quan ly thu chi va bao cao tai chinh"));
            dsViTriCongViec.Add(new ViTriCV("CV007", "Bao ve", "Canh chung co ai nao loan. Giup do nguoi khong biet duong"));
            dsViTriCongViec.Add(new ViTriCV("CV008", "Trong xe", "O duoi ham trong xe"));
            dsViTriCongViec.Add(new ViTriCV("CV009", "Nhan vien phat to roi", "Di phat to roi de quang ba phim"));
            dsViTriCongViec.Add(new ViTriCV("CV0010", "Tho dien", "Sua chua thiet bi dien bi hu hong"));
        }
        public static void taoDSDoiTac()
        {
            dsDoiTac.Add(new DoiTac("DT001", "Le Hoang Long", new DateTime(1985, 09, 15), "TP.HCM", "0987654321"));
            dsDoiTac.Add(new DoiTac("DT002", "Nguyen Thanh Trung", new DateTime(1990, 03, 25), "Ha Noi", "0901234567"));
            dsDoiTac.Add(new DoiTac("DT003", "Tran Thi Mai Anh", new DateTime(1988, 11, 10), "Quang Ninh", "0912345678"));
            dsDoiTac.Add(new DoiTac("DT004", "Vo Van Hiep", new DateTime(1995, 05, 18), "Binh dinh", "0923456789"));
            dsDoiTac.Add(new DoiTac("DT005", "Le Thi Thu Ha", new DateTime(1992, 07, 22), "TP.HCM", "0934567890"));
        }
        public static void taoDSHopDong()
        {
            dsHopDong.Add(new HopDong("HD001", "Hop dong phim tinh cam", new DateTime(2018, 10, 11), 100000.5));
            dsHopDong.Add(new HopDong("HD002", "Hop dong phim hanh dong", new DateTime(2019, 12, 11), 230000.49));
            dsHopDong.Add(new HopDong("HD003", "Hop dong phim kinh di", new DateTime(2018, 10, 11), 200000.5));
            dsHopDong.Add(new HopDong("HD004", "Hop dong phim anime", new DateTime(2019, 12, 11), 430000.49));
            dsHopDong.Add(new HopDong("HD005", "Hop dong phim hoc duong", new DateTime(2018, 10, 11), 50000.5));
            dsHopDong.Add(new HopDong("HD006", "Hop dong phim nhac", new DateTime(2019, 12, 11), 330000.49));
        }
        public static void taoDSLichChieu()
        {
            dsLichChieu.Add(new LichChieu(dsPhim[9], dsPhong[0], new DateTime(2023, 07, 13, 19, 30,00)));
            dsLichChieu.Add(new LichChieu(dsPhim[0], dsPhong[1], new DateTime(2023, 07, 14, 16, 00, 00)));
            dsLichChieu.Add(new LichChieu(dsPhim[1], dsPhong[0], new DateTime(2023, 07, 13, 18, 00, 00)));
            dsLichChieu.Add(new LichChieu(dsPhim[9], dsPhong[5], new DateTime(2023, 08, 02, 18, 30, 30)));
            dsLichChieu.Add(new LichChieu(dsPhim[2], dsPhong[3], new DateTime(2023, 07, 13, 20, 45, 50)));
            dsLichChieu.Add(new LichChieu(dsPhim[4], dsPhong[6], new DateTime(2023, 10, 23,19, 30, 00)));
            dsLichChieu.Add(new LichChieu(dsPhim[8], dsPhong[1], new DateTime(2023, 05, 24, 20, 45, 50)));
            dsLichChieu.Add(new LichChieu(dsPhim[10], dsPhong[4], new DateTime(2023, 07, 16, 18, 00, 00)));
            dsLichChieu.Add(new LichChieu(dsPhim[7], dsPhong[2], new DateTime(2023, 09, 30, 18, 00, 00)));
            dsLichChieu.Add(new LichChieu(dsPhim[7], dsPhong[3], new DateTime(2023, 07, 29, 18, 00, 00)));
            dsLichChieu.Add(new LichChieu(dsPhim[9], dsPhong[9], new DateTime(2023, 07, 28, 17, 30, 00)));
            dsLichChieu.Add(new LichChieu(dsPhim[2], dsPhong[3], new DateTime(2023, 07, 13, 19, 30, 00)));
            dsLichChieu.Add(new LichChieu(dsPhim[10], dsPhong[3], new DateTime(2023, 08, 17, 18, 00, 00)));
            dsLichChieu.Add(new LichChieu(dsPhim[11], dsPhong[9], new DateTime(2023, 08, 13, 17, 30, 00)));
            dsLichChieu.Add(new LichChieu(dsPhim[12], dsPhong[3], new DateTime(2023, 09, 12, 19, 30, 00)));
        }
        public static void taoDSKhaNang()
        {
            dsKhaNang.Add(new KhaNang(dsNhanVien[0], new List<ViTriCV> { dsViTriCongViec[1], dsViTriCongViec[2], dsViTriCongViec[3] }, 3));
            dsKhaNang.Add(new KhaNang(dsNhanVien[1], new List<ViTriCV> { dsViTriCongViec[4] }, 1));
            dsKhaNang.Add(new KhaNang(dsNhanVien[2], new List<ViTriCV> { dsViTriCongViec[8], dsViTriCongViec[4] }, 2));
            dsKhaNang.Add(new KhaNang(dsNhanVien[3], new List<ViTriCV> { dsViTriCongViec[6], dsViTriCongViec[7] }, 2));
            dsKhaNang.Add(new KhaNang(dsNhanVien[4], new List<ViTriCV> { dsViTriCongViec[5] }, 1));
            dsKhaNang.Add(new KhaNang(dsNhanVien[5], new List<ViTriCV> { dsViTriCongViec[0] }, 1));
            dsKhaNang.Add(new KhaNang(dsNhanVien[6], new List<ViTriCV> { dsViTriCongViec[6] }, 1));
            dsKhaNang.Add(new KhaNang(dsNhanVien[7], new List<ViTriCV> { dsViTriCongViec[9] }, 1));
            dsKhaNang.Add(new KhaNang(dsNhanVien[8], new List<ViTriCV> { dsViTriCongViec[3], dsViTriCongViec[9] }, 2));
            dsKhaNang.Add(new KhaNang(dsNhanVien[9], new List<ViTriCV> { dsViTriCongViec[6], dsViTriCongViec[7], dsViTriCongViec[8] }, 3));
            dsKhaNang.Add(new KhaNang(dsNhanVien[10], new List<ViTriCV> { dsViTriCongViec[2] }, 1));
            dsKhaNang.Add(new KhaNang(dsNhanVien[11], new List<ViTriCV> { dsViTriCongViec[3] }, 1));
        }
        public static void taoDSChiTietHD()
        {
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[0], dsDoiTac[0], 500000, new DateTime(2018, 06, 30)));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[1], dsDoiTac[1], 300000, new DateTime(2019, 01, 15)));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[2], dsDoiTac[2], 700000, new DateTime(2018, 08, 20)));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[3], dsDoiTac[3], 450000, new DateTime(2019, 02, 28)));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[4], dsDoiTac[4], 800000, new DateTime(2018, 09, 10)));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[5], dsDoiTac[0], 600000, new DateTime(2019, 03, 05)));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[0], dsDoiTac[1], 350000, new DateTime(2018, 10, 15)));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[1], dsDoiTac[2], 900000, new DateTime(2019, 04, 20)));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[2], dsDoiTac[3], 520000, new DateTime(2018, 11, 25)));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[3], dsDoiTac[4], 670000, new DateTime(2019, 05, 30)));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[4], dsDoiTac[0], 380000, new DateTime(2018, 12, 05)));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[5], dsDoiTac[1], 740000, new DateTime(2019, 06, 10)));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[0], dsDoiTac[2], 490000, new DateTime(2019, 01, 20)));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[1], dsDoiTac[3], 620000, new DateTime(2019, 07, 15)));
            dsChiTietHopDong.Add(new ChiTietHopDong(dsHopDong[2], dsDoiTac[4], 580000, new DateTime(2019, 02, 25)));
        }
        public static void taoDSChiTietNguoiXem()
        {
            dsChiTietNguoiXem.Add(new ChiTietNguoiXem(dsPhim[0], dsKhanGia[1], true));
            dsChiTietNguoiXem.Add(new ChiTietNguoiXem(dsPhim[0], dsKhanGia[3], false));
            dsChiTietNguoiXem.Add(new ChiTietNguoiXem(dsPhim[2], dsKhanGia[5], true));
            dsChiTietNguoiXem.Add(new ChiTietNguoiXem(dsPhim[3], dsKhanGia[7], true));
            dsChiTietNguoiXem.Add(new ChiTietNguoiXem(dsPhim[4], dsKhanGia[9], false));
            dsChiTietNguoiXem.Add(new ChiTietNguoiXem(dsPhim[5], dsKhanGia[4], true));
            dsChiTietNguoiXem.Add(new ChiTietNguoiXem(dsPhim[6], dsKhanGia[4], false));
            dsChiTietNguoiXem.Add(new ChiTietNguoiXem(dsPhim[11], dsKhanGia[1], true));
            dsChiTietNguoiXem.Add(new ChiTietNguoiXem(dsPhim[8], dsKhanGia[1], false));
            dsChiTietNguoiXem.Add(new ChiTietNguoiXem(dsPhim[9], dsKhanGia[3], true));
            dsChiTietNguoiXem.Add(new ChiTietNguoiXem(dsPhim[10], dsKhanGia[5], false));
            dsChiTietNguoiXem.Add(new ChiTietNguoiXem(dsPhim[11], dsKhanGia[7], true));
            dsChiTietNguoiXem.Add(new ChiTietNguoiXem(dsPhim[0], dsKhanGia[9], false));
            dsChiTietNguoiXem.Add(new ChiTietNguoiXem(dsPhim[12], dsKhanGia[9], true));
            dsChiTietNguoiXem.Add(new ChiTietNguoiXem(dsPhim[2], dsKhanGia[8], false));
            dsChiTietNguoiXem.Add(new ChiTietNguoiXem(dsPhim[3], dsKhanGia[7], true));
            dsChiTietNguoiXem.Add(new ChiTietNguoiXem(dsPhim[4], dsKhanGia[1], false));
            dsChiTietNguoiXem.Add(new ChiTietNguoiXem(dsPhim[5], dsKhanGia[3], true));
            dsChiTietNguoiXem.Add(new ChiTietNguoiXem(dsPhim[11], dsKhanGia[5], false));
        }
        //Cho biết những hợp đồng có trị giá lớn hơn 200000 USD
        public void Cau1()
        {

        }
        // Cho biết thông tin những bộ phim khi biết được mã khán giả. Nếu ds bộ phim rỗng -> Khán giả chưa xem phim nào.
        public void Cau2()
        {

        }
        // Cho biết thông tin của những nhân viên có địa chỉ ở TP.HCM
        public void Cau3()
        {


        }
        // Cho biết thông tin những nhân viên có cấp độ cao nhất
        public void Cau4()
        {

        }
        // Cho biết những hợp đồng khi biết mã đối tác
        public void Cau5()
        {

        }
        // Cho biết những khán giả thuộc tệp khách hàng khi biết mã tệp khách hàng
        public void Cau6()
        {

        }
        // Tính số tiền lương của từng nhân viên với công thức: lương cơ bản * cấp độ
        public void Cau7()
        {

        }
        // In ra những hóa đơn của khán giả đó khi biết mã tệp khách hàng khán giả thuộc vào.
        public void Cau8()
        {

        }
        public void Cau9()
        {

        }
        // Cho biết thông tin của người quản lý rạp khi biết được mã phòng.
        public void Cau10()
        {

        }

        static void Main(string[] args)
        {
            // Gọi phương thức tạo tập thực thể
            taoDanhSachBoPhim();
            taoDSNhanVien();
            taoDanhSachRap();
            taoDanhSachPhong();
            taoDanhSachTepKH();
            taoDanhSachKG();
            taoDanhSachHoaDon();
            taoDSViTriCV();
            taoDSDoiTac();
            taoDSHopDong();
            taoDSLichChieu();
            taoDSKhaNang();
            taoDSChiTietHD();
            // Trả lời các câu hỏi truy vấn
            
            Console.ReadKey();
        }
    }

}

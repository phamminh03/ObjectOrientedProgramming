using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_PhamVanMinh_KTL2
{
    class GiayThoiTrang:SanPham,IPhu
    {
        double chieucaode;
        public double Chieucaode
        {
            get { return chieucaode; }
            set { chieucaode = value; }
        }
        string loaimuigiay;
        public string Loaimuigiay
        {
            get { return loaimuigiay; }
            set { loaimuigiay = value; }
        }
        public GiayThoiTrang(string masp, string tensp, string chatlieu, int size, string color, int namsanxuat, double dongia, double chieucaode, string loaimuigiay):base()
        {
            Masp = masp;
            Tensp = tensp;
            Chatlieu = chatlieu;
            Size = size;
            Color = color;
            Namsanxuat = namsanxuat;
            Dongia = dongia;
            Chieucaode = chieucaode;
            Loaimuigiay = loaimuigiay;
        }
        public override double Thanhtien()
        {
            return dongia * 50000 + chieucaode * 2000;
        }
        public double Giaphuthu()
        {
            if (loaimuigiay == "Mui nhon")
                return 12500;
            else
                return 10000;
        }
        public double Tongthanhtien()
        {
            return Thanhtien() + Giaphuthu();
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("Chieu cao de: " + chieucaode);
            Console.WriteLine("Loai mui giay: " + loaimuigiay);
            Console.WriteLine("Thanh tien: " + Thanhtien());
            Console.WriteLine("Phu thu: " + Giaphuthu());
            Console.WriteLine("Tong thanh tien: " + Tongthanhtien());
        }
    }
}

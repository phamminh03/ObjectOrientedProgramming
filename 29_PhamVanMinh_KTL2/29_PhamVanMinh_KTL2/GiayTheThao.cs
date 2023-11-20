using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_PhamVanMinh_KTL2
{
    class GiayTheThao:SanPham, IPhu
    {
        string loaigiay;
        public string Loaigiay
        {
            get { return loaigiay; }
            set { loaigiay = value; }
        }
        public GiayTheThao(string masp, string tensp, string chatlieu, int size, string color, int namsanxuat, double dongia, string loaigiay)
            : base()
        {
            Masp = masp;
            Tensp = tensp;
            Chatlieu = chatlieu;
            Size = size;
            Color = color;
            Namsanxuat = namsanxuat;
            Dongia = dongia;
            Loaigiay = loaigiay;
        }
        public double Giaphuthu()
        {
            if (loaigiay == "Running")
                return 30000;
            else
                return 25000;
        }
        public override double Thanhtien()
        {
            return dongia * 65000 + 30000;
        }
        public double Tongthanhtien()
        {
            return Thanhtien() + Giaphuthu();
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("Loai giay: " + loaigiay);
            Console.WriteLine("Thanh tien: " + Thanhtien());
            Console.WriteLine("Phu thu: " + Giaphuthu());
            Console.WriteLine("Tong thanh tien: " + Tongthanhtien());
        }
    }
}

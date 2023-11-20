﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_PhamVanMinh_KTL2
{
    class DepSandal:SanPham,IPhu
    {
        int soquay;
        public int Soquay
        {
            get { return soquay; }
            set { soquay = value; }
        }
        string loaide;
        public string Loaide
        {
            get { return loaide; }
            set { loaide = value; }
        }
        public DepSandal(string masp, string tensp, string chatlieu, int size, string color, int namsanxuat, double dongia, int soquay, string loaide)
            : base()
        {
            Masp = masp;
            Tensp = tensp;
            Chatlieu = chatlieu;
            Size = size;
            Color = color;
            Namsanxuat = namsanxuat;
            Dongia = dongia;
            Soquay = soquay;
            Loaide = loaide;
        }
        public double Giaphuthu()
        {
            return 0;
        }
        public override double Thanhtien()
        {
            return dongia * 35000 + soquay * 5000;
        }
        public double Tongthanhtien()
        {
            return Thanhtien() + Giaphuthu();
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("So quay: " + soquay);
            Console.WriteLine("Loai de: " + loaide);
            Console.WriteLine("Thanh tien: " + Thanhtien());
            Console.WriteLine("Tong thanh tien: " + Tongthanhtien());
        }
    }
}

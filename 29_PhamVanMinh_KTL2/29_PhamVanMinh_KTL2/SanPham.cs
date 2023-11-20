using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_PhamVanMinh_KTL2
{
    public abstract class SanPham
    {
        public string masp;
        public string Masp
        {
            get { return masp; }
            set { masp = value; }
        }
        public string tensp;
        public string Tensp
        {
            get { return tensp; }
            set { tensp = value; }
        }
        public string chatlieu;
        public string Chatlieu
        {
            get { return chatlieu; }
            set { chatlieu = value; }
        }
        public int size;
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int namsanxuat;
        public int Namsanxuat
        {
            get { return namsanxuat; }
            set { namsanxuat = value; }
        }
        public double dongia;
        public double Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        public abstract double Thanhtien();
       
        public virtual void output()
        {
            Console.WriteLine("");
            Console.WriteLine("Ma san pham: " + masp);
            Console.WriteLine("Ten san pham: " + tensp);
            Console.WriteLine("Chat lieu: " + chatlieu);
            Console.WriteLine("Kich thuoc: " + size);
            Console.WriteLine("Mau sac: " + color);
            Console.WriteLine("Nam san xuat: " + namsanxuat);
            Console.WriteLine("Don gia: " + dongia);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_PhamVanMinh_Tuan4
{
    abstract public class NhanVien
    {
        string manv;
        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        string ten;
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        int namsinh;
        public int Namsinh
        {
            get { return namsinh; }
            set { namsinh = value; }
        }
        string gioitinh;
        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        int nvl;
        public int Namvaolam
        {
            get { return nvl; }
            set { nvl = value; }
        }
        
        double hsl;
        public double Hesoluong
        {
            get { return hsl; }
            set { hsl = value; }
        }
        protected static double lcb = 1150;
        public double PhuCapThamNien()
        {
            int thamnien = DateTime.Today.Year - nvl;
            if (nvl >= 5)
                return thamnien * NhanVien.lcb / 100;
            return 0;
        }
        public double ThuNhap()
        {
            char xl = XepLoai();
            double hesothidua = 0;
            if (xl == 'A')
                hesothidua = 1.0;
            else if (xl == 'B')
                hesothidua = 0.75;
            else if (xl == 'C')
                hesothidua = 0.5;
            else
                hesothidua = 0;
            return hesothidua * TinhLuong() + PhuCapThamNien();
        }
        abstract public char XepLoai();
        abstract public double TinhLuong();
        virtual public void output()
        {
            Console.WriteLine("Ma so nhan vien: " + manv);
            Console.WriteLine("Ten nhan vien: " + ten);
            Console.WriteLine("Nam sinh: " + namsinh);
            Console.WriteLine("Gioi tinh: " + gioitinh);
            Console.WriteLine("He so luong: " + hsl);
            Console.WriteLine("Nam vao lam: " + nvl);
            Console.WriteLine("Thu nhap: " + ThuNhap());
        }
    }
}

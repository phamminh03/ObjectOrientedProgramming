using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class NhanVien
    {
        string msnv;
        public string Msnv
        {
            get { return msnv; }
            set { msnv = value; }
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
        double hsl;
        public double Hsl
        {
            get { return hsl; }
            set { hsl = value; }
        }
        int nvl;
        public int Nvl
        {
            get { return nvl; }
            set { nvl = value; }
        }
        protected static double lcb = 1210;
        public double PhuCapThamNien()
        {
            int thamnien = DateTime.Today.Year - nvl;
            if (thamnien >= 5)
                return thamnien * lcb / 100;
            else
                return 0;
        }
        public double ThuNhap()
        {
            char xl = XepLoai();
            double HeSoThiDua = 0;
            if (xl == 'A')
                HeSoThiDua = 1;
            else if (xl == 'B')
                HeSoThiDua = 0.75;
            else if (xl == 'C')
                HeSoThiDua = 0.5;
            else if (xl == 'D')
                HeSoThiDua = 0;
            return HeSoThiDua * TinhLuong() + PhuCapThamNien();
        }
        abstract public char XepLoai();
        abstract public double TinhLuong();
        virtual public void output()
        {
            Console.WriteLine("Ma so nhan vien: " + msnv);
            Console.WriteLine("Ho ten: " + ten);
            Console.WriteLine("Nam sinh: " + namsinh);
            Console.WriteLine("Gioi tinh: " + gioitinh);
            Console.WriteLine("Nam vao lam: " + nvl);
            Console.WriteLine("He so luong: " + hsl);
            Console.WriteLine("Phu cap tham nien: " + PhuCapThamNien());
            Console.WriteLine("Thu nhap: " + ThuNhap());
        }
    }
}

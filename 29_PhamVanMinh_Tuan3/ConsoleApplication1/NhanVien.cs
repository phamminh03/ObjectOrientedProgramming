using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class NhanVien
    {
            string ma;
            public string MaSo
            {
                get { return ma; }
                set { ma = value; }
            }
            string ten;
            public string Hoten
            {
                get { return ten; }
                set { ten = value; }
            }
            int NamVL;
            public int NamVaoLam
            {
                get { return NamVL; }
                set { NamVL = value; }
            }
            int SoNgayNghi;
            public int Songaynghi
            {
                get { return SoNgayNghi; }
                set { SoNgayNghi = value; }
            }
            double HSL;

            public NhanVien()
            {
                ma = "NV01";
                ten = "Pham Van Minh";
                NamVL = 2021;
                SoNgayNghi = 10;
                HSL = 3.0;
            }
            public NhanVien(string maso, string hoten, double hesoluong)
            {
                ma = maso;
                ten = hoten;
                HSL = hesoluong;
                NamVL = DateTime.Today.Year;
                SoNgayNghi = 0;
            }
            public NhanVien (string ma, string ten, int nvl, int nghi, double hesoluong)
            {
                this.ma = ma;
                this.ten = ten;
                this.NamVL = nvl;
                this.SoNgayNghi = nghi;
                this.HSL = hesoluong;
            }
            protected static int LuongCoBan = 1150;
            public virtual double PhuCapThamNien()
            {
                int thamnien = DateTime.Today.Year - NamVL;
                if (thamnien >= 5)
                    return thamnien * NhanVien.LuongCoBan / 100.0;
                return 0;
            }
            public virtual char XepLoai()
            {
                if (SoNgayNghi <= 1)
                    return 'A';
                else if (SoNgayNghi <= 3)
                    return 'B';
                else return 'C';
            }
            public virtual double Luong()
            {
                double hesoThiDua = 0.5;
                char xl = XepLoai();
                if (xl == 'A')
                    hesoThiDua = 1.0;
                if (xl == 'B')
                    hesoThiDua = 0.75;
                return NhanVien.LuongCoBan * HSL * hesoThiDua + PhuCapThamNien();
            }

            public void input()
            {
                Console.Write("Nhap Ma nhan vien: ");
                this.ma = Console.ReadLine();
                Console.Write("Nhap Ho va ten: ");
                this.ten = Console.ReadLine();
                Console.Write("Nhap Nam vao lam: ");
                this.NamVL = int.Parse(Console.ReadLine());
                Console.Write("Nhap So ngay nghi: ");
                this.SoNgayNghi = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
            public void output()
            {
                Console.WriteLine("Ma nhan vien: {0}", ma);
                Console.WriteLine("Ho va ten: {0}", ten);
                Console.WriteLine("Nam vao lam: {0}", NamVL);
                Console.WriteLine("So ngay nghi: {0}", SoNgayNghi);
                Console.WriteLine("");
            }
        }
}

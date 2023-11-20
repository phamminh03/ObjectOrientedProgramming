using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class NhanVien
    {
        string maso;
        public string MaSo
        {
            get { return maso; }
            set { maso = value; }
        }

        string hoten;
        public string HoTen
        {
            get { return hoten; }
            set { hoten = value; }
        }

        int ngaycong; //So ngay cong
        public int NgayCong
        {
            get { return ngaycong; }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Du lieu sai!");
                    ngaycong = 0;
                }
                else ngaycong = value;
            }
        }

        public char xeploai
        {
            get
            {
                if (ngaycong >= 26)
                    return 'A';
                else if (ngaycong >= 22)
                    return 'B';
                else return 'C';
            }
        }

        public static int luongngay = 200000;
        public NhanVien()
        {
            MaSo = HoTen = "";
            NgayCong = 0;
        }
        public NhanVien(string hoten, string maso, int ngaycong)
        {
            this.HoTen = hoten;
            this.MaSo = maso;
            this.NgayCong = ngaycong;
        }
        public NhanVien(NhanVien a)
        {
            this.HoTen = a.HoTen;
            this.MaSo = a.MaSo;
            this.NgayCong = a.NgayCong;
        }

        public void nhapTTNV()
        {
            Console.Write("Nhap Ma so nhan vien: ");
            MaSo = Console.ReadLine();
            Console.Write("Nhap Ho va ten nhan vien: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap so ngay cong: ");
            NgayCong = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public void xuatTTNV()
        {
            Console.WriteLine("Ma so nhan vien: {0}", maso);
            Console.WriteLine("Ho va ten: {0}", hoten);
            Console.WriteLine("So ngay cong: {0}", ngaycong);
            Console.WriteLine("Xep loai: {0}", xeploai);
            Console.WriteLine("Luong: {0}", tinhluong());
            Console.WriteLine("Thuong: {0}", tinhthuong());
        }
        public int tinhluong()
        {
            return ngaycong * luongngay;
        }
        public float tinhthuong()
        {
            if (xeploai == 'A')
                return tinhluong() * 5 / 100;
            else if (xeploai == 'B')
                return tinhluong() * 5 / 100;
            else return 0;
        }
    }
}

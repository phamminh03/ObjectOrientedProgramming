using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nhan vien
            NhanVien nv = new NhanVien();
            Console.WriteLine("Nhap thong tin nhan vien");
            nv.input();
            Console.WriteLine("Thong tin nhan vien");
            nv.output();

            //Can bo : Nhan vien
            CanBo cb = new CanBo();
            Console.WriteLine("Nhap thong tin can bo");
            cb.input();
            Console.WriteLine("Thong tin can bo");
            cb.output();
            nv = cb;
            nv.output();

            //Phu cap tham nien
            double PhuCap = nv.PhuCapThamNien();
            Console.WriteLine("Phu cap tham nien: " + PhuCap);

            //Xep loai nv
            char XepLoai = nv.XepLoai();
            Console.WriteLine("Xep Loai: " + XepLoai);

            //Luong
            double Luong = nv.Luong();
            Console.WriteLine("Luong: " + Luong);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_PhamVanMinh_Tuan4
{
    class NhanVienKD:NhanVien
    {
        double hsl;
        double doanhthuTT;
        public double DoanhthuTT
        {
            get { return doanhthuTT; }
            set { doanhthuTT = value; }
        }
        double doanhthu;
        public double Doanhthu
        {
            get { return doanhthu; }
            set { doanhthu = value; }
        }
        public NhanVienKD()
        {
            doanhthu = 1;
            doanhthuTT = 1;
        }
        public NhanVienKD(string manv, string ten, int namsinh, string gioitinh, double hsl, int nvl, double doanhthu, double doanhthuTT) : base()
        {
            Manv = manv;
            Ten = ten;
            Namsinh = namsinh;
            Gioitinh = gioitinh;
            Hesoluong = hsl;
            Namvaolam = nvl;
            this.doanhthu = doanhthu;
            this.doanhthuTT = doanhthuTT;
        }
        public override char XepLoai()
        {
            if (doanhthu < 0.5 * doanhthuTT)
                return 'D';
            else if (doanhthu < doanhthuTT)
                return 'C';
            else if (doanhthu < 2 * doanhthuTT)
                return 'B';
            else
                return 'A';
        }
        public override double TinhLuong()
        {
            return hsl * NhanVien.lcb + HoaHong();
        }
        public double HoaHong()
        {
            char xl = XepLoai();
            double vuot = doanhthu - doanhthuTT;
            if (vuot > 0)
                return 0.15 * vuot;
            return 0;
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("Doanh thu: " + doanhthu);
            Console.WriteLine("Doan thu toi thieu: " + doanhthuTT);
        }
    }
}

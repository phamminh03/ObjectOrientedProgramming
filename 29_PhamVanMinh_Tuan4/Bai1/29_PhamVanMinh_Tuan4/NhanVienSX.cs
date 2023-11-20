using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_PhamVanMinh_Tuan4
{
    class NhanVienSX:NhanVien
    {
        double hsl;
        int snn;
        public int Snn
        {
            get { return snn; }
            set { snn = value; }
        }
        protected static double hesoPhuCapNangNhoc = 0.1;
        public NhanVienSX()
        {
            snn = 0;
        }
        public NhanVienSX(string manv, string ten, int namsinh, string gioitinh, double hsl, int nvl, int snn):base()
        {
            Manv = manv;
            Ten = ten;
            Namsinh = namsinh;
            Gioitinh = gioitinh;
            Hesoluong = hsl;
            Namvaolam = nvl;
            this.Snn = snn;
        }
        
        public override char XepLoai()
        {
            if (snn <= 1)
                return 'A';
            else if (snn <= 3)
                return 'B';
            else if (snn <= 5)
                return 'C';
            else    
                return 'D';
        }
        public override double TinhLuong()
        {
            return hsl * NhanVien.lcb * (1 + NhanVienSX.hesoPhuCapNangNhoc);
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("So ngay nghi: " + snn);
        }
    }
}

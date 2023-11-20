using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_PhamVanMinh_Tuan4
{
    class CanBo:NhanVien
    {
        string chucvu;
        double hsl;
        public string Chucvu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }
        double hesoPhuCapChucVu;
        public double HesoPhuCapChucVu
        {
            get { return hesoPhuCapChucVu; }
            set { hesoPhuCapChucVu = value; }
        }
        public override char XepLoai()
        {
            return 'A';
        }
        public double PhuCapChucVu()
        {
            return 1100 * hesoPhuCapChucVu;
        }
        public override double TinhLuong()
        {
            return hsl * NhanVien.lcb + PhuCapChucVu();
        }
        public CanBo():base()
        {
            chucvu = "";
            hesoPhuCapChucVu = 2;
        }
        public CanBo(string manv, string ten, int namsinh, string gioitinh, double hsl, int nvl, string chucvu, double hesoPhuCapChucVu) : base()
        {
            Manv = manv;
            Ten = ten;
            Namsinh = namsinh;
            Gioitinh = gioitinh;
            Hesoluong = hsl;
            Namvaolam = nvl;
            this.chucvu = chucvu;
            this.hesoPhuCapChucVu = hesoPhuCapChucVu;
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("Chuc vu: " + chucvu);
            Console.WriteLine("He so phu cap chuc vu: " + hesoPhuCapChucVu);
        }
    }
}

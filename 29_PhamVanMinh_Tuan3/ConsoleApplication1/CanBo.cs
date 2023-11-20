using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CanBo:NhanVien
    {
        string chucvu;
        string phongban;
        double hesold;
        public CanBo():base()
        {
            chucvu = "Truong phong";
            phongban = "Phong Hanh Chinh";
            hesold = 5.0;
        }
        public CanBo (string ma, string ten, double hsl, string chucvu, double hesophucapcv) : base (ma, ten, DateTime.Today.Year, 1, hsl)
        {
            this.chucvu = chucvu;
            this.hesold = hesophucapcv;
        }
        public CanBo (string ma, string ten, int nvl, int nghi, double hsl, string chucvu, string pb, double hesold) : base (ma, ten, nvl, nghi, hsl)
        {
            this.chucvu = chucvu;
            this.phongban = pb;
            this.hesold = hesold;
        }
            public override char XepLoai()
            {
                return 'A';
            }
            public double PhuCapCV()
            {
                return hesold * NhanVien.LuongCoBan;
            }
            public override double Luong()
            {
                return base.Luong() + PhuCapCV();
            }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan5
{
    class NhaO:BatDongSan
    {
        int solau;
        public int Solau
        {
            get { return solau; }
            set { solau = value; }
        }
        public NhaO(double chieudai, double chieurong, int solau) : base()
        {
            Chieudai = chieudai;
            Chieurong = chieurong;
            Solau = solau;
        }
        public override double GiaBan()
        {
            return (double)dientich() * 10000 + solau * 100000;
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("So lau: " + solau);
            Console.WriteLine("Gia ban: " + GiaBan());
        }
    }
}

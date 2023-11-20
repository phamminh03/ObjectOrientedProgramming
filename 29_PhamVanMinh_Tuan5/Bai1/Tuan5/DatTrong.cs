using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan5
{
    class DatTrong:BatDongSan
    {
        public override double GiaBan()
        {
            return dientich() * 10000;
        }
        public DatTrong(double chieudai, double chieurong) : base()
        {
            Chieudai = chieudai;
            Chieurong = chieurong;
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("Gia ban: " + GiaBan());
        }
    }
}

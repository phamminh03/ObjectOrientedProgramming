using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan5
{
    class BietThu:BatDongSan,IPhi
    {
        public BietThu(double chieudai, double chieurong) : base()
        {
            Chieudai = chieudai;
            Chieurong = chieurong;
        }
        public override double GiaBan()
        {
            return dientich() * 400000;
        }
        public double PhiKinhDoanh()
        {
            return dientich() * 1000;
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("Gia ban: " + GiaBan());
            Console.WriteLine("Phi kinh doanh: " + PhiKinhDoanh());
        }
    }
}

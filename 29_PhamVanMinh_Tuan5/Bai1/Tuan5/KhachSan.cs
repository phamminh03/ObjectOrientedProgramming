using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan5
{
    class KhachSan:BatDongSan,IPhi
    {
        int sosao;
        public int Sosao
        {
            get { return sosao; }
            set { sosao = value; }
        }
        public KhachSan(double chieudai, double chieurong, int sosao):base()
        {
            Chieudai = chieudai;
            Chieurong = chieurong;
            Sosao = sosao;
        }
        public override double GiaBan()
        {
            return 100000 + sosao * 50000;
        }
        public double PhiKinhDoanh()
        {
            return chieurong * 5000;
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("So sao: " + sosao);
            Console.WriteLine("Gia ban: " + GiaBan());
            Console.WriteLine("Phi kinh doanh: " + PhiKinhDoanh());
        }
    }
}

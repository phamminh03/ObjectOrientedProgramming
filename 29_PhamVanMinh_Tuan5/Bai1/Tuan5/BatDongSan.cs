using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan5
{
    abstract public class BatDongSan
    {
        public double chieudai;
        public double Chieudai
        {
            get { return chieudai; }
            set { chieudai = value; }
        }
        public double chieurong;
        public double Chieurong
        {
            get { return chieurong; }
            set { chieurong = value; }
        }
        abstract public double GiaBan();
        public double dientich()
        {
            return chieudai * chieurong;
        }
        virtual public void output()
        {
            Console.WriteLine("Chieu dai: " + chieudai);
            Console.WriteLine("Chieu rong: " + chieurong);
        }
    }
}

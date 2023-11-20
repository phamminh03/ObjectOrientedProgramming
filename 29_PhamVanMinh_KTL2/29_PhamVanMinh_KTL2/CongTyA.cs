using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_PhamVanMinh_KTL2
{
    class CongTyA
    {
        string diachi;
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        string masothue;
        public string Masothue
        {
            get { return masothue; }
            set { masothue = value; }
        }
        public CongTyA(string diachi, string masothue)
        {
            this.Diachi = diachi;
            this.Masothue = masothue;
        }
    }
}

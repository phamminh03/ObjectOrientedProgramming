using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_PhamVanMinh_KTL2
{
    class Program
    {
        static void Main(string[] args)
        {
            DSSP dssp = new DSSP();
            dssp.read(@"../../data/DSSanPham.xml");
            dssp.print();
            Console.WriteLine("");
            Console.WriteLine("Tong gia thanh cua tat ca san pham: " + dssp.Tonggiatri());
            Console.WriteLine("Tong Phi phu thu: " + dssp.Tongphuphi());
            Console.ReadLine();
        }
    }
}

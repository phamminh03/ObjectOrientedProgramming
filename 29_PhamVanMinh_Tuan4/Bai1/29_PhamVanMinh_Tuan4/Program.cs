using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _29_PhamVanMinh_Tuan4
{
    class Program
    {
        static void Main(string[] args)
        {
            DSNV dsnv = new DSNV();
            dsnv.readDSNV(@"../../data/DSNV.xml");
            dsnv.printDSNV();
            Console.ReadLine();
        }
    }
}

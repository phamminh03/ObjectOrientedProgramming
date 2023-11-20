using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            PDK pdk = new PDK();
            pdk.inputPDK(@"../../data/PDK.xml");
            pdk.print();
            Console.ReadLine();
        }
    }
}

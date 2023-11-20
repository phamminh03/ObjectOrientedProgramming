using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan5
{
    class Program
    {
        static void Main(string[] args)
        {
            DSBDS dsbds = new DSBDS();
            dsbds.inputDSBDS(@"../../data/DSBDS1.xml");
            dsbds.outputDSBDS();
            Console.ReadLine();
        }
    }
}

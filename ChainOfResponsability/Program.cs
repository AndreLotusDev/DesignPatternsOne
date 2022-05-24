using ChainOfResponsability.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            Dumper dumper = new Dumper(new Bill(8, 10), new Bill(2, 5), new Bill(100, 2));

            dumper.RunDump(257);
            
            Console.ReadKey();
        }
    }
}

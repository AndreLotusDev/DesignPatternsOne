using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Classes
{
    public class Subtract : IHandleCalc
    {
        public double Calc(double n1, double n2)
        {
            return n1 - n2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Classes
{
    public interface IHandleCalc
    {
        double Calc(double n1, double n2);
    }
}

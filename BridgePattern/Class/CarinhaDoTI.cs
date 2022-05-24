using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Class
{
    public class CarinhaDoTI : IEmpregado
    {
        public CarinhaDoTI(string nome, double salario, string gostos) :base("Carinha do TI", nome, salario, gostos){}
    }
}

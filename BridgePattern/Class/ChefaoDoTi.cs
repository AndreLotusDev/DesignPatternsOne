using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Class
{
    class ChefaoDoTi : IEmpregado
    {
        public ChefaoDoTi(string nome, double salario, string gostos) :base("Chefao do TI", nome, salario, gostos){}
    }
}

using BridgePattern.Class;
using BridgePattern.Format;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormatter formatadorJson = new JsonEmpregado();
            IFormatter formatadorExcel = new ExcelEmpregado();

            IEmpregado TI = new CarinhaDoTI("Andre", 5000.00, "Ciclismo");
            IEmpregado chefaoTI = new ChefaoDoTi("Barbara", 11000.00, "Automobilismo");

            var tiStringJson = formatadorJson.EmpregadoFormatado(TI);
            var chefaoTiJson = formatadorJson.EmpregadoFormatado(chefaoTI);

            var tiStringExcel = formatadorExcel.EmpregadoFormatado(TI);
            var chefaoTiExcel = formatadorExcel.EmpregadoFormatado(chefaoTI);

            Console.WriteLine(tiStringJson);
            Console.WriteLine(chefaoTiJson);
            Console.WriteLine();
            Console.WriteLine(tiStringExcel);
            Console.WriteLine(chefaoTiExcel);

            Console.ReadKey();
        }
    }
}

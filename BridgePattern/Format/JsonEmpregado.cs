using BridgePattern.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Format
{
    public class JsonEmpregado : IFormatter
    {
        public string EmpregadoFormatado(IEmpregado empregado)
        {
            var stringTemp = empregado.PegaInformacao();

            var stringFinal = $"Essa string foi formatada em JSON: {{{stringTemp}}}";

            return stringFinal;
        }
    }
}

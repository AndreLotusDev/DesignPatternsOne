using BridgePattern.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Format
{
    public interface IFormatter
    {
        String EmpregadoFormatado(IEmpregado empregado);
    }
}

using AbstractPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPattern.Services
{
    public interface IServiceAbstract
    {
        CarroModelo ObterCarroModelo();
        BicicletaModelo ObterBicicletaModelo();
    }
}

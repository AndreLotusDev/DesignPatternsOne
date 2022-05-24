using AbstractPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPattern.Services
{
    public class RestService : IServiceAbstract
    {
        public BicicletaModelo ObterBicicletaModelo()
        {
            Console.WriteLine("Bicicleta pelo Rest");

            return new BicicletaModelo();
        }

        public CarroModelo ObterCarroModelo()
        {
            Console.WriteLine("Carro pelo Rest");

            return new CarroModelo();
        }
    }
}

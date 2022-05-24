using AbstractPattern.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual conector deseja usar? R ou S");

            var connector = Console.ReadLine();

            IServiceAbstract service = default;

            if ("R".Equals(connector))
                service = new RestService();
            else if ("S".Equals(connector))
                service = new SoapService();

            Console.WriteLine();
            Console.WriteLine("Demonstrando o modelo do carro");
            Console.WriteLine();

            var carroModelo = service.ObterCarroModelo();
            carroModelo.FuncoesDemonstrar();

            Console.ReadLine();
        }
    }
}

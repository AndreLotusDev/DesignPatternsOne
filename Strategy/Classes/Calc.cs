using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Classes
{
    public class Calc 
    {
        private IHandleCalc _handleCalc;

        public double N1 { get; private set; }
        public double N2 { get; private set; }

        public Calc()
        {
            Console.WriteLine("Vc quer somar (+) ou subtrair(-)");
            var tecla = Console.ReadKey();

            if (tecla.Key == ConsoleKey.OemMinus)
            {
                _handleCalc = new Subtract();
            }
            else if (tecla.Key == ConsoleKey.OemPlus)
            {
                _handleCalc = new Sum();
            }
            else
            {
                Console.WriteLine("Ta fazendo merda");
                throw new Exception("Argumentos invalidos");
            }

            Console.WriteLine("\nPrimeiro numero: ");
            N1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nSegundo numero: ");
            N2 = Convert.ToDouble(Console.ReadLine());
        }

        public double Calculate()
        {
            return _handleCalc.Calc(N1, N2);
        }
    }
}

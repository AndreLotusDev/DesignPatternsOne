using Strategy.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        //delegate bool Comparativo(double number);
        static void Main(string[] args)
        {
            //    double[] numeros = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };

            //Console.WriteLine("Voce quer comparar que os numeros devam ser maiores que: ?");

            //    var numero = Convert.ToInt32(Console.ReadLine());

            //var listaFormatada = PercorreNumeros(numeros, (double n) => numero < n);

            //    foreach (var _numero in listaFormatada)
            //        Console.WriteLine($"\n{_numero}");

            //    Console.ReadKey();

            Calc calculadora = new Calc();

            Console.WriteLine(calculadora.Calculate());

            Console.ReadKey();
        }

    //static IEnumerable<double> PercorreNumeros(double[] numeros, Comparativo gatilho)
    //{
    //    foreach (var numero in numeros)
    //    {
    //        if (gatilho(numero))
    //            yield return numero;
    //    }
    //}

}
}

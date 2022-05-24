using Observer.Observers;
using Observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler porteiro = new DoorWay(new Mom(), new Dad(), new BestFriend());

            Console.WriteLine("Aperte A quando ele chegar");

            ConsoleKeyInfo tecla;
            do
            {
                tecla = Console.ReadKey();

            } while (tecla.Key != ConsoleKey.A);

            porteiro.OnAction();

            Console.ReadLine();
        }
    }
}

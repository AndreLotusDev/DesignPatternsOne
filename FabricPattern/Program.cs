using FabricPattern.FullPatern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMonster monstro = default;

            Console.WriteLine("Digite a fase desejada 1/2/3");
            Console.WriteLine();
            var faseSelec = Convert.ToInt32(Console.ReadLine());

            //Complex factory
            //switch (faseSelec)
            //{
            //    case 1:
            //        monstro = new MonsterEasyFactory().CriarMonstro();
            //        break;

            //    case 2:
            //        monstro = new MonsterMediumFactory().CriarMonstro();
            //        break;

            //    case 3:
            //        monstro = new MonsterHardFactory().CriarMonstro();
            //        break;
            //}

            monstro = new SimpleFactoryMonster().CriarMonstro(faseSelec);

            monstro.ShowInfo();

            Console.ReadLine();
        }
    }
}

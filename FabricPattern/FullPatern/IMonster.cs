using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricPattern.FullPatern
{
    public abstract class IMonster
    {
        public int Damage { get; set; }

        public string Name { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Mob do tipo {Name} e Dano: {Damage}");
        }
    }
}

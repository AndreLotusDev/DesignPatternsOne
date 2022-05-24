using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricPattern.FullPatern
{
    public class MonsterHard : IMonster
    {
        public MonsterHard()
        {
            Damage = 10;
            Name = "HardMonster";
        }
    }
}

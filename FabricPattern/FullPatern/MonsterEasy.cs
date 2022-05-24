using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricPattern.FullPatern
{
    public class MonsterEasy : IMonster
    {
        public MonsterEasy()
        {
            Damage = 10;
            Name = "EasyMonster";
        }
    }
}

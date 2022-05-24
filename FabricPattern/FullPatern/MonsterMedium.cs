using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricPattern.FullPatern
{
    public class MonsterMedium : IMonster
    {
        public MonsterMedium()
        {
            Damage = 10;
            Name = "MediumMonster";
        }
    }
}

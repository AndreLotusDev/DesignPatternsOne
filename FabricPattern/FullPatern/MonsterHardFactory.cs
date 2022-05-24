using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricPattern.FullPatern
{
    public class MonsterHardFactory : IMonsterFactory
    {
        public IMonster CriarMonstro()
        {
            return new MonsterHard();
        }
    }
}

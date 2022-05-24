using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricPattern.FullPatern
{
    public class SimpleFactoryMonster 
    {
        public IMonster CriarMonstro(int fase)
        {
            switch (fase)
            {
                case 1:
                    return new MonsterEasy();
                case 2:
                    return new MonsterMedium();
                case 3:
                    return new MonsterHard();
                default:
                    throw new ArgumentException($"Argumento {nameof(fase)} está incorreto");
            }
        }
    }
}

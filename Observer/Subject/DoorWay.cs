using Observer.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subject
{
    public class DoorWay : Handler
    {
        public DoorWay(params ObserverPeople[] peoples):base(peoples){}

        public override void OnAction()
        {
            People?.ForEach(m => m.OnAction());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observer
{
    public abstract class ObserverPeople
    {
        public string MessageBonification { get; set; }

        public ObserverPeople(string message)
        {
            MessageBonification = message;
        }

        public void OnAction()
        {
            Console.WriteLine($"{MessageBonification}");
        }
    }
}

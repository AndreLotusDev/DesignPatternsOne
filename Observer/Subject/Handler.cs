using Observer.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subject
{
    public abstract class Handler
    {
        public bool Status { get; set; }

        public List<ObserverPeople> People { get; set; } = new List<ObserverPeople>();

        public Handler(params ObserverPeople[] peoples)
        {
            peoples?.ToList().ForEach(m => People?.Add(m));
        }

        public abstract void OnAction();

        public void SetStatus(bool status)
        {
            if(Status != status)
            {
                OnAction();
            }
        }

        public void Add(ObserverPeople newPeople)
        {
            People?.Add(newPeople);
        }
    }
}

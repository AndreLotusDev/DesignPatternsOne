using State.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.HeadphoneClass
{
    public class Headphone
    {
        public IStateHeadphone State { get; set; }

        public bool IsOn { get; set; }
        public bool IsOff { get; set; }

        public Headphone()
        {
            State = OffState.Instance;

            IsOff = true;
            IsOn = false;
        }

        public void GetActualFunction()
        {
            State.ActualFunction(this);
            Console.WriteLine("\n");
        }

        public void OnClick()
        {
            Console.WriteLine("Clique");
            State.OnClick(this);
        }

        public void OnLongClick()
        {
            Console.WriteLine("Clique longo");
            State.OnLongClick(this);
        }

        public void PowerOn()
        {
            IsOff = false;
            IsOn = true;
        }

        public void PowerOff()
        {
            IsOff = true;
            IsOn = false;
        }
    }
}

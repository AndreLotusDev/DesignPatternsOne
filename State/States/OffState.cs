using State.HeadphoneClass;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class OffState : IStateHeadphone
    {
        public static IStateHeadphone Instance { get; } = new OffState();

        private OffState() { }

        public void OnClick(Headphone hp)
        {
            if(hp.IsOff)
            {
                WriteLine("O aparelho esta desligado, clique de forma mais longa para ligar");
                hp.GetActualFunction();
            }
            else
                throw new Exception("Erro interno");
        }

        public void OnLongClick(Headphone hp)
        {
            if(hp.IsOff)
            {
                WriteLine("O aparelho sera inicializado");
                hp.PowerOn();
                hp.State = OnState.Instance;
                hp.GetActualFunction();
            }
            else
                throw new Exception("Erro interno");
        }

        public void ActualFunction(Headphone hp)
        {
            WriteLine("O aparelho esta desligado, ligue ele");
        }
    }
}

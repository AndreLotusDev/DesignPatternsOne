using State.HeadphoneClass;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class OnState : IStateHeadphone
    {
        public static IStateHeadphone Instance { get; } = new OnState();

        private OnState() { }

        public void OnClick(Headphone hp)
        {
            if (hp.IsOn)
            {
                WriteLine("O aparelho comecou a tocar musica");
                hp.GetActualFunction();
                hp.State = OnPlaying.Instance;
            }
            else
                throw new Exception("Erro interno");
        }

        public void OnLongClick(Headphone hp)
        {
            if (hp.IsOn)
            {
                WriteLine("O aparelho ira se desligar");
                hp.State = OffState.Instance;
                hp.PowerOff();
                hp.GetActualFunction();
            }
            else
                throw new Exception("Erro interno");
        }

        public void ActualFunction(Headphone hp)
        {
            WriteLine("O aparelho esta ligado, pressione o clique longo para desligar e clique curto para dar play nas musicas");
        }
    }
}

using State.HeadphoneClass;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class OnPlaying : IStateHeadphone
    {
        public static IStateHeadphone Instance { get; } = new OnPlaying();

        private OnPlaying() { }

        public void OnClick(Headphone hp)
        {
            if (hp.IsOn)
            {
                WriteLine("O aparelho agora ira parar de tocar musica");
                hp.State = OnState.Instance;
                hp.GetActualFunction();
            }
            else
                throw new Exception("Erro interno");
        }

        public void OnLongClick(Headphone hp)
        {
            if (hp.IsOn)
            {
                WriteLine("O aparelho sera desligado");
                hp.PowerOff();
                hp.State = OffState.Instance;
                hp.GetActualFunction();
            }
            else
                throw new Exception("Erro interno");
        }

        public void ActualFunction(Headphone hp)
        {
            WriteLine("O aparelho esta tocando musica, um clique para pausar a musica, longo clique para desligar");
        }
    }
}

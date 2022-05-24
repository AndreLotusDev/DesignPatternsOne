using State.HeadphoneClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public interface IStateHeadphone
    {
        void OnClick(Headphone hp);
        void OnLongClick(Headphone hp);
        void ActualFunction(Headphone hp);
    }
}

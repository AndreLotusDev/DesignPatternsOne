using Decorator.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public class DoubleDrink : IDecorator
    {
        public DoubleDrink(IDrink drink):base(drink)
        {
            Descricao = Descricao.Remove(Descricao.LastIndexOf("+"), 2);
            Descricao += "(2X)";
            Preco *= 2;
        }
    }
}

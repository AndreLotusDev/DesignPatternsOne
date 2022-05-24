using Decorator.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public class Canela : IDecorator
    {
        public Canela(IDrink drink) : base(drink, "CANELA", 1.50) { }
    }
}

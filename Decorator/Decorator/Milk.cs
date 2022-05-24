using Decorator.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public class Milk : IDecorator
    {
        public Milk(IDrink drink) : base(drink, "LEITE", 2.50) { }
    }
}

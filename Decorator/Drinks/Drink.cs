using Decorator.Decorator;

namespace Decorator.Drinks
{
    public class Drink : IDrink
    {
        public Drink(string bebida, double preco)
        {
            Descricao = bebida;
            Preco = preco;
        }
    }
}

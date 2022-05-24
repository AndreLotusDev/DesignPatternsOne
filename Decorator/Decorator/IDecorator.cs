using Decorator.Drinks;
using System;

namespace Decorator.Decorator
{
    public abstract class IDecorator : IDrink
    {
        protected IDrink Drink;
        protected string _ingrediente;
        protected double _precoAdicional;
        public IDecorator(IDrink drink, string ingrediente = "", double preco = 0)
        {
            Drink = drink;

            _ingrediente = ingrediente;
            _precoAdicional = preco;

            this.AdicionaIngredienteAdicionais(_ingrediente);
            this.AdicionarPrecoDoAdicional(_precoAdicional);
        }

        private void AdicionaIngredienteAdicionais(string _ingrediente)
        {
            this.Descricao = Drink.AdicionaIngrediente(_ingrediente);
        }

        private void AdicionarPrecoDoAdicional(double _precoAdicional)
        {
            this.Preco = Drink.AdicionaPreco(_precoAdicional);
        }
    }
}

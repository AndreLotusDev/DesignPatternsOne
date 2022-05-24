using System;

namespace Decorator.Drinks
{
    public abstract class IDrink
    {
        public string Descricao { get; protected set; }
        public double Preco { get; protected set; }

        public void GetInformacao()
        {
            Console.WriteLine($"Bebida: {Descricao}");
        }

        public void GetPreco()
        {
            Console.WriteLine($"Preço da bebida: {Preco} R$");
        }

        public virtual double AdicionaPreco(double valorAdicional)
        {
            return Preco += valorAdicional;
        }

        public virtual string AdicionaIngrediente(string ingrediente)
        {
            return Descricao += " + " + ingrediente;
        }

        public override string ToString()
        {
            return $"Informações sobre o pedido:\n" +
                $"Descrição: {Descricao}\n" +
                $"Preço total: {Preco}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Class
{
    public class Dumper
    {
        public List<Bill> Bills { get; private set; } = new List<Bill>();
        public Dumper(params Bill[] bills)
        {
            bills.ToList().ForEach(m => Bills.Add(m));

            SetNodeRun();
        }

        private void SetNodeRun()
        { 
            if(Bills.Any())
            {
                for(int index = 0; index < Bills.Count - 1; index++)
                {
                    Bills[index].SetNextBill(Bills[index + 1]);
                }
            }
        }

        public void RunDump(int quantityToWithDraw)
        {
            Console.WriteLine($"Tentativa de retirada de: {quantityToWithDraw}");

            var oQueDeuPraRetirar = Bills[0].WithDraw(quantityToWithDraw);

            Bills.ForEach(m => Console.WriteLine(m.ToString()));

            if(oQueDeuPraRetirar > 0)
            {
                Console.WriteLine($"\nNao temos notas pra retirar esse restante de valor: {oQueDeuPraRetirar}");
            }
        }
    }
}

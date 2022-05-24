using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPattern.Models
{
    public abstract class IModel
    {
        public string NomeModelo { get; set; }
        
        public void FuncoesDemonstrar()
        {
            Console.WriteLine($"Esse modelo {NomeModelo} pode: Deletar e Atualizar");
        }

        public void Atualizar()
        {
            Console.WriteLine($"{NomeModelo} atualizado");
        }

        public void Deletar()
        {
            Console.WriteLine($"{NomeModelo} deletado");
        }
    }
}

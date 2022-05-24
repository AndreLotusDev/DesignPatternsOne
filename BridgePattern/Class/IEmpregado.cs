using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Class
{
    public abstract class IEmpregado
    {
        public IEmpregado(string posicao, string nome, double salario, string gostos)
        {
            Nome = nome;
            Salario = salario;
            Gostos = gostos;
            Posicao = posicao;
        }

        private string Nome { get; set; }
        private double Salario { get; set; }
        private string Gostos { get; set; }
        private string Posicao { get; set; }

        public string PegaInformacao()
        {
            return $"Nome : {Nome} - Salario {Salario} - Seus gostos: {Gostos} - Posicao na empresa :{Posicao}";
        }
    }
}

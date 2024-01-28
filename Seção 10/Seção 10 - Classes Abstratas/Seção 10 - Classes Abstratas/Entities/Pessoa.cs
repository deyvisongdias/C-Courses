using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_10___Classes_Abstratas.Entities
{
    internal abstract class Pessoa
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        protected Pessoa(string nome, double rendaAnual)
        {
            this.Nome = nome;
            this.RendaAnual = rendaAnual;
        }

        protected Pessoa()
        {
        }

        public abstract double CalculoDeImposto();
        public abstract string toString();

    }
}

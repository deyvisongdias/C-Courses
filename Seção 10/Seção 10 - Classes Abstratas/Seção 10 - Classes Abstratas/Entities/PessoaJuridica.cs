using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_10___Classes_Abstratas.Entities
{
    internal class PessoaJuridica : Pessoa
    {
        public int NumeroDeFuncionarios { get; set; }

        public PessoaJuridica(string nome, double RendaAnual, int numeroDeFuncionarios) : base(nome, RendaAnual)
        {
            NumeroDeFuncionarios = numeroDeFuncionarios;
        }

        public override double CalculoDeImposto()
        {
            if (this.NumeroDeFuncionarios > 0 && this.NumeroDeFuncionarios <= 10)
            {
                return base.RendaAnual * 0.16;
            }
            else
            {
                return base.RendaAnual * 0.14;
            }
        }

        public override string toString()
        {
            return base.Nome + ": $ " + CalculoDeImposto();
        }
    }
}

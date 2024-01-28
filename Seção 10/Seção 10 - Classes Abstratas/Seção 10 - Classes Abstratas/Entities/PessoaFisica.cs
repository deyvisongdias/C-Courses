using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_10___Classes_Abstratas.Entities
{
    internal class PessoaFisica : Pessoa
    {
        public double GastosComSaude { get; set; }

        public PessoaFisica(string nome, double RendaAnual, double gastosComSaude) : base(nome, RendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }

        public override double CalculoDeImposto()
        {
            if (base.RendaAnual >= 0 || base.RendaAnual < 20000)
            {
                if (GastosComSaude != 0)
                {
                    return (base.RendaAnual * 0.25)- (this.GastosComSaude * 0.5);
                }
                else if (this.GastosComSaude == 0)
                {
                    return (base.RendaAnual * 0.25);
                }
            }
            else if (base.RendaAnual >= 20000)
            {
                if (this.GastosComSaude != 0)
                {
                    return (base.RendaAnual * 0.15) - (this.GastosComSaude * 0.5);
                }
                else if (this.GastosComSaude == 0)
                {
                    return (base.RendaAnual * 0.15);
                }
            }
            return 0;
        }

        public override string toString()
        {
            return base.Nome + ": $ " + CalculoDeImposto();                                                                   
        }
    }
}

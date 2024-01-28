using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_10___Exercicio_resolvido.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double additionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            this.additionalCharge = additionalCharge;
        }

        public override double payment()
        {
            double value = (additionalCharge) * 1.10;
            return valuePerHour * hours + (value);
        }

        public override string toString()
        {
            return this.name + " - $ " + this.payment();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_10___Exercicio_resolvido.Entities
{
    internal class Employee
    {
        public String name { get; set; }
        public int hours { get; set; }
        public double valuePerHour { get; set; }

        public Employee(string name, int hours, double valuePerHour)
        {
            this.name = name;
            this.hours = hours;
            this.valuePerHour = valuePerHour;
        }

        public Employee()
        {
        }

        public virtual double payment()
        {
            return valuePerHour * hours;
        }

        public virtual string toString()
        { 
            return this.name+" - $ "+this.payment();
        }
    }
}

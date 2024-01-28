using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_10.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime manufactureDate { get; set; }

        public UsedProduct( string name, double price,DateTime manufactureDate) : base(name, price)
        {
            this.manufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return this.name + " $ " + this.price + " (Manufacture date: " + this.manufactureDate + ")";
        }

    }
}

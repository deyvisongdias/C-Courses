using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_10.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        private double totalPrice()
        {
            return CustomsFee + this.price;
        }
        public override string priceTag()
        {
            return this.name + " $ " + totalPrice() + " (Customs fee: & " + this.CustomsFee + ")";
        }
    }
}

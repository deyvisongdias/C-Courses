using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_9___Exercicio_cap.Entities
{
    internal class OrderItem
    {
        public int quantity { get; set; }
        public int price { get; set; }

        public Product product { get; set; }

        public OrderItem(int quantity, int price)
        {
            this.quantity = quantity;
            this.price = price;
            this.product = new Product();
        }
        public OrderItem()
        {

        }

        public double subTotal()
        {
            return quantity * price;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_9___Exercicio_cap.Entities
{
    internal class Order
    {
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }
        public List<OrderItem> orderItem { get; set; }
        public Client Client { get; set; }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            this.moment = moment;
            this.status = status;
            this.orderItem = new List<OrderItem>();
            Client = client;
        }

        public Order()
        {
        }

        public void addItem(OrderItem item)
        {
            orderItem.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            orderItem.Remove(item);
        }

        public double total()
        {
            return orderItem.Count();
        }
    }
}

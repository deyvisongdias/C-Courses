using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_9___Exercicio_cap.Entities
{
    internal class Client
    {
        public string name { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }

        public Order order { get; set; }

        public Client(string name, string email, DateTime birthDate, Order order)
        {
            this.name = name;
            this.email = email;
            this.birthDate = birthDate;
            this.order = order;
        }

        public Client()
        {
        }
    }
}

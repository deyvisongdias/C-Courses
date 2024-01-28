using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_6
{
    internal class Aluguel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public Aluguel(string name, string email, int room)
        {
            Name = name;
            Email = email;
            Room = room;
        }

        public Aluguel()
        {

        }   
        
        public String toString()
        {
            return "Name: " + this.Name + "\n" +
                "Email: " + this.Email + "\n" +
                "Room: " + this.Room;
        }
    }
}

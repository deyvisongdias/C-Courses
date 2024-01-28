using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_9.Entities
{
    internal class Department
    {
        public String name { get; set; }

        public Department(string name)
        {
            this.name = name;
        }

        public Department()
        {

        }
    }
}

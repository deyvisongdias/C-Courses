using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_9___Execicio_2.Entities
{
    internal class Comment
    {
       
        public String text { get; set; }

        public Comment(string text)
        {
            this.text = text;
        }

        public Comment()
        {
        }

    }
}

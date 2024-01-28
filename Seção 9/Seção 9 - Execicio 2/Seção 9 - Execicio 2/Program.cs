using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_9___Execicio_2.Entities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post(DateTime.Now, "Traveling to New Zealand", "Im going to visit this wonderfull country!", 12);
            post.AddComment("Have a nice trip");
            post.AddComment("Wow that's awesome!");
            Console.WriteLine(post.toString());
            Console.WriteLine("Comments: ");
            post.PrintComments();
            

            Console.WriteLine();

            Post post2 = new Post(DateTime.Now, "Good night guys", "See you tomorrow", 5);
            post2.AddComment("Good night");
            post2.AddComment("May the Force be with you");
            Console.WriteLine(post2.toString());
            Console.WriteLine("Comments: ");
            post2.PrintComments();
        }
    }
}

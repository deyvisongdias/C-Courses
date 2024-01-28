using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Seção_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int number;
            Console.WriteLine("How many rooms will be render?");
            number = int.Parse(Console.ReadLine());
            Aluguel[] vet = new Aluguel[10];
            String name, email;
            int room;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Rent #" + (i + 1));
                Console.WriteLine("Name:");
                name = Console.ReadLine();
                Console.WriteLine("Email:");
                email = Console.ReadLine();
                Console.WriteLine("Room:");
                room = int.Parse(Console.ReadLine());
                if (room < 0 || room > 9 || vet[room] != null)
                {
                    while (room < 0 || room > 9 || vet[room] != null)
                    {
                        Console.WriteLine("Room number already chosen. Choose another:");
                        Console.WriteLine("Room:");
                        room = int.Parse(Console.ReadLine());
                    }
                }
                Aluguel al = new Aluguel(name, email, room);
                vet[room] = al;
            }

            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine(vet[i].toString());
                }
            }           
        }
            */

            int x = 10;
            Console.WriteLine(x);
            teste(ref x);  //ref e utilizado para mudar a passagem de parametro de valor para referencia
            Console.WriteLine(x);

        }

        //ref e utilizado para mudar a passagem de parametro de valor para referencia
        public static void teste(ref int x)
        {
            x = x * 3;
        }

        //out e utilizado para mudar de valor para referencia tambem, porem não e necessario inicializar a variavel com no ref
    }
}

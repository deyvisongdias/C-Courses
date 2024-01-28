using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_10.Entities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the number of products:");
            int number = int.Parse(Console.ReadLine());
            List<Product> prod = new List<Product>();
            char type;
            String name;
            double price;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Product #" + (i + 1) + " data:");
                Console.WriteLine("Common, used or imported(c / u / i) ?");
                type = char.Parse(Console.ReadLine());
                if (type == 'c' || type == 'C')
                {
                    Console.WriteLine("Name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Price: ");
                    price = double.Parse(Console.ReadLine());
                    Product pdc = new Product(name, price);
                    prod.Add(pdc);
                }
                if (type == 'i' || type == 'I')
                {
                    Console.WriteLine("Name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Price: ");
                    price = double.Parse(Console.ReadLine());
                    Console.WriteLine("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    Product pdi = new ImportedProduct(name, price, customsFee);
                    prod.Add(pdi);
                }
                if (type == 'u' || type == 'U')
                {
                    Console.WriteLine("Name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Price: ");
                    price = double.Parse(Console.ReadLine());
                    Console.WriteLine("Manufacture date(DD/ MM / YYYY):");
                    string manufactureString = Console.ReadLine();
                    DateTime manufactureDate = DateTime.Parse(manufactureString);
                    Product pdu = new UsedProduct(name, price, manufactureDate);
                    prod.Add(pdu);
                }
            }
            Console.WriteLine("PRICE TAGS:");
            foreach (Product pd in prod)
            {
                Console.WriteLine(pd.priceTag());
            }
        }
    }
}

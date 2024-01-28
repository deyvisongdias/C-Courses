using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_10___Exercicio_resolvido.Entities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();
            Console.WriteLine("Enter the number of employees:");
            int number = int.Parse(Console.ReadLine());
            char ch;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Employee #" + (i + 1) + "data");
                Console.WriteLine("Outsourced(y/ n)?");
                ch = char.Parse(Console.ReadLine());
                if (ch == 'y')
                {
                    Console.WriteLine("Name: ");
                    String name = Console.ReadLine();
                    Console.WriteLine("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.WriteLine("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine());
                    Console.WriteLine("Additional charge:");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    Employee empObject = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    emp.Add(empObject);
                }
                if (ch == 'n')
                {
                    Console.WriteLine("Name: ");
                    String name = Console.ReadLine();
                    Console.WriteLine("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.WriteLine("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine());
                    Employee empObject = new Employee(name, hours, valuePerHour);
                    emp.Add(empObject);
                }
            }

            Console.WriteLine("PAYMENTS:");
            foreach (Employee e in emp)
            {
                Console.WriteLine(e.toString());
            }
        }
    }
}

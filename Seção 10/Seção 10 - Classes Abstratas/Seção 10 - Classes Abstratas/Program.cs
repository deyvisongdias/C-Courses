using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_10___Classes_Abstratas.Entities
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Pessoa> pessoas = new List<Pessoa>();

            Console.WriteLine("Enter the number of tax payers: ");
            int number = int.Parse(Console.ReadLine());
            char type;
            string name;
            double anualIncome;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Tax payer #" + (i + 1) + " data:");
                Console.WriteLine("Individual or company(i / c) ?");
                type = char.Parse(Console.ReadLine());
                if (type == 'i')
                {
                    Console.WriteLine("Name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Anual income:");
                    anualIncome = double.Parse(Console.ReadLine());
                    Console.WriteLine("Health expenditures:");
                    double healthExp = double.Parse(Console.ReadLine());
                    Pessoa pessoa = new PessoaFisica(name, anualIncome, healthExp);
                    pessoas.Add(pessoa);
                }
                if (type == 'c')
                {
                    Console.WriteLine("Name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Anual income:");
                    anualIncome = double.Parse(Console.ReadLine());
                    Console.WriteLine("Number of employees:");
                    int numberEmp = int.Parse(Console.ReadLine());
                    Pessoa pessoa = new PessoaJuridica(name, anualIncome, numberEmp);
                    pessoas.Add(pessoa);
                }
            }
            Console.WriteLine("TAXES PAID:");
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa.toString());
            }

            Console.WriteLine("\n");
            double totalTaxes = 0.0;

            foreach (Pessoa pessoa in pessoas)
            {
                totalTaxes += pessoa.CalculoDeImposto();
            }
            Console.WriteLine("TOTAL TAXES: $ " + totalTaxes);
        }
    }
}

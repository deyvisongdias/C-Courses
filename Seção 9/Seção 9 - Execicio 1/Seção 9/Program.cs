using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_9.Entities
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter department's name:");
            String departmentName = Console.ReadLine();

            Console.WriteLine("Enter worker data:");
            Console.WriteLine("Name:");
            String workerName = Console.ReadLine();
            Console.WriteLine("Level(Junior / MidLevel / Senior):");
            WorkerLevel work = WorkerLevel.JUNIOR;
            String level = Console.ReadLine();

            if (level.ToLower() == "junior")
            {
                work = WorkerLevel.JUNIOR;
            }
            if (level.ToLower() == "midlevel")
            {
                work = WorkerLevel.MID_LEVEL;
            }
            if (level.ToLower() == "senior")
            {
                work = WorkerLevel.SENIOR;
            }

            Console.WriteLine("Base salary:");
            Double baseSalary = double.Parse(Console.ReadLine());
            Console.WriteLine("How many contracts to this worker ?");
            int numberContracts = int.Parse(Console.ReadLine());

            Worker worker = new Worker(workerName, work, baseSalary, departmentName);

            int i = 0;
            while (i < numberContracts)
            {
                Console.WriteLine("Enter #" + (i + 1) + " contract data:");
                Console.WriteLine("Date(DD / MM / YYYY):");
                String strData = Console.ReadLine();
                DateTime data = DateTime.Parse(strData);
                Console.WriteLine("Value per hour:");
                Double value = Double.Parse(Console.ReadLine());
                Console.WriteLine("Duration(hours):");
                int duration = int.Parse(Console.ReadLine());
                HourContract hc = new HourContract(data, value, duration);
                worker.addContract(hc);
                i++;
            }

            Console.WriteLine("Enter month and year to calculate income(MM / YYYY):");
            Console.WriteLine("Month: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Income for " + month + "/" + year + ": " + worker.income(month, year));
        }
    }
}

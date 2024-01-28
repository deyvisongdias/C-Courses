using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_9.Entities
{
    internal class Worker
    {
        public String name { get; set; }
        public WorkerLevel workerLevel { get; set; }
        public Double baseSalary { get; set; }
        public List<HourContract> hourContract { get; set; }
        public Department department { get; set; }

        public Worker(string name, WorkerLevel workerLevel, double baseSalary, String departmentName)
        {
            this.name = name;
            this.workerLevel = workerLevel;
            this.baseSalary = baseSalary;
            this.department = new Department(departmentName);
            hourContract = new List<HourContract>();
        }

        public Worker()
        {
        }

        public void addContract(HourContract contract)
        {
            hourContract.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            hourContract.Remove(contract);
        }

        public void toStringE()
        {
            Console.WriteLine("Name: "+this.name);
            Console.WriteLine("Department: "+this.department.name);
        }

        public Double income(int month, int year)
        {
            Double result = 0;
            foreach (HourContract item in hourContract)
            {
                if (item.date.Year == year && item.date.Month == month)
                {
                    result = result + (item.totalValue());
                    Console.WriteLine("RESULTADO: " + result);
                }
            }
            toStringE();
            return result;
        }
    }
}

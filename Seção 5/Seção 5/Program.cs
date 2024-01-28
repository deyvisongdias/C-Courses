using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Conta conta = new Conta("15423", "Deyvison Gregorio Dias", 2000.0);
            Conta conta2 = new Conta("23232", "Sonia aparecida Gregorio");
            Console.WriteLine(conta.toString());
            Console.WriteLine(conta2.toString());

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Realizando depositos");
            conta.deposito(3203.0) ;
            conta2.deposito(2333.3);
            Console.WriteLine(conta.toString());
            Console.WriteLine(conta2.toString());

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Realizando saques");
            conta.saque(560.0);
            conta2.saque(345.2);
            Console.WriteLine(conta.toString());
            Console.WriteLine(conta2.toString());
        }
    }
}

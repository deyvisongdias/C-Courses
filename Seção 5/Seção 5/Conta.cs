using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_5
{
    internal class Conta
    {
        public String numero { get; }
        public String nome { get; set; }
        public Double depositoInicial { get; }
        public Double saldo { get; set; }

        public Conta(String numero, String nome, Double depositoInicial)
        {
            this.numero = numero;
            this.nome = nome;
            this.depositoInicial = depositoInicial;
            this.saldo = depositoInicial;
        }

        public Conta(String numero, String nome)
        {
            this.numero = numero;
            this.nome = nome;
            this.depositoInicial = 0;
        }

        public void deposito(Double valor)
        {
            this.saldo += valor;
        }

        public void saque(Double valor)
        {
            if ((saldo - valor) - 5 < 0)
            {
                Console.WriteLine("valor insuficiente de saldo para saque!");
            }
            else
            {
                saldo -= valor;
                saldo -= 5;
            }
        }

        public String toString()
        {
            return "Numero: " + this.numero + "\n"
                + "Nome: " + this.nome + "\n" +
                "Saldo: " + this.saldo;
        }
    }
}


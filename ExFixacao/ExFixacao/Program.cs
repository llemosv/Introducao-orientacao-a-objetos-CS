using System;
using System.Globalization;

namespace ExFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número da conta: ");
            int numConta = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titularConta = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char haveraDepositoInicial = Convert.ToChar(Console.ReadLine());
            
            ContaBancaria c1 = new ContaBancaria(titularConta, numConta, haveraDepositoInicial);

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c1.ToString());
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double deposito = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c1.ToString());
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double saque = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c1.ToString());
        }
    }
}

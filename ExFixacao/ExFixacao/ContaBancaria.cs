using System;
using System.Globalization;

namespace ExFixacao
{
    class ContaBancaria
    {
        public string Nome { get; set; }
        public int NumeroConta { get; private set; }
        public double SaldoBancario { get; private set; }

        public ContaBancaria(string nome, int numeroConta, char haveraDeposito)
        {
            Nome = nome;
            NumeroConta = numeroConta;
            if (haveraDeposito == 's' || haveraDeposito == 'S')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                SaldoBancario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            else if (haveraDeposito == 'n' || haveraDeposito == 'N') return;
        }
        public void Deposito(double deposito)
        {
            SaldoBancario += deposito;
        }
        public void Saque(double saque)
        {
            SaldoBancario -= saque + 5.0;
        }
        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Nome}, Saldo: $ {SaldoBancario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modificadoresAcesso
{
    internal class ContaBancaria
    {
        // Exemplo de membros com diferentes modificadores de acesso
        public int NumeroConta { get; set; }
        private double Saldo { get; set; }
        protected string Titular { get; set; }
        internal bool Ativa { get; set; }

        public ContaBancaria(int numeroConta, double saldoInicial, string titular)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
            Titular = titular;
            Ativa = true;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado. Novo saldo: {Saldo}");
        }

        private void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado. Novo saldo: {Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque.");
            }
        }

        protected void ExibirSaldo()
        {
            Console.WriteLine($"Saldo da conta {NumeroConta}: {Saldo}");
        }

    }
}

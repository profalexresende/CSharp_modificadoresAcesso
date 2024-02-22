// See https://aka.ms/new-console-template for more information
using modificadoresAcesso;

ContaBancaria minhaConta = new ContaBancaria(1234, 1000, "Alex");

bool continuar = true;

while (continuar)
{
    Console.WriteLine("\nMenu:");
    Console.WriteLine("1. Exibir Saldo");
    Console.WriteLine("2. Depositar");
    Console.WriteLine("3. Sacar");
    Console.WriteLine("4. Sair");

    Console.Write("Escolha uma opção: ");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            //minhaConta.ExibirSaldo(); ERRO: exibirSaldo não é acessível
            break;

        case "2":
            Console.Write("Digite o valor para depósito: ");
            double valorDeposito = Convert.ToDouble(Console.ReadLine());
            minhaConta.Depositar(valorDeposito);
            break;

        case "3":
            Console.Write("Digite o valor para saque: ");
            double valorSaque = Convert.ToDouble(Console.ReadLine());
            //minhaConta.Sacar(valorSaque); ERRO o sacar não é acessível
            break;

        case "4":
            continuar = false;
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}
    
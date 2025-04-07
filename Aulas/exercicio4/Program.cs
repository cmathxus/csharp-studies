using System;
using System.Security.Cryptography.X509Certificates;

namespace exercicio4{
    class Program{
        static void Main (String [] args) {
            
            ContaBancaria conta1 = new ContaBancaria();

            System.Console.Write("Digite o número da sua conta: ");
            conta1.NumeroConta = int.Parse(Console.ReadLine());
            System.Console.Write("Digite o nome do titular da conta: ");
            conta1.NomeTitular = Console.ReadLine();
            System.Console.Write("Digite o saldo da conta: R$");
            conta1.Saldo  = double.Parse(Console.ReadLine());

            int opcao;
            do {
                Console.WriteLine("\nQual operação você deseja realizar na conta?");
                Console.WriteLine("1 - Depósito\n2 - Saque\n3 - Mostrar dados\n0 - Sair");
                Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao) {
                    case 1:
                        conta1.depositoConta();
                        break;
                    case 2:
                        conta1.saqueConta();
                        break;
                    case 3:
                        conta1.printer();
                        break;
                    case 0:
                        Console.WriteLine("Encerrando o programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 0);
}
}
}
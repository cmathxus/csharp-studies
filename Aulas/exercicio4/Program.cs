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

            int x = 0;
            if (x == 0) {
            
            System.Console.WriteLine("Qual operação você deseja realizar na conta? 1 - Depósito // 2 - Saque");
            x = int.Parse(Console.ReadLine());

            do {
            if (x == 1) {
                
            } else if (x == 2) {
                conta1.saqueConta();
            }
            else {
                System.Console.WriteLine("Erro: Número digitado incorreto");
            }
            } while (x == 1 || x == 2);

            System.Console.WriteLine("Deseja realizar outra operação? 1 - Sim // 2 - Não");
            
        }
        }
    }
}
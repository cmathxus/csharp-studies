using System;

namespace exercicio8
{
    class Program
    {
        static void Main(String[] args)
        {
            System.Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            System.Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            ContaBancaria conta1 = new ContaBancaria(numeroConta, nome);

            conta1.DepositoInicial();
            System.Console.WriteLine(conta1);
            conta1.SaldoDeposito();
            System.Console.WriteLine(conta1);
            conta1.SaldoSaque();
            System.Console.WriteLine(conta1);
        }
    }
}
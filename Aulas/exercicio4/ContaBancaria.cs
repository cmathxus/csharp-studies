using System;

namespace exercicio4;

public class ContaBancaria
{
    private int numeroConta;
    private String nomeTitular;
    private double saldo;

    public void saqueConta () {
        double valorSaque;
            do {
                Console.Write("Digite o valor desejado para o saque: R$");
                valorSaque = double.Parse(Console.ReadLine());
                if (valorSaque <= saldo) {
                    saldo -= valorSaque;
                    Console.WriteLine("Saque realizado com sucesso!");
                    printer();
                } else {
                    Console.WriteLine("Valor maior que o saldo disponível. Tente novamente.");
                }

            } while (true);
    }

    public void depositoConta () {
            Console.Write("Digite o valor que deseja depositar: R$");
            double valorDeposito = double.Parse(Console.ReadLine());

            if (valorDeposito > 0) {
                saldo += valorDeposito;
                Console.WriteLine("Depósito realizado com sucesso!");
                printer();
            } else {
                Console.WriteLine("Valor inválido para depósito.");
            }
    }

    public void printer () {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Número da conta: " + numeroConta);
            Console.WriteLine("Nome do titular da conta: " + nomeTitular);
            Console.WriteLine("Saldo da conta: R$" + saldo.ToString("F2"));
            Console.WriteLine("-------------------------------------------");
    }

    public int NumeroConta
    {
        get => numeroConta;
        set
        {
          numeroConta = value;
        }
    }

    public String NomeTitular
    {
        get => nomeTitular;
        set
        {
          nomeTitular = value;
        }
    }

    public double Saldo
    {
        get => saldo;
        set
        {
          saldo = value;
        }
    }
}

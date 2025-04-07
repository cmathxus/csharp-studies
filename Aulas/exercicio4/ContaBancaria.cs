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
            System.Console.Write("Digite o valor desejado para o saque: R$");
            valorSaque = double.Parse(Console.ReadLine());
            if (valorSaque < saldo) {
            } else {
                System.Console.WriteLine("--------------------------");
                System.Console.WriteLine("Valor digitado para saque incorreto");
            }
        } while (valorSaque > saldo);

        saldo -= valorSaque;
        System.Console.WriteLine("Dados da conta após o saque: ");
        printer();
    }

    public void depositoConta () {

    }

    public void printer () {
        System.Console.WriteLine("Número da conta: " + numeroConta);
        System.Console.WriteLine("Nome do titular da conta: " + nomeTitular);
        System.Console.WriteLine("Saldo da conta: R$" + saldo);
        System.Console.WriteLine("-------------------------------------------");
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

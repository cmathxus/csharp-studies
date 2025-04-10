using System.Globalization;
using System.Runtime.CompilerServices;

namespace exercicio8;

public class ContaBancaria
{
    private String _nome;
    public int NumeroConta {get; private set;}
    public double SaldoConta {get; private set;}

    public ContaBancaria (int numeroConta, string nome) {
        NumeroConta = numeroConta;
        Nome = nome;
    }

    public string Nome {
        get { return _nome; }
        set {
            if (value != null && value.Length > 1) {
                _nome = value;
        } else {
            throw new ArgumentException("O campo nome não pode ser nulo.");
        }
    }
}

    public override string ToString()
    {
        return "Dados da conta: \n" 
            + "Conta: "
            + NumeroConta
            + " Titular: "
            + Nome
            + " Saldo: $"
            + SaldoConta.ToString("F2",CultureInfo.InvariantCulture);
    }

    public void DepositoInicial() {
        String resposta;

        do {
        System.Console.WriteLine("Haverá deposito inicial? s/n");
        resposta = System.Console.ReadLine().ToLower();
        if (resposta == "n"){
            break;
        } else if (resposta == "s") {
            System.Console.Write("Entre com o valor do depósito inicial: ");
            double x = double.Parse(Console.ReadLine());
            SaldoConta += x;
            break;
        } else {
            System.Console.WriteLine("Resposta inválida. Tente novamente");
        }
        } while (true);
    }


    public void SaldoDeposito () {
        System.Console.Write("Entre um valor para depósito: ");
        double x = double.Parse(Console.ReadLine());
        SaldoConta += x;
    }

    public void SaldoSaque () {
        double x;

        do {
            System.Console.Write("Entre um valor para saque: ");
            x = double.Parse(Console.ReadLine());

            if (x > SaldoConta) {
                System.Console.WriteLine("Valor indisponivel para saque. Tente novamente");
            } else {
                SaldoConta -= x;
                SaldoConta -= 5; // Taxa de saque
                break;
            }
        } while (true);
    }
}



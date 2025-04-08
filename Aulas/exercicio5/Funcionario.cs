using System.Globalization;

namespace exercicio5;

public class Funcionario
{
    private String nome;
    private double salarioBruto;
    private double imposto;

    public void aumentarSalario(double porcentagem) {
        double aumento = salarioBruto * porcentagem / 100;
        salarioBruto += aumento;
    }


    public double salarioLiquido () {
        double x = salarioBruto - imposto;
        return x;
    }

    public override string ToString()
    {
        return "Nome: " 
        + nome
        + ", Salário: $"
        + salarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
    }



    // Getters and Setters
    public String Nome
    {
        get => nome;
        set
        {
          nome = value;
        }
    }

    public double SalarioBruto
    {
        get => salarioBruto;
        set
        {
          salarioBruto = value;
        }
    }

    public double Imposto
    {
        get => imposto;
        set
        {
          imposto = value;
        }
    }
}

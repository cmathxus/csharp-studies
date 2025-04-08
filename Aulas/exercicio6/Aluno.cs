using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

namespace exercicio6;

public class Aluno
{
    private String nome;
    private double nota1;
    private double nota2;
    private double nota3;

    public double notaFinal()
    {
        return nota1 + nota2 + nota3;
    }

    public bool Aprovado() {
        return notaFinal() >= 60.0;
    }

    public double pontosFaltando() {
        if (Aprovado()){
            return 0.0;
        }
        else {
            return 60.0 - notaFinal();
        }
    }

    public void resultadoFinal() {
        if (Aprovado()) {
            System.Console.WriteLine("APROVADO");
        } else {
            System.Console.WriteLine("REPROVADO");
            System.Console.WriteLine("Faltaram " + pontosFaltando().ToString("F2", CultureInfo.InvariantCulture) + " pontos");
        }
    }

    public String Nome
    {
        get => nome;
        set
        {
          nome = value;
        }
    }

    public double Nota1
    {
        get => nota1;
        set
        {
          nota1 = value;
        }
    }

    public double Nota2
    {
        get => nota2;
        set
        {
          nota2 = value;
        }
    }

    public double Nota3
    {
        get => nota3;
        set
        {
          nota3 = value;
        }
    }

}


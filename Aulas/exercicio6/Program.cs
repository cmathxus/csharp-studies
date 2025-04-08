using System;

namespace exercicio6 {
    class Program {
        static void Main (String [] args) {
            Aluno aluno1 = new Aluno();
            System.Console.Write("Nome do aluno: ");
            aluno1.Nome = Console.ReadLine();
            System.Console.WriteLine("Digite as três notas do aluno: ");
            aluno1.Nota1 = double.Parse(Console.ReadLine());
            aluno1.Nota2 = double.Parse(Console.ReadLine());
            aluno1.Nota3 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Nota final: " + aluno1.notaFinal().ToString("F2"));
            aluno1.resultadoFinal();
        }
    }
}
using System;

namespace exercicio5{
    class Program {
        static void Main (String [] args) {
            Funcionario funcionario1 = new Funcionario();
            System.Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            System.Console.Write("Salario bruto: $");
            funcionario1.SalarioBruto = double.Parse(Console.ReadLine());
            System.Console.Write("Imposto: $");
            funcionario1.Imposto = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Funcionário: " + funcionario1);

            System.Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            funcionario1.aumentarSalario(double.Parse(Console.ReadLine()));

            System.Console.WriteLine("Dados atualizados: " + funcionario1);
        }
    }
}
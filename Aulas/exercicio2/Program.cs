using System;
using System.Runtime.InteropServices;

namespace exercicio2{
    class Program {
        static void Main (String [] args) {
            Person pessoa1 = new Person();
            Person pessoa2 = new Person();
            
            System.Console.Write("Digite o nome da primeira pessoa: ");
            pessoa1.name = Console.ReadLine();
            System.Console.Write("Digite a idade da primeira pessoa: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            System.Console.Write("Digite o nome da segunda pessoa: ");
            pessoa2.name = Console.ReadLine();
            System.Console.Write("Digite a idade da segunda pessoa: ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Dados da primeira pessoa: ");
            System.Console.WriteLine("Nome: " + pessoa1.name);
            System.Console.WriteLine("Idade: " + pessoa1.idade);

            System.Console.WriteLine("Dados da segunda pessoa: ");
            System.Console.WriteLine("Nome: " + pessoa2.name);
            System.Console.WriteLine("Idade: " + pessoa2.idade);

            if (pessoa1.idade > pessoa2.idade) {
                System.Console.WriteLine("Pessoa mais velha: " + pessoa1.name);
            }
            else {
                System.Console.WriteLine("Pessoa mais velha: " + pessoa2.name);
            }
        }
    }
}
using System;
using System.Globalization;

namespace aula1 {
    class Program {
        static void Main(string[] args) {

            char genero = 'F';
            int idade = 32;
            double saldo = 10.345612;
            string nome = "Maria";


            Console.WriteLine("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!!");
            System.Console.WriteLine("--------------");
            System.Console.WriteLine(idade);
            System.Console.WriteLine(saldo);
            System.Console.WriteLine(nome);
            System.Console.WriteLine(genero);
            System.Console.WriteLine(saldo.ToString("F2")); // utilizar o toString e F2 para delimitar o numero de casas decimais, nesse caso 2 casas decimais
            System.Console.WriteLine(saldo.ToString("F4")); // ^^ nesse caso 4 casas decimais
            System.Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture)); // Colocar o "." como ponto de separador
            System.Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            System.Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            System.Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais");
        }
    }
}
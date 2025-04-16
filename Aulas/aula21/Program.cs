using System;
using System.Globalization;
using System.Numerics;

namespace aula21 {
    class Program {
        static void Main (String [] args) {

            System.Console.WriteLine("Quantos produtos você irá digitar?");
            int n = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[n];
            
            for (int i = 0; i < n; i++)
            {
                produtos [i] = new Produto();
                System.Console.WriteLine($"Digite o nome do produto {i + 1}: ");
                produtos[i].Nome = Console.ReadLine();

                System.Console.WriteLine($"Digite o preço do produto {i + 1}: ");
                produtos[i].Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                soma += produtos[i].Preco;
            }

            double avg = soma / n;

            System.Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
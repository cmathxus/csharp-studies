using System;
using System.Reflection;

namespace exercicio9 {
    class Program {
        static void Main (String [] args) {
            Quarto[] quartos = new Quarto[10];

            System.Console.WriteLine("Quantos quartos serão ocupados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine($"Aluguel #{i + 1}");

                System.Console.WriteLine("Digite o nome: ");
                String nome = Console.ReadLine();

                System.Console.WriteLine("Digite o e-mail: ");
                String email = Console.ReadLine();

                System.Console.WriteLine("Digite o numero do quarto: ");
                int numero = int.Parse(Console.ReadLine());

                quartos[numero] = new Quarto();

                quartos[numero].NumeroQuarto = numero;
                quartos[numero].Estudante.Nome = nome;
                quartos[numero].Estudante.Email = email;
            }

            System.Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (quartos[i] != null) {
                    System.Console.WriteLine($"Quarto {i}: \n Nome: {quartos[i].Estudante.Nome} \n Email: {quartos[i].Estudante.Email}");
                }
            }
        }
    }
}
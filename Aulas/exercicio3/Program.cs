using System;

namespace exercicio3 {
    class Program {
        static void Main (String [] args) {
            Product produto1 = new Product ();

            System.Console.WriteLine("Entre com os dados do produto: ");
            System.Console.Write("Nome: ");
            produto1.Nome = Console.ReadLine();
            System.Console.Write("Preco: ");
            produto1.Preco = int.Parse(Console.ReadLine());
            System.Console.Write("Quantidade: ");
            produto1.Quantidade = int.Parse(Console.ReadLine());

            produto1.printer();

            produto1.adicionarProdutos();

            produto1.printer();

            produto1.removerProdutos();

            produto1.printer();
        } 
    }
}
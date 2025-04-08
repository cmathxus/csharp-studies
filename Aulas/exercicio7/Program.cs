using System;

namespace exercicio7 {
    class Program {
        static void Main (String [] args) {
            Produto produto1 = new Produto();

            System.Console.Write("Nome do  produto: ");
            produto1.Nome = Console.ReadLine();
            System.Console.Write("Preco do  produto: ");
            produto1.Preco = double.Parse(Console.ReadLine());
            System.Console.Write("Quantidade do  produto em  estoque: ");
            produto1.QuantidadeEstoque = int.Parse(Console.ReadLine());
            System.Console.WriteLine(produto1);

            produto1.adicionarProdutos();
            System.Console.WriteLine(produto1);

            produto1.removerProdutos();
            System.Console.WriteLine(produto1);
        }
    }
}
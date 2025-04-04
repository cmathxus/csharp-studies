using System;

namespace exercicio3 {
    class Program {
        static void Main (String [] args) {
            Product produto1 = new Product ();

            produto1.Nome = "Coca cola";
            produto1.Preco = 5;
            produto1.Quantidade = 30;

            produto1.printer();

            produto1.adicionarProdutos();

            produto1.printer();

            produto1.removerProdutos();

            produto1.printer();
        } 
    }
}
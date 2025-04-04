using System;

namespace exercicio3 {
    class Program {
        static void Main (String [] args) {
            Product produto1 = new Product ();

            produto1.nome = "Coca cola";
            produto1.preco = 5;
            produto1.quantidade = 30;

            produto1.printer();

            produto1.adicionarProdutos();

            produto1.printer();

            produto1.removerProdutos();

            produto1.printer();
        } 
    }
}
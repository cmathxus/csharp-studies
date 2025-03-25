using System;

namespace aula8 {
    class Program {
        static void Main (String [] args) {
            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0; // preciso inicializar a variavel no escopo maior para que eu possa utilizar ele futuramente, pois se inicializar no escopo menor o escopo maior não enxerga

            if (preco > 100.0) {
                desconto = preco * 0.1;
            } 

            System.Console.WriteLine(desconto);
        }
    }
}
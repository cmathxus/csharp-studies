using System;
using System.Globalization;

namespace aula26 {
    class Program {
        static void Main (String [] args) {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            System.Console.WriteLine(desconto);
        }
    }
}
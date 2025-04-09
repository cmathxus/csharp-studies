using System;
using System.Globalization;

namespace aula16 {
    class Program {
        static void Main (String [] args) {
            Circunferencia circunferencia1 = new Circunferencia();

            System.Console.Write("Entre o valor do raio: ");
            circunferencia1.Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            circunferencia1.calculoCircunferencia();
            circunferencia1.calculoVolume();
            System.Console.WriteLine(circunferencia1);
        }
    }
}
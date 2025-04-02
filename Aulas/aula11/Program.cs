using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace aula11{
    class Program {
        static void Main(String [] args) {

            System.Console.Write("Digite um número ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  
            while (x >= 0.0) {
                double raiz = Math.Sqrt(x);
                System.Console.WriteLine(raiz.ToString("F3",CultureInfo.InvariantCulture));
                System.Console.WriteLine("Digite outro número ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            
            System.Console.WriteLine("Número negativo");
        }
    }
}
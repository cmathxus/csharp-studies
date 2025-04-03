using System;
using System.Globalization;

namespace aula14 {
    class Program {
        static void Main (String [] args) {
            // Resolvendo um problema com POO (Orientação a objetos)

            Triangle x = new Triangle();
            Triangle y = new Triangle();

            System.Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C / 2.0);
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p * y.C));

            System.Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            

            if (areaX > areaY) {
                System.Console.WriteLine("Maior área: X");
            }
            else {
                System.Console.WriteLine("Maior área: Y");
            }
        }
    }
}
﻿using System;
using System.Globalization;

namespace aula13 {
    class Program {
        static void Main (String [] args) {
            // Resolvendo um problema sem POO (Orientação a objetos)

            double xA, xB, xC, yA, yB, yC;

            System.Console.WriteLine("Entre com as medidas do triângulo X: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Entre com as medidas do triângulo Y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC / 2.0);
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p * yC));

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
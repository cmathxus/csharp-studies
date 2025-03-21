﻿using System;
using System.Runtime.CompilerServices;

namespace aula4;
class Program {
static void Main (string [] args) {

        int n1 = 3 + 4 * 2;
        int n2 = (3 + 4) * 2;
        int n3 = 17 % 3;
        double n4 = 10.0 / 8;

        System.Console.WriteLine(n1);
        System.Console.WriteLine(n2);
        System.Console.WriteLine(n3);
        System.Console.WriteLine(n4);

        double a = 1.0, b = -3.0, c = -4.0;

        double delta = Math.Pow(b, 2.0) - 4.0 * a * c; // Math.Pow -> B (b) ao quadrado (2.0)

        double x1 = (-b + Math.Sqrt(delta)) / 2 * a; // Math.Sqrt -> Raiz quadrada
        double x2 = (-b - Math.Sqrt(delta)) / 2 * a;

        System.Console.WriteLine(delta);
        System.Console.WriteLine(x1);
        System.Console.WriteLine(x2);

    }
}
// Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou positivo

using System;
using System.Reflection;

namespace exercicio1{
    class Program {
        static void Main (String [] args) {
            System.Console.WriteLine("Digite o número: ");
            double num = Double.Parse(Console.ReadLine());

            if (num >= 0) {
                System.Console.WriteLine("O número digitado é positivo");
            }
            else {
                System.Console.WriteLine("O número digitado é negativo");
            }
        }
    }
}

using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace aula12 {
    class Program {
        static void Main (String [] args) {
            System.Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i++){
                System.Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            System.Console.WriteLine("Soma = " + soma);
        }
    }
}
using System;

namespace aula23 {
    class Program {
        static void Main(string [] args) {

            string[] vect = new string[] {"Maria", "Alex", "Bob"};

            foreach (string obj in vect) {
                System.Console.WriteLine(obj); // Utilizando o foreach para percorrer o vetor e imprimir os valores
            } 
        }
    }
}
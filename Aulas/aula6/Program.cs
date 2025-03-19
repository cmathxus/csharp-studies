using System;
using System.Globalization; 

namespace aula6;

class Program{
    static void Main (String [] args) {
        int n1 = int.Parse(Console.ReadLine());
        char ch = char.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // para poder digitar com a "." ao inves do "." como separador

        string [] vet = Console.ReadLine().Split(' ');
        string nome = vet[0];
        char sexo = char.Parse(vet[1]);
        int idade = int.Parse(vet[2]);
        double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

        System.Console.WriteLine("Voce digitou: ");
        System.Console.WriteLine(n1);
        System.Console.WriteLine(ch);
        System.Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
        System.Console.WriteLine(nome);
        System.Console.WriteLine(sexo);
        System.Console.WriteLine(idade);
        System.Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));
    }
}
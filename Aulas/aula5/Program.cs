using System;

namespace aula5 {
class Program{ 
    static void Main (String [] args) {

            string frase = Console.ReadLine() ?? "";

            string z = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();


            string s = Console.ReadLine();

            string[] v = s.Split(' '); // Armazenando os valores da string 's' separados por espaço ' ' em vetores (0,1,2)
            string a = v[0]; 
            string b = v[1];
            string c = v[2];

            System.Console.WriteLine(frase);

            System.Console.WriteLine(x);
            System.Console.WriteLine(y);
            System.Console.WriteLine(z);
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(c);

        }
    }
}
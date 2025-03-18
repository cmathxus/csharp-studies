using System;

namespace aula3_cursonelio;
class Program{
static void Main (string [] args) {
        float x = 4.5f;

        double y = x;

        System.Console.WriteLine(x);
        System.Console.WriteLine(y);

        double a;
        float b;

        a = 5.1;
        b = (float)a; // fazendo o casting -> transformando o double em float

        System.Console.WriteLine(b);

        double z;
        int x;

        z = 5.1;
        x = (int)z; // fazendo o casting -> transformando o double em int 

        System.Console.WriteLine(x); // nesse caso vou ter perda de informação devido ao numero inteiro
    
        int j = 5;
        int k = 2;

        double resultado = (double) j / k; // fazendo o casting para deixar o resultado em double (para ele dar 2,5), caso nao faça o casting ele vai dar um valor inteiro, pois é uma divisao de dois int

        System.Console.WriteLine(resultado);
    
}
}
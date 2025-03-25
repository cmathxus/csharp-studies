using System;

namespace aula7;

class Program{
    static void Main (String [] args) {
        
        int a = 10;
        bool c1 = a < 10; // a menor do que 10 ? False
        bool c2 = a < 20; // a menor do que 20 ? True
        bool c3 = a > 10; // a maior do que 10 ? False
        bool c4 = a > 5; // a maior do que 5 ? True

        System.Console.WriteLine(c1);
        System.Console.WriteLine(c2);
        System.Console.WriteLine(c3);
        System.Console.WriteLine(c4);
        System.Console.WriteLine("---------");

        bool c5 = a <= 10; // a menor/igual a 10 ? True
        bool c6 = a >= 10; // a maior/igual a 10 ? True
        bool c7 = a == 10; // a igual a 10 ? True
        bool c8 = a != 10; // a diferente de 10? False

        System.Console.WriteLine(c5);
        System.Console.WriteLine(c6);
        System.Console.WriteLine(c7);
        System.Console.WriteLine(c8);
    }
}
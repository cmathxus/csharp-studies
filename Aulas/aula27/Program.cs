using System;

namespace aula27 {
    class Program {
        static void Main (String [] args) {


            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(90000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);

            System.Console.WriteLine(t1);
            System.Console.WriteLine(t2);
        }
    }
}
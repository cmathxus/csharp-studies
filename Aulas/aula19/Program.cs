using System.Runtime.CompilerServices;

namespace aula19 {
    class Program {
        static void Main (String [] args) {

            
            // double y = 10; // Atribuindo o valor de X na variavel Y se X tiver algum valor, se nao tiver um valor (x ??) pega o valor de 0.0 (0.0)
            double? x = null;
            double? y = 10;

            double a = x ?? 5; // Atribuindo o valor de x na variavel A, se x for nulo pega o valor de 5
            double b = y ?? 5;

            System.Console.WriteLine(a);
            System.Console.WriteLine(b);

            // System.Console.WriteLine(x.GetValueOrDefault());
            // System.Console.WriteLine(y.GetValueOrDefault()); Pega o valor da variavel ou se for nulo pega o valor default (0)

            // System.Console.WriteLine(x.HasValue); Faz uma pergunta se a variavel tem algum valor e retorna true ou false
            // System.Console.WriteLine(y.HasValue);

            // if(x.HasValue) {
            //     System.Console.WriteLine(x.Value); Pega o valor da variavel, Se não tiver valor vai retornar uma excecao
            // } else {
            //     System.Console.WriteLine("X is null.");
            // }
            // if (y.HasValue) {
            //     System.Console.WriteLine(y.Value);
            // } else {
            //     System.Console.WriteLine("Y is null.");
            // }
        }
    }
}

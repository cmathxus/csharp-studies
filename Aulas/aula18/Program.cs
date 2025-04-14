using System;

namespace aula18 {
    class Program {
        static void Main (String [] args) {
            Point p; // tipo struct não necessita do comando = new, pois ele apenas copia o valor (não faz uma referencia a caixa de memoria)
            p.X = 10;
            p.Y = 20; // necessario sempre inicializar os valores da variavel, no caso de não inicializar vai retornar erro de "variavel nao atribuida"
            System.Console.WriteLine(p); // valor (10,20)

            p = new Point(); 
            System.Console.WriteLine(p); // valor (0,0), pois ele esta copiando o novo valor padrao da variavel
        }
    }
}
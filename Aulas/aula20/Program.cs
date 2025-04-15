/*   Vetores 
    Em programação, "vetor" é o nome dado a arranjos unidimensionais

    * Arranjo é uma estrutura de dados
    - Homogênea (dados do mesmo tipo)
    - Ordenada (elementos acessados por meio de posições)
    - Alocada de uma vez só, em um bloco contíguo de memória

    *Vantagens: 
    - Acesso imediato aos elementos pela sua posição (Se tiver na posição 5000, não vai percorrer 4999 antes)

    *Desvantagens:
    - Tamanho fixo (Não há possibilidade de alterar o tamanho)
    - Dificuldade para se realizar inserções e deleções
*/

using System;
using System.Globalization;

namespace aula20 {
    class Program {
        static void Main (String [] args) {
            System.Console.WriteLine("Quantas alturas você irá digitar?");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];
            
            double mediaAltura = 0;

            for (int i = 0; i < n; i++) {
                System.Console.WriteLine($"Digite o valor da altura {i + 1}");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                mediaAltura += vect[i];
            }

            System.Console.WriteLine("Média de altura = " + (mediaAltura/n).ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
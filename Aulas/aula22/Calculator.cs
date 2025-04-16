namespace aula22;

public class Calculator
{
    public static int Soma (params int [] numeros ){ // Utilizando o "params" para passar uma quantidade variavel de argumentos no metodo
        int soma = 0;
        for (int i = 0; i < numeros.Length; i++) {
            soma += numeros[i];
        }
        return soma;
    }
}

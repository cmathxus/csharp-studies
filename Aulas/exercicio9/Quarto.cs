using System.Dynamic;

namespace exercicio9;

public class Quarto
{
    public int NumeroQuarto {get;set;}
    private Estudante estudante = new Estudante();


    public Estudante Estudante
    {
        get => estudante;
        set
        {
          estudante = value;
        }
    }
}

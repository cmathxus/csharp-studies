namespace aula21;

public class Produto
{
    private string _nome;

    public double Preco { get; set; }

    public void calcularMedia () {
        
    }

    public string Nome
    {
        get => _nome;

        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _nome = value;
            }
            else
            {
                throw new ArgumentException("O nome não pode ser nulo ou vazio");
            }
        }
    }
}

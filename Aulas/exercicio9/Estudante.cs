namespace exercicio9;

public class Estudante
{
    private string _nome;

    private string _email;



    public string Nome
    {
        get => _nome;
        set 
        {
            if (!string.IsNullOrWhiteSpace(value)) {
                _nome = value;
            } else {
                throw new ArgumentException("O nome não pode ser nulo!");
            }
        }
    }

    public string Email
    {
        get => _email;
        set
        {
            if(!string.IsNullOrWhiteSpace(value)) {
                _email = value;
            } else {
                throw new ArgumentException("O e-mail não pode ser vazio ou só espaços");
            }
        }
    }
}

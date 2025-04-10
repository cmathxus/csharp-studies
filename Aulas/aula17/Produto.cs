using System.Globalization;

namespace aula17;

public class Produto
{
    private string _nome;
    public double Preco {get; private set;}
    public int Quantidade {get; private set;}
    
    // Utilizando construtores
    public Produto() {
        Quantidade = 10;
    }

    public Produto(string nome, double preco) : this () {
        Nome = nome;
        Preco = preco;
    }

    public Produto(string nome, double preco, int quantidade) : this (nome, preco) {
        Quantidade = quantidade;
    }

    public double ValorTotalEmEstoque()
    {
        return Preco * Quantidade;
    }
    public void AdicionarProdutos(int quantidade)
    {
        Quantidade += quantidade;
    }
    public void RemoverProdutos(int quantidade)
    {
        Quantidade -= quantidade;
    }
    public override string ToString()
    {
        return Nome
        + ", $ "
        + Preco.ToString("F2", CultureInfo.InvariantCulture)
        + ", "
        + Quantidade
        + " unidades, Total: $ "
        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }

    public string Nome {
        get { return _nome; }
        set {
            if (value != null && value.Length > 1) {
                _nome = value;
        }
    }
}
}


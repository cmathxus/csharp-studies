using System.Globalization;

namespace aula17;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;
    
    // Utilizando construtores
    public Produto(string nome, double preco, int quantidade) {

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
}


using System.Globalization;

namespace exercicio7;

public class Produto
{
    private String nome;
    private double preco;
    private int quantidadeEstoque;

    private double valorTotalEmEstoque() {
        return preco * quantidadeEstoque;
    }

    public void adicionarProdutos() {
        System.Console.WriteLine("Informe a quantidade de produtos que deseja adicionar no estoque: ");
        int quantidade = int.Parse(Console.ReadLine());
        quantidadeEstoque += quantidade;
    }

    public void removerProdutos() {
    int quantidade;
    do {
        Console.Write("Informe a quantidade de produtos que deseja remover do estoque: ");
        quantidade = int.Parse(Console.ReadLine());

        if (quantidade <= quantidadeEstoque) {
            quantidadeEstoque -= quantidade;
            Console.WriteLine("Produtos removidos com sucesso!");
            break;
        } else {
            Console.WriteLine("Valor informado maior que o estoque. Tente novamente.");
        }
    } while (true);
    }

    public override string ToString()
    {
        return "Nome do produto: "
        + nome
        + " Preço: R$"
        + preco
        + " Quantidade em estoque: "
        + quantidadeEstoque
        + " Total em estoque: R$"
        + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }


    public String Nome
    {
        get => nome;
        set
        {
          nome = value;
        }
    }

    public double Preco
    {
        get => preco;
        set
        {
          preco = value;
        }
    }

    public int QuantidadeEstoque
    {
        get => quantidadeEstoque;
        set
        {
          quantidadeEstoque = value;
        }
    }
}

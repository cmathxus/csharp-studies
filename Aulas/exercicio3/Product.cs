using System.Globalization;

public class Product
{
    private String nome;
    private double preco;
    private int quantidade;

    public double valorTotalEmEstoque(){
        double p = preco * quantidade;
        return p;
    }

    public void adicionarProdutos () {
        System.Console.WriteLine("Realize uma entrada no estoque");
        int novaQuantidade = int.Parse(Console.ReadLine());
        quantidade += novaQuantidade;
    }

    public void removerProdutos () {
        int novaQuantidade;
        
        do {
        System.Console.WriteLine("Realize uma saída no estoque");
        novaQuantidade = int.Parse(Console.ReadLine());
        if (novaQuantidade < quantidade) {
        } else {
            System.Console.WriteLine("Erro: Não há produtos suficientes no estoque!");
            System.Console.WriteLine("-------------------");
        }
        } while (novaQuantidade > quantidade);

        quantidade -= novaQuantidade;
    }

    public override string ToString(){ // Aprendendo object e ToString
        return Nome 
            + ", $ " 
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }


    // Getters and Setters
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

    public int Quantidade
    {
        get => quantidade;
        set
        {
          quantidade = value;
        }
    }
}

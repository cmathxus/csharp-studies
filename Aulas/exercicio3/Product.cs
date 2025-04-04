public class Product
{
    public String nome;
    public double preco;
    public int quantidade;

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


    public void printer(){
        System.Console.WriteLine("Nome do produto: " + nome);
        System.Console.WriteLine("Preco do produto: " + preco);
        System.Console.WriteLine("Quantidade do produto em estoque: " + quantidade);
        System.Console.WriteLine("Valor total em estoque: " + valorTotalEmEstoque()); 
        System.Console.WriteLine("------------------------------");
    }
}

public class Produto
{
    public string Nome;
    public decimal Preco;
    public int Quantidade;

    public Produto(string nome, decimal preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public string FormatarPreco()
    {
        return Preco.ToString("0.00");
    }

    public override string ToString()
    {
        return $"Nome: {Nome} / Preço: {FormatarPreco()} / Quantidade disponível: {Quantidade}";
    }
}

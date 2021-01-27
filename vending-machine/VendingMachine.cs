using System;
using System.Collections.Generic;
public class VendingMachine
{
    private decimal ValorInserido = new decimal(0);
    private decimal ValorTotalDeVendas = new decimal(0);
    private List<Produto> Produtos = new List<Produto>();
    private Produto ProdutoSelecionado;

    public void Abastecer()
    {
        if (Produtos.Count > 0) {
            Console.WriteLine("A máquina já está abastecida!");
            return;
        }
        Produtos.Add(new Produto("Coca-Cola", new decimal(15.50), 4));
        Produtos.Add(new Produto("Sprite", new decimal(12.70), 2));
        Produtos.Add(new Produto("Pepsi", new decimal(14.50), 3));
        Produtos.Add(new Produto("Fanta", new decimal(7.30), 8));
    }

    public void MostrarEstoque()
    {
        Console.WriteLine("-- Bebidas na máquina: --");

        bool mostrou = false;
        Produtos.ForEach(produto => {
            if (produto.Quantidade > 0) {
                Console.WriteLine(produto);
                mostrou = true;
            }
        });

        if (!mostrou) {
            Console.WriteLine("As bebidas estão esgotadas...");
        }
    }

    public void SelecionarProduto(string nome)
    {
        if (ProdutoSelecionado != null)
        {
            Console.WriteLine("Já há outro produto selecionado: " + ProdutoSelecionado.Nome);
            return;
        }

        var produtos = Produtos.FindAll(
            produto => produto.Nome.ToLower().StartsWith(nome.ToLower()) && produto.Quantidade > 0
        );

        if (produtos.Count > 1) {
            Console.WriteLine("Por favor, escreva um nome mais específico!");
        } else if (produtos.Count == 0) {
            Console.WriteLine("Produto não encontrado!");
        } else {
            ProdutoSelecionado = produtos[0];
            Console.WriteLine("Selecionado: " + ProdutoSelecionado.Nome);
            Console.WriteLine($"Insira R$ {ProdutoSelecionado.FormatarPreco()} para concluir a compra");
        }
    }

    public void InserirValor(decimal valor)
    {
        if (ProdutoSelecionado == null) {
            Console.WriteLine("Não há produto selecionado!");
            return;
        }

        ValorInserido += valor;

        if (ValorInserido >= ProdutoSelecionado.Preco) {
            Console.WriteLine("Venda concluída. Aqui está sua " + ProdutoSelecionado.Nome);

            decimal troco = ValorInserido - ProdutoSelecionado.Preco;
            if (troco > 0) {
                Console.WriteLine("Troco: R$ " + troco.ToString("0.00"));
            }

            ValorTotalDeVendas += ProdutoSelecionado.Preco;
            ProdutoSelecionado.Quantidade--;
            ProdutoSelecionado = null;
            ValorInserido = 0;
        } else {
            decimal valorRestante = ProdutoSelecionado.Preco - ValorInserido;
            Console.WriteLine("Valor faltante: R$ " + valorRestante.ToString("0.00"));
        }
    }

    public void MostrarValorTotalDeVendas()
    {
        Console.WriteLine($"Valor total de vendas realizadas: R$ {ValorTotalDeVendas.ToString("0.00")}");
    }
}

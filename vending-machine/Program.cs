using System;

namespace vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.Abastecer();

            Console.WriteLine("Bem vindo à máquina de vendas!");

            int opcao;

            do {
                Console.WriteLine("1 - Mostrar estoque");
                Console.WriteLine("2 - Selecionar produto");
                Console.WriteLine("3 - Inserir valor");
                Console.WriteLine("4 - Mostrar valor total de vendas");
                Console.WriteLine("5 - Sair");

                Console.Write("Selecione uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                Console.WriteLine();

                if (opcao == 1) {
                    vendingMachine.MostrarEstoque();
                } else if (opcao == 2) {
                    Console.Write("Escreva o nome do produto: ");
                    string nome = Console.ReadLine();

                    vendingMachine.SelecionarProduto(nome);
                } else if (opcao == 3) {
                    Console.Write("Digite o valor a ser inserido: ");
                    decimal valor = decimal.Parse(Console.ReadLine());

                    vendingMachine.InserirValor(valor);
                } else if (opcao == 4) {
                    vendingMachine.MostrarValorTotalDeVendas();
                }

                if (opcao != 5) {
                    Console.WriteLine("-------------");
                    Console.WriteLine("Pressione Enter para continuar");
                    Console.ReadLine();
                }

            } while (opcao != 5);
        }
    }
}

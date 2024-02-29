using System;

namespace PedidoDeProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o produto:");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Qual a quantidade do produto:");
            double quantidadeProduto = double.Parse(Console.ReadLine());

            double preco = 55.00;
            double precoQuantidade = preco * quantidadeProduto;

            if (quantidadeProduto <= 10)
            {
                Console.WriteLine($"O pedido de {quantidadeProduto} {nomeProduto} ficou no total de {precoQuantidade:c2}");
            }
            else if (quantidadeProduto > 10 && quantidadeProduto < 21)
            {
                Console.WriteLine($"O pedido de {quantidadeProduto} {nomeProduto} ficou no total de {precoQuantidade * 0.9:c2}");
            }
            else if (quantidadeProduto >= 21 && quantidadeProduto < 50)
            {
                Console.WriteLine($"O pedido de {quantidadeProduto} {nomeProduto} ficou no total de {precoQuantidade * 0.8:c2}");
            }
            else
            {
                Console.WriteLine($"O pedido de {quantidadeProduto} {nomeProduto} ficou no total de {precoQuantidade * 0.85:c2}");
            }
        }
    }
}
   

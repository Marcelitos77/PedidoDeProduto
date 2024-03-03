using System;

namespace Pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o produto:");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Qual a quantidade do produto:");
            double quantidadeProduto = double.Parse(Console.ReadLine());

            Pedido pedido = new Pedido(nomeProduto, quantidadeProduto);

            pedido.ExibirDetalhesPedido();
        }
    }
}


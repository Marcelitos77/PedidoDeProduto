using System;

namespace Pedido
{
    class Pedido
    {
        public string NomeProduto;
        public double QuantidadeProduto;

        public Pedido(string nomeProduto, double quantidadeProduto)
        {
            NomeProduto = nomeProduto;
            QuantidadeProduto = quantidadeProduto;
        }

        public double CalcularPrecoTotal()
        {
            double preco = 55.00;
            double precoQuantidade = preco * QuantidadeProduto;

            if (QuantidadeProduto <= 10)
            {
                return precoQuantidade;
            }
            else if (QuantidadeProduto > 10 && QuantidadeProduto < 21)
            {
                return precoQuantidade * 0.9;
            }
            else if (QuantidadeProduto >= 21 && QuantidadeProduto < 50)
            {
                return precoQuantidade * 0.8;
            }
            else
            {
                return precoQuantidade * 0.85;
            }
        }

        public void ExibirDetalhesPedido()
        {
            double precoTotal = CalcularPrecoTotal();

            Console.WriteLine($"O pedido de {QuantidadeProduto} {NomeProduto} ficou no total de {precoTotal:c2}");
        }
    }
}

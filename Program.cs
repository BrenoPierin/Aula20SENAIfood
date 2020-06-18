using System;

namespace Aula20SENAIfood
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente sergin = new Cliente("sergin");
            sergin.EnderecoAtual = "Brasilia,DF";
            System.Console.WriteLine(sergin.MostrarDados());

            Restaurante PeDeFava = new Restaurante("Pé de fava");
            PeDeFava.Endereco = "São Paulo";
            System.Console.WriteLine(PeDeFava.MostrarDados());

            Pedido Fejuca = new Pedido();
            System.Console.WriteLine(Fejuca.EntregarPedido("fejuca, farofa", "Crédito"));
        }
    }
}

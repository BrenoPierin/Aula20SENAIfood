namespace Aula20SENAIfood
{
    public class Restaurante
    {
        public string NomeFantasia { get; set; }
        public string Endereco { get; set; }

        public string MostrarDados(){
            return $"{NomeFantasia}, o pedido já pode sair do {Endereco}"
        }
    }
}
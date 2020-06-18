namespace Aula20SENAIfood
{
    public class Pedido
    {
        public string Nome { get; set; }
        public string EnderecoAtual { get; set; }

        public string MostrarDados(){
            return $"{Nome}, seu pedido já pode ser feito para o endereço {EnderecoAtual}"
        }
    }
}
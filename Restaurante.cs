namespace Aula20SENAIfood
{
    public class Restaurante
    {
        public string NomeFantasia { get; set; }
        public string Endereco { get; set; }

        public Restaurante(string nomeFantasia_){
            NomeFantasia = nomeFantasia_;
        }    

        public string MostrarDados(){
            return $"{NomeFantasia}, o pedido já pode sair do {Endereco}";
        }
    }
}
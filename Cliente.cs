namespace Aula20SENAIfood
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string EnderecoAtual { get; set; }

        public Cliente(string nome_){
            Nome = nome_ ;
       }

        public string MostrarDados(){
            return $"{Nome}, seu pedido já pode ser feito para o endereço {EnderecoAtual}";
        }
    }
}
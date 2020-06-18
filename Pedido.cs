namespace Aula20SENAIfood
{
    public class Pedido
    {
       public string itens { get; set; }
       public string Cliente { get; set; }
       public string Restaurante { get; set; }
       public string FormaDePGTO { get; set; }
       public bool ProdutoPago = true;

       public string EntregarPedido(string itens, string FormaDePGTO){
           if(ProdutoPago == true){
                return $"{itens} sendo entregues, pagando com {FormaDePGTO}";
           }
           return "Não foi possivel entregar por falta de pagamento";
       }

       
    }
}
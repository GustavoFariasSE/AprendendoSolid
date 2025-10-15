
namespace ExerciciosModulo3
{
    public class GerenciadorDeDesconto
    {
        public decimal AplicarDesconto(decimal precoProduto, int statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoDepoisDoDesconto = 0;
            decimal descontoPorFidelidade = (tempoDeContaEmAnos > 5) ? 
                (decimal)5 / 100 : 
                (decimal)tempoDeContaEmAnos / 100;
            
            switch (statusContaCliente)
            {
                case (int)StatusContaCliente.NaoResgistrado:
                    precoDepoisDoDesconto = precoProduto;
                    break;
            }
            
            return precoDepoisDoDesconto;
        }
    }
}

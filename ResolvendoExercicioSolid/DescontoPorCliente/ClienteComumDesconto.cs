using ResolvendoExercicioSolid.Interfaces;


namespace ResolvendoExercicioSolid.DescontoPorCliente
{
    public class ClienteComumDesconto : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return preco - (Constantes.DESCONTO_CLIENTE_COMUM * preco);
        }
    }
}

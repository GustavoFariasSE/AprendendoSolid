using ResolvendoExercicioSolid.Interfaces;


namespace ResolvendoExercicioSolid.DescontoPorCliente
{
    public class ClienteEspecialDesconto : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return preco - (Constantes.DESCONTO_CLIENTE_ESPECIAL * preco);
        }
    }
}

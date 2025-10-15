using ResolvendoExercicioSolid.Interfaces;
using System.Net;
using System.Reflection.Metadata.Ecma335;


namespace ResolvendoExercicioSolid.DescontoPorCliente
{
    public class ClienteVIPDesconto : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return preco - (Constantes.DESCONTO_CLIENTE_VIP * preco);
        }
    }
}

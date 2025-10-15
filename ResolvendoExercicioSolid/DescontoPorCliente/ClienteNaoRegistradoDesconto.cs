using ResolvendoExercicioSolid.Interfaces;


namespace ResolvendoExercicioSolid.DescontoPorCliente
{
    public class ClienteNaoRegistradoDesconto : ICalculaDescontoStatusConta
    {

        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return preco;
        }
    }
}

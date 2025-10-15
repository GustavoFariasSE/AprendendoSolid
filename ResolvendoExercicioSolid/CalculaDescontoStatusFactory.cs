

using ResolvendoExercicioSolid.DescontoPorCliente;
using ResolvendoExercicioSolid.Interfaces;

namespace ResolvendoExercicioSolid
{
    public class CalculaDescontoStatusFactory : ICalculaStatusContaFactory
    {
        public ICalculaDescontoStatusConta 
            GetCalculoDescontoStatusConta(StatusContaCliente statusContaCliente)
        {
            ICalculaDescontoStatusConta calcular;

            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    calcular = new ClienteNaoRegistradoDesconto();
                    break;
                case StatusContaCliente.ClienteComum:
                    calcular = new ClienteComumDesconto();
                    break;
                case StatusContaCliente.ClienteEspecial:
                    calcular = new ClienteEspecialDesconto();
                    break;
                case StatusContaCliente.ClienteVIP:
                    calcular = new ClienteVIPDesconto();
                    break;
                default:
                    throw new NotImplementedException("O tipo do cliente não foi informado");   
            }

            return calcular;
        }

        
    }
}

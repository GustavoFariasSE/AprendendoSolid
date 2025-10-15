
using ResolvendoExercicioSolid.DescontoPorCliente;
using ResolvendoExercicioSolid.Interfaces;

namespace ResolvendoExercicioSolid
{
    class GerenciadorDeDescontos
    {

        private readonly ICalculaStatusContaFactory descontoStatusContaFactory;
        private readonly ICalculaDescontoFidedlidade descontoFidedlidade;
        public GerenciadorDeDescontos(ICalculaDescontoFidedlidade _descontoFidelidade, ICalculaStatusContaFactory _descontoStatusConta)
        {
            descontoFidedlidade = _descontoFidelidade;
            descontoStatusContaFactory = _descontoStatusConta;
        }

        public decimal AplicarDesconto(decimal preco, StatusContaCliente statusContaCliente,
            int tempoDeContaEmAnos)
        {
            decimal precoDepoisDoDesconto = 0;

            precoDepoisDoDesconto = descontoStatusContaFactory
                .GetCalculoDescontoStatusConta(statusContaCliente)
                .AplicarDescontoStatusConta(preco);

            precoDepoisDoDesconto = descontoFidedlidade.AplicarDescontoFidelidade(preco, tempoDeContaEmAnos);

            return precoDepoisDoDesconto;
        }
    }       
}

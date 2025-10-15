
using ResolvendoExercicioSolid.DescontoPorCliente;
using ResolvendoExercicioSolid.Interfaces;

namespace ResolvendoExercicioSolid
{
    class GerenciadorDeDescontos
    {
        private readonly ICalculaDescontoFidedlidade descontoFidedlidade;
        public GerenciadorDeDescontos(ICalculaDescontoFidedlidade _descontoFidelidade)
        {
            descontoFidedlidade = _descontoFidelidade;
        }

        public decimal AplicarDesconto(decimal preco, StatusContaCliente statusContaCliente,
            int tempoDeContaEmAnos)
        {
            decimal precoDepoisDoDesconto = 0;

            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    precoDepoisDoDesconto = new ClienteNaoRegistradoDesconto().AplicarDescontoStatusConta(preco);
                    precoDepoisDoDesconto = descontoFidedlidade.AplicarDescontoFidelidade(preco, tempoDeContaEmAnos);
                    break;
                case StatusContaCliente.ClienteComum:
                    precoDepoisDoDesconto = new ClienteComumDesconto().AplicarDescontoStatusConta(preco);
                    precoDepoisDoDesconto = descontoFidedlidade.AplicarDescontoFidelidade(preco, tempoDeContaEmAnos);
                    break;
                case StatusContaCliente.ClienteEspecial:
                    precoDepoisDoDesconto = new ClienteEspecialDesconto().AplicarDescontoStatusConta(preco);
                    precoDepoisDoDesconto = descontoFidedlidade.AplicarDescontoFidelidade(preco, tempoDeContaEmAnos);
                    break;
                case StatusContaCliente.ClienteVIP:
                    precoDepoisDoDesconto = new ClienteVIPDesconto().AplicarDescontoStatusConta(preco);
                    precoDepoisDoDesconto = descontoFidedlidade.AplicarDescontoFidelidade(preco, tempoDeContaEmAnos);
                    break;
                default:
                    throw new NotImplementedException("O tipo do cliente não foi informado");
            }
            return precoDepoisDoDesconto;
        }
    }       
}

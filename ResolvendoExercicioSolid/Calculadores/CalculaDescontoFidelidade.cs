using ResolvendoExercicioSolid.Interfaces;


namespace ResolvendoExercicioSolid.Calculadores
{
    class CalculaDescontoFidelidade : ICalculaDescontoFidedlidade
    {
        public decimal AplicarDescontoFidelidade(decimal preco, int tempoDeContaEmAnos)
        {
            decimal descontoPorFidelidade = tempoDeContaEmAnos > Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE ?
                (decimal)Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE / 100 : (decimal)tempoDeContaEmAnos / 100;

            return preco - descontoPorFidelidade * preco;
        }
    }
}

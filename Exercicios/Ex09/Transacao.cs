namespace Exercicios.Ex09
{
    internal class Transacao : ConectarBancoDados, ITransacao
    {
        public void Executar()
        {
            Console.WriteLine("Processando transação");
        }
    }
}

using InterfaceBoasPraticas.Interfaces;

namespace InterfaceBoasPraticas.RegistroServices
{
    internal class RegistrarNoArquivo : IRegistro
    {
        private readonly string _caminhoDoArquivo;

        public RegistrarNoArquivo(string path)
        {
            _caminhoDoArquivo = path;
        }

        public void RegistrarInfo(string mensagem)
        {
            Log(mensagem);
        }

        public void Log(string mensagem)
        {
            using (var streamWriter = new StreamWriter(_caminhoDoArquivo, true))
            {

                streamWriter.WriteLine(mensagem);
            }
        }
    }
}

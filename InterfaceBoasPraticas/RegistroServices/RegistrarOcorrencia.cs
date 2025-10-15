using InterfaceBoasPraticas.Interfaces;

namespace InterfaceBoasPraticas.RegistroServices
{
    class RegistrarOcorrencia
    {
        private readonly IRegistro _registro;

        public RegistrarOcorrencia(IRegistro registro)
        {
            _registro = registro;
        }

        public void Registrar(string mensagem)
        {
            _registro.RegistrarInfo($"{mensagem} : {DateTime.Now}");
        }
    }
}

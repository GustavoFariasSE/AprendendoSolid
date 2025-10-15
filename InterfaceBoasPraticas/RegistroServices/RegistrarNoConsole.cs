using InterfaceBoasPraticas.Interfaces;

namespace InterfaceBoasPraticas.RegistroServices
{
    internal class RegistrarNoConsole : IRegistro
    {
        public void RegistrarInfo(string mensagem)
        {
            Console.WriteLine($"info : {mensagem}");
        }
    }
}

using Exercicios.Ex10;

namespace Exercicios.Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Peixe("Tucunaré");
            Animal animal2 = new Ave("Pato");

            animal1.Mover();
            animal2.Mover();

            Console.ReadLine();
        }
    }
}
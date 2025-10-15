
namespace Exercicios.Ex10
{
    public abstract class Animal
    {
        public string Tipo { get; set; }

        public Animal(string tipo)
        {
            Tipo = tipo;
        }

        public abstract void Mover();
       
    }
}

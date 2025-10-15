using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Ex10
{
    internal class Peixe : Animal
    {
        public Peixe(string tipo) : base(tipo)
        {

        }

        public override void Mover()
        {
            Console.WriteLine($"O {Tipo} está nadando");
        }
    }
}

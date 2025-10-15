using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Ex10
{
    internal class Ave : Animal
    {
        public Ave(string tipo) : base(tipo)
        {

        }

        public override void Mover()
        {
            Console.WriteLine($"A {Tipo} está voando");
        }
    }
}

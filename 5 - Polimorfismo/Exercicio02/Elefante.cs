using System;

namespace Exercicio02
{
    public class Elefante : Animal // Elefante É UM Animal!
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Barulho de Elefante...");
        }
    }
}
using System;

namespace Exercicio01
{
    public class Gato : Animal // Gato É UM Animal!
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Miau...");
        }
    }
}
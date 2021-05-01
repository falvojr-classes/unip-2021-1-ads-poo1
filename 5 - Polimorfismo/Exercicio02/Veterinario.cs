using System;

namespace Exercicio01
{
    public class Veterinario
    {
        public void Examinar(Animal animal)
        {
            Console.WriteLine("Examinando {0}...", animal.Nome);
            animal.EmitirSom();
            Console.WriteLine("Exame finalizado!");
        }
    }
}
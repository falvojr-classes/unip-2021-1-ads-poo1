using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato gato = new Gato();
            gato.Nome = "Tom";

            Pombo pombo = new Pombo();
            pombo.Nome = "Pombo";

            Veterinario joao = new Veterinario();
            joao.Examinar(gato);
            joao.Examinar(pombo);
        }
    }
}

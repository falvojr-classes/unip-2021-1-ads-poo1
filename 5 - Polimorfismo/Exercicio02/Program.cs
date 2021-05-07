using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Elefante elefante = new Elefante();
            elefante.Apelido = "Dumbo";

            Leao leao = new Leao();
            leao.Apelido = "Simba";

            Preguica preguica = new Preguica();
            preguica.Apelido = "Cid";

            Zoologico zoo = new Zoologico();
            zoo.RazaoSocial = "Zoo de Araraquara";
            zoo.Animais.Add(elefante);
            zoo.Animais.Add(leao);
            zoo.Animais.Add(preguica);

            Veterinario veterinario = new Veterinario();
            veterinario.Nome = "João";
            veterinario.Examinar(zoo.Animais);

            veterinario.Examinar(preguica);
        }
    }
}

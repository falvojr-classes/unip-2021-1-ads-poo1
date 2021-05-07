using System.Collections.Generic;

namespace Exercicio02
{
    public class Zoologico
    {
        public string RazaoSocial { get; set; }
        public List<Animal> Animais { get; set; } = new List<Animal>();
    }
}
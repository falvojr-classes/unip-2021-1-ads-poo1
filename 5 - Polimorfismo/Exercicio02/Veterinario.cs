using System;
using System.Collections.Generic;

namespace Exercicio02
{
    // [ F ] Herança
    // [ V ] Polimorfismo
    // [ V ] Encapsulamento
    // [ F ] Sobreescrita (virtual, override)
    // [ V ] Sobrecarga
    public class Veterinario
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        // Sobrecarga de Construtores:

        public Veterinario()
        {

        }

        public Veterinario(string nome)
        {
            Nome = nome;
        }

        // Sobrecarga de Métodos:

        public void Examinar(Animal animal)
        {
            Console.WriteLine("Examinando {0}...", animal.Apelido);
            animal.EmitirSom();
            Console.WriteLine("Exame finalizado!");
        }

        public void Examinar(List<Animal> animais)
        {
            foreach (Animal animal in animais)
            {
                Examinar(animal);
            }
        }
    }
}
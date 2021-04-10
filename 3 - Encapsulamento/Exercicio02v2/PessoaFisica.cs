using System;

namespace Exercicio02v2
{
    public class PessoaFisica : Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public override void PagarImposto()
        {
            System.Console.WriteLine("PF pagando 27.50% de imposto...");
        }
    }
}
using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.Nome = "Venilton";
            pf.Cpf = "111.111.111-11";
            
            Console.WriteLine(pf.Nome);
        }
    }
}

using System;

namespace Exercicio02v2
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.Nome = "Venilton";
            pf.Documento = "111.111.111-11";

            PessoaJuridica pj = new PessoaJuridica();
            pj.RazaoSocial = "XPTO LTDA";
            pj.Documento = "22.222.222/0001-0";

            Governo governo = new Governo();
            governo.CobrarImposto(pf);
            governo.CobrarImposto(pj);
        }
    }
}

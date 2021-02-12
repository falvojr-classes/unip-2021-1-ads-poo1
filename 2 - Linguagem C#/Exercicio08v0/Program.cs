using System;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente venilton = new Cliente();
            venilton.Nome = "Venilton";
            venilton.Agencia = "82-5";
            venilton.Conta = "745456-9";

            Cartao cartao = new Cartao();
            cartao.Numero = 787978454645123;
            cartao.Cliente = venilton;
            cartao.Cliente.Documento = "12313213";

            Console.WriteLine(venilton.Documento);
        }
    }
}

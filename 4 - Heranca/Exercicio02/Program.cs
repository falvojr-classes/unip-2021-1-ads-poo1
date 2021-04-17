using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor();
            vendedor.Nome = "José";
            vendedor.Comissao = 1000.00;
            vendedor.NumeroVendas = 10;

            Consultor consultor = new Consultor();
            consultor.Nome = "Fabio";
            consultor.ValorHora = 85.50;
            consultor.HorasTrabalhadas = 160;

            Gerente gerente = new Gerente();
            gerente.Nome = "João Silva";
            gerente.Bonificacao = 5000;

            Console.WriteLine("Salário Minimo: R${0:0.00}", Funcionario.SalarioMinimo);
            Console.WriteLine("{0}: R${1:0.00}", vendedor.Nome, vendedor.CalcularSalario());
            Console.WriteLine("{0}: R${1:0.00}", consultor.Nome, consultor.CalcularSalario());
            Console.WriteLine("{0}: R${1:0.00}", gerente.Nome, gerente.CalcularSalario());
        }
    }
}

using System;

namespace Exercicio08v2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando as instâncias das Classes (objetos)
            Cliente cliente = new Cliente();
            Conta conta = new Conta();
            Cartao cartao = new Cartao();

            // Preenche os dados das instâncias
            cliente.Nome = "Jaum";
            cliente.Documento = "123";

            conta.Numero = 1;
            conta.Agencia = "0001";
            conta.Limite = 500.00;

            cartao.Numero = 123;
            cartao.Limite = 250.00;

            // Relaciona as instancias considerando os atributos criados a partir da cardinalidade (UML)
            cliente.Conta = conta;
            cartao.Cliente = cliente;

            Console.WriteLine(cartao.Cliente.Nome);
            Console.WriteLine(cartao.Cliente.Conta.Numero);
            Console.WriteLine(cartao.Numero);
        }
    }
}

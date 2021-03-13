using System;
using System.Collections.Generic;

namespace Exercicio08
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Venilton";
            cliente.Documento = "123456789-0";

            // Criar a Conta e relacioná-la com o Cliente

            Conta contaCorrente = new Conta();
            contaCorrente.Numero = "1";
            contaCorrente.Agencia = "0001";
            contaCorrente.Limite = 500.00;

            cliente.Conta = contaCorrente;

            // Criar 2 Cartões e relacioná-los com o Cliente

            Cartao cartaoCredito = new Cartao();
            cartaoCredito.Numero = 123;

            Cartao cartaoDebito = new Cartao();
            cartaoDebito.Numero = 456;

            cliente.Cartoes = new List<Cartao>();
            cliente.Cartoes.Add(cartaoCredito);
            cliente.Cartoes.Add(cartaoDebito);

            Console.WriteLine("Nome: {0} ({1})", cliente.Nome, cliente.Documento);
            Console.WriteLine("Número Conta: {0}", cliente.Conta.Numero);
            Console.WriteLine("Agência: {0}", cliente.Conta.Agencia);
            Console.WriteLine("Lista de Cartões:");
            foreach (Cartao cartao in cliente.Cartoes)
            {
                Console.WriteLine("Cartão {0}", cartao.Numero);
            }
        }
    }
}

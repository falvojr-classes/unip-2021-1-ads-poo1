using System;
using System.Collections.Generic;

namespace Exercicio08 
{
    public class Cliente
    {
        public string Nome;
        public string Documento;
        public List<Cartao> Cartoes;
        public Conta Conta;

        public void Depositar(double valor) 
        {
            Conta.Depositar(valor);
        }

        public void Sacar(double valor) 
        {
            Conta.Sacar(valor);
        }

        public void Transferir(double valor, Conta destino) 
        {
            Conta.Transferir(valor, destino);
        }

        public void ImprimirExtrato()
        {
            Console.WriteLine("Nome Cliente: {0}", Nome);
            Console.WriteLine("Documento Cliente: {0}", Documento);
            Conta.ImprimirExtrato();
        }
    }
}
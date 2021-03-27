using System;

namespace Exercicio08
{
    public class Conta
    {
        public string Numero { get; set; }
        public double Limite { get; set; }
        public double Saldo { get; private set; }
        public Agencia Agencia { get; set; }

        public void Depositar(double valor) 
        {
            Saldo += valor;
            //Saldo = Saldo + valor;
        }

        public bool Sacar(double valor) 
        {
            bool saqueRealizado = false;
            if (Saldo >= valor)
            {
                Saldo -= valor;
                //Saldo = Saldo - valor;
                saqueRealizado = true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente na Conta {0}", Numero);
            }
            return saqueRealizado;
        }

        public void Transferir(double valor, Conta destino) 
        {
            if(this.Sacar(valor)) 
            {
                destino.Depositar(valor);
            }
        }

        public void ImprimirExtrato()
        {
            Console.WriteLine("Numero: {0}", Numero);
            Console.WriteLine("Agencia: {0}", Agencia.Numero);
            Console.WriteLine("Saldo: {0}", Saldo);
        }
    }
}
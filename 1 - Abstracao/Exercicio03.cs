using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Cliente cliente = new Cliente();
        cliente.Nome = "Venilton";
        cliente.Cpf = "00000";
        cliente.Enderecos = new List<Endereco>();

        Endereco end1 = new Endereco();
        end1.Cep = "14801788";

        Endereco end2 = new Endereco();
        end2.Cep = "14835000";

        cliente.Enderecos.Add(end1);
        cliente.Enderecos.Add(end2);

        Console.WriteLine("Meu nome e {0}!", cliente.Nome);
        Console.WriteLine("Meus enderecos:");
        foreach (Endereco endereco in cliente.Enderecos)
        {
            Console.WriteLine(endereco.Cep);
        }
    }
}

class Cliente
{
    public String Nome;
    public String Cpf;
    public List<Endereco> Enderecos;
}

class Endereco
{
    public String Logradouro;
    public String Cep;
    public String Numero;
}
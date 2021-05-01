using System;
using System.Collections.Generic;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar os quartos do Hotel
            Quarto casal = new Quarto();
            casal.Numero = "1";
            casal.Disponivel = true;
            casal.Capacidade = 2;
            casal.ValorDiario = 90.00;

            Quarto individual = new Quarto();
            individual.Numero = "2";
            individual.Disponivel = true;
            individual.Capacidade = 1;
            individual.ValorDiario = 50.00;

            // Criar os funcionários do Hotel
            Funcionario recepcionista = new Funcionario();
            recepcionista.Nome = "José";
            recepcionista.Cracha = 1;

            Gerente gerente = new Gerente();
            gerente.Nome = "Paula";
            gerente.Cracha = 2;

            // Criar os clientes do Hotel
            Cliente joao = new Cliente();
            joao.Nome = "João";

            Cliente maria = new Cliente();
            maria.Nome = "Maria";

            Cliente mario = new Cliente();
            mario.Nome = "Mario";

            // Simular uma Estadia
            Estadia estadia1 = new Estadia();
            estadia1.Responsavel = gerente;
            estadia1.Hospedes.Add(joao);
            estadia1.Hospedes.Add(maria);
            estadia1.Quarto = casal;
            estadia1.CheckIn();

            Servico frigobar = new Servico("Bebidas", 20.00);
            estadia1.Servicos.Add(Servico.Lavandeira);
            estadia1.Servicos.Add(frigobar);
            estadia1.Servicos.Add(Servico.Lavandeira);

            estadia1.CheckOut();

            // Estadia estadia2 = new Estadia();
            // estadia2.Responsavel = gerente;
            // estadia2.Hospedes.Add(mario);
            // estadia2.Quarto = individual;
        }
    }
}

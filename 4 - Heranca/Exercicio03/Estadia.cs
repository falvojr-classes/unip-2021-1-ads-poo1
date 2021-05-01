using System;
using System.Collections.Generic;

namespace Exercicio03
{
    public class Estadia
    {
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public double ValorTotal { get; set; }
        public bool Pago { get; set; }
        public List<Cliente> Hospedes { get; set; }
        public Funcionario Responsavel { get; set; }
        public Quarto Quarto { get; set; }
        public List<Servico> Servicos { get; set; }

        public Estadia()
        {
            Hospedes = new List<Cliente>();
            Servicos = new List<Servico>();
        }

        public void CheckIn()
        {
            if (Hospedes.Count > Quarto.Capacidade)
            {
                Console.WriteLine("[ERRO] Capacidade do Quanto excedida!");
            }
            else
            {
                // Simula a entrada a 3 dias atrás.
                Entrada = DateTime.Now.AddDays(-3);
                Quarto.Disponivel = false;
            }
        }

        public void CheckOut()
        {
            Saida = DateTime.Now;
            double total = CalcularTotal();
            // Imprime a comanda para pagamento
            Console.WriteLine("============================");
            Console.WriteLine("Hospede Primário: {0}", Hospedes[0].Nome);
            Console.WriteLine("Todos os Hospedes: {0}", string.Join(", ", Hospedes.ConvertAll(cliente => cliente.Nome)));
            Console.WriteLine("Total: R${0:0.00}", total);
            Console.WriteLine("============================");

            Quarto.Disponivel = true;
        }

        private double CalcularTotal()
        {
            // Calcular o total dos Servicos
            double totalServicos = 0;
            foreach (Servico servico in Servicos)
            {
                totalServicos += servico.Valor;
            }
            // Calcular o total das diárias
            double diasNoQuarto = (Saida - Entrada).TotalDays;
            double totalQuarto = diasNoQuarto * Quarto.ValorDiario;
            // Calcular o valor total (serviços + diárias)
            return totalServicos + totalQuarto;
        }
    }
}
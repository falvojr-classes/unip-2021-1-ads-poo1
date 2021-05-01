namespace Exercicio03
{
    public class Servico
    {
        // Cria um serviço de lavanderia fixo/estático:
        public static Servico Lavandeira = new Servico("Lavanderia", 100.00);

        public string Nome { get; set; }
        public double Valor { get; set; }

        public Servico(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
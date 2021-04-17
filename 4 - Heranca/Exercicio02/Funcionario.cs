namespace Exercicio02
{
    public abstract class Funcionario
    {
        public const double SalarioMinimo = 1100.00;

        public string Nome { get; set; }
        public string Cpf { get; set; }

        public abstract double CalcularSalario();
    }
}
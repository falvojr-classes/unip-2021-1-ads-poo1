namespace Exercicio02
{
    public class Gerente : Funcionario
    {
        public double Bonificacao { get; set; }

        public override double CalcularSalario()
        {
            //Gerentes ganham 6 salários mínimos, mais sua bonificação.
            return (6 * SalarioMinimo) + Bonificacao;
        }
    }
}
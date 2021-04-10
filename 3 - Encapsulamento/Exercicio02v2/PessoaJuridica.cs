namespace Exercicio02v2
{
    public class PessoaJuridica : Pessoa
    {
        public string RazaoSocial { get; set; }

        public override void PagarImposto()
        {
            System.Console.WriteLine("PJ pagando 19.63% de imposto...");
        }
    }
}
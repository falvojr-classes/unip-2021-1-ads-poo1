using System;

namespace Exercicio02
{
    public class ControlePonto
    {
        // Exemplo do uso efetivo do "this":
        public int Id { get; set; }
        public ControlePonto(int Id)
        {
            this.Id = Id;
        }

        public ControlePonto() { }

        public void RegistrarEntrada(Funcionario funcionario)
        {
            ImprimirComprovante(funcionario, true);
        }

        public void RegistrarSaida(Funcionario funcionario)
        {
            ImprimirComprovante(funcionario, false);
        }

        private void ImprimirComprovante(Funcionario funcionario, bool ehEntrada)
        {
            string tipoEntrada = ehEntrada ? "Entrada" : "Saída";
            Console.WriteLine("==============================");
            Console.WriteLine("{0}: {1}", tipoEntrada, DateTime.Now);
            Console.WriteLine("Funcionário: {0}", funcionario.Nome);
            Console.WriteLine("Tipo: {0}", funcionario.GetType().Name);
            Console.WriteLine("==============================");
        }
    }
}
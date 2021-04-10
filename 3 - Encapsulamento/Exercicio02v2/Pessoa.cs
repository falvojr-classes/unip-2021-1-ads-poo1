using System;

namespace Exercicio02v2
{
    public abstract class Pessoa
    {
        public string Documento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }

        public abstract void PagarImposto();
    }
}
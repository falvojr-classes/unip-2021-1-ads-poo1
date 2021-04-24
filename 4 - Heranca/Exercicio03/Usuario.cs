namespace Exercicio03
{
    public abstract class Usuario
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public void Cadastrar()
        {
            //TODO Implementar lógica de cadastro de usuários.
        }

        public bool Logar()
        {
            //TODO Implementar lógica de login.
            return false;
        }
    }
}
namespace Exercicio02
{
    public abstract class Animal : IAnimal
    {
        public string Apelido { get; set; }
        public string Especie { get; set; }

        public abstract void EmitirSom();
    }
}
namespace Exercicio01
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public string Genero { get; set; }
        public string Especie { get; set; }
        public int Idade { get; set; }

        public abstract void EmitirSom();
    }
}
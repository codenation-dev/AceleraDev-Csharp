using System;

namespace Interfaces
{
    public class Gato : ISom
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeDoDono { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine("Miauuuuu");
        }
    }
}

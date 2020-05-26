using System;

namespace Interfaces
{
    public class Carro : ISom
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int AnoFabricacao { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine("Fazer Brummmm");
        }
    }
}

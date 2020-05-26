using System;

namespace Interfaces
{
    public class Ventilador : ISom
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Cor { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine("Barulho do vento");
        }
    }
}

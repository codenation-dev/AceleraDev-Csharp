using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            new Carro().EmitirSom();
            new Gato().EmitirSom();
            new Ventilador().EmitirSom();
        }
    }
}

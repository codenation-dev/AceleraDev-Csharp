namespace Generics
{
    public class KiloBuffet : ICalculoValor
    {
        public decimal ValorBruto { get; set; }
        public decimal ValorFinal { get; set; }

        public KiloBuffet()
        {
            ValorBruto = 42;
        }
    }
}

namespace Generics
{
    public class DesenvolvimentoDeSoftware : ICalculoValor
    {
        public decimal ValorBruto { get; set; }
        public decimal ValorFinal { get; set; }

        public DesenvolvimentoDeSoftware()
        {
            ValorBruto = 50;
        }
    }
}

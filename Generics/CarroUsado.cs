namespace Generics
{
    public class CarroUsado : ICalculoValor
    {
        public decimal ValorBruto { get; set; }
        public decimal ValorFinal { get; set; }

        public CarroUsado()
        {
            ValorBruto = 30000;
        }
    }
}

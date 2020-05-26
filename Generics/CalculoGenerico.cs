namespace Generics
{
    public class CalculoGenerico<T> where T : ICalculoValor
    {
        private decimal _imposto = 0.05m;
        private decimal _lucro = 0.10m;

        public void CalcularValorUnitario(T obj)
        {
            obj.ValorFinal += obj.ValorBruto;
            obj.ValorFinal += obj.ValorBruto * _imposto;
            obj.ValorFinal += obj.ValorBruto * _lucro;            
        }
    }
}

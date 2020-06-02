using Generics;
using Xunit;

namespace MeuPrimeiroTeste_xUnit.Generics
{
    public class GenericsTest
    {
        [Fact]
        public void Calcular_valor_unitario_dev()
        {
            // arrange
            DesenvolvimentoDeSoftware dev = new DesenvolvimentoDeSoftware();
            CalculoGenerico<DesenvolvimentoDeSoftware> calcDev = new CalculoGenerico<DesenvolvimentoDeSoftware>();            

            // act
            calcDev.CalcularValorUnitario(dev);

            //assert
            Assert.Equal(57.50M, dev.ValorFinal);
        }

        [Fact]
        public void Calcular_valor_unitario_carro()
        {
            // arrange
            CarroUsado carro = new CarroUsado();
            CalculoGenerico<CarroUsado> calcCarro = new CalculoGenerico<CarroUsado>();

            // act
            calcCarro.CalcularValorUnitario(carro);

            //assert
            Assert.Equal(34500, carro.ValorFinal);
        }

        [Fact]
        public void Calcular_valor_unitario_comida()
        {
            // arrange
            KiloBuffet comida = new KiloBuffet();
            CalculoGenerico<KiloBuffet> calcBuffet = new CalculoGenerico<KiloBuffet>();

            // act
            calcBuffet.CalcularValorUnitario(comida);

            //assert
            Assert.Equal(48.30M, comida.ValorFinal);
        }

        [Theory]
        [InlineData("Thamy Gameiro Developer", 3)]
        [InlineData("Thamy ... Gameiro", 2)]
        public void Vericar_quantidade_de_palavras(string texto, int valorEsperado)
        {
            int qtdd = texto.ContadorDePalavras();
            Assert.Equal(valorEsperado, qtdd);
        }
    }
}

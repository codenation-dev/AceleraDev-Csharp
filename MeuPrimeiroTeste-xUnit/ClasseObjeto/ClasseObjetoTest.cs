using ClasseObjeto;
using Xunit;

namespace MeuPrimeiroTeste_xUnit.ClasseObjeto
{
    public class ClasseObjetoTest
    {
        [Fact]
        public void Verificar_latido_doguinho()
        {
            // arrange
            Doguinho doguinho = new Doguinho();

            // act
            var latido = doguinho.Latir();

            //assert
            Assert.Equal("Au au au", latido);
        }
    }
}

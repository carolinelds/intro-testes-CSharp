using Xunit;

namespace Tests.Intro.Tests
{
    public class AreaCirculoTest
    {
        [Fact]
        public void CalculoTest()
        {
            var entrada = 2;
            var saidaEsperada = "12,5664";

            var retorno = AreaCirculo.Calculo(entrada);

            Assert.Equal(retorno, saidaEsperada);
        }
    }
}
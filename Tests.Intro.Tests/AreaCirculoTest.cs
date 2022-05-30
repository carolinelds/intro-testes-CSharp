using Xunit;

namespace Tests.Intro.Tests
{
    public class AreaCirculoTest
    {
        [Theory]
        [InlineData(2, "12,5664")]
        [InlineData(100.64, "31819,3103")]
        [InlineData(150, "70685,7750")]
        public void CalculoTest(double entrada, string esperado)
        {
            var retorno = AreaCirculo.Calculo(entrada);

            Assert.Equal(retorno, esperado);
        }
    }
}
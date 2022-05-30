using System;
using Xunit;

namespace Tests.Intro.Tests
{
    public class AreaCirculoTest
    {
        // testes anteriores, valores válidos
        [Theory]
        [InlineData(2, "12,5664")]
        [InlineData(100.64, "31819,3103")]
        [InlineData(150, "70685,7750")]
        public void Quando_PassadoValorValido_Deve_RetornarCalculoArea(double entrada, string esperado)
        {
            var retorno = AreaCirculo.Calculo(entrada);

            Assert.Equal(retorno, esperado);
        }

        // teste com entrada zero
        [Fact]
        public void Quando_PassadoZero_Deve_RetornarZero()
        {
            var entrada = 0;
            var esperado = "0";

            var retorno = AreaCirculo.Calculo(entrada);

            Assert.Equal(retorno, esperado);
        }

        // testes com entradas negativas
        [Theory]
        [InlineData(-2)]
        [InlineData(-2.564)]
        public void Quando_PassadoValorInvalido_Deve_RetornarExcecao(double entrada)
        {
            const string mensagemEsperada = "Raio deve ser positivo.";

            var exception = Assert.Throws<ArgumentException>(
                () => AreaCirculo.Calculo(entrada));

            Assert.Equal(exception.Message, mensagemEsperada);
        }
    }
}
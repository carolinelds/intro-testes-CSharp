using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.Intro.Tests
{
    public class MediaTest
    {
        [Theory]
        [InlineData(2, 2, "2,0")]
        [InlineData(2, 4, "3,0")]
        [InlineData(2.5, 5.2, "3,9")]
        public void Quando_PassadoDoisValoresValidos_Deve_RetornarCalculoMedia(double n1, double n2, string esperado)
        {
            var resultado = Media.Simples(n1, n2);

            Assert.Equal(resultado, esperado);
        }

        [Theory]
        [InlineData(5, 6, 7, "6,0")]
        [InlineData(5, 10, 10, "8,3")]
        [InlineData(10.5, 6.2, 7.8, "8,2")]
        public void Quando_PassadoTresValoresValidos_Deve_RetornarCalculoMedia(double n1, double n2, double n3, string esperado)
        {
            var resultado = Media.Simples(n1, n2, n3);

            Assert.Equal(resultado, esperado);
        }

        [Theory]
        [InlineData(2, -2)]
        [InlineData(-2, 4)]
        [InlineData(-2, -4)]
        public void Quando_PassadoUmADoisValoresInvalidos_Deve_RetornarExcecao(double n1, double n2)
        {
            const string msgEsperada = "Os valores devem ser positivos.";

            var exception = Assert.Throws<ArgumentException>(
                () => Media.Simples(n1,n2));

            Assert.Equal(msgEsperada, exception.Message);
        }

        [Theory]
        [InlineData(-2, 2, 1)]
        [InlineData(2, -4, 1)]
        [InlineData(2, 4, -1)]
        [InlineData(-2, -4, 1)]
        [InlineData(2, -4, -1)]
        [InlineData(-2, 4, -1)]
        [InlineData(-2, -4, -1)]
        public void Quando_PassadoUmATresValoresInvalidos_Deve_RetornarExcecao(double n1, double n2, double n3)
        {
            const string msgEsperada = "Os valores devem ser positivos.";

            var exception = Assert.Throws<ArgumentException>(() => Media.Simples(n1,n2,n3));

            Assert.Equal(msgEsperada, exception.Message);
        }
    }
}

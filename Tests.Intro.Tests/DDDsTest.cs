using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace Tests.Intro.Tests
{
    public class DDDsTest
    {
        [Theory]
        [InlineData(-11)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(9)]
        [InlineData(100)]
        public void Quando_PassaValorInvalido_Deve_RetornarExcecao(int num)
        {
            string msgEsperada = "DDD inválido.";

            var exception = Assert.Throws<ArgumentException>(() => DDDs.ChecaDDD(num));

            Assert.Equal(msgEsperada, exception.Message);
        }

        [Theory]
        [InlineData(11, "São Paulo")]
        [InlineData(19, "Campinas")]
        [InlineData(21, "Rio de Janeiro")]
        [InlineData(27, "Vitória")]
        [InlineData(31, "Belo Horizonte")]
        [InlineData(32, "Juiz de Fora")]
        [InlineData(61, "Brasília")]
        [InlineData(71, "Salvador")]
        public void Quando_PassaValorValido_Deve_RetornarCidade(int num, string esperado)
        {
            string resultado = DDDs.ChecaDDD(num);

            Assert.Equal(resultado, esperado);
        }

        [Theory]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(22)]
        [InlineData(23)]
        [InlineData(54)]
        public void Quando_PassaValorInvalido_Deve_RetornarNaoEncontrado(int num)
        {
            string msgEsperada = "DDD não encontrado";

            string resultado = DDDs.ChecaDDD(num);

            Assert.Equal(msgEsperada, resultado);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.Intro.Tests
{
    public class PopulacaoTests
    {
        [Theory]
        [InlineData(-100, 150, 1.0, 1.2)]
        [InlineData(100, -150, 1.0, 1.2)]
        [InlineData(-100, -150, 1.0, 1.2)]
        public void Quando_PassadoPopulacoesNegativas_Deve_RetornarExcecao(int popA, int popB, double crescA, double crescB)
        {
            string msgEsperada = "População não pode ser negativa.";

            var exception = Assert.Throws<ArgumentException>(
                () => Populacao.CalculaCrescimento(popA, popB, crescA, crescB));

            Assert.Equal(msgEsperada, exception.Message);
        }

        [Theory]
        [InlineData(151, 150, 1.0, 1.2)]
        [InlineData(1100, 150, 1.0, 1.2)]
        [InlineData(100, 0, 1.0, 1.2)]
        public void Quando_PassadoPopulacaoAMenorOuIgualAPopulacaoB_Deve_RetornarExcecao(int popA, int popB, double crescA, double crescB)
        {
            string msgEsperada = "População da cidade A já é maior ou igual.";

            var exception = Assert.Throws<ArgumentException>(
                () => Populacao.CalculaCrescimento(popA, popB, crescA, crescB));

            Assert.Equal(msgEsperada, exception.Message);
        }

        [Theory]
        [InlineData(100, 150, 1.0, 1.2)]
        [InlineData(149, 150, 1.0, 1.2)]
        [InlineData(0, 0, 1.0, 1.2)]
        public void Quando_PassadoCrescimentoAMenorOuIgualACrescimentoB_Deve_RetornarExcecao(int popA, int popB, double crescA, double crescB)
        {
            string msgEsperada = "Cidade A nunca terá uma população maior que a cidade B";

            var exception = Assert.Throws<ArgumentException>(
                () => Populacao.CalculaCrescimento(popA, popB, crescA, crescB));

            Assert.Equal(msgEsperada, exception.Message);
        }

        [Theory]
        [InlineData(100, 150, 1.0, 0, "51 anos.")]
        [InlineData(90000, 120000, 5.5, 3.5, "16 anos.")]
        [InlineData(56700, 72000, 5.2, 3.0, "12 anos.")]
        [InlineData(123, 2000, 3.0, 2.0, "Mais de 1 século.")]
        [InlineData(100000, 110000, 1.5, 0.5, "10 anos.")]
        [InlineData(62422, 484317, 3.1, 1.0, "100 anos.")]
        [InlineData(100, 150, 4.5, 4.0, "95 anos.")]
        public void Quando_PassadoDadosValidos_Deve_RetornarCalculoCrescimento(int popA, int popB, double crescA, double crescB, string esperado)
        {
            var resultado = Populacao.CalculaCrescimento(popA, popB, crescA, crescB);

            Assert.Equal(resultado, esperado);
        }
    }
}

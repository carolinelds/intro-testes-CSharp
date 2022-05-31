using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace Tests.Intro.Tests
{
    public class FloresTest
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("Palavra")]
        public void Quando_PassadoValorInvalido_Deve_RetornarExcecao(string frase)
        {
            const string msgEsperada = "Frase inválida.";

            var exception = Assert.Throws<ArgumentException>(() => Flores.IsTautograma(frase));

            Assert.Equal(msgEsperada, exception.Message);
        }

        [Theory]
        [InlineData("Flowers Flourish from France", "Y")]
        [InlineData("Sam Simmonds speaks softly", "Y")]
        [InlineData("Peter pIckEd pePPers", "Y")]
        [InlineData("truly tautograms triumph", "Y")]
        [InlineData("Isso não é um Tautograma", "N")]
        public void Quando_PassadoValorValido_Deve_RetornarIsTautograma(string frase, string esperado)
        {
            var resultado = Flores.IsTautograma(frase);

            Assert.Equal(resultado, esperado);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.Intro.Tests
{
    public class CriptografiaTests
    {
        [Theory]
        [InlineData("Tex")]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void Quando_PassaValorInvalido_Deve_RetornarExcecao(string entrada)
        {
            var msgEsperada = "entrada é nula, vazia ou muito pequena.";

            var exception = Assert.Throws<ArgumentException>(
                () => Criptografia.Criptografar(entrada));

            Assert.Equal(msgEsperada, exception.Message);
        }

        [Theory]
        [InlineData("Texto #3", "3# rvzgV")]
        [InlineData("abcABC1", "1FECedc")]
        [InlineData("vxpdylY .ph", "ks. \\n{frzx")]
        [InlineData("vv.xwfxo.fd", "gi.r{hyz-xx")]
        public void Quando_PassaValorValido_Deve_RetornarValorCriptografado(string entrada, string esperado)
        {
            var resultado = Criptografia.Criptografar(entrada);

            Assert.Equal(resultado, esperado);
        }
    }
}

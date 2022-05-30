using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.Intro.Tests
{
    public class SalarioTest
    {
        [Theory]
        [InlineData(500, 1230.3, "684,54")]
        [InlineData(700, 150, "722,50")]
        [InlineData(1700, 1230.5, "1884,58")]
        public void Quando_PassadoValoresValidos_Deve_RetornarSalarioComBonus(double salario, double vendas, string esperado)
        {
            var retorno = Salario.SalarioComBonus(salario, vendas);

            Assert.Equal(retorno, esperado);
        }

        [Theory]
        [InlineData(500, -52564.45)]
        [InlineData(700, -1)]
        [InlineData(1700, -0.99)]
        public void Quando_PassadoVendasInvalidas_Deve_RetornarExcecaoVendas(double salario, double vendas)
        {
            const string msgEsperada = "Vendas não podem ser negativas.";

            var exception = Assert.Throws<ArgumentException>(() => Salario.SalarioComBonus(salario, vendas));

            Assert.Equal(msgEsperada, exception.Message);
        }

        [Theory]
        [InlineData(-700, 1230.3)]
        [InlineData(0, 0)]
        [InlineData(499.999, 1230.5)]
        public void Quando_PassadoSalarioInvalido_Deve_RetornarExcecaoSalario(double salario, double vendas)
        {
            const string msgEsperada = "Salário deve ser válido, acima do piso de 500.";

            var exception = Assert.Throws<ArgumentException>(() => Salario.SalarioComBonus(salario, vendas));

            Assert.Equal(msgEsperada, exception.Message);
        }
    }
}

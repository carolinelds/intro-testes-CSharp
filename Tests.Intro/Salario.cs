using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Intro
{
    public static class Salario
    {
        public static string SalarioComBonus(double salario, double vendas)
        {
            if (salario < 500)
            {
                throw new ArgumentException("Salário deve ser válido, acima do piso de 500.");
            } 
            else if (vendas < 0)
            {
                throw new ArgumentException("Vendas não podem ser negativas.");
            }
            else if (vendas == 0)
            {
                return salario.ToString("F2");
            }

            return (salario + vendas * 0.15).ToString("F2");
        }
    }
}

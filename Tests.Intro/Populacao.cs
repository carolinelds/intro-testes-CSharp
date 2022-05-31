using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Intro
{
    public class Populacao
    {
        public static string CalculaCrescimento(int popA, int popB, double crescA, double crescB)
        {
            if (popA < 0 || popB < 0)
            {
                throw new ArgumentException("População não pode ser negativa.");
            }

            if (popA >= popB && popA != 0)
            {
                throw new ArgumentException("População da cidade A já é maior ou igual.");
            }

            if (crescA <= crescB)
            {
                throw new ArgumentException("Cidade A nunca terá uma população maior que a cidade B");
            }

            int anos = 0;
            while (popA <= popB)
            {
                if (anos > 100)
                {
                    break;
                }
                var novosA = Math.Floor(popA * crescA/100);
                popA += (int)novosA;

                var novosB = Math.Floor(popB * crescB/100);
                popB += (int)novosB;

                anos++;
            }

            if (anos > 100)
            {
                return "Mais de 1 século.";
            }
            else
            {
                return $"{anos} anos.";
            }
        }
    }
}

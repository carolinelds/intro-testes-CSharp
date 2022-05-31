using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Intro
{
    public static class Flores
    {
        public static string IsTautograma(string? frase)
        {
            if (frase == null || frase == "" || frase == " " || !frase.Contains(' '))
            {
                throw new ArgumentException("Frase inválida.");
            }

            char letra = char.ToLower(frase[0]);

            string[] palavras = frase.Split(' ');

            string saida = "Y";
            foreach (var palavra in palavras){
                if (char.ToLower(palavra[0]) != letra)
                {
                    saida = "N";
                }
            }

            return saida;
        }
    }
}

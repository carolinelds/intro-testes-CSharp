using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Intro
{
    public static class Criptografia
    {
        public static string Criptografar(string? entrada)
        {
            if (entrada == null || entrada.Length < 4 || String.IsNullOrEmpty(entrada))
            {
                throw new ArgumentException("entrada é nula, vazia ou muito pequena.");
            }

            string saida1 = "";
            foreach (char c in entrada)
            {
                if (Char.IsLetter(c))
                    saida1 += (char)(c + 3);
                else
                    saida1 += c;
            }
            Console.WriteLine(saida1);

            string saida2 = new string(saida1.Reverse().ToArray());
            Console.WriteLine(saida2);

            var metade = saida2.Length / 2;

            string saida3 = "";
            int cont = 0;
            foreach (char c in saida2)
            {
                if (cont < metade)
                {
                    saida3 += c; 
                } 
                else
                {
                    saida3 += (char)(c - 1);
                }
                cont++;
            }
            Console.WriteLine(saida3);


            return saida3;
        }
    }
}

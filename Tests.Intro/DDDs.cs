using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Intro
{
    public static class DDDs
    {
        public static string ChecaDDD(int num)
        {
            var tabela = ConstroiTabela();

            if (num < 10 || num > 99)
            {
                throw new ArgumentException("DDD inválido.");
            }

            try
            {
                return tabela[num];
            }
            catch (KeyNotFoundException)
            {
                return "DDD não encontrado";
            }
        }

        public static Dictionary<int, string> ConstroiTabela()
        {
            Dictionary<int, string> tabelaDDDs = new Dictionary<int, string>();

            int[] ddds = new int[] { 61, 71, 11, 21, 32, 19, 27, 31 };

            string[] cidades = new string[] { "Brasília", "Salvador", "São Paulo", "Rio de Janeiro", "Juiz de Fora", "Campinas", "Vitória", "Belo Horizonte" };

            for (int i = 0; i < ddds.Length; i++)
            {
                tabelaDDDs.Add(ddds[i], cidades[i]);
            }

            return tabelaDDDs;
        }
    }
}
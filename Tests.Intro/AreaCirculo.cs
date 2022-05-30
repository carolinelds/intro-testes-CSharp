namespace Tests.Intro
{
    public static class AreaCirculo
    {
        private static readonly double PI = 3.14159;

        public static string Calculo(double raio)
        {
            if (raio < 0) // validação 1
            {
                throw new ArgumentException("Raio deve ser positivo.");
            } 
            else if (raio == 0) // validação 2
            {
                return "0";
            }

            var resultado = PI * Math.Pow(raio, 2);
            return resultado.ToString("F4");
        }
    }
}


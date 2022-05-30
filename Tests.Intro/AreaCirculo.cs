namespace Tests.Intro
{
    public static class AreaCirculo
    {
        private static readonly double PI = 3.14159;

        public static string Calculo(double raio)
        {
            var resultado = PI * Math.Pow(raio, 2);
            return resultado.ToString("F4");
        }
    }
}
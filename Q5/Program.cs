using System;
namespace Q5
{
    public class Program
    {
        public static int ConatarQuantidadeDePares (int n)
        {
            int qtd = 0;
            var array = Array.ConvertAll (n.ToString ().ToCharArray (), c => (Char.GetNumericValue (c)));
            foreach (var item in array)
            {
                if (item % 2 == 0) qtd++;
            }
            return qtd;
        }
        public static int ConatarQuantidadeDeParesR (int n, int qtd = 0)
        {
            if (n == 0) return 0;
            if (n % 2 != 0) return ConatarQuantidadeDeParesR (n / 10);
            return 1 + ConatarQuantidadeDeParesR (n / 10);
        }
    }
}
using System;
namespace Q6
{
    public class Program
    {
        public static int SomaDosInteirosPositivos (int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
        public int SomaDosInteirosPositivos_R (int n)
        {
            if (n == 0) return 0;
            return n + SomaDosInteirosPositivos_R (n - 1);
        }
    }
}
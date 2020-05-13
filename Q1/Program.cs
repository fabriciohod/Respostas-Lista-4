using System;
namespace Q1
{
    public class Program
    {
        public static int MaiorNumemroNaMatriz (int[, ] matriz)
        {
            int max = matriz[0, 0];
            foreach (var item in matriz)
            {
                if (item > max) max = item;
            }
            return max;
        }

    }
}
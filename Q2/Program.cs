using System;
namespace Q2
{
    public class Program
    {
        public static int SomaDaosParesMatriz (int[, ] matriz)
        {
            int sum = 0;
            foreach (var item in matriz) if (item % 2 == 0) sum += item;

            return sum;
        }
    }
}
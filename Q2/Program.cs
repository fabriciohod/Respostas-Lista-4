using System;
namespace Q2
{
    public class Program
    {
        public static int SomaDaMatriz (int[, ] matriz)
        {
            int sum = 0;
            foreach (var item in matriz) sum += item;
            return sum;
        }

    }
}
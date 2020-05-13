using System;
namespace Q7
{
    public class Program
    {
        public static int MultiplicaoDosPares (int[] array)
        {
            int mult = 1;
            foreach (var item in array)
            {
                if (item % 2 == 0) mult *= item;
            }
            return mult;
        }
        public static int MultiplicaoDosPares_R (int[] array, int index = 0)
        {
            try
            {
                if (array[index] % 2 != 0) return MultiplicaoDosPares_R (array, index + 1);
                return array[index] * MultiplicaoDosPares_R (array, index + 1);
            }
            catch (System.IndexOutOfRangeException)
            {
                return 1;
            }
        }
    }
}
using System;
using Xunit;

namespace Q7
{
    public class Q7Test : Program
    {
        [Fact]
        public void TestMultiplicaoDosParesEmArrayInterracao ()
        {
            int[] array = { 1, 3, 4, 8, 9, 10, 15, 80 };
            Assert.Equal (25600, MultiplicaoDosPares (array));
        }

        [Fact]
        public void TestMultiplicaoDosParesEmArrayRecursao ()
        {
            int[] array = { 1, 3, 4, 8, 9, 10, 15, 80 };
            Assert.Equal (25600, MultiplicaoDosPares_R (array));
        }
    }
}
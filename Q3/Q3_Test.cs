using System;
using Xunit;

namespace Q3
{
    public class Q3Test : Program
    {
        [Fact]
        public void ContagemDeNumerosRepitidosTest ()
        {
            int[] array = { 2, 3, 7, 89, 5, 3 };
            Assert.Equal ($"O numero 3 se repete 2", ContagemDeNumerosRepitidos (array, 3));
        }

        [Fact]
        public void TesteComNumeroQueNaoTemNoArray ()
        {
            int[] array = { 2, 3, 7, 89, 5, 3 };
            Assert.Equal ($"0", ContagemDeNumerosRepitidos (array, 90));
        }
    }
}
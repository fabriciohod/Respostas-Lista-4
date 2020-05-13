using System;
using Xunit;
using Q1;
namespace Q1
{
    public class UnitTest1:Program
    {
        [Fact]
        public void MaiorNumerroEmUmaMatrizTest ()
        {
            int[, ] matriz = { { 83, 36, 3 }, { 1337, 455, 8 }, { 908, 412, 14 } };
            Assert.Equal (1337, MaiorNumemroNaMatriz (matriz));
        }
    }
}
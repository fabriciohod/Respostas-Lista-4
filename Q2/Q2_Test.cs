using System;
using System.Linq;
using Xunit;

namespace Q2
{
    public class Q2Test : Program
    {
        [Fact]
        public void TestName ()
        {
            int[, ] matriz = { { 32, 7, 2 }, { 3, 9, 43 }, { 67, 40, 93 } };

            Assert.Equal (74, SomaDaMatriz (matriz));
        }
    }
}
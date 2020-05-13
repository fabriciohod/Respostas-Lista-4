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
            int[, ] matriz = { { 31, 78, 90 }, { 85, 97, 40 }, { 123, 7, 90 } };

            Assert.Equal (641, SomaDaMatriz (matriz));
        }
    }
}
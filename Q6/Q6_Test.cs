using System;
using Xunit;

namespace Q6
{
    public class Q6Test : Program
    {
        [Fact]
        public void SomaDosInteirosPositivosInterracao ()
        {
            Assert.Equal (55, SomaDosInteirosPositivos (10));
            Assert.Equal (66, SomaDosInteirosPositivos (11));
        }

        [Fact]
        public void SomaDosInteirosPositivosRecursao ()
        {
            Assert.Equal (55, SomaDosInteirosPositivos_R (10));
            Assert.Equal (66, SomaDosInteirosPositivos_R (11));
        }
    }
}
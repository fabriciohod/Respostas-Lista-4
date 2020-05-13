using System;
using Xunit;

namespace Q5
{
    public class Q5Test : Program
    {
        [Fact]
        public void TesteComInterracao ()
        {
            int numero = 237895;
            Assert.Equal (2, ConatarQuantidadeDePares (numero));
        }

        [Fact]
        public void TesteComInterracaoComResultado_0 ()
        {
            int numero = 135;
            Assert.Equal (0, ConatarQuantidadeDePares (numero));
        }

        [Fact]
        public void TesteComRecursao ()
        {
            int numero = 237895;
            Assert.Equal (2, ConatarQuantidadeDeParesR (numero));
        }

        [Fact]
        public void TesteComRecursaoComResultado_0 ()
        {
            int numero = 135;
            Assert.Equal (0, ConatarQuantidadeDeParesR (numero));
        }
    }
}
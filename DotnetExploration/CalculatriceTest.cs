using AutoFixture.Xunit2;
using Xunit;

namespace DotnetExploration
{
    public class CalculatriceTest
    {
        [Theory]
        [InlineAutoData(2, 2, 4)]
        [InlineAutoData(5, 0, 5)]
        public void Additionner_NombrePositif1(int x, int y, int attendut, Calculatrice calculatrice)
        {
            Assert.Equal(attendut, calculatrice.Additionner(x, y));
        }

        [Theory]
        [InlineAutoData(-3, -3, -6)]
        [InlineAutoData(0, -6, -6)]
        public void Additionner_NombreNegatif1(int x, int y, int attendut, Calculatrice calculatrice)
        {
            Assert.Equal(attendut, calculatrice.Additionner(x, y));
        }
    }
}

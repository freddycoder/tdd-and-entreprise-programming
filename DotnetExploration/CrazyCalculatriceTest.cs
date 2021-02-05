using Xunit;

namespace DotnetExploration
{
    public class CrazyCalculatriceTest
    {
        [Theory]
        [MapperInlineAutoData(2, 2, 4)]
        [MapperInlineAutoData(5, 0, 5)]
        public void Additionner_NombrePositif1(int x, int y, int attendut, CrazyCalculatrice crazyCalculatrice)
        {
            Assert.Equal(attendut, crazyCalculatrice.Additionner(new Model1Intrant { A = x, B = y }).Result);
        }

        [Theory]
        [MapperInlineAutoData(-3, -3, -6)]
        [MapperInlineAutoData(0, -6, -6)]
        public void Additionner_NombreNegatif1(int x, int y, int attendut, CrazyCalculatrice crazyCalculatrice)
        {
            Assert.Equal(attendut, crazyCalculatrice.Additionner(new Model1Intrant { A = x, B = y }).Result);
        }
    }
}

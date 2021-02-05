using AutoFixture.Xunit2;

namespace DotnetExploration
{
    public class MapperInlineAutoDataAttribute : InlineAutoDataAttribute
    {
        public MapperInlineAutoDataAttribute(params object[] values) : base(new MapperAutoDataAttribute(), values)
        {
        }
    }
}
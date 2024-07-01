using Xunit;

namespace Algorithms.Test.DeadfishSwimming
{
    public class SolutionTest
    {
        [Theory]
        [InlineData("iiisdoso", new int[] { 8, 64 })]
        public void SampleTest1(string data, int[] expected)
        {
            Assert.Equal(expected, Deadfish.Parse(data));
        }

        [Theory]
        [InlineData("iiisdosodddddiso", new int[] { 8, 64, 3600 })]
        public void SampleTest2(string data, int[] expected)
        {
            Assert.Equal(expected, Deadfish.Parse(data));
        }
    }
}

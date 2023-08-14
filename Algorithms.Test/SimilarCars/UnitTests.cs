using Xunit;
using Xunit.Abstractions;

namespace Algorithms.Test.SimilarCars
{
    public class UnitTests
    {
        private readonly ITestOutputHelper _output;

        public UnitTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Test1()
        {
            int[] result = Solution.solution(_output, new string[] { "100", "110", "010", "011", "100" });
            Assert.Equal(new int[] { 2, 3, 2, 1, 2 }, result);
        }

        [Fact]
        public void Test2()
        {
            int[] result = Solution.solution(_output, new string[] { "0011", "0111", "0111", "0110", "0000" });
            Assert.Equal(new int[] { 2, 3, 3, 2, 0 }, result);
        }
    }
}
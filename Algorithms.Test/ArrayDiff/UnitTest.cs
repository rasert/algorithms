using Xunit;

namespace Algorithms.Test.ArrayDiff
{
    public class UnitTest
    {
        [Fact]
        public void SampleTest()
        {
            Assert.Equal(new int[] { 2 }, Kata.ArrayDiff([1, 2], [1]));
            Assert.Equal(new int[] { 2, 2 }, Kata.ArrayDiff([1, 2, 2], [1]));
            Assert.Equal(new int[] { 1 }, Kata.ArrayDiff([1, 2, 2], [2]));
            Assert.Equal(new int[] { 1, 2, 2 }, Kata.ArrayDiff([1, 2, 2], []));
            Assert.Equal(new int[] { }, Kata.ArrayDiff([], [1, 2]));
            Assert.Equal(new int[] { 3 }, Kata.ArrayDiff([1, 2, 3], [1, 2]));
        }
    }
}

using Xunit;

namespace Algorithms.Test.ZerosToTheEnd
{
    public class UnitTest
    {
        [Fact]
        public void Test()
        {
            Assert.Equal(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, Kata.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
        }
    }
}

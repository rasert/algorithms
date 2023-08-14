using System.Collections.Generic;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace Algorithms.Test.CastleOnTheGrid
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
            // arrange
            int startX = 1;
            int startY = 0;
            int goalX = 33;
            int goalY = 33;
            List<string> grid = new(File.ReadAllText(@"CastleOnTheGrid/Test1Input.txt").Split("\r\n"));

            // act
            int moves = Solution.minimumMoves(grid, startX, startY, goalX, goalY);

            Assert.Equal(65, moves);
        }
    }
}

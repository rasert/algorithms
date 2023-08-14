using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Algorithms.Test.BasicCalculator
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
            var result = Solution.Calculate("1 + 1");
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test2()
        {
            var result = Solution.Calculate(" 2-1 + 2 ");
            Assert.Equal(3, result);
        }

        [Fact]
        public void Test3()
        {
            var result = Solution.Calculate("(1+(4+5+2)-3)+(6+8)");
            Assert.Equal(23, result);
        }

        [Fact]
        public void Test4()
        {
            var result = Solution.Calculate("-2+ 1");
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Test5()
        {
            var result = Solution.Calculate("1-(-2)");
            Assert.Equal(3, result);
        }

        [Fact]
        public void Test6()
        {
            var result = Solution.Calculate("- (3 + (4 + 5))");
            Assert.Equal(-12, result);
        }

        [Fact]
        public void Test7()
        {
            var result = Solution.Calculate("- (3 - (- (4 + 5) ) )");
            Assert.Equal(-12, result);
        }
    }
}

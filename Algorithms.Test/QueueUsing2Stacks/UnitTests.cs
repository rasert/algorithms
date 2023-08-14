using System;
using System.IO;
using Xunit;

namespace Algorithms.Test.QueueUsing2Stacks
{
    public class UnitTests
    {

        [Fact]
        public void Test1()
        {
            // arrange
            StringReader stringReader = new StringReader(
@"8
1 15
1 17
3
1 25
2
3
2
3");
            Console.SetIn(stringReader);
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // act
            Solution.Main2(new string[0]);

            // assert
            Assert.Equal("15\r\n17\r\n25\r\n", stringWriter.ToString());
        }

    }
}

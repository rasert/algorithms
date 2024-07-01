using Xunit;

namespace Algorithms.Test.StopSpinningMyWords
{
    public class UnitTest
    {
        [Fact]
        public static void Test1()
        {
            Assert.Equal("emocleW", Kata.SpinWords("Welcome"));
        }

        [Fact]
        public static void Test2()
        {
            Assert.Equal("Hey wollef sroirraw", Kata.SpinWords("Hey fellow warriors"));
        }

        [Fact]
        public static void Test3()
        {
            Assert.Equal("This is a test", Kata.SpinWords("This is a test"));
        }

        [Fact]
        public static void Test4()
        {
            Assert.Equal("This is rehtona test", Kata.SpinWords("This is another test"));
        }

        [Fact]
        public static void Test5()
        {
            Assert.Equal("You are tsomla to the last test", Kata.SpinWords("You are almost to the last test"));
        }

        [Fact]
        public static void Test6()
        {
            Assert.Equal("Just gniddik ereht is llits one more", Kata.SpinWords("Just kidding there is still one more"));
        }
    }
}

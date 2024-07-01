using Xunit;

namespace Algorithms.Test.CamelCase
{
    public class UnitTests
    {
        [Fact]
        public void NormalCases()
        {
            Assert.Equal("theStealthWarrior", Kata.ToCamelCase("the_stealth_warrior"));
            Assert.Equal("TheStealthWarrior", Kata.ToCamelCase("The-Stealth-Warrior"));
        }

        [Fact]
        public void EdgeCases()
        {
            Assert.Equal(string.Empty, Kata.ToCamelCase(string.Empty));
            Assert.Equal(string.Empty, Kata.ToCamelCase("-----"));
            Assert.Equal("a", Kata.ToCamelCase("a"));
            Assert.Equal("A", Kata.ToCamelCase("A"));
            Assert.Equal("a", Kata.ToCamelCase("a-"));
            Assert.Equal("A", Kata.ToCamelCase("A-"));
            Assert.Equal("a", Kata.ToCamelCase("-a"));
            Assert.Equal("A", Kata.ToCamelCase("-A"));
            Assert.Equal("a", Kata.ToCamelCase("-a-"));
            Assert.Equal("A", Kata.ToCamelCase("-A-"));
            Assert.Equal("a", Kata.ToCamelCase("a--"));
            Assert.Equal("A", Kata.ToCamelCase("A--"));
            Assert.Equal("a", Kata.ToCamelCase("--a"));
            Assert.Equal("A", Kata.ToCamelCase("--A"));
            Assert.Equal("a", Kata.ToCamelCase("--a--"));
            Assert.Equal("A", Kata.ToCamelCase("--A--"));
        }
    }
}

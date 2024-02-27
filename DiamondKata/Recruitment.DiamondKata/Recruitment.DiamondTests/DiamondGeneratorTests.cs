using Xunit;

namespace Recruitment.Diamond.Tests
{
    public class DiamondGeneratorTests
    {

        [Fact]
        public void GenerateTest_ShouldReturnThreeLevelDiamond()
        {
            var diamondGenerator = new DiamondGenerator();
            //not very fortunate formatting of expected string but known as a fact that in three level diamond first A starts with 2 spaces
            Assert.Equal(
@"  A
 B B
C   C
 B B
  A
", 
                diamondGenerator.Generate('C'));
        }

        //same as above but less explicit formatting (more test cases are needed)
        [Theory]
        [InlineData('A', "A\r\n")]
        [InlineData('B', " A\r\nB B\r\n A\r\n")]
        [InlineData('C', "  A\r\n B B\r\nC   C\r\n B B\r\n  A\r\n")]
        public void PrintDiamond_ValidInput_ReturnsExpectedResult(char inputChar, string expectedOutput)
        {
            var diamondGenerator = new DiamondGenerator();
            Assert.Equal(expectedOutput, diamondGenerator.Generate(inputChar));
        }

        [Fact]
        public void GenerateTest_ShouldReturnNull_InvalidInput_NotAlphabetic()
        {
            var diamondGenerator = new DiamondGenerator();

            Assert.Equal(string.Empty, diamondGenerator.Generate('1'));
        }

        [Fact]
        public void GenerateTest_ShouldReturnNull_EmptyChar()
        {
            var diamondGenerator = new DiamondGenerator();

            Assert.Equal(string.Empty, diamondGenerator.Generate(' '));
        }
    }
}
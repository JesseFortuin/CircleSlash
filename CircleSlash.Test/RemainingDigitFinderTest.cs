using CircleSlash.BL;

namespace CircleSlash.Test
{
    public class RemainingDigitFinderTest
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(4, 1)]
        [InlineData(3, 3)]
        [InlineData(15, 15)]
        public void Test1(int input, int expected)
        {
            //arrange
            IRemainingDigitFinder finder = new RemainingDigitFinder();

            //act
            int actual = finder.CircleSlash(input);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
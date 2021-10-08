using Xunit;
using ShipCom.Classes;

namespace ShipComTest
{
	public class ColorBandsTest
	{
		public ColorBandsTest()
		{
		}

		[Theory]
		[InlineData("black",  0, 1)]
		[InlineData("BlAcK",  0, 1)]
		[InlineData("brown",  1, 10)]
		[InlineData("red",    2, 100)]
		[InlineData("orange", 3, 1000)]
		[InlineData("yellow", 4, 10000)]
		[InlineData("green",  5, 100000)]
		[InlineData("blue",   6, 1000000)]
		[InlineData("violet", 7, 10000000)]
		public void ColorbandColorLookupCorrect(string ringColor, int digit, int multiplier)
		{
			// Arrange
			// Act
			var cb = ResistorColorBands.GetColorBand(ringColor);

			// Assert
			Assert.Equal(digit, cb.Digit);
			Assert.Equal(multiplier, cb.Multiplier);
		}
	}
}

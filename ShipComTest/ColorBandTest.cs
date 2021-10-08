using Xunit;
using ShipCom.Classes;

namespace ShipComTest
{
	public class ColorBandTest
	{
		public ColorBandTest()
		{
		}

		[Fact]
		public void ColorBandConstructorSuccess()
		{
			// Arrange
			// Act
			ColorBand cb = new ColorBand("rrr", 2, 3);

			// Assert
			Assert.Equal("rrr", cb.RingColor);
			Assert.Equal(2, cb.Digit);
			Assert.Equal(3, cb.Multiplier);
		}
	}
}

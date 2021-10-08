using Xunit;
using ShipCom.Classes;

namespace ShipComTest
{
	public class ResisterTest
	{
		[Theory]
		[InlineData("brown", "yellow", "red", "black", 1400)]
		[InlineData("violet", "blue", "black", "black", 76)]
		public void ResistorCalculateOhmValueSuccess(string bandAColor, string bandBColor, string bandCColor, string bandDColor, int expectedOhmValue)
		{
			// Arrange
			Resistor resistor = new Resistor();

			// Act
			int actualOhmValue = resistor.CalculateOhmValue(bandAColor, bandBColor, bandCColor, bandDColor);

			Assert.Equal(expectedOhmValue, actualOhmValue);
		}
	}
}

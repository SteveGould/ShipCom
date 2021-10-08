using ShipCom.Interfaces;

namespace ShipCom.Classes
{
	public class Resistor : IOhmValueCalculator
	{
		public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
		{
			int ohmValue = 0;

			ohmValue = ResistorColorBands.GetColorBand(bandAColor).Digit;
			ohmValue = (ohmValue * 10) + ResistorColorBands.GetColorBand(bandBColor).Digit;

			int trailingZeros = ResistorColorBands.GetColorBand(bandCColor).Multiplier;
			ohmValue *= trailingZeros;

			return ohmValue;
		}
	}
}

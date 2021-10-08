namespace ShipCom.Classes
{
	public class OhmValueCalculator
	{
		public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
		{
			Resistor resistor = new Resistor();
			int ohmValue = resistor.CalculateOhmValue(bandAColor, bandBColor, bandCColor, bandDColor);
			return ohmValue;
		}
	}
}

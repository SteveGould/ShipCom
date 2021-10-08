namespace ShipCom.Classes
{
	public class ColorBand
	{
		public ColorBand(string ringColor, int digit, int multiplier)
		{
			RingColor  = ringColor.ToLower();
			Digit      = digit;
			Multiplier = multiplier;
		}

		public string RingColor { get; set; }
		public int Digit { get; set; }
		public int Multiplier { get; set; }
	}
}

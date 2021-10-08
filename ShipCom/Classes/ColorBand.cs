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

		public string RingColor { get; }
		public int Digit { get;  }
		public int Multiplier { get; }
	}
}

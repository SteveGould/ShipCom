using System.Collections.Generic;

namespace ShipCom.Classes
{
	public static class ResistorColorBands
	{
		private static List<ColorBand> colorBands = new List<ColorBand>()
		{
			new ColorBand("black",  0, 1),
			new ColorBand("brown",  1, 10),
			new ColorBand("red",    2, 100),
			new ColorBand("orange", 3, 1000),
			new ColorBand("yellow", 4, 10000),
			new ColorBand("green",  5, 100000),
			new ColorBand("blue",   6, 1000000),
			new ColorBand("violet", 7, 10000000)
		};

		public static ColorBand GetColorBand(string ringColor)
		{
			var cb = colorBands.Find(c => c.RingColor == ringColor.ToLower());

			return cb;
		}
	}
}

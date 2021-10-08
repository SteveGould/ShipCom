using ShipCom.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCom
{
	class Program
	{
		static void Main(string[] args)
		{
			OhmValueCalculator ovc = new OhmValueCalculator();
			int ohmValue = ovc.CalculateOhmValue("red", "yellow", "blue", "brown");
		}
	}
}

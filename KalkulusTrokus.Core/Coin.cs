using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulusTrokus.Core
{
	public class Coin : ItemWithMonetaryValue
	{
		public Coin() : base()
		{
			Name = "Coin";
		}

		public static List<Coin> AllAvaliableCoins = new List<Coin> { 
			new Coin { AmountInCents = 100 }, 
			new Coin { AmountInCents = 50 }, 
			new Coin { AmountInCents = 25 }, 
			new Coin { AmountInCents = 10 }, 
			new Coin { AmountInCents = 5 }, 
			new Coin { AmountInCents = 1 }, 
		};
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulusTrokus.Core.Processors
{
	internal class CoinChangeProcessor : AbstractChangeProcessor
	{
		public CoinChangeProcessor() : base()
		{
		}

		internal override long[] ValueCollection
		{
			get 
			{
				return new long[] { 100, 50, 25, 10, 5, 1 };
			}
		}

		//public static List<Coin> AllAvaliableCoins = new List<Coin> { 
		//	new Coin { AmountInCents = 100 }, 
		//	new Coin { AmountInCents = 50 }, 
		//	new Coin { AmountInCents = 25 }, 
		//	new Coin { AmountInCents = 10 }, 
		//	new Coin { AmountInCents = 5 }, 
		//	new Coin { AmountInCents = 1 }, 
		//};

		public override string Name
		{
			get { return "Coin"; }
		}
	}
}

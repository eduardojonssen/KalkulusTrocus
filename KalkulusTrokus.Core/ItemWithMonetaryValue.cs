using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulusTrokus.Core
{
	public class ItemWithMonetaryValue
	{
		public ItemWithMonetaryValue()
		{ }

		public ItemWithMonetaryValue(string name, long amountInCents)
		{
			this.Name = name;
			this.AmountInCents = amountInCents;
		}

		public string Name { get; protected set; }

		public long AmountInCents { get; internal set; }
	}
}

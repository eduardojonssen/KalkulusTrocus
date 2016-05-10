using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulusTrokus.Core.Response
{
	public class Change	{

		public Change()
		{
			ItemWithMonetaryValueCollection = new List<ItemWithMonetaryValue>();
		}

		public List<ItemWithMonetaryValue> ItemWithMonetaryValueCollection { get; set; }

		public long ChangeAmount { get; internal set; }
	}
}

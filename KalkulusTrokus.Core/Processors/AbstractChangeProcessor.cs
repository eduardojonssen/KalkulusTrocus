using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulusTrokus.Core.Processors
{
	internal abstract class AbstractChangeProcessor
	{
		public AbstractChangeProcessor()
		{
		}

		public abstract string Name { get; }

		internal abstract long[] ValueCollection { get; }

		public virtual IEnumerable<long> Calculate(long change)
		{
			//while (change > 0 && change > this.ValueCollection.Min())
			//{
				foreach (long value in this.ValueCollection.OrderByDescending(v => v))
				{
					long quantityCurrencyToken = (change / value);
					change -= quantityCurrencyToken * value;

					for (int i = 0; i < quantityCurrencyToken; i++)
					{
						yield return value;
					}
				}
			//}
		}
	}
}

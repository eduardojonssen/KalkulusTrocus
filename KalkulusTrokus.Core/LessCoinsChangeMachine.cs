using KalkulusTrokus.Core.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulusTrokus.Core
{
	public class LessCurrencyTokenChangeMachine
	{
		private long TotalChange(long productAmountInCents, long paidAmountInCents)
		{
			return (paidAmountInCents - productAmountInCents);
		}

		public IEnumerable<ItemWithMonetaryValue> CalculateChanges(long productAmountInCents, long paidAmountInCents)
		{
			long remainingChange = TotalChange(productAmountInCents, paidAmountInCents);

			while (remainingChange > 0)
			{
				AbstractChangeProcessor processor = ChangeProcessorFactory.Create(remainingChange);
				//todo: check null;
				IEnumerable<long> changeCollection = processor.Calculate(remainingChange);

				foreach (long item in changeCollection)
				{
					ItemWithMonetaryValue itemMonet = new ItemWithMonetaryValue(processor.Name, item);

					yield return itemMonet;
				}

				remainingChange -= changeCollection.Sum();
			}
		}

		/*
		public List<ItemWithMonetaryValue> ItemWithMonetaryValueCollection = Note.AllAvaliableNotes.Cast<ItemWithMonetaryValue>().Concat(Coin.AllAvaliableCoins).ToList();

		public bool IsPossibleToChange(long productAmountInCents, long paidAmountInCents)
		{
			return true;
		}

		public IEnumerable<ItemWithMonetaryValue> CalculateChanges(long productAmountInCents, long paidAmountInCents)
		{
			long remainingChange = TotalChange(productAmountInCents, paidAmountInCents);

			while (remainingChange > 0)
			{
				foreach (ItemWithMonetaryValue itemWithMonetaryValue in this.ItemWithMonetaryValueCollection.OrderByDescending(i => i.AmountInCents))
				{
					long quantityCurrencyToken = (remainingChange / itemWithMonetaryValue.AmountInCents);
					remainingChange -= quantityCurrencyToken * itemWithMonetaryValue.AmountInCents;

					for (int i = 0; i < quantityCurrencyToken; i++)
					{
						yield return itemWithMonetaryValue;
					}
				}
			}
		}

		private long TotalChange(long productAmountInCents, long paidAmountInCents)
		{
			return (paidAmountInCents - productAmountInCents);
		}
		 * */
	}
}

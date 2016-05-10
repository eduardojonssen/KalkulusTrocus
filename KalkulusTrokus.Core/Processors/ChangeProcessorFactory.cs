using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulusTrokus.Core.Processors
{
	internal static class ChangeProcessorFactory
	{
		private static AbstractChangeProcessor[] processorCollection = 
		{
			new CoinChangeProcessor(),
			new NoteChangeProcessor(),
			new SilverChangeProcessor(),
			new CandyChangeProcessor(),
			//Adicionar novos processadores nessa lista.
		};

		public static AbstractChangeProcessor Create(long change)
		{
			List<AbstractChangeProcessor> processorCollectionOrdered = processorCollection.OrderByDescending(p => p.ValueCollection.Min()).ToList();
			foreach (AbstractChangeProcessor processor in processorCollectionOrdered)
			{
				if (change >= processor.ValueCollection.Min())
					return processor;
			}
			return null;
		}
	}
}

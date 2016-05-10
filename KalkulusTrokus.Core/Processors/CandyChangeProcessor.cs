using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulusTrokus.Core.Processors
{
	internal class CandyChangeProcessor : AbstractChangeProcessor
	{
		public CandyChangeProcessor() : base()
		{
		}

		public override string Name
		{
			get { return "Candy"; }
		}

		internal override long[] ValueCollection
		{
			get 
			{ 
				return new long[] { 3, 1 };
			}
		}
	}
}

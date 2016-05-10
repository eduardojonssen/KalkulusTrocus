using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulusTrokus.Core.Processors
{
	internal class SilverChangeProcessor : AbstractChangeProcessor
	{
		public override string Name
		{
			get { return "Silver Plates"; }
		}

		internal override long[] ValueCollection
		{
			get
			{
				return new long[] { 100000, 50000 };
			}
		}
	}
}

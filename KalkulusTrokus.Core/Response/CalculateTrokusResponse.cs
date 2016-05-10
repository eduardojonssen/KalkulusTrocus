using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulusTrokus.Core.Response
{
	public class CalculateTrokusResponse : AbstractResponse
	{
		public CalculateTrokusResponse() : base ()
		{}

		public Change Change { get; internal set; }
	}
}

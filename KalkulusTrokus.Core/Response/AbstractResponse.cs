using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulusTrokus.Core.Response
{
	public abstract class AbstractResponse
	{
		public AbstractResponse()
		{
			IsValid = false;
			Reports = new List<Report>();
		}

		public List<Report> Reports { get; set; }
		public bool IsValid { get; set; }
	}
}

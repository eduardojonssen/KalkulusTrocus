using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulusTrokus.Core.Response
{
	public class Report
	{
		public string Field { get; set; }
		public string Message { get; set; }
		public bool ErrorOcurred { get; set; }

		public Report()
		{
		}

		public Report(string field, string message, bool errorOcurred)
		{
			Field = field;
			Message = message;
			ErrorOcurred = errorOcurred;
		}
	}
}

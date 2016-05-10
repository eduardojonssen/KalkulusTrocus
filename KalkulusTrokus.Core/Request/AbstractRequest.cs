using KalkulusTrokus.Core.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulusTrokus.Core.Request
{
	public abstract class AbstractRequest
	{
		public AbstractRequest()
		{
			this.ValidationReport = new List<Report>();
		}

		internal List<Report> ValidationReport { get; private set; }

		internal bool IsValid {
			get {
				this.ValidationReport.Clear();
				this.Validate();
				return (this.ValidationReport.Any() == false);
			}
		}

		protected abstract void Validate();

		protected void AddError(string field, string message) {

			Report report = new Report();

			report.Field = field;
			report.Message = message;
			report.ErrorOcurred = true;

			this.ValidationReport.Add(report);
		}
	}
}

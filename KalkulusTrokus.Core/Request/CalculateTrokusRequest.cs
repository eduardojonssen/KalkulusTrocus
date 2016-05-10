using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulusTrokus.Core.Request
{
	public class CalculateTrokusRequest : AbstractRequest
	{
		public CalculateTrokusRequest() : base() { }

		public CalculateTrokusRequest(long productAmountInCents, long paidAmountInCents) : base()
		{
			ProductAmountInCents = productAmountInCents;
			PaidAmountInCents = paidAmountInCents;
		}

		public long ProductAmountInCents { get; set; }
		public long PaidAmountInCents { get; set; }		

		protected override void Validate()
		{
			string greaterThanZeroMessage = "The parameter must be greater than zero.";

			if (this.ProductAmountInCents < 0)
				this.AddError("productAmountInCents", greaterThanZeroMessage);

			if (this.PaidAmountInCents < 0)
				this.AddError("paidAmountInCents", greaterThanZeroMessage);

			if (this.PaidAmountInCents < this.ProductAmountInCents)
				this.AddError("paidAmountInCents", "The parameter must be greater than, or equal to, 'productAmountInCents'.");
		}
	}
}

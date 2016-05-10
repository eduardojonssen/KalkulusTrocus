using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulusTrokus.UI.WinForms.Model
{
	class ItemWithMonetaryValueWithQtd
	{
		public int Qnt { get; internal set; }
		public long Value { get; internal set; }

		public string Name { get; internal set; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulusTrokus.Core.Processors
{
	internal class NoteChangeProcessor : AbstractChangeProcessor
	{
		public NoteChangeProcessor() : base()
		{
		}

		internal override long[] ValueCollection
		{
			get 
			{
				return new long[] { 10000, 5000, 2000, 1000, 500, 200 };
			}
		}

		//public static List<Note> AllAvaliableNotes = new List<Note> { 
		//	new Note { AmountInCents = 10000 }, 
		//	new Note { AmountInCents = 5000 }, 
		//	new Note { AmountInCents = 2000 }, 
		//	new Note { AmountInCents = 1000 }, 
		//	new Note { AmountInCents = 500 }, 
		//	new Note { AmountInCents = 200 }, 
		//};

		public override string Name
		{
			get { return "Note"; }
		}
	}
}

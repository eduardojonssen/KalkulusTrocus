using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulusTrokus.Core
{
	public class Note : ItemWithMonetaryValue
	{
		public Note() : base()
		{
			Name = "Bank Note";
		}

		public static List<Note> AllAvaliableNotes = new List<Note> { 
			new Note { AmountInCents = 10000 }, 
			new Note { AmountInCents = 5000 }, 
			new Note { AmountInCents = 2000 }, 
			new Note { AmountInCents = 1000 }, 
			new Note { AmountInCents = 500 }, 
			new Note { AmountInCents = 200 }, 
		};
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani {
	interface ISoundable {
		string sound();
		//string getName();
		public string Name { get; }
	}
}

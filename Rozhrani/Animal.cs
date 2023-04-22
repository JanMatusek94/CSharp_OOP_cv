using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani {
	abstract class Animal {
			public string name;
			public Animal(string name) { this.name = name; }
			//public override string ToString() {
			//   return string.Format("{0}", GetType().Name);
			//}
	}
}


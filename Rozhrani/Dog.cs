using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani {
	class Dog : Animal, ISoundable {
		public bool isPedigree;
		public Dog(string name) : base(name) { }
		public string sound() {
			return "haf";
		}
		//public string getName() {
		//    return name;
		//}
		public string Name {
			get { return name; }
		}
		public override string ToString() {
			return string.Format("{0} jménem {1} vydává zvuk: {2}", GetType().Name, Name, sound());
		}
	}
}
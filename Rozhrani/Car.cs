using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani {
	class Car : ISoundable {
		public string name;
		public int speed;
		public Car(string name) {
			this.name = name;
		}
		public string sound() {
			return "vrrrr";
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
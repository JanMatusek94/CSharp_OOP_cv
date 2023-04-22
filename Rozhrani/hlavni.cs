using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani {
	internal class hlavni {
		public static void Mainx() {
			Dog pes1 = new Dog("Azor");
			Dog pes2 = new Dog("Bart");
			Dog pes3 = new Dog("Doge");
			Cat kocka1 = new Cat("Liza");
			Cat kocka2 = new Cat("Micina");         //// 1. způsob
			Cat kocka3 = new Cat("Snehulka");
			Turtle zelva1 = new Turtle("Turbo");
			Turtle zelva2 = new Turtle("Karel");
			Turtle zelva3 = new Turtle("Pepa");
			Car toyota = new Car("Corolla");

			ISoundable[] zvirata = { pes1, pes2, pes3, kocka1, kocka2, kocka3, toyota };
			for (int i = 0; i < zvirata.Length; i++) {
				//Animal pomocna = (Animal) zvirata[i];
				Console.WriteLine(zvirata[i].ToString());
			}
		}
	}
}

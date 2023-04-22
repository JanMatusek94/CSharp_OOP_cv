using System.Reflection.PortableExecutable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani1 {
	abstract class Animal {
		public string name;
		public static int countOfAnimals;
		public Animal(string name) {
			this.name = name;
			countOfAnimals++;
		}
		public override string ToString() {
			return string.Format("Typ: {0}", GetType().Name);
		}
	}
	class Dog : Animal {
		public bool isPedigree;
		public Dog(string name) : base(name) {
		}
		public string sound() {
			return "haf";
		}
	}
	class Cat : Animal {
		public bool isPedigree;
		public Cat(string name) : base(name) {
		}
		public string sound() {
			return "mňau";
		}
	}
	class Turtle : Animal{
		int speed;
		public Turtle(string name) : base(name) {

		}
	}
	public class Rozhrani {
		public static void Mainx() {
			//Dog pes1 = new Dog("Azor");			//
			//Dog pes2 = new Dog("Bart");			//
			//Dog pes3 = new Dog("Doge");			//
			//Cat kocka1 = new Cat("Liza");			//
			//Cat kocka2 = new Cat("Micina");		//   1. a 2. krok
			//Cat kocka3 = new Cat("Snehulka");		//
			//Turtle zelva1 = new Turtle("Turbo");	//
			//Turtle zelva2 = new Turtle("Karel");	//
			//Turtle zelva3 = new Turtle("Pepa");	//

            //Animal[] zvirata = new Animal[Animal.countOfAnimals];//
            //zvirata[0] = pes1;			//
            //zvirata[1] = pes2;			//
            //zvirata[2] = pes3;			//
            //zvirata[3] = kocka1;			//
            //zvirata[4] = kocka2;			//   1. krok
            //zvirata[5] = kocka3;			//
            //zvirata[6] = zelva1;			//
            //zvirata[7] = zelva2;			//
            //zvirata[8] = zelva3;			//

            //Animal[] zvirata = { pes1, pes2, pes3, kocka1, kocka2, kocka3, zelva1, zelva2, zelva3 };   //	2.krok

			Animal[] zvirata = { new Dog("Azor"), new Dog("Bart"), new Dog("Doge"), new Cat("Liza"), new Cat("Micina"),
				new Cat("Snehulka"), new Turtle("Turbo"), new Turtle("Karel"), new Turtle("Pepa") };						//	3.krok

            for (int i = 0; i < zvirata.Length; i++) {
				Console.WriteLine(string.Format("Typ: {0}, jméno: {1}", zvirata[i].GetType().Name, zvirata[i].name));
			}
		}
	}
}
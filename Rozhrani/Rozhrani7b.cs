using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani7b {
	  interface ISoundable {
		    string sound();
        //string getName();
        public string Name { get; }
	  } 
    abstract class Animal {
        public string name;
        public Animal(string name) { this.name = name; }
        //public override string ToString() {
        //   return string.Format("{0}", GetType().Name);
        //}
    }
    class Dog : Animal, ISoundable {
        public bool isPedigree;
        public Dog(string name) : base(name) {}
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
    class Cat : Animal, ISoundable {
        public bool isPedigree;
        public Cat(string name) : base(name) {}
        public string sound() {
            return "mňau";
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
    class Turtle : Animal {
        int speed;
        public Turtle(string name) : base(name) {}
    }
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
    public class Rozhrani {
        public static void Mainx() {
            Dog pes1 = new Dog("Azor");
            Dog pes2 = new Dog("Bart");
            Dog pes3 = new Dog("Doge");
            Cat kocka1 = new Cat("Liza");
            Cat kocka2 = new Cat("Micina");	        //// 1. způsob
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

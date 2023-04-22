using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani2 {
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
    class Turtle : Animal {
        int speed;
        public Turtle(string name) : base(name) {

        }
    }
    public class Rozhrani {
        public static void Mainx() {

            Animal[] zvirata = { new Dog("Azor"), new Dog("Bart"), new Dog("Doge"), new Cat("Liza"), new Cat("Micina"),
                new Cat("Snehulka"), new Turtle("Turbo"), new Turtle("Karel"), new Turtle("Pepa") };						


            foreach (Animal item in zvirata)
            {
                Console.WriteLine(string.Format("Typ: {0}, jméno: {1}", item.GetType().Name, item.name));
            }

            //for (int i = 0; i < zvirata.Length; i++) {
            //    Console.WriteLine(string.Format("Typ: {0}, jméno: {1}", zvirata[i].GetType().Name, zvirata[i].name));
            //}
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani4 {
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
    interface ISoundable {
        string sound();
    }
    class Dog : Animal, ISoundable {
        public bool isPedigree;
        public Dog(string name) : base(name) {
        }
        public string sound() {
            return "haf";
        }
    }
    class Cat : Animal, ISoundable {
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
            Dog pes1 = new Dog("Azor");
            Dog pes2 = new Dog("Bart");
            Dog pes3 = new Dog("Doge");
            Cat kocka1 = new Cat("Liza");
            Cat kocka2 = new Cat("Micina");	        //// 1. způsob
            Cat kocka3 = new Cat("Snehulka");
            Turtle zelva1 = new Turtle("Turbo");
            Turtle zelva2 = new Turtle("Karel");
            Turtle zelva3 = new Turtle("Pepa");

            ISoundable[] zvirata = { pes1, pes2, pes3, kocka1, kocka2, kocka3};


            foreach (ISoundable item in zvirata) {
                if (item is Dog) {
                    Console.WriteLine(string.Format("Typ: {0}, zvuk: {1}", item.GetType().Name, ((Dog)item).sound()));
                }
                else if (item is Cat) {
                    Console.WriteLine(string.Format("Typ: {0}, zvuk: {1}", item.GetType().Name, ((Cat)item).sound()));
                }
                else {
                    Console.WriteLine(string.Format("Typ: {0}", item.GetType().Name));
                }
            }
            foreach (ISoundable item in zvirata) {
                if (item is Dog) {
                    Console.WriteLine(string.Format("Typ: {0}, zvuk: {1}", item.GetType().Name, ((Dog)item).sound()));
                }
                else {
                    Console.WriteLine(item is Cat ? string.Format("Typ: {0}, zvuk: {1}", item.GetType().Name, ((Cat)item).sound()) :
                        string.Format("Typ: {0}", item.GetType().Name));
                }
            }

            foreach (Animal item in zvirata) {
                if (item.GetType() == typeof(Dog)) {
                    Dog dog = (Dog)item;
                    Console.WriteLine(string.Format("Typ: {0}, jméno: {1}, zvuk: {2}", item.GetType().Name, item.name, dog.sound()));
                }
                else if (item.GetType().Equals(typeof(Cat))) {
                    Cat cat = (Cat)item;
                    Console.WriteLine(string.Format("Typ: {0}, jméno: {1}, zvuk: {2}", item.GetType().Name, item.name, cat.sound()));
                }
                else {
                    Console.WriteLine(string.Format("Typ: {0}, jméno: {1}", item.GetType().Name, item.name));
                }
            }
        }
    }
}


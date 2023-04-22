using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani6 {
    abstract class Animal {
        public string name;
        public static int countOfAnimals;
        public Animal(string name) {
            this.name = name;
            countOfAnimals++;
        }
        public override string ToString() {
            return string.Format("{0}", GetType().Name);
        }
    }
    interface ISoundable {
        string sound();
        string getName();
        
    }
    class Dog : Animal, ISoundable {
        public bool isPedigree;
        public Dog(string name) : base(name) {
        }
        public string sound() {
            return "haf";
        }
        public string getName() {
            return name;
        }
        public override string ToString() {
            return string.Format("{0} jménem {1} vydává zvuk: {2}",GetType().Name, getName(), sound());
        }
    }
    class Cat : Animal, ISoundable {
        public bool isPedigree;
        public Cat(string name) : base(name) {
        }
        public string sound() {
            return "mňau";
        }
        public string getName() {
            return name;
        }
        public override string ToString() {
            return string.Format("{0} jménem {1} vydává zvuk: {2}", GetType().Name, getName(), sound());
        }
    }
    class Turtle : Animal {
        int speed;
        public Turtle(string name) : base(name) {

        }
    }
    class Car : ISoundable {
        public string name;
        public int speed;
        public Car(string name, int speed) {
            this.name = name;
            this.speed = speed;
        }
        public string sound() {
            return "vrrrr";
        }
        public string getName() {
            return name;
        }
        public override string ToString() {
            return string.Format("{0} jménem {1} vydává zvuk: {2}", GetType().Name, getName(), sound());
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
            Car toyota = new Car("Corolla", 100);

            ISoundable[] zvirata = { pes1, pes2, pes3, kocka1, kocka2, kocka3, toyota };


            for (int i = 0; i < zvirata.Length; i++) {
                //Animal pomocna = (Animal) zvirata[i];
                 Console.WriteLine(zvirata[i].ToString());
            }



            //foreach (ISoundable item in zvirata) {
            //    if (item is Dog) {
            //        Console.WriteLine(string.Format("Typ: {0}, zvuk: {1}", item.GetType().Name, ((Dog)item).sound()));
            //    }
            //    else if (item is Cat) {
            //        Console.WriteLine(string.Format("Typ: {0}, zvuk: {1}", item.GetType().Name, ((Cat)item).sound()));
            //    }
            //    else {
            //        Console.WriteLine(string.Format("Typ: {0}", item.GetType().Name));
            //    }
            //}
            //foreach (ISoundable item in zvirata) {
            //    if (item is Dog) {
            //        Console.WriteLine(string.Format("Typ: {0}, zvuk: {1}", item.GetType().Name, ((Dog)item).sound()));
            //    }
            //    else {
            //        Console.WriteLine(item is Cat ? string.Format("Typ: {0}, zvuk: {1}", item.GetType().Name, ((Cat)item).sound()) :
            //            string.Format("Typ: {0}", item.GetType().Name));
            //    }
            //}

            //foreach (Animal item in zvirata) {
            //    if (item.GetType() == typeof(Dog)) {
            //        Dog dog = (Dog)item;
            //        Console.WriteLine(string.Format("Typ: {0}, jméno: {1}, zvuk: {2}", item.GetType().Name, item.name, dog.sound()));
            //    }
            //    else if (item.GetType().Equals(typeof(Cat))) {
            //        Cat cat = (Cat)item;
            //        Console.WriteLine(string.Format("Typ: {0}, jméno: {1}, zvuk: {2}", item.GetType().Name, item.name, cat.sound()));
            //    }
            //    else {
            //        Console.WriteLine(string.Format("Typ: {0}, jméno: {1}", item.GetType().Name, item.name));
            //    }
            //}
        }
    }
}

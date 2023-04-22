using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozhrani3 {
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
            //Dog pes1 = new Dog("Azor");	
            //Dog pes2 = new Dog("Bart");	
            //Dog pes3 = new Dog("Doge");	
            //Cat kocka1 = new Cat("Liza");	
            //Cat kocka2 = new Cat("Micina");	        //// 1. způsob
            //Cat kocka3 = new Cat("Snehulka");	
            //Turtle zelva1 = new Turtle("Turbo");
            //Turtle zelva2 = new Turtle("Karel");
            //Turtle zelva3 = new Turtle("Pepa");	

            List<Animal> animals = new List<Animal>() {new Dog("Azor"), new Dog("Bart"), new Dog("Doge"), new Cat("Liza"), new Cat("Micina"),
            new Cat("Snehulka"), new Turtle("Turbo"), new Turtle("Karel"), new Turtle("Pepa")};
            //animals.Add(pes1);
            //animals.Add(pes2);
            //animals.Add(pes3);
            //animals.Add(kocka1);
            //animals.Add(kocka2);          //// 1. způsob
            //animals.Add(kocka3);
            //animals.Add(zelva1);
            //animals.Add(zelva2);
            //animals.Add(zelva3);

            Dog pes = (Dog)animals[0];
            Dog pes2 = (Dog)animals[1];
            Dog pes3 = (Dog)animals[2];
            Dog pes4 = animals[2] as Dog;
            Console.WriteLine(pes.sound());
            Console.WriteLine(pes2.sound());
            Console.WriteLine(pes3.sound());
            Console.WriteLine(pes4.sound());

            foreach (Animal item in animals) {
                if (item is Dog) {
                    Console.WriteLine(string.Format("Typ: {0}, jméno: {1}, zvuk: {2}", item.GetType().Name, item.name, ((Dog)item).sound()));
                }
                else if (item is Cat) {
                    Console.WriteLine(string.Format("Typ: {0}, jméno: {1}, zvuk: {2}", item.GetType().Name, item.name, ((Cat)item).sound()));
                }
                else {
                    Console.WriteLine(string.Format("Typ: {0}, jméno: {1}", item.GetType().Name, item.name));
                }
            }
            foreach (Animal item in animals) {
                if (item is Dog) {
                    Console.WriteLine(string.Format("Typ: {0}, jméno: {1}, zvuk: {2}", item.GetType().Name, item.name, ((Dog)item).sound()));
                }
                else {
                    Console.WriteLine( item is Cat ? string.Format("Typ: {0}, jméno: {1}, zvuk: {2}", item.GetType().Name, item.name, ((Cat)item).sound()) :
                        string.Format("Typ: {0}, jméno: {1}", item.GetType().Name, item.name));
                }
            }

            foreach (Animal item in animals) {
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


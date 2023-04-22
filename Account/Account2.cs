using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account2 {

    class Person {
        public string name;
        public int age;
        public Person (string name, int age) {
            this.name = name;
            this.age = age;
        }
    }
    internal class Account {

        public static void Mainx() {
            Person Pepa = new Person("Pepa", 20);
            Person Honza = new Person("Honza", 30);
            Account acc1 = new Account(Pepa, 100);
            Account acc2 = new Account(Honza, 100);
            //acc1.insertInto(100);
            //acc2.insertInto(100);
            //acc1.writeInfo();
            //acc2.writeInfo();
            Console.WriteLine(acc1.ToString());
            Console.WriteLine(acc2.ToString());
            acc1.transferTo(acc2, 50);
            Console.WriteLine(acc1.ToString()); 
            Console.WriteLine(acc2.ToString());
        }

        public int balance;
        public Person owner;

        public Account(Person owner, int amount) {
            this.owner = owner;
            this.balance = amount;
        }
        public void insertInto(int amount) {
            balance += amount;
        }
        //public void writeInfo() {
        //    Console.WriteLine(owner.name + " " + balance);
        //}
        public void transferTo(Account druhy, int amount) {
            druhy.balance += amount;
            balance -= amount;
        }
        public override string ToString() {
            return string.Format("jméno: {0} \t zůstatek: {1}", owner.name, balance);
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account4 {

    class Person {
        public string name;
        public int age;
        public Account[] myAccounts = new Account[20];
        public int countOfAccounts = 0;
        public Person(string name, int age) {
            this.name = name;
            this.age = age;
        }
        public void writeAccounts() {
            Console.WriteLine(age);
            int i = 0;
            while (myAccounts[i] != null) {
                Console.WriteLine(myAccounts[i].balance);
                i++;
            }
        }
        public override string ToString() {
            int i = 0;
            string pomocny = "";
            while (myAccounts[i] != null) {
                pomocny += this.myAccounts[i].ToString() + "\n";
                i++;
            }
            return pomocny;
        }
    }
    internal class Account {

        public static void Mainx() {
            Person Pepa = new Person("Pepa", 20);
            Person Honza = new Person("Honza", 30);
            Account acc1 = new Account(Pepa, 100);
            Account acc3 = new Account(Pepa, 300);
            Account acc4 = new Account(Pepa, 400);
            Account acc2 = new Account(Honza, 100);
            Pepa.writeAccounts();
            Console.Write(Pepa.ToString()); 
            //Console.WriteLine(Pepa.age);
            //acc1.writeInfo();
            //acc2.writeInfo();
            //Console.WriteLine(acc1.ToString());
            //Console.WriteLine(acc2.ToString());
            //acc1.transferTo(acc2, 50);
            //Console.WriteLine(acc1.ToString());
            //Console.WriteLine(acc2.ToString());
        }

        public int balance;
        public Person owner;
        
        public Account(Person owner, int amount) {
            this.owner = owner;
            this.balance = amount;
            owner.myAccounts[owner.countOfAccounts] = this;
            owner.countOfAccounts++;
        }
        public void insertInto(int amount) {
            balance += amount;
        }
        public void writeInfo() {
            Console.WriteLine("jméno: {0} \t zůstatek: {1}", owner.name, balance);
        }
        public void transferTo(Account druhy, int amount) {
            druhy.balance += amount;
            balance -= amount;
        }
        public override string ToString() {
            return string.Format("jméno: {0} \t zůstatek: {1}", owner.name, balance);
        }

    }
}
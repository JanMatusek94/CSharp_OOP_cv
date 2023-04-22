using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account6 {
	class Date {
		public int day;
		public int month;
		public int yearOfBirth;
		public Date(int rok, int mesic, int den) {
			day = den;
			month = mesic;
			yearOfBirth = rok;
		}
	}
	class Person {
		public string name;
		public Date dateOfBirth;
		public List<Account> myAccounts = new List<Account>();
		//public ArrayList myAccounts = new ArrayList();
		//public int countOfAccounts = 0;
		public Person(string name, Date datnar){
			this.name = name;
			this.dateOfBirth = datnar;
		}
		public Person(string jmeno, int den, int mesic, int rok) : this(jmeno, new Date(rok, mesic, den)) {
		}
		public void writeAccounts() {
			Console.WriteLine(this.dateOfBirth.yearOfBirth);
			int i = 0;
			foreach (Account acc in myAccounts) {
				Console.WriteLine($"{i}. owner: {acc.owner.name} zustatek: {acc.balance}");
				//i++;
				Console.WriteLine(this.dateOfBirth.yearOfBirth);
				Console.WriteLine($"{i}. účet: {myAccounts[i]}");
				myAccounts[i].writeBalance();
				i++;
			}
		}
		//public override string ToString() {
		//    //int i = 0;
		//    string pomocny = "";
		//    foreach (Account acc in myAccounts) {
		//        pomocny += acc.ToString() + "\n";
		//        //i++;
		//    }
		//    return pomocny;
		//}
	}
	internal class Account {
		public int balance;
		public Person owner;
		public Account(Person majitel, int castka) {
			this.owner = majitel;
			this.balance = castka;
			owner.myAccounts.Add(this);
			//owner.countOfAccounts++;
		}
		public void insertInto(int castka) {
			balance += castka;
		}
		public void writeBalance() {
			Console.WriteLine($"vlastník účtu: {owner.name} je starý " +
				$"{DateTime.Today.Year - owner.dateOfBirth.yearOfBirth} let, na účtu je: {balance}");
		}
		public void transferTo(Account druhy, int castka) {
			druhy.balance += castka;
			balance -= castka;
		}
		public override string ToString() {
			return $"owner: {owner.name}\nbalance: {balance}";
		}


		public static void Mainx() {
			Date dt = new Date(1994, 3, 6);

			Person Pepa = new Person("Pepa", dt);
			Person Honza = new Person("Honza", new Date(1995, 8, 12));

			Account acc8 = new Account(new Person("Franta", new Date(1996, 10, 9)), 500);
			Account acc9 = new Account(new Person("Franta", new Date(1996, 3, 17)), 800);
			Person Davik = new Person("David", 1, 6, 2000);
			Console.WriteLine(Davik.ToString());
			Console.WriteLine(Davik.dateOfBirth.yearOfBirth);


			Account acc1 = new Account(Pepa, 100);
			Account acc3 = new Account(Pepa, 300);
			Account acc4 = new Account(Pepa, 400);
			Account acc2 = new Account(Honza, 100);
			Account acc5 = new Account(Honza, 600);

			Pepa.writeAccounts();
			//Console.Write(Pepa.ToString());
			//Console.WriteLine(Honza.ToString());
			//Console.WriteLine(acc9.owner.ToString());
			//Console.WriteLine(Pepa.age);
			//acc1.writeInfo();
			//acc2.writeInfo();
			//Console.WriteLine(acc1.ToString());
			//Console.WriteLine(acc2.ToString());
			//acc1.transferTo(acc2, 50);
			//Console.WriteLine(acc1.ToString());
			//Console.WriteLine(acc2.ToString());
		}
	}
}


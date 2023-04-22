using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni9 {
	class Person {
		private int age;
		protected static int count;
		public int GetAge() { return age; }
		public void SetAge(int x) { age = x; }
		public static int GetCount() { return count; }
		public Person(int age) {
			this.age = age;
			count++;
		}
		public Person() {
			count++;  //kdyby nebyla inkrementace tady tak druha instance tridy student s pouzitim bezparam. konstruktoru vypise taky 1 protoze se vola tento kontruktor
		}
		public virtual void writeInfo() {
			Console.Write($"věk: {age}, počet: {count}"); 
		}
		//public void Info() {
		//	Console.Write($"věk: {age}");
		//}
	}
	class Employee : Person {
		private int salary;

		//public int Salary {  //Vlastnost se jmenuje stejne jako datova slozka jen s velkym pismenem na zacatku, muze mit pouze getter ale ne pouze setter
		//	get { return salary; }
		//	set { salary = value; }
		//}
		//public int Salary { get; set; } //automaticky implementovana vlastnost, neuvádí se datova složka ta je implicitní

		public Employee(int salary, int age) : base(age) {
			this.salary = salary;
		}
		public Employee() { }
		public override void writeInfo() {
			base.writeInfo();
			//Console.WriteLine(GetAge().ToString() + " " + count); //pokud class dedi tak muze pristuopovat k protected, ale ne k private (v tom pripade je treba pouzit getter/setter nebo vlastnost
			Console.Write($", salary: {salary}");
		}
	}
	class Student : Person {
		public int scholarship;
		public Student(int age, int scholarship) : base(age) {
			//this.age = age;
			this.scholarship = scholarship;
		}
		public Student() {

		}
		public override void writeInfo() {
			base.writeInfo();
			//base.Info(); //neni třeba volat s base. protože v class Student neni stejnojmenna metoda takže kompilator vi kterou metodu ma volat
			Console.WriteLine($", scholarship: {scholarship}");
		}
	}
	class Accountant : Employee {
		public Accountant(int age, int salary) : base(salary, age) {
			//this.age = age;
			//this.salary = salary;
		}
		public override void writeInfo() {
			base.writeInfo();
			Console.WriteLine();
		}
	}
	class Teacher : Employee {
		private int teachingTime;
		//public int TeachingTime {
		//	get { return teachingTime; }
		//	set {
		//		if (value > 40) {
		//			Console.WriteLine("Uvazek nesmi byt vic nez 40 hodin"); //zde Vlastnost kontroluje zadání, to getteru setteru nejde. (nelze pouzit jako parametr predvany jinak nez hodnotou
		//		}
		//		else {
		//			teachingTime = value;
		//		}
		//	}
		//}
		public Teacher(int age, int salary, int teachingTime) : base(salary, age) {
			//this.age = age;
			//this.salary = salary;
			this.teachingTime = teachingTime;
		}
		public override void writeInfo() {
			//Console.Write("věk učitele:  " + age + ", salary: " + salary);	//původní podoba se sčítáním řetězců
			//Console.WriteLine(", počet úvazkových hodin: " + teachingTime);
			base.writeInfo();
			Console.WriteLine($", počet úvazkových hodin: {teachingTime}");
		}
	}
	class Prvni {
		public static void Mainx() {
			Student s1 = new Student(17, 120000);
			s1.writeInfo();
			Student s2 = new Student(23, 15000);
			s2.writeInfo();
			Accountant e1 = new Accountant(31, 80000);
			e1.writeInfo();
			Teacher u1 = new Teacher(48, 70000, 30);
			u1.writeInfo();
			//Console.WriteLine(s2.GetAge().ToString() + " " + Person.GetCount());
		}
	}
}
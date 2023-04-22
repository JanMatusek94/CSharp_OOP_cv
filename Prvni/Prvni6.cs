using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni6 {
	class Person {
		public int age;
		public Person(int age) {
			this.age = age;
		}
		public Person() { }
		public void writeInfo() {
			Console.Write($"věk: {age}");
		}
	}
	class Employee : Person {
		public int salary;
		public Employee(int salary, int age) : base(age) {
			this.salary = salary;
		}
		public Employee() { }
		public void writeInfo() {
			base.writeInfo();
			Console.Write($", salary: {salary}");
		}
	}
	class Student : Person {
		public int scholarship;
		public Student(int age, int scholarship) : base(age) {
			//this.age = age;
			this.scholarship = scholarship;
		}
		public void writeInfo() {
			base.writeInfo();
			Console.WriteLine($", scholarship: {scholarship}");
		}
	}
	class Accountant : Employee {
		public Accountant(int age, int salary) : base(salary, age) {
			//this.age = age;
			//this.salary = salary;
		}
		public void writeInfo() {
			base.writeInfo();
			Console.WriteLine();
		}
	}
	class Teacher : Employee {
		public int teachingTime;
		public Teacher(int age, int salary, int teachingTime) : base(salary, age) {
			//this.age = age;
			//this.salary = salary;
			this.teachingTime = teachingTime;
		}
		public void writeInfo() {
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
			Accountant e1 = new Accountant(31, 80000);
			e1.writeInfo();
			Teacher u1 = new Teacher(48, 70000, 160);
			u1.writeInfo();
		}
	}
}
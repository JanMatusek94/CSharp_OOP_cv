using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni3 {
	class Person {
		public int age;
	}
	class Employee : Person {
		public int salary;
	}
	class Student : Person {
		public int scholarship;
		public Student(int age, int scholarship) {
			this.age = age;
			this.scholarship = scholarship;
		}
		public void writeInfo() {
			Console.WriteLine($"věk studenta: {age}, scholarship: {scholarship}");
		}
	}
	class Accountant : Employee {
		public Accountant(int age, int salary) {
			this.age = age;
			this.salary = salary;
		}
		public void writeInfo() {
			Console.WriteLine($"věk ekonomky: {age}, salary: {salary}");
		}
	}
	class Teacher : Employee {
		public int teachingTime;
		public Teacher(int age, int salary, int teachingTime) {
			this.age = age;
			this.salary = salary;
			this.teachingTime = teachingTime;
		}
		public void writeInfo() {
			//Console.Write("věk učitele:  " + age + ", salary: " + salary);	//původní podoba se sčítáním řetězců
			//Console.WriteLine(", počet úvazkových hodin: " + teachingTime);
			Console.Write($"věk učitele:  {age}, salary: {salary}");
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
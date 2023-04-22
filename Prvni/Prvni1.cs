using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni1 {
	class Student {
		public int age, scholarship;
		public void writeInfo() {
			Console.WriteLine($"věk studenta: {age}, scholarship: {scholarship}");
		}
	}
	class Accountant {
		public int age, salary;
		public void writeInfo() {
			Console.WriteLine($"věk ekonomky: {age}, salary: {salary}");
		}
	}
	class Teacher {
		public int age, salary, teachingTime;
		public void writeInfo() {
			//Console.Write("věk učitele:  " + age + ", salary: " + salary);	//původní podoba se sčítáním řetězců
			//Console.WriteLine(", počet úvazkových hodin: " + teachingTime);
			Console.Write($"věk učitele:  {age}, salary: {salary}");
			Console.WriteLine($", počet úvazkových hodin: {teachingTime}");
		}
	}
	class Prvni {
		public static void Mainx() {
			Student s1 = new Student();
			s1.age = 20;
			s1.scholarship = 1000;
			s1.writeInfo();
			Accountant e1 = new Accountant();
			e1.age = 30;
			e1.salary = 12000;
			e1.writeInfo();
			Teacher u1 = new Teacher();
			u1.age = 40;
			u1.salary = 20000;
			u1.teachingTime = 22;
			u1.writeInfo();
		}
	}
}

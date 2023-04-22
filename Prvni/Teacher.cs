using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni12 {
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
			Console.Write(age);
			base.writeInfo();
			Console.WriteLine($", počet úvazkových hodin: {teachingTime}");
		}
	}
}
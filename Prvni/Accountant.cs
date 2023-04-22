using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni12 {
	class Accountant : Employee {
		public Accountant(int age, int salary) : base(salary, age) {
			//this.age = age;
			//this.salary = salary;
		}
		public override void writeInfo() {
			Console.Write(age);
			base.writeInfo();
			Console.WriteLine();
		}
	}
}
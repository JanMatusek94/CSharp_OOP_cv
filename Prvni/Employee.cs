using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni12 {
	abstract class Employee : Person {
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
			//Console.WriteLine(GetAge().ToString() + " " + count); //pokud class dedi tak muze pristuopovat k protected, ale ne k private (v tom pripade je treba pouzit getter/setter nebo vlastnost
			Console.Write($", počet osob: {GetCount()}, salary: {salary}");
		}
	}
}
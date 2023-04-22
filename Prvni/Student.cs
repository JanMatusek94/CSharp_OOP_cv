using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni12 {
	class Student : Person {
		public int scholarship;
		public Student(int age, int scholarship) : base(age) {
			//this.age = age;
			this.scholarship = scholarship;
		}
		public Student() {

		}
		public override void writeInfo() {
			Console.Write(age);
			//base.Info(); //neni třeba volat s base. protože v class Student neni stejnojmenna metoda takže kompilator vi kterou metodu ma volat
			Console.WriteLine($", počet osob: {GetCount()}, scholarship: {scholarship}");
		}  //pri zavolani metody writeinfo se hleda v studentovi, tady neni tak jde vys do person, tam ji najde ale ta nevypise scholarship, takze se vypise jen age a count
		public override string ToString() {   //kdyby tu nebylo override tak se po zavolani cw vola metoda ToString tridy Object, po napsani override se prekryje a vola se metoda instance
			return base.ToString() + String.Format(" scholarship: {0}", scholarship);
		}

	}
}

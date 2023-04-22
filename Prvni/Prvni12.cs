using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni12 {
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
			Console.WriteLine(s1);
			Console.WriteLine(e1);
			Console.WriteLine(u1);
			Console.WriteLine(s1.ToString());
			Console.WriteLine(e1.ToString());
			Console.WriteLine(u1.ToString());
		}
	}
}

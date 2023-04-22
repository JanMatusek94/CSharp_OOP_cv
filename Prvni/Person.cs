using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvni12 {
	abstract class Person {
		public int age;
		protected static int count;
		//public int GetAge() { return age; }
		//public void SetAge(int x) { age = x; }
		public static int GetCount() { return count; }
		public Person(int age) {
			this.age = age;
			count++;
		}
		public Person() {
			count++;  //kdyby nebyla inkrementace tady tak druha instance tridy student s pouzitim bezparam. konstruktoru vypise taky 1 protoze se vola tento kontruktor
		}
		public abstract void writeInfo(); //{
																			//	Console.Write($"věk: {age}, počet: {count}");
																			//}

		//public void Info() {
		//	Console.Write($"věk: {age}");
		//}
		public override string ToString() {   //kdyby tu nebylo override tak se po zavolani cw vola metoda ToString tridy Object, po napsani override se prekryje a vola se metoda instance
			return $"ToString: počet osob: {Person.GetCount()}, věk:  {age}";  //
		}
	}
}
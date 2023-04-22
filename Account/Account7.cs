using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account7 {
    internal class Account {
        public int balance;
        public void insertInto(int amount) {
            balance += amount;
        }
        public void writeInfo() {
            Console.WriteLine(balance);
        }
        public void transferTo(Account druhy, int amount) {
            druhy.balance += amount;
            balance -= amount;
        }
		public static void Mainx() {;
      Account acc1 = new Account();


      Console.WriteLine("Enter amount, > 0");

      if (int.TryParse(Console.ReadLine(), out int result)&& result > 0) {
        acc1.insertInto(result);
      }
      else {
        Console.WriteLine("Nesmí být záporny, musi byt cislo");
      }
      Console.WriteLine("ucet: {0}", acc1.balance);
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account1 {
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
    }
}

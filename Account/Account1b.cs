using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account1b {

    internal class Account {

        public static void Mainx() {
            Account acc1 = new Account();
            Account acc2 = new Account();
            acc1.insertInto(100);
            acc2.insertInto(100);
            acc1.writeInfo();
            acc2.writeInfo();
            acc1.transferTo(acc2);
            acc1.writeInfo();
            acc2.writeInfo();
        }

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
        public void transferTo(Account druhy) {
            //druhy.balance += this.balance;
            ////this.balance = 0;
            //this.balance -= this.balance;
            transferTo(druhy, this.balance);
        }

    }
}
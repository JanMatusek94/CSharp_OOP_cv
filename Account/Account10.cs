using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account10 {
    internal class Account {
        public int balance;
        public void insertInto(int amount) {
            try {
                if (balance + amount < 0) {
                    throw new ArgumentOutOfRangeException($"Na výběr nemáš dostatek love, je zde {balance}");
                }
                else {
                    balance += amount;
                }
            }
            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Na účtu máš momentálně {0} chechtáků", balance);
        }
        public void writeInfo() {
            Console.WriteLine(balance);
        }
        public void transferTo(Account druhy, int amount) {

            if (balance - amount < 0) {
                throw new ArgumentOutOfRangeException("Na převod nemáš dostatek love");
            }
            if (amount < 0) {
                throw new ArgumentOutOfRangeException("Nesmíš vysávat cizí účty, ty loupežníku jeden!!!");
            }
            if (amount == 0) {
                throw new ArgumentOutOfRangeException("Nejde převádět nula, ty troubelíne jeden!!!");
            }
            if (this == druhy) {
                throw new FormatException("Nemůžeš převádět peníze sám sobě!!!");
            }
            druhy.balance += amount;
            balance -= amount;
        }
        public static void Mainx() {
            Account acc1 = new Account();
            Account acc2 = new Account();
            acc1.balance = 100;
            acc2.balance = 200;
            //int result;


            //Console.WriteLine("Enter amount, > 0");
            //result = int.Parse(Console.ReadLine());
            //acc1.insertInto(result);
            Console.WriteLine("ucet: {0}", acc1.balance);


            try {
                acc1.transferTo(acc2, 0);
            }
            catch (ArgumentOutOfRangeException e) { Console.WriteLine(e.StackTrace); }
            catch (FormatException e) { Console.WriteLine(e.StackTrace); }

            //acc1.transferTo(acc2, 200);
            //acc1.transferTo(acc2, -20);
            //acc1.transferTo(acc2, 0);
            //acc1.transferTo(acc1, 50);
            Console.WriteLine(acc1.balance);
        }
    }
}
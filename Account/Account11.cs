using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account11 {
    internal class Account {
        public int balance;
        public void insertInto(int amount) {
            Console.WriteLine($"Stav účtu: {this.balance}");
            if (balance + amount < 0) {
                    throw new ArgumentOutOfRangeException($"Na výběr nemáš dostatek love, je zde {balance}");
                }
                else {
                    balance += amount;
                    Console.WriteLine("Na účtu máš momentálně {0} chechtáků", balance);
            }
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
            //if (this == druhy) {
            //    throw new FormatException("Nemůžeš převádět peníze sám sobě!!!");
            //}
            druhy.balance += amount;
            balance -= amount;
            Console.WriteLine($"Na 1. účtu je {balance}, na 2. účtu je {druhy.balance}");
        }
        public static void Mainx() {
            Account acc1 = new Account();
            Account acc2 = new Account();
            acc1.balance = 100;
            acc2.balance = 200;
            int result;
            bool ok;


            do {
                Console.WriteLine("Zadej částku pro vložení nebo výběr: ");
                try {
                    result = int.Parse(Console.ReadLine());
                    acc1.insertInto(result);
                    break;
                }
                catch (ArgumentOutOfRangeException e) { Console.WriteLine(e.Message);  }
            } while (true);


            //Console.WriteLine("Enter amount, > 0");
            //result = int.Parse(Console.ReadLine());
            //acc1.insertInto(result);
            Console.WriteLine("ucet 1: {0}, učet 2: {1}", acc1.balance, acc2.balance);

            do {
                ok = false;
                Console.WriteLine("Zadej částku pro převod");
                try {
                    result = int.Parse(Console.ReadLine());
                    acc1.transferTo(acc2, result);
                }
                catch (ArgumentOutOfRangeException e) { 
                    Console.WriteLine(e.Message);
                    ok = true;
                }
                //catch (FormatException e) { 
                //    Console.WriteLine(e.Message);
                //    ok = true;
                //}
            } while (ok);


            //acc1.transferTo(acc2, 200);
            //acc1.transferTo(acc2, -20);
            //acc1.transferTo(acc2, 0);
            //acc1.transferTo(acc1, 50);
            //Console.WriteLine(acc1.balance);
        }
    }
}

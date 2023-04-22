using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcetVlastni9 {
    class MaloPenezException : Exception { }
    class VyberZCizihoUctuExcpetion : Exception { }
    class PrevodNulyException : Exception { }

        internal class Account {
            public int balance;
            public void insertInto(int amount) {
                try {
                    if (balance + amount < 0) {
                        throw new MaloPenezException();
                    }
                    else {
                        balance += amount;
                    }
                }
                catch (MaloPenezException e) {
                    Console.WriteLine(e.Message + $" Na výběr nemáš dostatek love, je zde {balance}");
                }

                Console.WriteLine("Na účtu máš momentálně {0} chechtáků", balance);
            }
            public void writeInfo() {
                Console.WriteLine(balance);
            }
            public void transferTo(Account druhy, int amount) {
            try {
                if (balance - amount < 0) {
                    throw new MaloPenezException();
                }
                if (amount < 0) {
                    throw new VyberZCizihoUctuExcpetion();
                }
                if (amount == 0) {
                    throw new PrevodNulyException();
                }
                druhy.balance += amount;
                balance -= amount;
            }
            catch (MaloPenezException e) { Console.WriteLine(e.Message + $"Na výběr nemáš dostatek love, je zde {balance}"); }
            catch (VyberZCizihoUctuExcpetion e) { Console.WriteLine(e.Message + $"Nesmíš vybírat z cizího účtu!"); }
            catch (PrevodNulyException e) { Console.WriteLine(e.Message + $"Nejde převádět nula!"); }
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

                acc1.transferTo(acc2, 200);
                acc1.transferTo(acc2, -20);
                acc1.transferTo(acc2, 0);
                acc1.transferTo(acc1, 50);
                Console.WriteLine(acc1.balance);
            }
        }
}

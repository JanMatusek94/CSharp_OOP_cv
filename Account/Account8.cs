using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account8 {
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
        public void writeBalanceInDollars(int kurz) {
            try {
                Console.WriteLine("Zůstatek v dolarech je {0}$", balance / kurz);
            } 
            catch (DivideByZeroException e){ Console.WriteLine(e); 
            }
            catch (ArithmeticException e) { Console.WriteLine(e);
            } 
            catch (Exception e) { Console.WriteLine(e); 
            }
        }
        public void writeBalanceInDollarDouble(double kurz) {
            try {
                if (kurz == 0) {
                    throw new DivideByZeroException("Nesmíš dělit nulou.");
                } else {
                    Console.WriteLine("Zůstatek v dolarech je {0}$", balance / kurz);
                    }
            }
            catch (DivideByZeroException e) { Console.WriteLine(e.Message + " (realnou)"); }
        }

        public static void Mainx() {
            ;
            Account acc1 = new Account();


            Console.WriteLine("Enter amount, > 0");

            if (int.TryParse(Console.ReadLine(), out int result) && result > 0) {
                acc1.insertInto(result);
            }
            else {
                Console.WriteLine("Nesmí být záporny, musi byt cislo");
            }
            Console.WriteLine("ucet: {0}", acc1.balance);

            acc1.writeBalanceInDollars(20);
            acc1.writeInfo();
            acc1.writeBalanceInDollarDouble(20.3);
        }
    }
}

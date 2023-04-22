using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account1 {
    internal class TestAccount {
        public static void Mainx() {
            Account acc1 = new Account();
            Account acc2 = new Account();
            acc1.insertInto(100);
            acc2.insertInto(100);
            acc1.transferTo(acc2,50);
            acc1.writeInfo();
            acc2.writeInfo();
            //acc1.transferTo(acc2,acc1.balance);
            Console.WriteLine($"{nameof(acc1)}");
            acc1.writeInfo();
            Console.WriteLine($"{nameof(acc2)}");
            acc2.writeInfo();
        }
    }
}

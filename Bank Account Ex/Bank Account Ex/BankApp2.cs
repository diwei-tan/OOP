using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Ex
{
    class BankApp2
    {
        static void Main()
        {
            Customer c = new Customer("Di Wei", "123 Happy Lane, S123456", "T234809A", 25);
            BankAccount2 account = new BankAccount2(c, 143766, 5467.82);
            account.PrintInfo();
            account.Withdraw(500);
            account.Deposit(34.50);

        }
    }
}

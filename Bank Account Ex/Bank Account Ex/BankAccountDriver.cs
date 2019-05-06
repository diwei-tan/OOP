using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Ex
{
    class BankAccountDriver
    {
        static void Main()
        {
            BankAccount1 myAcc = new BankAccount1("Di Wei", 91195026, 546.36);
            BankAccount1 another = new BankAccount1("Emilia", 1234566, 0);
            myAcc.PrintInfo();
            myAcc.Withdraw(50);
            myAcc.Deposit(4368.45);
            myAcc.Transfer(another, 1000);
            another.PrintInfo();
        }
    }
}

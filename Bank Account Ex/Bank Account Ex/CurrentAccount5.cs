using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Ex
{
    class CurrentAccount5 : BankAccount1
    {
        public CurrentAccount5(string name, int number, double amount):base(name, number, amount)
        {

        }
        public override void CreditInterest()
        {
            balance = balance * 1.01;
        }
    }
}

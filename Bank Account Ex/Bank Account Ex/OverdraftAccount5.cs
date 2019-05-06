using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Ex
{
    class OverdraftAccount5 : BankAccount1
    {
        public OverdraftAccount5(string name, int number, double amount) : base(name, number, amount)
        {

        }
        public override void CreditInterest()
        {
            if(balance >= 0)
            {
                balance = balance * 1.005;
                //Console.WriteLine("5% Credited");
            }
            else if (balance < 0)
            {
                balance = balance * 1.1;
                //Console.WriteLine("10% Credited");
            }
        }
        public void RunCreditInterest(OverdraftAccount5 a1)
        {
            a1.CreditInterest();
        }
    }
}

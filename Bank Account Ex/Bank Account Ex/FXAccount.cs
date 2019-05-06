using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Ex
{
    class FXAccount : BankAccount1
    {
        string currency;
        public FXAccount(string name, int number, double amount, string currency) : base(name, number, amount)
        {
            this.currency = currency;
        }
        public string Currency { get { return currency; } set { currency = value; } }

    }
}

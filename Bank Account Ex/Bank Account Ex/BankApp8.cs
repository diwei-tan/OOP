using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Ex
{
    class BankApp8
    {
        static void Main()
        {
            BankAccount8 ac = new BankAccount8("ABC", 1111, 500);
            Console.WriteLine(ac.GetName());
            Console.WriteLine(ac.GetBalance());
            Console.WriteLine(ac.GetState());

            Console.WriteLine("Balance is 500, trying to withdraw 450");
            ac.Withdraw(450);
            Console.WriteLine(ac.GetBalance());
            Console.WriteLine(ac.GetState());

            Console.WriteLine("Balance is 50, trying to withdraw 20 under min balance amount");
            ac.Withdraw(20);
            Console.WriteLine(ac.GetBalance());
            Console.WriteLine(ac.GetState());
        }
    }
}

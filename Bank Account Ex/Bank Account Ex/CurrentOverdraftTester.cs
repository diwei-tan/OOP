using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Ex
{
    class CurrentOverdraftTester
    {
        static void Main()
        {
            CurrentAccount5 a1 = new CurrentAccount5("Di Wei", 342111, 10000);
            OverdraftAccount5 a2 = new OverdraftAccount5("Bennie", 342112, 10000);
            FXAccount a3 = new FXAccount("Jenny", 342113, 10000, "INR");
            //BankAccount1 a4 = a2;

            a1.PrintInfo();
            a2.PrintInfo();
            a1.CreditInterest();
            a2.CreditInterest();
            a1.PrintInfo();
            a2.PrintInfo();
            Console.WriteLine();

            //RunCreditInterest that runs CreditInterest() by taking account
            a2.RunCreditInterest(a2);
            a2.PrintInfo();
            Console.WriteLine();
            // a4.CreditInterest();
            //a4.PrintInfo();
            Console.WriteLine();

            //Print method
            PrintAllDetails(a1, a2, a3);

        }
        static void PrintAllDetails(CurrentAccount5 a1, OverdraftAccount5 a2, FXAccount a3)
        {
            //Exercise to manually print account, test inheritance
            //Test for CurrentAccount child class obj
            Console.WriteLine("Account Number: {0}", a1.GetAccountNum());
            Console.WriteLine("Account Name: {0}", a1.GetName());
            Console.WriteLine("Current Status: {0}", a1.GetState());
            Console.WriteLine($"Account Balance: {a1.GetBalance():C}");

            //Test for OverDraftAccount child class obj
            Console.WriteLine("Account Number: {0}", a2.GetAccountNum());
            Console.WriteLine("Account Name: {0}", a2.GetName());
            Console.WriteLine("Current Status: {0}", a2.GetState());
            Console.WriteLine($"Account Balance: {a2.GetBalance():C}");

            //Test for FXAccount child class obj
            Console.WriteLine("Account Number: {0}", a3.GetAccountNum());
            Console.WriteLine("Account Name: {0}", a3.GetName());
            Console.WriteLine("Current Status: {0}", a3.GetState());
            Console.WriteLine($"Account Balance: {a3.Currency}{a2.GetBalance():C}");
        }
    }
}

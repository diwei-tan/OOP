using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Ex
{
    class BankAccount2
    {
        int accountNum;
        Customer customer;
        double balance;
        string accountState;

        public BankAccount2()
        {
            accountState = "Active";
        }
        public BankAccount2(Customer cus) : this()
        {
            customer = cus;
        }
        public BankAccount2(Customer cus, int number) : this(cus)
        {
            accountNum = number;
        }
        public BankAccount2(Customer cus, int number, double amount) : this(cus, number)
        {
            balance = amount;
        }

        public string GetName()
        {
            return customer.GetName();
        }
        public void SetName(string name)
        {
            customer.SetName(name);
        }
        public int GetAccountNum()
        {
            return accountNum;
        }
        public double GetBalance()
        {
            return balance;
        }
        public void SetState(string state)
        {
            accountState = state;
        }
        public void Withdraw(double amount)
        {
            balance = balance - amount;
            Console.WriteLine($"Your amount of {amount:C} has been withdrawn successfully.");
            Console.WriteLine($"Your current balance is {balance:C}.");
        }
        public void Deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine($"Your amount of {amount:C} has been deposited successfully.");
            Console.WriteLine($"Your current balance is {balance:C}.");
        }
        public void CreditInterest(double interest)
        {
            balance = balance * (1 + interest);
        }
        public void PrintInfo()
        {
            Console.WriteLine("Account Number: {0}", accountNum);
            Console.WriteLine("Account Name: {0}", customer.GetName());
            Console.WriteLine("Current Status: {0}", accountState);
            Console.WriteLine("Account Balance: {0}", balance);
        }
    }
}

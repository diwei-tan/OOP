using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Ex
{
    class BankAccount1
    {
        int accountNum;
        string customer;
        protected double balance;
        string accountState;

        public BankAccount1()
        {
            accountState = "Active";
        }
        public BankAccount1(string name) : this()
        {
            customer = name;
        }
        public BankAccount1(string name, int number) : this(name)
        {
            accountNum = number;
        }
        public BankAccount1(string name, int number, double amount) : this(name, number)
        {
            balance = amount;
        }

        public string GetName()
        {
            return customer;
        }
        public void SetName(string name)
        {
            customer = name;
        }
        public int GetAccountNum()
        {
            return accountNum;
        }
        public string GetState()
        {
            return accountState;
        }
        public void SetState(string state)
        {
            accountState = state;
        }
        public void Withdraw(double amount)
        {
            balance = balance - amount;
            //Console.WriteLine($"Your amount of {amount:C} has been withdrawn successfully.");
            //Console.WriteLine($"Your current balance is {balance:C}.");
        }
        public void Deposit(double amount)
        {
            balance = balance + amount;
            //Console.WriteLine($"Your amount of {amount:C} has been deposited successfully.");
            //Console.WriteLine($"Your current balance is {balance:C}.");
        }
        public virtual void CreditInterest()
        {
            //Console.WriteLine("2% is credited");
            balance = balance * 1.02;
        }
        public double GetBalance()
        {
            return balance;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Account Number: {0}", accountNum);
            Console.WriteLine("Account Name: {0}", customer);
            Console.WriteLine("Current Status: {0}", accountState);
            Console.WriteLine($"Account Balance: {balance:C}");
        }
        public void Transfer(BankAccount1 a, double amount) //Transfer
        {
            Console.WriteLine($"Your balance before transfer is {balance:C}.");
            balance = balance - amount;
            a.balance = a.balance - amount;
            Console.WriteLine($"{amount:C} transferred to {a.GetName()}. Your current balance is {this.GetBalance():C}");
        }

    }
}

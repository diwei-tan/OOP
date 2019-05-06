using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Ex
{
    class BankAccount8
    {
        int accountNum;
        string customer;
        protected double balance;
        AccountStateEnum accountState;

        public BankAccount8()
        {
            accountState = AccountStateEnum.Inadequate;
        }
        public BankAccount8(string name) : this()
        {
            customer = name;
        }
        public BankAccount8(string name, int number) : this(name)
        {
            accountNum = number;
        }
        public BankAccount8(string name, int number, double amount) : this(name, number)
        {
            balance = amount;
            if(balance >= 100)
            {
                accountState = AccountStateEnum.Active;
            }
        }

        private void SetAccountState()
        {
            if (balance >= 100)
                accountState = AccountStateEnum.Active;
            else
                accountState = AccountStateEnum.Inadequate;
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
        public AccountStateEnum GetState()
        {
            return accountState;
        }

        public void Withdraw(double amount)
        {
            if (balance > amount && accountState == AccountStateEnum.Active)
            {
                balance -= amount;
                Console.WriteLine($"Your amount of {amount:C} has been withdrawn successfully.");
                Console.WriteLine($"Your current balance is {balance:C}.");
            }
            else
            {
                Console.WriteLine("Insufficient Amount");
                Console.WriteLine($"Your current balance is {balance:C}.");
            }
            SetAccountState();
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
        public void Transfer(BankAccount8 a, double amount) //Transfer
        {
            Console.WriteLine($"Your balance before transfer is {balance:C}.");
            balance = balance - amount;
            a.balance = a.balance - amount;
            Console.WriteLine($"{amount:C} transferred to {a.GetName()}. Your current balance is {this.GetBalance():C}");
        }
    }
}

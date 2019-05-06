using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Ex
{
    class BankAccount5
    {
        int accountNum;
        Customer customer;
        Customer jointcustomer;
        double balance;
        string accountState;

        public BankAccount5()
        {
            accountState = "Active";
            jointcustomer = null;
        }
        public BankAccount5(Customer cus) : this()
        {
            customer = cus;
        }
        public BankAccount5(Customer cus, int number) : this(cus)
        {
            accountNum = number;
        }
        public BankAccount5(Customer cus, int number, double amount) : this(cus, number)
        {
            balance = amount;
        }
        public BankAccount5(Customer cus, Customer joint, int number, double amount) : this(cus, number, amount)
        {
            jointcustomer = joint;
        }

        public string GetJointName()
        {
            return jointcustomer.GetName();
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
            if (jointcustomer != null)
                Console.WriteLine("Account Joint Name: {0}", jointcustomer.GetName());
            Console.WriteLine("Current Status: {0}", accountState);
            Console.WriteLine("Account Balance: {0}", balance);
        }
    }
}

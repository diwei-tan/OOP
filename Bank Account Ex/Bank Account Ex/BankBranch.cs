using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Ex
{
    class BankBranch
    {
        string branchName;
        string branchLocation;
        string branchManager;
        Customer[] bankCustomers;
        BankAccount2[] bankAccounts;

        //constructor practice (create for all cases)
        public BankBranch(string name)
        {
            branchName = name;
        }
        public BankBranch(string name, string location) : this(name)
        {
            branchLocation = location;
        }
        public BankBranch(string name, string location, string manager) : this(name, location)
        {
            branchManager = manager;
        }
        public BankBranch(string name, string location, string manager, 
            Customer [] c):this(name, location, manager)
        {
            bankCustomers = c;
        }
        public BankBranch(string name, string location, string manager,
            Customer[] c, BankAccount2[] a) : this (name, location, manager, c)
        {
            bankAccounts = a;
        }

        //Methods
        public void AddCustomer(Customer c)
        {
            Array.Resize(ref bankCustomers, bankCustomers.Length + 1);
            bankCustomers[bankCustomers.Length-1] = c; //why add -1? Cause the previous changed the size!
            Console.WriteLine($"{c.GetName()} has been successfully added as a customer.");
            Console.WriteLine();
        }
        public void AddCustomer(string name, string address, string ic, int age)
        {
            Customer c = new Customer(name, address, ic, age);
            Array.Resize(ref bankCustomers, bankCustomers.Length + 1);
            bankCustomers[bankCustomers.Length-1] = c;
            Console.WriteLine($"{c.GetName()} has been successfully added as a customer.");
            Console.WriteLine();
        }
        public void SetCustomer(Customer c, int index)
        {
            bankCustomers[index] = c;
        }
        public double WhatIsCurrentBalance()
        {
            double total = 0;
            for(int i=0; i < bankAccounts.Length; i++)
            {
                total = total + bankAccounts[i].GetBalance();
            }
            return total;
        }
        public void PrintCustomers()
        {
            Console.WriteLine("List of Customers currently in the bank");
            Console.WriteLine("---------------------------------------");
            for (int i=0; i < bankCustomers.Length; i++)
            {
                bool accountExist = false;
                Console.WriteLine($"{bankCustomers[i].GetName()}'s Accounts:\t");
                for (int j = 0; j < bankAccounts.Length; j++)
                {
                    if(bankCustomers[i].GetName() == bankAccounts[j].GetName())
                    {
                        Console.WriteLine(bankAccounts[j].GetAccountNum());
                        accountExist = true;
                    }
                }
                if (accountExist == false)
                    Console.WriteLine("Account does not exist for customer.");
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
        }
    }
}

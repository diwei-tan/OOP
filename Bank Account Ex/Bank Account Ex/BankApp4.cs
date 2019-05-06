using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Ex
{
    class BankApp4
    {
        static void Main()
        {
            //generate bankbranch information
            Customer[] customers = new Customer[3];
            customers[0] = new Customer("Di Wei", "123 Happy Lane", "T1234567A", 35);
            customers[1] = new Customer("Emilia", "09-11 SengKang Street 21", "S6472813I", 31);
            customers[2] = new Customer("Lovren", "25 King's Court", "T3267899G", 32);
            Customer add = new Customer("Michael", "19 Ferntree Villas", "S2411345J", 25);
            BankAccount2[] accounts = new BankAccount2[4];
            accounts[0] = new BankAccount2(customers[0], 483920, 15000);
            accounts[1] = new BankAccount2(customers[0], 592841, 30000);
            accounts[2] = new BankAccount2(customers[1], 113445, 52345.34);
            accounts[3] = new BankAccount2(customers[2], 452667, 3200);
            BankBranch branch = new BankBranch("POSB Ang Mo Kio Branch", "Ang Mo Kio", "Nelson Sim",
                customers, accounts);
            
            //Print total sum in branch
            double total = branch.WhatIsCurrentBalance();
            Console.WriteLine($"Total amount in branch is {total:C}");
            Console.WriteLine();
            
            //Print all customers and their accounts (can be multiple)
            branch.PrintCustomers();
            //test adding customers
            branch.AddCustomer(add);
            branch.AddCustomer("Jennifer", "54 Jalan Semiyak", "T442336A", 22);
            branch.PrintCustomers();

        }
    }
}

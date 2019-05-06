using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Ex
{
    class BankApp5
    {
        static void Main()
        {
            Customer c = new Customer("Di Wei", "123 Happy Lane, S123456", "T234809A", 25);
            Customer j = new Customer("Emilia", "123 Happy Lane, S123456", "T847329G", 22);
            BankAccount5 account = new BankAccount5(c, 148273, 3500);
            account.PrintInfo();
        }


    }
}

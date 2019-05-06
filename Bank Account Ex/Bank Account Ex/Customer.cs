using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Ex
{
    class Customer
    {
        string customerName;
        string customerAddress;
        string icNum;
        int age;

        public Customer(string name)
        {
            customerName = name;
        }
        public Customer(string name, string address) : this(name)
        {
            customerAddress = address;
        }
        public Customer(string name, string address, string ic) : this(name, address)
        {
            icNum = ic;
        }
        public Customer(string name, string address, string ic, int input):this(name, address, ic)
        {
            age = input;
        }
        public string GetName()
        {
            return customerName;
        }
        public void SetName(string name)
        {
            customerName = name;
        }
        public string GetAddress()
        {
            return customerAddress;
        }
        public string GetIC()
        {
            return icNum;
        }
        public int GetAge()
        {
            return age;
        }
        public void GrowOld()
        {
            age++;
        }
    }
}

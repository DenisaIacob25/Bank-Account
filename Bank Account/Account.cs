using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Account
    {
        //fields in base class
        private string firstName;
        private string lastName;

        private int accountNmbr;
        private float balance;
        

        //properties in base class
        public int AccountNmbr
        {
            get { return this.accountNmbr; }
            set { this.accountNmbr = value; }
        }

        //constructor base class
        public Account()
        {

        }
    
        public Account(string firstName,string lastName,int accountNmbr,float balance)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.accountNmbr = accountNmbr;
            this.balance = balance;
        }

        //method base class
        public virtual void PrintAccountInfo()
        {
            Console.WriteLine(firstName+lastName);
            Console.WriteLine("Account number: " + AccountNmbr);
            Console.WriteLine("Balance: $" +balance);
        }
    }
}

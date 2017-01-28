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

        private int accountNmbr= 54546;
        private float accountBalance=0.00f;
        

        //properties in base class
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public int AccountNmbr
        {
            get { return this.accountNmbr; }
            set { this.accountNmbr = value; }
        }

        //constructor base class
    
        public Account(string firstName,string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
           
        }

        //method base class
        public virtual float Deposit(float depositAmount)
        {
            this.accountBalance += depositAmount;
            return accountBalance;
        }
        public virtual float Withdraw(float withdrawAmount)
        {
            this.accountBalance -= withdrawAmount;
            return accountBalance;
        }
        public virtual void PrintAccountBalance()
        {
            Console.WriteLine("Current Balance $" + accountBalance);
        }

        public void PrintAccountInfo()
        {
            Console.WriteLine(firstName+ " " + lastName);
            Console.WriteLine("Account number: " + accountNmbr);
            Console.WriteLine("Account balance: $" + accountBalance);
            
        }
    }
}

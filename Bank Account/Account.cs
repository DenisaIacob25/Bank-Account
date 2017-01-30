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
        private string accountType = "individual";

        private long phoneNmbr = 4406230537;
        private int accountNmbr = 54546;
        private decimal accountBalance;


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
        public decimal AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }

        //constructor base class
        public Account(string firstName, string lastName, decimal accountBalance)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AccountBalance = accountBalance;

        }

        //method base class
        public virtual decimal Deposit(decimal depositAmount)
        {
            this.accountBalance += depositAmount;
            return accountBalance;
        }
        public virtual decimal Withdraw(decimal withdrawAmount)
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
            Console.WriteLine("User: " + firstName + " " + lastName);
            Console.WriteLine("Account type: " + accountType);
            Console.WriteLine("User phone number: " + phoneNmbr);
            Console.WriteLine("Account number: " + accountNmbr);
            Console.WriteLine("Account balance: $" + accountBalance);
            Console.WriteLine();

        }
    }
}

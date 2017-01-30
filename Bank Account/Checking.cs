using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Checking : Account
    {
        //fields for checking
        protected decimal checkingBalance;
        private int checkingAccountNmbr;

        //properties
        public decimal CheckingBalance
        {
            get { return this.checkingBalance; }
            set { this.checkingBalance = value; }
        }
        public int CheckingAccountNmbr
        {
            get { return this.checkingAccountNmbr; }
            set { this.checkingAccountNmbr = value; }
        }

        //constructor
        public Checking(string firstName, string lastName) : base(firstName, lastName)
        {
            this.checkingBalance = 100m;
            this.checkingAccountNmbr = 67788;
        }

        //methods
        public override decimal Deposit(decimal depositAmount)
        {
            this.checkingBalance += depositAmount;
            return base.Deposit(depositAmount);
        }

        public override decimal Withdraw(decimal withdrawAmount)
        {
            this.checkingBalance -= withdrawAmount;
            return base.Withdraw(withdrawAmount);
        }

        public override void PrintAccountBalance()
        {
            Console.WriteLine("Savings account balance: $" + CheckingBalance);
            Console.WriteLine("Account Number: " + CheckingAccountNmbr);
            Console.WriteLine();
        }
    }
}

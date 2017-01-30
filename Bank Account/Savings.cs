using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Savings : Account
    {
        //fields for savings
        private decimal savingsBalance;
        private int savingsAccountNmbr;

        //properties 
        public decimal SavingsBalance
        {
            get { return this.savingsBalance; }
            set { this.savingsBalance = value; }
        }
        public int SavingsAccountNmbr
        {
            get { return this.savingsAccountNmbr; }
            set { this.savingsAccountNmbr = value; }
        }

        //constructor 
        public Savings(string firstName, string lastName) : base(firstName, lastName)
        {
            this.savingsBalance = 100;
            this.savingsAccountNmbr = 90089;
        }

        //methods
        public override decimal Deposit(decimal depositAmount)
        {
            this.savingsBalance += depositAmount;
            return base.Deposit(depositAmount);
        }
        public override decimal Withdraw(decimal withdrawAmount)
        {
            this.savingsBalance -= withdrawAmount;
            return base.Withdraw(withdrawAmount);
        }
        public override void PrintAccountBalance()
        {
            Console.WriteLine("Savings account balance: $" + SavingsBalance);
            Console.WriteLine("Account Number: " + SavingsAccountNmbr);
            Console.WriteLine();
        }
    }
}

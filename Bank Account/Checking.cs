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
        protected float checkingBalance;
        private int checkingAccountNmbr;

        //properties
        public float CheckingBalance
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
        public Checking(string firstName, string lastName):base(firstName,lastName)
        {
            this.checkingBalance = 0f;
            this.checkingAccountNmbr = 67788;
        }

        //methods
        public override float Deposit(float depostiAmount)
        {
            this.checkingBalance += depostiAmount;
            return base.Deposit(depostiAmount);
        }

        public override float Withdraw(float withdrawAmount)
        {
            this.checkingBalance -= withdrawAmount;
            return base.Withdraw(withdrawAmount);
        }

        public override void PrintAccountBalance()
        {
            Console.WriteLine("Savings account balance: $" + CheckingBalance);
        }
    }
}

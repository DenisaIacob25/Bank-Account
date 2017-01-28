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
        protected float savingsBalance;
        private int savingsAccountNmbr;

        //properties 
        public float SavingsBalance
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
        public Savings(string firstName,string lastName):base(firstName,lastName)
        {
            this.savingsBalance = 0f;
            this.savingsAccountNmbr = 20009;
        }

        //methods
        public override float Deposit(float depositAmount)
        {
            this.savingsBalance += depositAmount;
            return base.Deposit(depositAmount);
        }
        public override float Withdraw(float withdrawAmount)
        {
            this.savingsBalance -= withdrawAmount;
            return base.Withdraw(withdrawAmount);
        }
        public override void PrintAccountBalance()
        {
            Console.WriteLine("Savings account balance: $" + SavingsBalance);
        }
    }
}

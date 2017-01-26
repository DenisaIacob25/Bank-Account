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
        protected decimal savingsBalance;
        private decimal savingsDeposit;
        private decimal savingsWithdraw;

        //properties 
        public decimal SavingsBalance
        {
            get { return this.savingsBalance; }
            set { this.savingsBalance = value; }
        }
        public decimal SavingsDeposit
        {
            get { return this.savingsDeposit; }
            set { this.savingsDeposit = value; }
        }
        public decimal SavingsWithdraw
        {
            get { return this.savingsWithdraw; }
            set { this.savingsWithdraw = value; }
        }

        //constructor 
        public Savings()
        {
            SavingsBalance = this.savingsBalance;
            SavingsDeposit = this.savingsDeposit;
            SavingsWithdraw = this.savingsWithdraw;
        }
    }
}

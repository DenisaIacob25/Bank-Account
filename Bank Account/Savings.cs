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
        public Savings()
        { 
        }
    }
}

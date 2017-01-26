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
        private decimal checkingDeposit;
        private decimal checkingWithdraw;

        //constructor
        public decimal CheckingBalance
        {
            get { return this.checkingBalance; }
            set { this.checkingBalance = value; }
        }
        public decimal CheckingDeposit
        {
            get { return this.checkingDeposit; }
            set { this.checkingDeposit = value; }
        }
        public decimal CheckingWithdraw
        {
            get { return this.checkingWithdraw; }
            set { this.checkingWithdraw = value; }
        }

        //constructor
        public Checking()
        {
            CheckingBalance = this.checkingBalance;
            CheckingDeposit = this.checkingDeposit;
            CheckingWithdraw = this.checkingWithdraw;
        }

    }
}

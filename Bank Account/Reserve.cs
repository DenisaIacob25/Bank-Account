using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Reserve : Account
    {
        //fields for reserve 
        protected decimal reserveBalance;
        private decimal reserveDeposit;
        private decimal reserveWithdraw;

        //properties 
        public decimal ReserveBalance
        {
            get { return this.reserveBalance; }
            set { this.reserveBalance = value; }
        }
        public decimal ReserveDeposit
        {
            get { return this.reserveDeposit; }
            set { this.reserveDeposit = value; }
        }
        public decimal ReserveWithdraw
        {
            get { return this.reserveWithdraw; }
            set { this.reserveWithdraw = value; }
        }

        //constructor 

        public Reserve()
        {
            ReserveBalance = this.reserveBalance;
            ReserveDeposit = this.reserveDeposit;
            ReserveWithdraw = this.reserveWithdraw;
        }

    }
}

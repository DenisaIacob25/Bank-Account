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
        protected float reserveBalance;
        private int reserveAccountNmbr;

        //properties 
        public float ReserveBalance
        {
            get { return this.reserveBalance; }
            set { this.reserveBalance = value; }
        }
        public int ReserveAccountNmbr
        {
            get { return this.reserveAccountNmbr; }
            set { this.reserveAccountNmbr = value; }
        }

        //constructor 

        public Reserve(string firstName,string lastName):base (firstName,lastName)
        {
            this.reserveBalance = 0f;
            this.reserveAccountNmbr = 34234;
        }

        //methods
        public override float Deposit(float depositAmount)
        {
            this.reserveBalance += depositAmount;
            return base.Deposit(depositAmount);
        }
        public override float Withdraw(float withdrawAmount)
        {
            this.reserveBalance -= withdrawAmount;
            return base.Withdraw(withdrawAmount);
        }
        public override void PrintAccountBalance()
        {
            Console.WriteLine("Reserve account balance: $" + ReserveBalance);
        }

    }
}

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
        public Checking()
        {
            
        }

        public override void CheckingDeposit(float depostiAmount)
        {
            base.PrintAccountInfo();
            Console.WriteLine("Cheking balance: $"+CheckingBalance);
            
            checkingBalance += depostiAmount;
        }
    }
}

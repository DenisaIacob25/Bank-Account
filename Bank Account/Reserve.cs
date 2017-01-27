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

        public Reserve()
        {
            
        }

    }
}

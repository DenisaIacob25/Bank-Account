﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Account
    {
        //fields in base class
        private string firstName="Britney";
        private string lastName="Spears";
        private string accountType;

        private int accountNmbr;
        private decimal balance;
        

        //properties in base class
        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }
        public int AccountNmbr
        {
            get { return this.accountNmbr; }
            set { this.accountNmbr = value; }
        }

        //constructor base class


        //method base class

    }
}
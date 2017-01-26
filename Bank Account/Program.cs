using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bank of Ohio");
            Console.WriteLine("Please select one of the options below to being your transaction");

            //menu items
            List<string> menu = new List<string>();
            menu.Add("1.View Account Information");
            menu.Add("2.Checking Account Balanace");
            menu.Add("3.Reserve Account Balance");
            menu.Add("4.Savings Account Balance");
            menu.Add("5.Deposit Funds");
            menu.Add("6.Withdraw Funds");
            menu.Add("7.Exit");
        }
    }
}

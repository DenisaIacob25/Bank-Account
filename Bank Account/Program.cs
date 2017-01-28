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
            Console.WriteLine();
            Console.WriteLine("Please select one of the options below to being your transaction.");


            //intances of acccounts
            Checking CheckingAccount = new Checking("Mad", "Money");
            Reserve ReserveAccount = new Reserve("Mad", "Money");
            Savings SavingsAccount = new Savings("Mad", "Money");

            //loop for menu
            while (true)
            {
                //menu items
                List<string> menu = new List<string>();
                menu.Add("1.View Account Information");
                menu.Add("2.Checking Account Balanace");
                menu.Add("3.Reserve Account Balance");
                menu.Add("4.Savings Account Balance");
                menu.Add("5.Deposit Funds");
                menu.Add("6.Withdraw Funds");
                menu.Add("7.Exit");
                menu.ForEach(Console.WriteLine);
                int userResponse = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (userResponse)
                {
                    case 1:
                        SavingsAccount.PrintAccountInfo();
                        break;

                    case 2:
                        CheckingAccount.PrintAccountBalance();
                        break;
                    case 3:
                        SavingsAccount.PrintAccountBalance();
                        break;
                    case 4:
                        ReserveAccount.PrintAccountBalance();
                        break;
                    case 5:
                        Console.WriteLine("Where would you like to make a deposit");
                        Console.WriteLine("1.Checking Account");
                        Console.WriteLine("2.Savings Account");
                        Console.WriteLine("3.Reserve Account");
                        int depositResponse = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter dollar amount");
                        decimal depositAmount = decimal.Parse(Console.ReadLine());

                        switch (depositResponse)
                        {
                            case 1:
                                CheckingAccount.Deposit(depositResponse);
                                Console.WriteLine("New balance: $" + CheckingAccount.CheckingBalance);
                                break;
                            case 2:
                                SavingsAccount.Deposit(depositResponse);
                                Console.WriteLine("New balance: $" + SavingsAccount.SavingsBalance);
                                break;
                            case 3:
                                ReserveAccount.Deposit(depositResponse);
                                Console.WriteLine("New balance: $" + ReserveAccount.ReserveBalance);
                                break;

                            default:
                                break;
                        }
                        break;
                    case 6:
                        Console.WriteLine("Withdraw from which account?");
                        Console.WriteLine("1.Checking Account");
                        Console.WriteLine("2.Savings Account");
                        Console.WriteLine("3.Reserve Account");
                        int withdrawResponse = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter dollar amount");
                        decimal withdrawAmount = decimal.Parse(Console.ReadLine());

                        switch (withdrawResponse)
                        {
                            case 1:
                                CheckingAccount.Withdraw(withdrawResponse);
                                Console.WriteLine("New balance: $" + CheckingAccount.CheckingBalance);
                                break;
                            case 2:
                                SavingsAccount.Withdraw(withdrawResponse);
                                Console.WriteLine("New balance: $" + SavingsAccount.SavingsBalance);
                                break;
                            case 3:
                                ReserveAccount.Withdraw(withdrawResponse);
                                Console.WriteLine("New balance: $" + ReserveAccount.ReserveBalance);
                                break;

                            default:
                                break;
                        }
                        break;
                    case 7:
                        Console.WriteLine("Thank you for for your business.");
                        Console.ReadKey();
                        Console.Clear();
                        Environment.Exit(0);
                        break;

                    default:
                        break;

                }
            }
        }
    }
}

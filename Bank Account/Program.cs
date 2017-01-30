using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine("Welcome to Bank of Ohio");
            Console.WriteLine();
            Console.WriteLine("Please select one of the options below to being your transaction.");

            //intances of acccounts
            Account Account = new Account("Jordan", "Belfort", 1000);
            Checking CheckingAccount = new Checking("Jordan", "Belfort",1000);
            Reserve ReserveAccount = new Reserve("Jordan", "Belfort",1000);
            Savings SavingsAccount = new Savings("Jordan", "Belfort",1000);

            //streamwriter - attempted to get stream writer to work for all fields but not sure how for all requirements
            StreamWriter savingsStream = new StreamWriter("..\\..\\savings.txt");
            using (savingsStream)
            {
                savingsStream.WriteLine(SavingsAccount.FirstName + " " + SavingsAccount.LastName);
                savingsStream.WriteLine("Account number: " + SavingsAccount.SavingsAccountNmbr);
                savingsStream.WriteLine("Account type: Savings");
                //each transaction on line
                //date and time of transaction DateTime.Now
                //+ for deposit - for withdrawl
                //show transaction amount
                savingsStream.WriteLine("Account balance: $" + SavingsAccount.SavingsBalance);
            }

            StreamWriter checkingStream = new StreamWriter("..\\..\\checking.txt");
            using (checkingStream)
            {
                checkingStream.WriteLine(CheckingAccount.FirstName + " " + CheckingAccount.LastName);
                checkingStream.WriteLine("Account number: " + CheckingAccount.CheckingAccountNmbr);
                checkingStream.WriteLine("Account type: Checking");
                string depositAmount=null;
                checkingStream.WriteLine("+" + depositAmount + " " + DateTime.Now); //getting date and time to show but it is now showing deposit amount 
                //each transaction on line
                //date and time of transaction DateTime.Now
                //+ for deposit - for withdrawl
                //show transaction amount
                checkingStream.WriteLine("Account balance: $" + CheckingAccount.CheckingBalance);
            }

            StreamWriter reserveStream = new StreamWriter("..\\..\\reserve.txt");
            using (reserveStream)
            {
                reserveStream.WriteLine(ReserveAccount.FirstName +" " + ReserveAccount.LastName);
                reserveStream.WriteLine("Account number: " + ReserveAccount.ReserveAccountNmbr);
                reserveStream.WriteLine("Account type: Reserve");
                //each transaction on line
                //date and time of transaction DateTime.Now
                //+ for deposit - for withdrawl
                //show transaction amount
                reserveStream.WriteLine("Account balance: $" + ReserveAccount.ReserveBalance);            
            }

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
                        Account.PrintAccountInfo();
                        break;
                    case 2:
                        CheckingAccount.PrintAccountInfo();
                        CheckingAccount.PrintAccountBalance();
                        break;
                    case 3:
                        ReserveAccount.PrintAccountInfo();
                        ReserveAccount.PrintAccountBalance();
                        break;
                    case 4:
                        SavingsAccount.PrintAccountInfo();
                        SavingsAccount.PrintAccountBalance();
                        break;
                    case 5:
                        Console.WriteLine("Where would you like to make a deposit?");
                        Console.WriteLine();
                        Console.WriteLine("1.Checking Account");
                        Console.WriteLine("2.Savings Account");
                        Console.WriteLine("3.Reserve Account");
                        int depositResponse = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter dollar amount");
                        decimal userInputResponse = Convert.ToDecimal(Console.ReadLine());

                        switch (depositResponse)
                        {
                            case 1:
                                CheckingAccount.Deposit(userInputResponse);
                                Console.WriteLine("New balance: $" + CheckingAccount.CheckingBalance);
                                Console.WriteLine();
                                break;
                            case 2:
                                SavingsAccount.Deposit(userInputResponse);
                                Console.WriteLine("New balance: $" + SavingsAccount.SavingsBalance);
                                Console.WriteLine();
                                break;
                            case 3:
                                ReserveAccount.Deposit(userInputResponse);
                                Console.WriteLine("New balance: $" + ReserveAccount.ReserveBalance);
                                Console.WriteLine();
                                break;

                            default:
                                break;
                        }
                        break;
                    case 6:
                        Console.WriteLine("Withdraw from which account?");
                        Console.WriteLine();
                        Console.WriteLine("1.Checking Account");
                        Console.WriteLine("2.Savings Account");
                        Console.WriteLine("3.Reserve Account");
                        int withdrawResponse = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter dollar amount");
                        decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());

                        switch (withdrawResponse)
                        {
                            case 1:
                                CheckingAccount.Withdraw(withdrawAmount);
                                Console.WriteLine("New balance: $" + CheckingAccount.CheckingBalance);
                                Console.WriteLine();
                                break;
                            case 2:
                                SavingsAccount.Withdraw(withdrawAmount);
                                Console.WriteLine("New balance: $" + SavingsAccount.SavingsBalance);
                                Console.WriteLine();
                                break;
                            case 3:
                                ReserveAccount.Withdraw(withdrawAmount);
                                Console.WriteLine("New balance: $" + ReserveAccount.ReserveBalance);
                                Console.WriteLine();
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

                //close streamwriters
                savingsStream.Close();
                reserveStream.Close();
                checkingStream.Close();
            }
        }
    }
}

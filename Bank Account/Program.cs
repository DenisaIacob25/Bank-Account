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
            Console.WriteLine("Welcome to Bank of Ohio");
            Console.WriteLine();
            Console.WriteLine("Please select one of the options below to being your transaction.");

            //intances of acccounts
            Checking CheckingAccount = new Checking("Jordan", "Belfort");
            Reserve ReserveAccount = new Reserve("Jordan", "Belfort");
            Savings SavingsAccount = new Savings("Jordan", "Belfort");

            //streamwriter - attempted to get stream writer to work 
            StreamWriter savings = new StreamWriter("..\\..\\savings.txt");
            using (savings)
            {
                savings.WriteLine("User name: Jordan Belfort");
                savings.WriteLine("Account type: Savings");
            }

            ////savings.WriteLine(SavingsAccount.SavingsAccountNmbr);
            ////savings.WriteLine(SavingsAccount.FirstName);
            ////savings.WriteLine(SavingsAccount.LastName);

            StreamWriter checking = new StreamWriter("..\\..\\checking.txt");
            using (checking)
                checking.WriteLine("Account type: Checking");

            StreamWriter reserve = new StreamWriter("..\\..\\reserve.txt");
            using (reserve)
                reserve.WriteLine("Account type: Reserve");

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
                        CheckingAccount.PrintAccountInfo();
                        CheckingAccount.PrintAccountBalance();
                        break;
                    case 3:
                        SavingsAccount.PrintAccountInfo();
                        SavingsAccount.PrintAccountBalance();
                        break;
                    case 4:
                        SavingsAccount.PrintAccountInfo();
                        ReserveAccount.PrintAccountBalance();
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
            }
        }
    }
}

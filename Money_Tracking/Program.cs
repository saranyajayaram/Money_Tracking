using System;
using System.Collections.Generic;

using System.Linq;

namespace Money_Tracking
{
    internal class Program
    {
        private static object console;

        static void Main(string[] args)

        {

            int n;
            
            List<Account> accounts = new List<Account>();
            {
              Account acc1 = new Account("January", 25000, 10000, 15000);
              Account acc2 = new Account("Feburary", 20000, 8000, 12000);
              Account acc3 = new Account("April", 25000, 12000, 13000);
              Account acc4 = new Account("May", 25000, 2000, 23000);
                accounts.Add(acc1);
                accounts.Add(acc2);
                accounts.Add(acc3);
                accounts.Add(acc4);



            }

            do
            {

            



                Console.WriteLine("Welcome to Money Tracking");
                Console.WriteLine("Your Current Balance  kr on Your Account");
                Console.WriteLine("Choose Option");
                Console.WriteLine("1: Show All Income");
                Console.WriteLine("2: Show All Expenses");
                Console.WriteLine("3: Add New Income ");
                Console.WriteLine("4: Add New Expenses ");
                Console.WriteLine("5: Delete ");
                Console.WriteLine("6: Quit ");
                n = int.Parse(Console.ReadLine());

                switch(n)


                {
                    case 1:
                        {   
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            Account.NewIncome();
                            break;
                        }
                    case 4:
                        {
                            Account.NewExpensess();
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    case 6:
                        {
                            break;
                        }
                    case 7:
                        {
                            break;
                        }

                }




            
                Console.WriteLine("Account Details");
                Console.WriteLine("----------------");
                Console.WriteLine("Month".PadRight(10) + "Income".PadRight(10) + "Expensess".PadRight(10) + "Balance".PadRight(10));


                foreach (Account account in accounts)
                {
                    Console.WriteLine(account.Month.PadRight(10) + " " + account.Income.ToString().PadRight(10) + " " + account.Expensess.ToString().PadRight(15) + " " + account.Balance);
                }

                //sortedList
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("sorted List");
                Console.WriteLine("------------");
                List<Account> sortedList = accounts.OrderBy(accounts => accounts.Month).ToList();

                Console.WriteLine("Month".PadRight(10) + "Income".PadRight(10) + "Expensess".PadRight(15) + "Balance");

                foreach (Account account in sortedList)
                {
                    Console.WriteLine(account.Month.PadRight(10) + " " + account.Income.ToString().PadRight(10) + " " + account.Expensess.ToString().PadRight(15) + " " + account.Balance);

                }

                



                Console.ReadLine();




        }
    }

    class Account
    {
        private double balance1;

        public Account(string month, double income, double expensess, double balance)
        {
            Month = month;
            Income = income;
            Expensess = expensess;
            Balance = balance;
        }

        public string Month { get; set; }
        public double Income { get; set; }
        public double Expensess { get; set; }

        public double Balance { get; set; }
     
     public void ShowIncome()
            {

            }

    public void NewIncome()
        {
            double x;
            x = double.Parse(Console.ReadLine());
            Income += x;
            balance1 += x;

        }

        public void NewExpensess()
        {
            double y;
            y = double.Parse(Console.ReadLine());
            balance1 -= y;

        }

       
        }
    }

}

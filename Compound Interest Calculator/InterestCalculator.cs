using System;

namespace C_Sharp_Monthly_Compound_Interest_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            double current_amount;
            double interest;
            double balance = 0;
            int months;

            //describes to user what the program does
            Console.WriteLine("=========|Monthly Compound Interest Calculator|=========");
            Console.WriteLine("| This program takes 3 input values provided by a user |");
            Console.WriteLine("| 1. current account balance                           |");
            Console.WriteLine("| 2. interest rate                                     |");
            Console.WriteLine("| 3. months                                            |");
            Console.WriteLine("| It will calculate the future balance for the account |");
            Console.WriteLine("========================================================");

            //takes user input for current balance
            Console.WriteLine("Enter the current balance");
            current_amount = Convert.ToDouble(Console.ReadLine());

            //takes user input for interest rate
            Console.WriteLine("Enter the Interest Rate");
            interest = Convert.ToDouble(Console.ReadLine()) / 100;

            //takes user input for number of months to compound
            Console.WriteLine("Enter number of months");
            months = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= months; i++)
            {
                //F = P x (1 + i)^t
                //where F = Future Value , P = Current Value, i = monthly interest rate , t = months passed
                //uses Math.Pow method = Math.Pow(x,y) where x is the base number and y is the exponent
                balance = current_amount * Math.Pow((1 + interest), months);
            }

            //format where {0} and {1} are equal to their numbered variables respectively
            Console.WriteLine("Your future balance is ${0} after {1} months", balance, months);

            //stops program from auto closing
            Console.ReadLine();
        }
    }
}

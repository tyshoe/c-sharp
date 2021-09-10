using System;

namespace C_Sharp_PenniesforPay
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int days = 0;
            decimal total_pay = 0.01M;
            decimal daily_pay = 0.01M;

            //user input to get days
            Console.Write("Enter the number of days: ");
            days = Convert.ToInt32(Console.ReadLine());

            for(int current_day = 1; current_day <= days; current_day++)
            {
                Console.Write($"On Day {current_day}, you made ${daily_pay}");
                Console.WriteLine($" and have earned ${total_pay} so far.");
               
                daily_pay = daily_pay * 2;
                total_pay += daily_pay;
            }
        }
    }
}

using System;

namespace C_Sharp_Leap_Year_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int year;
            bool isLeapYear;

            //Ask user for year, take input and store input as int variable year
            Console.Write("Enter the year: ");
            year = Convert.ToInt32(Console.ReadLine());


            //if you wanted to mass test this system and not an individual year... comment out asking user for year and leave this code in
            //for (year = 0; year <= 2020; year++) and then surround the logic in {}
            
            //If the year is divisible by 100, then it is a leap year if it also is divisible by 400.
            if (year % 100 == 0 && year % 400 == 0)
            {
                isLeapYear = true;
            }
            //If the year is not divisible by 100, but divisible by 4, then it is a leap year.
            else if (year % 100 != 0 && year % 4 == 0)
            {
                isLeapYear = true;
            }
            //else its not a leap year
            else
            { 
                isLeapYear = false;
            }



            //output results
            if (isLeapYear == true)
                Console.WriteLine($"{year} is a Leap year!");
            else
                Console.WriteLine($"{year} is not a leap year!");

        }
    }
}

//maybe add a transaction history????

using System;

namespace C_Sharp_ATM
{

    class Program
    {
        static private decimal balance = 0.00M;
        static void Main(string[] args)
        {
            bool run_program = true;
            while (run_program)
            {
                int choice = Menu();
                switch (choice)
                {
                    case 1:
                        Show_balance();
                        break;
                    case 2:
                        Deposit();
                        break;
                    case 3:
                        Withdraw();
                        break;
                    case 4:
                        run_program = false;
                        break;
                }
            }
        }

        //show menu and grabs choice for menu option selection
        static int Menu()
        {
            int choice = 0;

            do
            {
                Console.WriteLine("**********MENU**********");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.WriteLine("************************");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice < 1 || choice > 4)//checks to see if input is an integer between 1 and 4
                    {
                        Console.WriteLine("Error: Not a valid menu option");
                    }

                }
                catch (FormatException)//checks to see if input is an integer
                {
                    Console.WriteLine("Please enter a valid integer");
                }


            } while (choice > 4 || choice < 1);


            return choice;
        }

        //checks account value
        static void Show_balance()
        {
            Console.WriteLine("Current balance $" + balance);
        }

        //deposits
        static void Deposit()
        {
            decimal deposit_amount = 0.00m;
            Console.WriteLine("Enter Deposit Amount:");

            try
            {
                deposit_amount = Convert.ToDecimal(Console.ReadLine());
            }
            catch (FormatException)//makes sure input is valid
            {
                Console.WriteLine("Please enter a valid input");
            }

            balance = balance + deposit_amount;
        }
        //withdraws
        static void Withdraw()
        {
            decimal withdraw_amount = 0.00m;//variable
            Console.WriteLine("Enter Withdrawal Amount:");//prompt
            withdraw_amount = Convert.ToDecimal(Console.ReadLine());//read input

            //logic
            if ((balance - withdraw_amount) < 0)//if withdraw exceeds current balance output error and ask if they would like to withdraw max amount
            {
                //tell user you cant withdraw that much and ask if they would like to withdraw max amount
                Console.WriteLine("ERROR: You cannot do this because the value you wish to withdraw exceeds your balance.");
                Console.WriteLine("The max you can withdraw is $" + balance);
                Console.WriteLine("Would you like to withdraw ${0}? Y or N", balance);
                
                try
                {
                    char input = Convert.ToChar(Console.ReadLine());
                    if (input == 'Y' || input == 'y')
                    {
                        balance = balance - balance;
                    }
                }
                catch (FormatException)//checks to see if input is an integer
                {
                    Console.WriteLine("Please enter a valid input");
                }
            }
            else// if it doesnt exceed balance, just withdraw
            {
                balance = balance - withdraw_amount;
            }
        }

    }
}

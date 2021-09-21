//to view txt file
//C:\Users\Tyler\source\repos\C-Sharp current time and date\C-Sharp current time and date\bin\Debug\net5.0     JOURNAL.TXT
//for now, if you run this program, comment out part 1 and run part 2, or comment out part 2 and run part 1

using System;
using System.IO;

namespace C_Sharp_current_time_and_date
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run_program = true;
            while (run_program)
            {
                int choice = Get_choice();
                bool result;

                switch (choice)
                {
                    case 1:
                        //1. Display Latest Entry
                        break;

                    case 2:
                        result = Display_entries();

                        if (result == true)
                            Console.WriteLine("Successfully displayed all entries");
                        break;

                    case 3:
                        result = Add_entry();

                        if (result == true)
                            Console.WriteLine("Add Entry Successful");
                        break;

                    case 4:
                        //4. Clear All Entries
                        break;

                    case 5:
                        //5. Exit
                        run_program = false;
                        break;
                }
            }
        }

        static int Get_choice()
            {
            int choice = 0;

            do
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("-------------");
                Console.WriteLine("1. Display Latest Entry");
                Console.WriteLine("2. Display All Entries");
                Console.WriteLine("3. Add New Entry");
                Console.WriteLine("4. Clear All Entries");
                Console.WriteLine("5. Exit");
                Console.Write("---:");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Not a valid number");
                    choice = -1;
                }

                if (choice < 1 || choice > 5)
                {
                    Console.WriteLine("Error: Not a valid menu option");
                }


            } while (choice < 1 || choice > 5);

            return choice;
            }

        static bool Add_entry()
        {
            //part 1
            //prompts user to input a journal entry... saves time and user entry to a text file

            //creates .txt file and assigns it to file
            //true will enable saves between uses and it wont overwrite the file each run
            StreamWriter file = new StreamWriter("journal.txt", true);

            //get current date and time
            string current_date_time = Convert.ToString(DateTime.Now);

            //variable
            string journal_entry;

            //get user journal entry
            Console.WriteLine("Enter your journal entry: ");
            journal_entry = Console.ReadLine();

            //write to file
            file.WriteLine(current_date_time);
            file.WriteLine(journal_entry);
            file.WriteLine();

            //always close your file
            file.Close();

            return true;
        }

        static bool Display_entries()
        {
            //part 2
            //reads input text file and ouputs contents to console

            StreamReader file_1;

            //if it tries to read file and file doesnt exist, do catch block of code
            try
            {
                file_1 = new StreamReader("journal.txt");

                string line = file_1.ReadToEnd();//reads entire file

                Console.WriteLine(line);

                file_1.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: File not found.");
                return false;
            }
            catch (Exception a)//default exception
            {
                Console.WriteLine("Error: " + a.Message);
                return false;
            }

            return true;
        }
    }
}


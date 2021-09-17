using System;

namespace C_Sharp_calculator
{
    class Program
    {
        static public decimal a = 0.00M;
        static public decimal b = 0.00M;
        static public decimal c = 0.00M;
        static void Main(string[] args)
        {

            bool run_program = true;
            while (run_program)
            {
                //call menu
                int choice = Menu();

                switch (choice)
                {
                    case 1:
                        Add();
                        break;

                    case 2:
                        Subtract();
                        break;

                    case 3:
                        Multiply();
                        break;

                    case 4:
                        Divide();
                        break;

                    case 5:
                        Square();
                        break;

                    case 6:
                        Square_root();
                        break;

                    case 7:
                        run_program = false;
                        break;
                }
            }
        }

        static int Menu()
        {
            int choice = 0;

            do
            {
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Square");
                Console.WriteLine("6. Square root");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Select your option");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice < 1 || choice > 7)//checks to see if input is an integer between 1 and 4
                    {
                        Console.WriteLine("Error: Not a valid menu option");
                    }

                }
                catch (FormatException)//checks to see if input is an integer
                {
                    Console.WriteLine("Please enter a valid integer");
                }


            } while (choice > 7 || choice < 1);

            return choice;
        }

        //this is to prevent writing redundant code.  used in all functions
        static void Function_format_exception()
        {
            //input a
            Console.Write("Enter your first value (a): ");

            try
            {
                a = Convert.ToDecimal(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }

            //input b
            Console.Write("Enter your second value (b): ");
            try
            {
                b = Convert.ToDecimal(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }
        }


        static public void Add()
        {
            Function_format_exception();
            //output
            decimal c = a + b;
            Console.WriteLine("a + b = {0}", c);
        }

        static public void Subtract()
        {
            Function_format_exception();
            //output
            decimal c = a - b;
            Console.WriteLine("a - b = {0}", c);
        }

        static public void Multiply()
        {
            Function_format_exception();
            //output
            decimal c = a * b;
            Console.WriteLine("a * b = {0}", c);
        }

        static public void Divide()
        {
            Function_format_exception();
            //output
            decimal c = a / b;
            Console.WriteLine("a / b = {0}", c);
        }

        static public void Square()
        {
            Function_format_exception();
            double x = Convert.ToDouble(a);
            double y = Convert.ToDouble(b);

            double z = Math.Pow(x,y);
            
            Console.WriteLine("a ^ b = {0}", z);
        }
        static public void Square_root()
        {
            Console.Write("Input number: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double y = Math.Sqrt(x);

            // \u221A is the sqrt symbol found in UTF-16 (unicode)
            Console.WriteLine("\u221A{0} = {1}",x , y);

        }
    }
}

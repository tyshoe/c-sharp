//add morse to message choice 3 - will also need the method
using System;

namespace C_Sharp_Morse_Code_Translator
{
    class Program
    {
        static string str, str_lower;//string input = str  str_lower
        static void Main(string[] args)
        {
            bool run_program = true;
            while (run_program)
            {
                int choice = Get_choice();
                switch (choice)
                {
                    case 1://Show Morse Code Chart
                        Show_Chart();//show chart
                        break;

                    case 2://Convert Message to Morse
                        Get_english_sentence();//converts string to lowercase
                        Convert_to_morse();//breaks down string to compare characters then creates translation and prints
                        break;

                    case 3://Convert Morse to Message
                        //opportunity to expand program functionality-separate letters with /
                        Console.WriteLine("Sorry, This feature is currently not working");
                        break;

                    case 4://exit
                        run_program = false;
                        break;
                }
            }
        }

        //displays menu for user, gets input and selects switch option based on input
        static int Get_choice()
        {
            int choice = 0;

            do
            {
                Console.WriteLine("Morse Code Translator");
                Console.WriteLine("-------------");
                Console.WriteLine("1. Show Morse Code Chart");
                Console.WriteLine("2. Convert Message to Morse");
                Console.WriteLine("3. Convert Morse to Message");
                Console.WriteLine("4. Exit");
                Console.Write("Your Choice:");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Not a valid number");
                    choice = -1;
                }
                //choice != -1 will prevent this from outputting:
                //Error: Not a valid number
                //Error: Not a valid menu option
                //instead, it will only ouput one or the other
                if (choice != -1 && choice < 1 || choice > 4)
                {
                    Console.WriteLine("Error: Not a valid menu option");
                }


            } while (choice < 1 || choice > 4);

            return choice;
        }
        //shows morse code chart key
        static void Show_Chart()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("|            Morse Code Chart            |");
            Console.WriteLine("| Letters        Characters      Numbers |");
            Console.WriteLine("| a .-           space '     '   1 .---- |");
            Console.WriteLine("| b -...         , --..--        2 ..--- |");
            Console.WriteLine("| c -.-.         ? .-.-.-        3 ...-- |");
            Console.WriteLine("| d -..          ! ..--..        4 ....- |");
            Console.WriteLine("| e .            / -.-.--        5 ..... |");
            Console.WriteLine("| f ..-.         ( -.--.         6 -.... |");
            Console.WriteLine("| g --.          ) -.--.-        7 --... |");
            Console.WriteLine("| h ....         & .-...         8 ---.. |");
            Console.WriteLine("| i ..           : ---...        9 ----. |");
            Console.WriteLine("| j .---         = -...-         0 ----- |");
            Console.WriteLine("| k -.-          + .-.-.                 |");
            Console.WriteLine("| l .-..         - -....-                |");
            Console.WriteLine("| m --           _ ..--.-                |");
            Console.WriteLine("| n -.           \".- ..-.                |");//has to be like this :(
            Console.WriteLine("| o ---          $ ...-..-               |");
            Console.WriteLine("| p .---.        @ .--.-.                |");
            Console.WriteLine("| q --.-                                 |");
            Console.WriteLine("| r .-.                                  |");
            Console.WriteLine("| s ...                                  |");
            Console.WriteLine("| t -                                    |");
            Console.WriteLine("| u ..-                                  |");
            Console.WriteLine("| v ...-                                 |");
            Console.WriteLine("| w .--                                  |");
            Console.WriteLine("| x -..-                                 |");
            Console.WriteLine("| y -.--                                 |");
            Console.WriteLine("| z --..                                 |");
            Console.WriteLine("------------------------------------------");
        }
        //gets users string and converts it to lower case
        static string Get_english_sentence()
        {
            Console.WriteLine("Enter your message:");
            str = Console.ReadLine();
            str_lower = str.ToLower();//converts string to lowercase because morse code is only lower
            Console.WriteLine("your string in lower case: " + str_lower);//prints user input in lower
            return str_lower;
        }
        //array for english characters
        static char[] Get_chars()
        {
            //index of morse code
            char[] characters =
             { 'a',
                'b',
                'c',
                'd',
                'e',
                'f',
                'g',
                'h',
                'i',
                'j',
                'k',
                'l',
                'm',
                'n',
                'o',
                'p',
                'q',
                'r',
                's',
                't',
                'u',
                'v',
                'w',
                'x',
                'y',
                'z',
                '1',
                '2',
                '3',
                '4',
                '5',
                '6',
                '7',
                '8',
                '9',
                '0',
                ' ',
                ',',
                '.',
                '?',
                '!',
                '/',
                '(',
                ')',
                '&',
                ':',
                '=',
                '+',
                '-',
                '_',
                '"',
                '$',
                '@'
                };

            return characters;
        }
        //aray for morse code
        static string[] Get_morse()
        {
            //index of morse code
            string[] morse =
              { ".-",//a     characters
                "-...",//b
                "-.-.",//c
                "-..",//d
                ".",//e
                "..-.",//f
                "--.",//g
                "....",//h
                "..",//i
                ".---",//j
                "-.-",//k
                ".-..",//l
                "--",//m
                "-.",//n
                "---",//o
                ".---.",//p
                "--.-",//q
                ".-.",//r
                "...",//s
                "-",//t
                "..-",//u
                "...-",//v
                ".--",//w
                "-..-",//x
                "-.--",//y
                "--..",//z
                ".----",//1   digits
                "..---",//2
                "...--",//3
                "....-",//4
                ".....",//5
                "-....",//6
                "--...",//7
                "---..",//8
                "----.",//9
                "-----",//0
                "     ",//space    symbols
                "--..--",//,   
                ".-.-.-",//.
                "..--..",//?
                "-.-.--",//!
                "-..-.",// /
                "-.--.",//(
                "-.--.-",//)
                ".-...",//&
                "---...",//:
                "-...-",//=
                ".-.-.",//+
                "-....-",//-
                "..--.-",//_
                ".-..-.",//"
                "...-..-",//$
                ".--.-."//@
        };
            return morse;
        }
        static string Convert_to_morse()
        {
            string translation = "";
            //calls methods that contain characters and their morse equivalents
            string[] morse = Get_morse();

            try
            {
                for (int i = 0; i < str_lower.Length; i++)
                {
                    if (Is_valid_character(str_lower[i]))
                    {
                        translation = translation + (morse[Get_char_position(str_lower[i])] + " ");
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                Console.WriteLine("Translation: " + translation);
            }
            catch (Exception)
            {
                Console.WriteLine("Error:  Please refer to the Morse Code Chart for all valid characters.");
            }



            //beeps
            foreach (var x in translation)
            {
                if (x == '.')
                    Console.Beep(528, 100);
                else if (x == '-')
                    Console.Beep(432, 400);
            }
            System.Threading.Thread.Sleep(600);


            return translation;
        }
        //
        static bool Is_valid_character(char input)
        {
            bool charIsValid = false;
            char[] chars = Get_chars();

            for (int i = 0; i < chars.Length; i++)
            {
                if (input == chars[i])
                {
                    charIsValid = true;
                }
            }
            return charIsValid;
        }

        static int Get_char_position(char input)
        {
            int position = -1;

            char[] characters = Get_chars();
            for (int i = 0; i < characters.Length; i++)
            {
                if (input == characters[i])
                {
                    position = i;
                    return position;
                }
            }
            return position;
        }
    }
}

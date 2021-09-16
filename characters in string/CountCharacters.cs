using System;

namespace C_Sharp_count_characters_in_string
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables  
            string str;
            int a = 0;
            int words = 1;
            int letters = 0;
            int digits = 0;
            int punctuations = 0;

            //explains program
            Console.WriteLine("This program will read user input and count letters, digits, words, and punctuations." +
                " Do not double space and do not enter a space before the first word and after the last word");


            //user input
            Console.WriteLine("Write down any sentence");
            str = Console.ReadLine();


            //logic
            //reads each character [variable x] in the string [str] and checks if...
            foreach (char x in str)
            {
                if (Char.IsDigit(x))
                    digits++;
                else if (Char.IsLetter(x))
                    letters++;
                else if (Char.IsWhiteSpace(x))
                    words++;
                else if (Char.IsPunctuation(x))
                    punctuations++;
            }

            //output
            Console.WriteLine($"Number of words: {words}");
            Console.WriteLine($"Number of letters: {letters}");
            Console.WriteLine($"Number of digits: {digits}");
            Console.WriteLine($"Number of Punctuation: {punctuations}");
        }
    }
}

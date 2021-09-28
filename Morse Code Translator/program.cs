

using System;

namespace C_Sharp_Morse_Code_Translator
{
    class Program
    {
        static string str, str_lower;//string input = str  str_lower
        //public char[] characters;
        //public string[] morse;
        static void Main(string[] args)
        {
            string translation = "";

            Console.WriteLine("Enter a string");
            str = Console.ReadLine();
            str_lower = str.ToLower();//converts string to lowercase because morse code is only lower
            Console.WriteLine("String: " + str_lower);//prints user input in lower

            Get_chars();
            Get_morse();

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
                '\'',
                '$',
                '@',
                '¿',
                '¡'

                //.,:"'-
                };
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
                "     ",//         space
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
                ".----.",//'
                "...-..-",//$
                ".--.-.",//@
                "..-.-",//¿
                "--...-"//¡
        };
            try
            {
                for (int i = 0; i < str_lower.Length; i++)//str_lower.Length to check size of input string
                {
                    for (int j = 0; j < morse.Length; j++)//morse.Length to check size of morse array
                    {
                        if (str_lower[i] == characters[j])
                        {
                            translation = translation + morse[j];
                            break;
                        }
                    }

                }
            }

            catch (FormatException)
            {
                Console.WriteLine("ERROR");
            }

            Console.WriteLine(translation);
            foreach (var x in translation)
            {
                if (x == '.')
                    Console.Beep(528, 100);
                else if (x == '-')
                    Console.Beep(432, 400);
            }
            System.Threading.Thread.Sleep(600);
            //Show_Chart();
        }


        //shows morse code chart key
        //static void Show_Chart()
        //{
        //    Console.WriteLine("a = .-");
        //    Console.WriteLine("b = -...");
        //    Console.WriteLine("c = -.-.");
        //    Console.WriteLine("d = -..");
        //    Console.WriteLine("e = .");
        //    Console.WriteLine("f = ..-.");
        //    Console.WriteLine("g = --.");
        //    Console.WriteLine("h = ....");
        //    Console.WriteLine("i = ..");
        //    Console.WriteLine("j = .---");
        //    Console.WriteLine("k = -.-");
        //    Console.WriteLine("l = .-..");
        //    Console.WriteLine("m = --");
        //    Console.WriteLine("n = -.");
        //    Console.WriteLine("o = ---");
        //    Console.WriteLine("p = .---.");
        //    Console.WriteLine("q = --.-");
        //    Console.WriteLine("r = .-.");
        //    Console.WriteLine("s = ...");
        //    Console.WriteLine("t = -");
        //    Console.WriteLine("u = ..-");
        //    Console.WriteLine("v = ...-");
        //    Console.WriteLine("w = .--");
        //    Console.WriteLine("x = -..-");
        //    Console.WriteLine("y = -.--");
        //    Console.WriteLine("z = --..");
        //    Console.WriteLine("1 = .----");
        //    Console.WriteLine("2 = ..---");
        //    Console.WriteLine("3 = ...--");
        //    Console.WriteLine("4 = ....-");
        //    Console.WriteLine("5 = .....");
        //    Console.WriteLine("6 = -....");
        //    Console.WriteLine("7 = --...");
        //    Console.WriteLine("8 = ---..");
        //    Console.WriteLine("9 = ----.");
        //    Console.WriteLine("0 = -----");
        //    Console.WriteLine("space = '     '");

        //        "--..--",//,
        //        ".-.-.-",//.
        //        "..--..",//?
        //        "-.-.--",//!
        //        "-..-.",// /
        //        "-.--.",//(
        //        "-.--.-",//)
        //        ".-...",//&
        //        "---...",//:
        //        "-...-",//=
        //        ".-.-.",//+
        //        "-....-",//-
        //        "..--.-",//_
        //        ".-..-.",//"
        //        "...-..-",//$
        //        ".--.-.",//@
        //        "..-.-",//¿
        //        "--...-"//¡
        //}
        public static void Get_chars()
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
                '@',
                '¿',
                '¡'
                };
        }

        //logic
        static void logic()
        {

        }

        static void Get_morse()
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
                "     ",//         space
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
                ".--.-.",//@
                "..-.-",//¿
                "--...-"//¡
        };
        }
    }
}

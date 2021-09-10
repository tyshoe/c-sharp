using System;

namespace C_Sharp_RightTriangleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //create variables for input
            decimal a, b, c;

            //ask user for input of 3 sides of triangle
            Console.Write("Enter the length of side A: ");
            a = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the length of side B: ");
            b = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the length of side C: ");
            c = Convert.ToDecimal(Console.ReadLine());

            //compute whether it is right triangle using pythagorean theorem.
            if ((a * a) == (b * b) + (c * c))
                Console.Write("This is a right triangle with A as the hypotenuse");
            else if ((b * b) == (a * a) + (c * c))
                Console.Write("This is a right triangle with B as the hypotenuse");
            else if ((c * c) == (b * b) + (a * a))
                Console.Write("This is a right triangle with C as the hypotenuse");
            else
                Console.Write("This is not a right triangle.");
            //output whether it is a right triangle

        }
    }
}

using System;

namespace C_Sharp_GradingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] student_names = { "Tyler", "Gabe", "Jessica", "Josh", "John" };
            double[] student_grades = { 0, 56, 84, 100, 97};

            //highest scoring student
            
            //lowest scoring student
            
            //Class average function 
            static double class_average(double [] grades)
            {
                double total = 0;

                for (int i = 0; i < grades.Length; i++)
                    total += grades[i];

                total = total / grades.Length;
                return total;
            }


            Console.WriteLine($"The Class Average is {class_average(student_grades)}");
        }
    }
}

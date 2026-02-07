using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAverageApp
{
    internal class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            double grade;
            double sum = 0;
            Console.WriteLine("Enter 5 grades separated by new line:");

            for (int i = 1; i <= 5; i++)
            {
                grade = Convert.ToDouble(Console.ReadLine());
                sum += grade;
            }

            double average = sum / 5;
            double averageR = Math.Round(average);
            Console.WriteLine("\n______________________________________________________");
            Console.WriteLine($"The average is {average} and round off to {averageR}");
           
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

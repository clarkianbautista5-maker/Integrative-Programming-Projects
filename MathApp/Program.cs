using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    internal class MathProgram
    {
        static void Main(string[] args)
        {
            double a = 5.0;
            double b = 14.0;
            double c = -15.0;

            double powerR = Math.Pow(a, b);
            double sqrtR = Math.Sqrt(a);
            double logR = Math.Log(a);
            double expR = Math.Exp(a);
            double absR = Math.Abs(c);

            Console.WriteLine($"{a} raised to the power of {b} is {powerR}");
            Console.WriteLine($"The square root of {a} is {sqrtR}");
            Console.WriteLine($"The natural logarithm of {a} is {logR}");
            Console.WriteLine($"The exponential of {a} is {expR}");
            Console.WriteLine($"The absolute value of {c} is {absR}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

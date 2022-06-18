using System;
using static System.Console;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            double result= Add(2, 7);
            WriteLine(result);
        }

        static double Add(double a, double b)
        {
            return a + b;
        }
    }
}

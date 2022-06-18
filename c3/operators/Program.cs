using System;
using static System.Console;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a= 3, b= a++;
            WriteLine($"a is {a} and b is {b}");

            int c= 3, d= ++c;
            WriteLine($"c is {c} and d is {d}");

            double f= 11.2;
            WriteLine($"f is {f:N3}");
        }
    }
}

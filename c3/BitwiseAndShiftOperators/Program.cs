using System;
using static System.Console;

namespace BitwiseAndShiftOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a= 10, b= 6; // 0000 1010 , 0000 0110
            WriteLine($"a = {a}");
            WriteLine($"b = {b}");
            WriteLine($"a & b = {a & b}");
            WriteLine($"a | b = {a | b}");
            WriteLine($"a ^ b = {a ^ b}");

            WriteLine($"a << 3 = {a << 3}");
            WriteLine(a * 8);
            WriteLine($"b >> 1 = {b >> 1}");
        }
    }
}

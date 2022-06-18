using System;
using static System.Console;
using System.Numerics;

namespace WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var largest=  ulong.MaxValue;
            WriteLine($"{largest,40:N0}");

            var atomsinuniverse= BigInteger.Parse("123456789012345678901234567890");
            WriteLine($"{atomsinuniverse,40:N0}");
        }
    }
}
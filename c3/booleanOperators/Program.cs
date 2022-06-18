using System;
using static System.Console;

namespace booleanOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a= true, b= false;
            WriteLine($"AND     |       a       |       b");
            WriteLine($"a       |   {a & a}     |   {a & b}");
            WriteLine($"b       |   {b & a}     |   {b & b}");

            WriteLine($"OR      |       a       |       b");
            WriteLine($"a       |   {a | a}     |   {a | b}");
            WriteLine($"b       |   {b | a}     |   {b | b}");

            WriteLine($"AND     |       a       |       b");
            WriteLine($"a       |   {a ^ a}     |   {a ^ b}");
            WriteLine($"b       |   {b ^ a}     |   {b ^ b}");

            WriteLine("&");
            WriteLine($"a & doStuff() = {a & doStuff()}");
            WriteLine($"b & doStuff() = {b & doStuff()}");

            WriteLine("&&");
            WriteLine($"a && doStuff() = {a && doStuff()}");
            WriteLine($"b && doStuff() = {b && doStuff()}");
        }

        static bool doStuff()
        {
            WriteLine("I am doing stuff");
            return true;
        }
    }
}

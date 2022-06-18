using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args);
            object height= 0.43;
            object name= "Tyrion Lannister";
            Console.WriteLine($"{name} is {height} meters tall");
            // int length1= name.Length;
            int length2= ((string)name).Length;
            Console.WriteLine($"{name}'s name is {length2} characters long.");

            // var population= 66_000_000;
            // var meters= 1.55D;
            // var apple=  1.46M;
            // var name= "emeka";

            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(string) = {default(string)}");
        }
    }
}

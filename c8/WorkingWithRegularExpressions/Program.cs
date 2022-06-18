using System;
using System.Text.RegularExpressions;
using static System.Console;

namespace WorkingWithRegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("How old are you? ");
            string input= ReadLine();

            var ageChecker= new Regex(@"^\d+$");

            if(ageChecker.IsMatch(input)){
                WriteLine("Arigato kosaimas");
            }else{
                WriteLine($"This is not a valid age: {input}");
            }
        }
    }
}

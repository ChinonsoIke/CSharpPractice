using System;
using static System.Console;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("How old are you? ");
            // int userAge;
            string input= ReadLine();
            try{
                WriteLine($"I see. You look good for {int.Parse(input)}!");
            }catch(FormatException){
                WriteLine("Your input is the wrong format");
            }catch(Exception e){
                WriteLine($"{e.GetType()} says {e.Message}");
            }
        }
    }
}

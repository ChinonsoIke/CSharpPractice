using System;
using static System.Console;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0){
                WriteLine("There are console arguments");
            }else{
                WriteLine("There are no console arguments");
            }

            object o= 5; int j = 4;
            if(o is int i){
                WriteLine($"o * j = {i * j}");
            }else{
                WriteLine("o is not an int");
            }
        }
    }
}

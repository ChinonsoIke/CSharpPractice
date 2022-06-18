using System;
using static System.Console;
using System.Collections.Generic;

namespace WorkingWithDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            var prefects= new Dictionary<string, string>();
            prefects.Add("Emeka", "Head Boy");
            prefects.Add("Kemi", "Lib. Prefect");
            prefects.Add("Steve", "Lab Prefect");
            prefects.Add("Tunde", "Health Prefect");
            prefects.Add("Samantha", "Head Girl");

            WriteLine("Prefects and their roles:");
            foreach(KeyValuePair<string, string> prefect in prefects){
                WriteLine($"{prefect.Key}: {prefect.Value}");
            }
        }
    }
}

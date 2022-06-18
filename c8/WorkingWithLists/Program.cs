using System;
using static System.Console;
using System.Collections.Generic;

namespace WorkingWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities= new List<string>();
            cities.Add("Paris");
            cities.Add("Lagos");
            cities.Add("New York");
            cities.Add("Berlin");

            WriteLine(cities.Count);

            foreach(string city in cities){
                WriteLine(city);
            }

            cities.Insert(2, "Stockholm");

            foreach(string city in cities){
                WriteLine(city);
            }
        }
    }
}
